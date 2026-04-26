/****************************** Enum (Enumerator) ******************************/
//An enum (short for "enumeration") is a special data type in C# that 
//allows you to define a set of named constants. 
//Enums are useful for representing a fixed number of
//Basic Example
/*
using System;

public class EnumDemo
{
    // 1. Define the Enum
    // By default, the first element is 0, the second is 1, and so on.
    public enum OrderStatus
    {
        Pending,   // 0
        Processing, // 1
        Shipped,    // 2
        Delivered,   // 3
        Cancelled   // 4
    }

    public static void Main()
    {
        // 2. Assigning an enum value to a variable
        OrderStatus currentStatus = OrderStatus.Pending;

        Console.WriteLine($"The current order status is: {currentStatus}");

        // 3. Using Enums in a Switch Statement (The most common use case)
        switch (currentStatus)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Order is waiting for payment.");
                break;
            case OrderStatus.Shipped:
                Console.WriteLine("Order is on the way!");
                break;
            case OrderStatus.Delivered:
                Console.WriteLine("Order has arrived.");
                break;
            default:
                Console.WriteLine("Order is in a different state.");
                break;
        }
    }
}
*/


/*
// BAD CODE: Using "Magic Numbers"
if (orderStatus == 0) { 
    // Wait... what was 0 again? Was it Pending or Cancelled?
}


// GOOD CODE: Using Enums
if (orderStatus == OrderStatus.Pending) { 
    // Now it's obvious! The order is Pending.
}

*/


//Customizing underlying variables
//You don't have to use the default 0, 1, 2 sequence. You can assign your own integer values.

/*
public enum ErrorCode
{
    None = 0,
    NotFound = 404,
    InternalServerError = 500,
    BadGateway = 502
}
*/



//Changing Underlying Type
//By default, enums use int. 
//If you are building a high-performance application or working with hardware/network protocols, you can change the type to byte, short, long, etc., to save memory.

// This enum now uses only 1 byte of memory instead of 4 bytes (int)
// public enum UserRole : byte
// {
//     Guest = 1,
//     User = 2,
//     Admin = 3
// }



//Casting: Converting between Enums and Integers
//Since enums are backed by integers, you can "cast" them back and forth.
/*
OrderStatus status = OrderStatus.Shipped;

// Enum to Int
int value = (int)status; 
Console.WriteLine(value); // Output: 2

// Int to Enum
OrderStatus newStatus = (OrderStatus)3; 
Console.WriteLine(newStatus); // Output: Delivered
*/





//Bitwise Enums with the [Flags] Attribute
//Sometimes, a variable needs to hold multiple values at once. 
//For example, a file might be "Read-Only" AND "Hidden".
//To do this, we use the [Flags] attribute and assign values in powers of 2.

/*
[Flags] // This attribute allows the enum to be treated as a bitmask
public enum FilePermissions
{
    None = 0,
    Read = 1,    // 0001 in binary
    Write = 2,   // 0010 in binary
    Execute = 4, // 0100 in binary
    Delete = 8   // 1000 in binary
}

public class FlagsDemo
{
    public static void Main()
    {
        // Assign multiple values using the OR operator (|)
        FilePermissions myPermissions = FilePermissions.Read | FilePermissions.Write;

        Console.WriteLine($"Permissions: {myPermissions}"); // Output: Read, Write

        // Check if a flag is set using .HasFlag()
        if (myPermissions.HasFlag(FilePermissions.Read))
        {
            Console.WriteLine("You have Read access.");
        }

        // Remove a flag using the AND NOT operator (~ and &)
        myPermissions &= ~FilePermissions.Write;
        Console.WriteLine($"Updated Permissions: {myPermissions}"); // Output: Read
    }
}
*/

//Complete Example - User Management System 
/*
using System;

namespace EnumMasterclass
{
    // 1. BASIC ENUM with Explicit Values
    // Explicitly assigning numbers prevents data corruption if we add 
    // new roles in the middle of the list later.
    public enum UserRole
    {
        Guest = 0,
        User = 1,
        Moderator = 2,
        Admin = 3
    }

    // 2. STATUS ENUM
    public enum AccountStatus
    {
        Pending,   // 0
        Active,    // 1
        Suspended, // 2
        Closed      // 3
    }

    // 3. FLAGS ENUM for Multiple Selections
    // [Flags] allows us to combine values (e.g., Read AND Write)
    // Values MUST be powers of 2 (1, 2, 4, 8, 16...)
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        ManageUsers = 8
    }

    public class UserAccount
    {
        public string Username { get; set; }
        public UserRole Role { get; set; }
        public AccountStatus Status { get; set; }
        public Permissions UserPermissions { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"--- User: {Username} ---");
            Console.WriteLine($"Role: {Role} (ID: {(int)Role})"); // Casting Enum to Int
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Permissions: {UserPermissions}");
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main()
        {
            // --- SCENARIO 1: Basic Assignment and Switch ---
            UserAccount user1 = new UserAccount
            {
                Username = "Alice",
                Role = UserRole.Admin,
                Status = AccountStatus.Active,
                // Combine permissions using the Bitwise OR operator (|)
                UserPermissions = Permissions.Read | Permissions.Write | Permissions.ManageUsers 
            };

            user1.DisplayDetails();

            // Logic based on Enum
            switch (user1.Role)
            {
                case UserRole.Admin:
                    Console.WriteLine("Access Level: Full System Access granted.");
                    break;
                case UserRole.Guest:
                    Console.WriteLine("Access Level: Read-only access.");
                    break;
            }

            // --- SCENARIO 2: The [Flags] Logic ---
            Console.WriteLine("\nChecking Permissions...");
            if (user1.UserPermissions.HasFlag(Permissions.Delete))
            {
                Console.WriteLine("User can delete files.");
            }
            else
            {
                Console.WriteLine("User DOES NOT have delete permissions.");
            }

            // --- SCENARIO 3: Casting and Validation ---
            int databaseValue = 2; 
            // Casting integer from DB to Enum
            UserRole roleFromDb = (UserRole)databaseValue; 
            Console.WriteLine($"\nDatabase Role ID {databaseValue} is: {roleFromDb}");

            // Validation: Checking if a number is actually defined in the Enum
            int randomValue = 99;
            if (Enum.IsDefined(typeof(UserRole), randomValue))
            {
                Console.WriteLine("Value is a valid Role.");
            }
            else
            {
                Console.WriteLine($"Error: {randomValue} is not a valid UserRole!");
            }

            // --- SCENARIO 4: Parsing Strings to Enums ---
            string inputFromApi = "Suspended";
            
            // TryParse is the safest way to convert strings to enums
            if (Enum.TryParse(inputFromApi, out AccountStatus parsedStatus))
            {
                Console.WriteLine($"API status successfully parsed to: {parsedStatus}");
            }
            else
            {
                Console.WriteLine("Invalid status received from API.");
            }
        }
    }
}
*/