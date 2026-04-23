//*************************************************** Generics ******************************************************//
//Imagine we want a method that swaps two values. Without generics, we have to write 
// a new method for every single data type.

//Generic Methods 
/*
using System;

class Program
{
    // Swap method specifically for Integers
    static void SwapInts(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Swap method specifically for Strings
    static void SwapStrings(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 10, y = 20;
        SwapInts(ref x, ref y);
        Console.WriteLine($"Ints swapped: {x}, {y}");

        string firstName = "John", lastName = "Doe";
        SwapStrings(ref firstName, ref lastName);
        Console.WriteLine($"Strings swapped: {firstName}, {lastName}");
        
        // PROBLEM: What if we need to swap doubles? Booleans? 
        // We have to keep writing new methods! This is "Code Duplication."
    }
}

// Solution
// Instead of saying int or string, we use T. 
// When the user calls the method, C# replaces T with the actual type they are using.
using System;

class Program
{
    // <T> tells C# that this method is generic. 
    // 'T' is a placeholder for "whatever type the user provides."
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a; // temp will be of type T
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Example 1: Using it with integers
        int x = 10, y = 20;
        Swap<int>(ref x, ref y); // We explicitly tell it T is an 'int'
        Console.WriteLine($"Ints: {x}, {y}");

        // Example 2: Using it with strings
        string firstName = "John", lastName = "Doe";
        Swap<string>(ref firstName, ref lastName); // T is now a 'string'
        Console.WriteLine($"Strings: {firstName}, {lastName}");

        // Example 3: Type Inference
        // C# is smart! It can guess the type, so you don't always need <string>
        double d1 = 1.1, d2 = 2.2;
        Swap(ref d1, ref d2); 
        Console.WriteLine($"Doubles: {d1}, {d2}");
    }
}


/*
//Generic Classes
// A generic class can hold any type of data. 
//This is perfect for "Containers" (classes that store, wrap, or manage data)
*/
/*
using System;

// This class can store one piece of data of ANY type
class DataStore<T>
{
    private T _data;

    // Method to save data
    public void Save(T item)
    {
        _data = item;
        Console.WriteLine($"Data of type {typeof(T)} saved successfully.");
    }

    // Method to retrieve data
    public T Get()
    {
        return _data;
    }
}

public class CompanyDetails
{
    public string Name { get; set; }
    public int EmployeeCount { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a store specifically for Integers
        DataStore<int> intStore = new DataStore<int>();
        intStore.Save(100);
        Console.WriteLine($"Retrieved: {intStore.Get()}");

        Console.WriteLine("-------------------");

        // Create a store specifically for Strings
        DataStore<string> stringStore = new DataStore<string>();
        stringStore.Save("Hello Generics!");
        Console.WriteLine($"Retrieved: {stringStore.Get()}");


        //object generic store
        DataStore<CompanyDetails> companyStore = new DataStore<CompanyDetails>();
        companyStore.Save(new CompanyDetails { Name = "Tech Corp", EmployeeCount = 500 });
        CompanyDetails details = companyStore.Get();
        Console.WriteLine($"Company: {details.Name}, Employees: {details.EmployeeCount}");
    }
}
*/

//Multiple Type Parameters
/*
using System;

// We use T1 and T2 to represent two different types
class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public void Display()
    {
        Console.WriteLine($"First: {First} | Second: {Second}");
    }
}

class Program
{
    static void Main()
    {
        // Case 1: String and Integer (Name and Age)
        Pair<string, int> person = new Pair<string, int>("Bob", 25);
        person.Display();

        // Case 2: Integer and Boolean (ID and IsActive status)
        Pair<int, bool> userStatus = new Pair<int, bool>(101, true);
        userStatus.Display();
    }
}
*/


