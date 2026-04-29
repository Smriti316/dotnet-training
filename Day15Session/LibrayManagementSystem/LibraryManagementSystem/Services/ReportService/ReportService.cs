using LibraryManagementSystem.Model.Report;

namespace LibraryManagementSystem.Services.ReportService
{
    public class ReportService : IReportService
    {
        public List<BorrowedReport> GetCurrentlyBorrowedBooksReport(BorrowedReportFilter borrowedReportFilter)
        {
            throw new NotImplementedException();
        }

        public List<DueDateReport> GetOverDueBooksReport(DateOnly currentDate)
        {
            throw new NotImplementedException();
        }

        public List<MemberHistoryReport> MemberHistoryReport(int memberId)
        {
            throw new NotImplementedException();
        }
    }
}
