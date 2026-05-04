using LibraryManagementSystem.Model;
using System.Net;
using System.Text.Json;

namespace LibraryManagementSystem.Repository.BorrowRepository
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly string _connectionString = "../../../Data/borrow.json";

        public void BorrowBook(int bookId, int memberId)
        {
            var borrowDetails = ViewAllBorrowLists();
            int maxRecordId = borrowDetails.Any() ? borrowDetails.Max(b => b.RecordId) : 0;
            var newBorrow = new Borrow
            {
                RecordId = maxRecordId + 1,
                BookId = bookId,
                MemberId = memberId,
                IssuedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(15), // Assuming a 14-day loan period
                Status = "Borrowed",
                CreatedDate = DateTime.Now,
                CreatedBy = "admin"
            };
            borrowDetails.Add(newBorrow);
            var borrowString = JsonSerializer.Serialize(borrowDetails, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, borrowString);
        }

        public bool ReturnBook(Borrow borrow)
        {
            var borrowDetailList = ViewAllBorrowLists();
            var borrowDetails = borrowDetailList.FirstOrDefault(x => x.RecordId == borrow.RecordId);
            if (borrowDetails == null)
            {
                return false;
            }
            borrowDetails.Status = borrow.Status;
            borrowDetails.ModifiedBy = borrow.ModifiedBy;
            borrowDetails.ModifiedDate = borrow.ModifiedDate;
            borrowDetails.ReturnedDate = borrow.ReturnedDate;
            var borrowString = JsonSerializer.Serialize(borrowDetailList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_connectionString, borrowString);
            return true;
        }
        
        public double BorrowFine(int bookId, int memberId, int noOfDaysExceeded)
        {
            var borrowDetails = ViewAllBorrowLists();
            var borrowRecord = borrowDetails.FirstOrDefault(b => b.BookId == bookId && b.MemberId == memberId && b.Status == "Borrowed");
            if (borrowRecord != null)
            {
                double fineRate = 0.50;
                borrowRecord.LateFine = noOfDaysExceeded * fineRate;
                borrowRecord.ModifiedDate = DateTime.Now;
                borrowRecord.ModifiedBy = "admin";

                var borrowString = JsonSerializer.Serialize(borrowDetails, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_connectionString, borrowString);
                return borrowRecord.LateFine;
            }
            return 0;
        }

        public bool DueDateManagement(Borrow borrow)
        {
            var borrowDetails = ViewAllBorrowLists();
            var borrowRecord = borrowDetails.FirstOrDefault(b => b.RecordId == borrow.RecordId);
            if(borrowRecord == null)
            {
                return false;
            }
            else
            {
                borrowRecord.BookRenewedDate = borrow.BookRenewedDate;
                borrowRecord.ModifiedDate = borrow.ModifiedDate;
                borrowRecord.ModifiedBy = borrow.ModifiedBy;
                borrowRecord.DueDate = borrow.DueDate;
                var borrowString = JsonSerializer.Serialize(borrowDetails, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_connectionString, borrowString);
                return true;
            }

        }

        public List<Borrow> ViewAllBorrowLists()
        {
            if (!File.Exists(_connectionString))
            {
                return new List<Borrow>();
            }

            var borrowFromTable = File.ReadAllText(_connectionString);
            if (string.IsNullOrWhiteSpace(borrowFromTable))
            {
                return new List<Borrow>();
            }

            var borrowDetails = JsonSerializer.Deserialize<List<Borrow>>(borrowFromTable);
            return borrowDetails ?? new List<Borrow>();
        }
    }
}