/*
// Generics with constraints
// Sometimes we want to restrict the types that can be used with our generic class or method. For example, we might want to ensure that T is a class (reference type) or that it implements a certain interface. 
// This is where constraints come in.
*/
/*
using System;

class Program
{
    // We use 'where T : IComparable' because we want to compare two values.
    // Not all types can be compared (e.g., you can't compare two random Classes).
    // This ensures that whatever T is, it MUST support comparison.
    static T GetMax<T>(T val1, T val2) where T : IComparable
    {
        var result = val1.CompareTo(val2);
        // .CompareTo is a method provided by the IComparable interface
        if (val1.CompareTo(val2) > 0)
        {
            return val1;
        }
        return val2;
    }

    static void Main()
    {
        // This works because 'int' is comparable
        int maxInt = GetMax(10, 20);
        Console.WriteLine($"Max Int: {maxInt}");

        // This works because 'string' is comparable (alphabetical order)
        string maxStr = GetMax("Apple", "Zebra");
        Console.WriteLine($"Max String: {maxStr}");
        
        // If you tried to use a custom class that doesn't implement IComparable,
        // the code wouldn't even compile! This prevents runtime crashes.
    }
}
*/

//Real Life Case Scenerios
/*
using System;

// A generic response class to wrap any data coming from a database/API

public class PropertyResponse
{
    public string name {get; set;}
}

class ApiResponse<T>
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Data { get; set; } // This can be a User, a Product, a List, etc.

    public ApiResponse(bool success, string msg, T data)
    {
        IsSuccess = success;
        Message = msg;
        Data = data;
    }
}

class Program
{
    static void Main()
    {
        // The API returns a string message
        ApiResponse<string> nameResponse = new ApiResponse<string>(true, "Success", "John Doe");
        Console.WriteLine($"API Result: {nameResponse.Data}");

        // The API returns an integer ID
        ApiResponse<int> idResponse = new ApiResponse<int>(true, "Success", 5001);
        Console.WriteLine($"API ID: {idResponse.Data}");

        ApiResponse<PropertyResponse> propertyResponse = new ApiResponse<PropertyResponse>(true, "Success", new PropertyResponse { name = "My Property" });
    }
}
*/



//*************************************************** Task ******************************************************//
/*
Asynchronous programming allows your program to start a long-running task and "yield" the 
CPU to do other work while waiting for that task to complete. 
Once the task is finished, the program resumes where it left off.

keywords:
async: Marks a method as asynchronous, allowing it to use the await keyword inside.
await: Used to pause the execution of an async method until the awaited Task completes. It does not block the thread; instead, it allows other work to run while waiting.   


Task and Task<T>
Task: Represents a single operation that does not return a value (similar to void).
Task<T>: Represents an operation that will eventually return a value of type T.
*/

/*
//basic implementation
using System;
using System.Threading.Tasks;
using System.Net.Http;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting application...");

        // We call the async method and 'await' it
        string content = await DownloadWebsiteAsync("https://www.microsoft.com");

        Console.WriteLine($"Downloaded {content.Length} characters.");
        Console.WriteLine("Application finished.");
    }

    // 'async' modifier allows use of 'await'
    // 'Task<string>' means this method will eventually return a string
    static async Task<string> DownloadWebsiteAsync(string url)
    {
        Console.WriteLine("Downloading website... (this takes time)");

        using (HttpClient client = new HttpClient())
        {
            // await tells the program to pause here and free up the thread
            // until GetStringAsync is finished.
            string result = await client.GetStringAsync(url);
            
            return result;
        }
    }
}
*/

/*
//Running Task in parallel
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

class ParallelExample
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Start three tasks WITHOUT awaiting them immediately
        Task<string> task1 = DoWorkAsync("Task 1", 3000);
        Task<string> task2 = DoWorkAsync("Task 2", 1000);
        Task<string> task3 = DoWorkAsync("Task 3", 2000);

        string task5 = await DoWorkAsync("Task 5", 3000);
        string task6 = await DoWorkAsync("Task 6", 1000);
        string task7 = await DoWorkAsync("Task 7", 2000);

        Console.WriteLine("Tasks have been started. Waiting for all to finish...");

        // Task.WhenAll waits for all tasks in the list to complete
        string[] results = await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        foreach (var res in results)
        {
            Console.WriteLine(res);
        }

        // Total time will be ~3 seconds (the longest task), NOT 6 seconds.
        Console.WriteLine($"Total time elapsed: {stopwatch.ElapsedMilliseconds}ms");
    }

    static async Task<string> DoWorkAsync(string name, int delay)
    {
        await Task.Delay(delay); // Simulate work
        return $"{name} completed after {delay}ms";
    }
}
*/

/*
//handling exceptions in async methods
//Task.Run forces the code inside to run on a DIFFERENT thread (ThreadPool)

static async Task ProcessDataAsync()
{
    try
    {
        await Task.Run(() => {
            throw new InvalidOperationException("Something went wrong in the background!");
        });
    }
    catch (InvalidOperationException ex)
    {
        // Exceptions are "unwrapped" by await and caught here
        Console.WriteLine($"Caught exception: {ex.Message}");
    }
}
*/

/*
//Cancellation Tokens allow you to signal that an async operation should stop before it completes. 
//This is essential for long-running tasks or when the user wants to cancel an operation.
//await client.GetStringAsync(url).ConfigureAwait(false);
//Why? By default, await tries to return to the original "context" (e.g., the UI thread). 
//ConfigureAwait(false) tells the program it doesn't need to return to the original context, which improves performance and prevents deadlocks.
using System;
using System.Threading;
using System.Threading.Tasks;
class CancellationExample
{
    static async Task Main()
    {
        // 1. Create a CancellationTokenSource
        CancellationTokenSource cts = new CancellationTokenSource();

        // Start the task and pass the token
        Task downloadTask = DownloadWithCancelAsync(cts.Token);

        // Simulate user clicking "Cancel" after 2 seconds
        await Task.Delay(2000);
        Console.WriteLine("User clicked cancel. Cancelling task...");
        cts.Cancel(); 

        try 
        {
            await downloadTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Task was successfully cancelled.");
        }
    }

    static async Task DownloadWithCancelAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            // Check if cancellation was requested
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"Downloading chunk {i}...");
            await Task.Delay(1000, token); // Pass token to Delay as well
        }
    }
}
*/

/*
//.Result or .Wait()
//Calling .Result or .Wait() on a task blocks the current thread until the task completes. This often leads to Deadlocks, especially in UI applications.
//Multithreading in C# tells the OS: "Please create a new Software Thread and schedule it onto a Hardware Thread/Core."
//Async/Await tells the OS: "I'm going to wait for the network; you can take this Software Thread off the CPU Core and let another thread use it until the data arrives." (This avoids wasting a CPU core's time on a thread that is just sitting there waiting).
Standard Await await SendEmailAsync(); $\rightarrow$ Program stops -> Waits for Email $\rightarrow$ Email finishes $\rightarrow$ Program continues. (User sees a freeze/pause)
The _ = Task.Run approach _ = Task.Run(async () => { await SendEmailAsync(); }); -> Program tells background thread to start $\rightarrow$ Program immediately continues to next line. (User sees zero pause)
*/


//Sending Email and Fire and Forget
/*
public void OnSendButtonClick()
{
    // 1. Give the user immediate feedback (Random Message)
    string[] messages = { "Sending your email...", "Working on it!", "Almost there...", "Dispatching mail..." };
    string randomMsg = messages[new Random().Next(messages.Length)];
    
    Console.WriteLine(randomMsg); 
    // Or if UI: myLabel.Text = randomMsg;

    // 2. Fire and Forget the email work
    // We use Task.Run to push the work to a background thread immediately
    // The '_' is a 'discard' variable, telling C# we intentionally aren't awaiting this.
    _ = Task.Run(async () => 
    {
        try 
        {
            await SendEmailAsync(); 
        }
        catch (Exception ex) 
        {
            // Since you don't care if it fails, we just log it.
            // IMPORTANT: You MUST have a try-catch here, or a crash in the 
            // background could kill your entire application.
            Console.WriteLine($"Background email failed: {ex.Message}");
        }
    });

    // 3. The code reaches here INSTANTLY.
    // The user is now free to do other things while the email sends.
    Console.WriteLine("You can keep using the app while we send the mail!");
}

public async Task SendEmailAsync()
{
    // Simulate network delay
    await Task.Delay(5000); 
    Console.WriteLine("Email actually sent in background!");
}
*/




/*
C# Basics (Variable, Data Types...)
Control Flow (If, Switch, Loops...)
Functions and Methods (Parameters, Return Types, Overloading)
How C# Works (Compilation, CLR, JIT)
OOP (Classes, Objects, Inheritance, Polymorphism)
Advanced OOP (Abstract Classes, Interfaces, Encapsulation, Exception Handling)
Collections
LINQ
File Operation IO
Struct, Records, Tuple, Delegates, Events
Generics (Generic Methods, Classes, Constraints)
Asynchronous Programming (async/await, Tasks, Cancellation)
*/




/*
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("*********************************************************");
Console.WriteLine("*********************************************************");
Console.WriteLine("******************  Practice Session  *******************");
Console.WriteLine("*********************************************************");
Console.WriteLine("*********************************************************");
Console.ResetColor();
*/


//************************************************************************************* Practice Problems *********************************************************************// 
/*
1.⁠ ⁠Create an immutable record called Order and asynchronously process a list of orders using a generic Repository<T> to calculate total revenue.
2.⁠ ⁠Write a generic method ProcessAsync<T> that accepts a list of records and simulates processing each item using Task.Delay and async/await.
3.⁠ ⁠Use Task.WhenAll to process multiple Order records in parallel and return a new modified record using the with expression.
4.⁠ ⁠Create a generic method with constraint where T : IComparable<T> to find the highest value (e.g., highest order amount) from asynchronously processed data.
5.⁠ ⁠Design a flow where records are fetched asynchronously, stored in a generic repository, processed in parallel, and the final result is printed in a non-blocking way.
*/
//Solution:
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{
    // 1. Immutable record called Order. 
    // Positional parameters make this record immutable by default.
    public record Order(int OrderId, decimal Amount, bool IsProcessed = false);

    // 1. Generic Repository<T> to store and manage data.
    public class Repository<T>
    {
        private readonly List<T> _storage = new();

        public void SaveAll(IEnumerable<T> items) => _storage.AddRange(items);
        public List<T> GetAll() => _storage;
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting non-blocking order processing flow...\n");

            // 5. Design a flow: Fetch -> Store -> Process -> Print
            // We use 'await' to ensure the main thread isn't blocked while waiting for I/O or processing.
            var orders = await FetchOrdersAsync(); 
            
            var repository = new Repository<Order>();
            repository.SaveAll(orders);

            // 3. Process multiple records in parallel and return modified records using 'with'
            // We pass a lambda that uses the 'with' expression to change the IsProcessed flag.
            var processedOrders = await ProcessAsync(
                repository.GetAll(), 
                order => order with { IsProcessed = true }
            );

            // Calculate total revenue
            decimal totalRevenue = processedOrders.Sum(o => o.Amount);
            Console.WriteLine($"Total Revenue: ${totalRevenue:F2}");

            // 4. Use the generic method with IComparable constraint to find the highest amount
            // We extract the amounts from the processed orders to find the max.
            var amounts = processedOrders.Select(o => o.Amount).ToList();
            decimal maxAmount = FindMax(amounts);

            Console.WriteLine($"Highest Order Amount: ${maxAmount:F2}");
            Console.WriteLine("\nFlow completed successfully.");
        }

        // Simulation of fetching data asynchronously
        private static async Task<List<Order>> FetchOrdersAsync()
        {
            await Task.Delay(500); // Simulate network latency
            return new List<Order>
            {
                new Order(1, 150.50m),
                new Order(2, 200.00m),
                new Order(3, 50.25m),
                new Order(4, 450.75m),
                new Order(5, 120.00m)
            };
        }

        // 2. Generic method ProcessAsync<T>
        // Accepts a list of records and a transformation function.
        // This allows the method to remain generic while still allowing specific records to be modified.
        public static async Task<List<T>> ProcessAsync<T>(List<T> items, Func<T, T> transform)
        {
            // Create a list of tasks to process items in parallel
            var tasks = items.Select(async item =>
            {
                // Simulate processing time (e.g., database update, API call)
                await Task.Delay(100); 
                
                // Return the modified record using the transformation function provided (which uses 'with')
                return transform(item);
            });

            // 3. Use Task.WhenAll to process all tasks in parallel
            T[] results = await Task.WhenAll(tasks);
            return results.ToList();
        }

        // 4. Generic method with constraint where T : IComparable<T>
        // This ensures that the type T can be compared to another T to determine which is "greater".
        public static T FindMax<T>(IEnumerable<T> items) where T : IComparable<T>
        {
            if (items == null || !items.Any())
                throw new ArgumentException("Collection cannot be empty");

            T max = items.First();
            foreach (var item in items)
            {
                // CompareTo returns > 0 if the current item is greater than 'max'
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
*/