/*
 1. Collections
    i. Arrays
    ii. List
    iii. Dictionary
    iv. HashSet
    v. Queue
    vi. Stack
 2. LINQ
 3. File Operations 

*/

/*
// IEnumerable & IEnumerator — The Foundation
// Everything in C# that can be looped over implements IEnumerable. It is the base interface.
// Understanding it helps you grasp how foreach works under the hood.
// IEnumerable is the base interface for all collections
// Any class that has GetEnumerator() can be used in a foreach loop
//IEnumerable = 'I can be looped'. IEnumerator = 'I do the actual looping'. You rarely implement these manually — C# collections already do it for you.
using System;
using System.Collections;
// Custom class implementing IEnumerable
public class NumberRange : IEnumerable
{
    private int[] numbers;
    public NumberRange(int[] nums) => numbers = nums;
    // Must implement GetEnumerator
    public IEnumerator GetEnumerator()
    {
        return numbers.GetEnumerator();
    }
}
class Program
{
    static void Main()
    {
        var range = new NumberRange(new[] { 10, 20, 30, 40, 50 });
        // foreach works because NumberRange implements IEnumerable
        foreach (var num in range)
        {
            Console.WriteLine(num); // Output: 10, 20, 30, 40, 50
        }
        // Manual way (what foreach does internally)
        IEnumerator e = range.GetEnumerator();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}
*/


//********************************************************** Collections ****************************************************//
//************************************************************* Arrays ******************************************************//
//Arrays store a fixed number of elements of the same type. Size cannot change after creation. Best used when you know the exact count upfront.
//Use an array when the size is known and fixed — like the 12 months, 7 days of week, or a chess board (8x8).
/*
class ArrayExamples
{
    static void Main()
    {
        // ── 1D Array ──────────────────────────────────────────
        int[] scores = new int[5];        // Creates array of 5 zeros
        scores[0] = 95;
        scores[1] = 87;
        scores[2] = 92;
 
        // Initialize with values directly
        string[] fruits = { "Apple", "Banana", "Cherry", "Mango" };
 
        // Access elements
        Console.WriteLine(fruits[0]);       // Apple
        Console.WriteLine(fruits.Length);   // 4
 
        // Loop through array
        foreach (string fruit in fruits)
            Console.WriteLine(fruit);
 
        // ── Array Methods ─────────────────────────────────────
        int[] numbers = { 5, 3, 8, 1, 9, 2 };
 
        Array.Sort(numbers);               // Sort in place
        Console.WriteLine(string.Join(", ", numbers)); // 1,2,3,5,8,9
 
        Array.Reverse(numbers);            // Reverse
        Console.WriteLine(string.Join(", ", numbers)); // 9,8,5,3,2,1
 
        int index = Array.IndexOf(numbers, 5); // Find index of 5
        Console.WriteLine(index);          // 2
 
        // Copy array
        int[] copy = new int[6];
        Array.Copy(numbers, copy, numbers.Length);
 
        // ── 2D Array ──────────────────────────────────────────
        int[,] matrix = new int[3, 3];     // 3x3 grid
        matrix[0, 0] = 1; matrix[0, 1] = 2; matrix[0, 2] = 3;
        matrix[1, 0] = 4; matrix[1, 1] = 5; matrix[1, 2] = 6;
 
        // Initialize 2D array with values
        int[,] grid = { {1,2,3}, {4,5,6}, {7,8,9} };
 
        // Loop through 2D array
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int col = 0; col < grid.GetLength(1); col++)
                Console.Write(grid[row, col] + " ");
            Console.WriteLine();
        }
 
        // ── Jagged Array (Array of Arrays) ────────────────────
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };
 
        foreach (var row in jagged)
            Console.WriteLine(string.Join(", ", row));
    }
}
*/





//************************************************************* Lists ******************************************************//
// List<T> is your go-to collection.
// It resizes automatically as you add items. It's like an array but flexible. 
/*
class ListExamples
{
    static void Main()
    {
        // Create a list
        List<string> names = new List<string>();
 
        // Add items
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("Diana");
 
        // Add multiple at once
        names.AddRange(new[] { "Eve", "Frank" });
 
        // Insert at specific position
        names.Insert(1, "Anna");  // Insert at index 1
 
        Console.WriteLine($"Count: {names.Count}");       // 7
        Console.WriteLine($"First: {names[0]}");          // Alice
        Console.WriteLine($"Last:  {names[names.Count-1]}"); // Frank
 
        // Check if item exists
        Console.WriteLine(names.Contains("Bob"));         // True
 
        // Find index
        Console.WriteLine(names.IndexOf("Charlie"));      // 3 (after insert)
 
        // Remove items
        names.Remove("Anna");         // Remove by value
        names.RemoveAt(0);            // Remove by index
        names.RemoveAll(n => n.StartsWith("E")); // Remove where condition
 
        // Sort
        names.Sort();
 
        // Loop
        foreach (string name in names)
            Console.WriteLine(name);
 
        // Convert to array
        string[] arr = names.ToArray();
 
        // Clear all
        names.Clear();
        Console.WriteLine($"After clear: {names.Count}"); // 0
 
        List<Student> studentsNew = new List<Student>();
        Student studentValue = new Student();
        studentValue.Name = "Rashik";
        studentValue.Grade = 12;
        studentsNew.Add(studentValue);
        
        Student studentValue1 = new Student();
        studentValue1.Name = "Hari";
        studentValue1.Grade = 11;
        studentsNew.Add(studentValue1);
        
        
        // ── List of objects ───────────────────────────────────
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Grade = 90 },
            new Student { Name = "Bob",   Grade = 75 },
            new Student { Name = "Carol", Grade = 88 }
        };
        
        // Find first match
        Student top = students.Find(s => s.Grade > 85);
        Console.WriteLine(top.Name);  // Alice
 
        // Find all matches
        List<Student> passing = students.FindAll(s => s.Grade >= 80);
        Console.WriteLine(passing.Count); // 2
    }
}
 
class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
*/


//************************************************************* Dictionary ******************************************************//
//Dictionary stores items as key-value pairs. Keys must be unique.
//Perfect for lookups — like a phone book (name → phone number).
/*
class DictionaryExamples
{
    static void Main()
    {
        // Create dictionary (key=string, value=int)
        Dictionary<string, int> ages = new Dictionary<string, int>();
 
        // Add entries
        ages["Alice"]   = 30;
        ages["Bob"]     = 25;
        ages["Bob"]     = 27;
        ages["Charlie"] = 35;
        ages.Add("Diana", 28);
 
        // Access by key
        Console.WriteLine(ages["Alice"]);         // 30
 
        // Safe access with TryGetValue (no exception if missing)
        if (ages.TryGetValue("Bob", out int bobAge))
            Console.WriteLine($"Bob is {bobAge}"); // Bob is 25
 
        // Check if key exists
        Console.WriteLine(ages.ContainsKey("Eve"));  // False
        Console.WriteLine(ages.ContainsValue(35));    // True
 
        // Update a value
        ages["Alice"] = 31;
 
        // Remove
        ages.Remove("Bob");
 
        // Loop through keys
        foreach (string name in ages.Keys)
            Console.WriteLine(name);
 
        // Loop through values
        foreach (int age in ages.Values)
            Console.WriteLine(age);
 
        // Loop through both (KeyValuePair)
        foreach (KeyValuePair<string, int> entry in ages)
            Console.WriteLine($"{entry.Key} => {entry.Value}");
 
        // Shorter syntax with var
        foreach (var (name, age) in ages)
            Console.WriteLine($"{name} is {age} years old");
 
        // ── Word frequency counter example ────────────────────
        string sentence = "apple banana apple cherry banana apple";

        //var abc = sentence.Split(' ');
        
        Dictionary<string, int> freq = new Dictionary<string, int>();
 
        foreach (string word in sentence.Split(' '))
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }
 
        foreach (var pair in freq)
            Console.WriteLine($"{pair.Key}: {pair.Value}x");
    }
}
*/


//************************************************************* HashSet ******************************************************//
//HashSet stores only unique items.
//Automatically ignores duplicates. Great for checking membership and removing duplicates.
/*
class HashSetExamples
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
 
        // Duplicates are ignored automatically
        set1.Add(3);   // Already exists — nothing happens
        set1.Add(6);
        Console.WriteLine(set1.Count);  // 6 (not 7, no duplicate 3)
 
        // Check membership — O(1) speed
        Console.WriteLine(set1.Contains(3));  // True
        Console.WriteLine(set1.Contains(99)); // False
 
        // ── Set operations ────────────────────────────────────
 
        // Union — all items from both sets
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        Console.WriteLine("Union: " + string.Join(",", union));
 
        // Intersection — items in BOTH sets
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine("Intersection: " + string.Join(",", intersection));
 
        // Difference — items in set1 NOT in set2
        HashSet<int> diff = new HashSet<int>(set1);
        diff.ExceptWith(set2);
        Console.WriteLine("Difference: " + string.Join(",", diff));
 
        // ── Remove duplicates from a list ──────────────────────
        List<string> withDupes = new List<string>
            { "cat", "dog", "cat", "bird", "dog", "fish" };
 
        HashSet<string> unique = new HashSet<string>(withDupes);
        Console.WriteLine(string.Join(", ", unique)); // cat, dog, bird, fish
    }
}
*/


//************************************************************* Queue And Stack ******************************************************//
//Queue = First In, First Out (FIFO) — like a checkout line.
//Stack = Last In, First Out (LIFO) — like a stack of plates.
/*
class QueueStackExamples
{
    static void Main()
    {
        // ── Queue<T> (FIFO — First In First Out) ──────────────
        Queue<string> ticketLine = new Queue<string>();
 
        // Enqueue = join the line
        ticketLine.Enqueue("Alice");
        ticketLine.Enqueue("Bob");
        ticketLine.Enqueue("Charlie");
 
        Console.WriteLine($"In line: {ticketLine.Count}");       // 3
        Console.WriteLine($"Next up: {ticketLine.Peek()}");      // Alice (don't remove)
 
        // Dequeue = serve the first person
        string served = ticketLine.Dequeue();
        Console.WriteLine($"Served: {served}");                  // Alice
        Console.WriteLine($"Remaining: {ticketLine.Count}");     // 2
 
        // Process entire queue
        while (ticketLine.Count > 0) 
            Console.WriteLine($"Serving: {ticketLine.Dequeue()}");
 
 
        // ── Stack<T> (LIFO — Last In First Out) ───────────────
        Stack<string> browserHistory = new Stack<string>();
 
        // Push = visit a page
        browserHistory.Push("google.com");
        browserHistory.Push("github.com");
        browserHistory.Push("stackoverflow.com");
 
        Console.WriteLine($"Current page: {browserHistory.Peek()}"); // stackoverflow.com
 
        // Pop = press Back button
        string back = browserHistory.Pop();
        Console.WriteLine($"Went back from: {back}");  // stackoverflow.com
        Console.WriteLine($"Now on: {browserHistory.Peek()}"); // github.com
 
        // ── Real use: Undo system ──────────────────────────────
        Stack<string> undoStack = new Stack<string>();
        undoStack.Push("Typed 'Hello'");
        undoStack.Push("Typed ' World'");
        undoStack.Push("Deleted 'World'");
 
        Console.WriteLine("Undo: " + undoStack.Pop()); // Undo last action
        Console.WriteLine("Undo: " + undoStack.Pop()); // Undo second-to-last
    }
}
*/



//*************************************************** LINQ (Language Integrated Query) ******************************************************//
//LINQ lets you query any collection (arrays, lists, databases, XML) using a clean, readable syntax — similar to SQL but inside C#. 
//There are two ways to write LINQ:
//Query Syntax (SQL-like) and
//Method Syntax (using lambda functions). Both produce the same results.
// The same query written both ways — both give identical results

// select * from tblAbc abc where abc.Name = "Rashik"

/*
int[] numbers = { 5, 3, 9, 1, 7, 2, 8, 4, 6 };
// Query Syntax (looks like SQL)
var result1 = from n in numbers
              where n > 4
              orderby n
              select n;
Console.WriteLine(string.Join(",", result1));
// Method Syntax (chained methods)
var result2 = numbers.Where(n => n > 4).OrderBy(n => n);
foreach(var r in result2)
{
    Console.WriteLine(r);
}
Console.WriteLine(string.Join(",", result2));
// Both give: 5, 6, 7, 8, 9
*/




/* 
// Our data model
class Product
{
    public int    Id       { get; set; }
    public string Name     { get; set; }
    public string Category { get; set; }
    public double Price    { get; set; }
    public int    Stock    { get; set; }
    public bool   InStock  => Stock > 0;
}

//  Main
class Program
{
    static void Main()
    {
        // Sample data — we'll use this throughout all LINQ examples
        List<Product> products = new List<Product>
        {
            new Product { Id=1, Name="Laptop",    Category="Electronics", Price=999.99, Stock=15 },
            new Product { Id=2, Name="Phone",     Category="Electronics", Price=699.99, Stock=30 },
            new Product { Id=3, Name="Headphones",Category="Electronics", Price=149.99, Stock=0  },
            new Product { Id=4, Name="Desk",      Category="Furniture",   Price=299.99, Stock=8  },
            new Product { Id=5, Name="Chair",     Category="Furniture",   Price=199.99, Stock=12 },
            new Product { Id=6, Name="Notebook",  Category="Stationery",  Price=4.99,  Stock=100 },
            new Product { Id=7, Name="Pen",       Category="Stationery",  Price=1.99,  Stock=500 },
            new Product { Id=8, Name="Monitor",   Category="Electronics", Price=399.99, Stock=0  },
        };


              
        // foreach (var product in products)
        // {
        //     Console.WriteLine(product.Name);
        // }

        //************************************************* Basic filter :Where — Filtering *************************************************
        var expensive = products.Where(p => p.Price > 200);
        foreach (var p in expensive)
            Console.WriteLine($"{p.Name}: ${p.Price}");
        // Laptop, Phone, Desk, Monitor
        
        // Multiple conditions
        var electronics = products.Where(p => p.Category == "Electronics" && p.InStock);
        
        // Query syntax equivalent
        var electronics2 = from p in products
                        where p.Category == "Electronics" && p.InStock
                        select p;
        
        // Filter with string methods
        var containsO = products.Where(p => p.Name.Contains("o", StringComparison.OrdinalIgnoreCase));
        
        // Count filtered results
        int outOfStock = products.Count(p => p.Stock == 0);
        Console.WriteLine($"Out of stock: {outOfStock}");  // 2





        //************************************************* Select — Projection (Transform) *************************************************
        // Get just the names
        var names = products.Select(p => p.Name);
        Console.WriteLine(string.Join(", ", names));
        
        // Get names as uppercase
        var upperNames = products.Select(p => p.Name.ToUpper());
        
        // Create a new anonymous object
        var summary = products.Select(p => new { p.Name, p.Price, Discounted = p.Price * 0.9 });
        
        foreach (var item in summary)
            Console.WriteLine($"{item.Name}: ${item.Price:F2} → ${item.Discounted:F2}");
        
        // Select with index
        var numbered = products.Select((p, i) => $"{i+1}. {p.Name}");
        foreach (var n in numbered)
            Console.WriteLine(n);
        
        // SelectMany — flatten nested collections
        List<List<int>> nested = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 6, 7, 8, 9 }
        };
        
        var flat = nested.SelectMany(list => list);
        Console.WriteLine(string.Join(", ", flat)); // 1,2,3,4,5,6,7,8,9




        

        //************************************************* OrderBy / OrderByDescending — Sorting *************************************************
        // Sort by price ascending
        var cheapest = products.OrderBy(p => p.Price);
        
        // Sort by price descending
        var mostExpensive = products.OrderByDescending(p => p.Price);
        
        // Sort by category, then by price within category
        var sorted = products.OrderBy(p => p.Category).ThenBy(p => p.Price);
        
        foreach (var p in sorted)
            Console.WriteLine($"{p.Category,-15} {p.Name,-15} ${p.Price:F2}");
        
        // Sort strings: alphabetically
        var byName = products.OrderBy(p => p.Name, StringComparer.OrdinalIgnoreCase);
        
        // Query syntax sort
        var sorted2 = from p in products
                    orderby p.Category ascending, p.Price descending
                    select p;





        //************************************************* Aggregate Methods — Count, Sum, Min, Max, Average *************************************************
        // Count
        int total    = products.Count();                           // 8
        int inStock  = products.Count(p => p.Stock > 0);          // 6
        
        // Sum
        double totalValue = products.Sum(p => p.Price);           // sum of all prices
        int totalStock    = products.Sum(p => p.Stock);           // total items
        
        // Min & Max
        double minPrice = products.Min(p => p.Price);             // 1.99
        double maxPrice = products.Max(p => p.Price);             // 999.99
        
        // Find the actual cheapest/most expensive object
        Product cheapest  = products.MinBy(p => p.Price);         // Pen
        Product dearest   = products.MaxBy(p => p.Price);         // Laptop


        


        //************************************************* GroupBy — Grouping *************************************************
        // Group products by category
        var byCategory = products.GroupBy(p => p.Category);
        
        foreach (var group in byCategory)
        {
            Console.WriteLine($"\n=== {group.Key} ===");
            foreach (var p in group)
                Console.WriteLine($"  {p.Name}: ${p.Price}");
        }
        
        // Group and get count/total per group
        var stats = products.GroupBy(p => p.Category).Select(g => new
        {
            Category  = g.Key,
            Count     = g.Count(),
            Total     = g.Sum(p => p.Price),
            Average   = g.Average(p => p.Price),
            MaxPrice  = g.Max(p => p.Price),
        });
        
        foreach (var stat in stats)
            Console.WriteLine($"{stat.Category}: {stat.Count} items, avg ${stat.Average:F2}");
        
        // Query syntax
        var byCategory2 = from p in products
                        group p by p.Category into g
                        select new { Category = g.Key, Count = g.Count() };







        //************************************************* Element Access — First, Last, Single, Any, All *************************************************
        // First — gets first item (throws if empty)
        Product first = products.First();
        Product firstExpensive = products.First(p => p.Price > 500);  // Laptop
        
        // FirstOrDefault — returns null if not found (safe!)
        Product found  = products.FirstOrDefault(p => p.Name == "Laptop");
        Product notFound = products.FirstOrDefault(p => p.Price > 10000); // null
        
        if (found != null)
            Console.WriteLine($"Found: {found.Name}");
        
        // Last / LastOrDefault
        Product last = products.Last();
        Product lastCheap = products.LastOrDefault(p => p.Price < 10);
        
        // Single — expects EXACTLY ONE match (throws if 0 or 2+ found)
        Product laptop = products.Single(p => p.Name == "Laptop");
        Product safe   = products.SingleOrDefault(p => p.Id == 99); // null, no throw
        
        // Any — is there at least one match?
        bool hasExpensive = products.Any(p => p.Price > 900);  // true
        bool hasGames     = products.Any(p => p.Category == "Games"); // false
        
        // All — do ALL items match?
        bool allPositive = products.All(p => p.Price > 0);  // true
        bool allInStock  = products.All(p => p.Stock > 0);  // false
        
        // Contains (direct value check)
        var names = new[] { "Alice", "Bob", "Carol" };
        bool hasBob = names.Contains("Bob");  // true





        //************************************************* Skip, Take, Distinct — Paging & Deduplication *************************************************
        // Take — get first N items
        var top3 = products.OrderByDescending(p => p.Price).Take(3);
        foreach (var p in top3) Console.WriteLine(p.Name);
        
        // Skip — skip first N items
        var after3 = products.Skip(3);
        
        // Skip + Take together = PAGINATION
        int pageSize = 3;
        int page = 1;  // 0-based
        
        var page1 = products.Skip(page * pageSize).Take(pageSize);  // items 1-3
        var page2 = products.Skip(1   * pageSize).Take(pageSize);   // items 4-6
        
        // SkipWhile / TakeWhile — skip/take while condition is true
        int[] numbers = { 2, 4, 6, 7, 8, 10 };
        var evenThenStop = numbers.TakeWhile(n => n % 2 == 0); // 2,4,6 (stops at 7)
        var afterEven    = numbers.SkipWhile(n => n % 2 == 0); // 7,8,10
        
        // Distinct — remove duplicates
        int[] withDupes = { 1, 2, 2, 3, 3, 3, 4 };
        var unique = withDupes.Distinct();
        Console.WriteLine(string.Join(", ", unique));  // 1, 2, 3, 4
        
        // DistinctBy (C# 6+) — unique by a property
        var distinctCategories = products.DistinctBy(p => p.Category);
        foreach (var p in distinctCategories)
            Console.WriteLine(p.Category);  // Electronics, Furniture, Stationery





        //************************************************* Join — Combining Two Collections *************************************************
        // Two data sets to join
        var products2 = new[]
        {
            new { Id = 1, Name = "Laptop",  CategoryId = 1 },
            new { Id = 2, Name = "Desk",    CategoryId = 2 },
            new { Id = 3, Name = "Notebook",CategoryId = 3 },
        };
        
        var categories = new[]
        {
            new { Id = 1, Label = "Electronics" },
            new { Id = 2, Label = "Furniture"   },
            new { Id = 3, Label = "Stationery"  },
        };
        
        // Inner Join — only matching items
        var joined = products2.Join(
            categories,
            p => p.CategoryId,           // key from products
            c => c.Id,                   // key from categories
            (p, c) => new { p.Name, c.Label }  // result shape
        );
        
        foreach (var item in joined)
            Console.WriteLine($"{item.Name} → {item.Label}");
        
        // Query syntax join
        var joined2 = from p in products2
                    join c in categories on p.CategoryId equals c.Id
                    select new { p.Name, c.Label };
        
        // GroupJoin — left outer join equivalent
        var leftJoin = categories.GroupJoin(
            products2,
            c => c.Id,
            p => p.CategoryId,
            (cat, prods) => new { cat.Label, Products = prods }
        );
        
        foreach (var cat in leftJoin)
        {
            Console.Write($"{cat.Label}: ");
            Console.WriteLine(string.Join(", ", cat.Products.Select(p => p.Name)));
        }
        



        //************************************************* Set Operations — Union, Intersect, Except, Zip *************************************************
        int[] a = { 1, 2, 3, 4, 5 };
        int[] b = { 3, 4, 5, 6, 7 };
        
        // Union — all unique items from both
        var union = a.Union(b);
        Console.WriteLine(string.Join(",", union));      // 1,2,3,4,5,6,7
        
        // Intersect — items in BOTH
        var intersect = a.Intersect(b);
        Console.WriteLine(string.Join(",", intersect));  // 3,4,5
        
        // Except — items in a NOT in b
        var except = a.Except(b);
        Console.WriteLine(string.Join(",", except));     // 1,2
        
        // Concat — join two sequences (keeps duplicates)
        var concat = a.Concat(b);
        Console.WriteLine(string.Join(",", concat));     // 1,2,3,4,5,3,4,5,6,7
        
        // Zip — pair items from two collections together
        string[] names = { "Alice", "Bob", "Carol" };
        int[]    scores = { 92,     85,    78 };
        
        var zipped = names.Zip(scores, (name, score) => $"{name}: {score}");
        foreach (var z in zipped)
            Console.WriteLine(z);  // Alice: 92, Bob: 85, Carol: 78






        //************************************************* Deferred vs Immediate Execution *************************************************
        //This is an important concept: 
        //LINQ queries don't run immediately when you write them — they run when you iterate over results (deferred). Use ToList() or ToArray() 
        //to force immediate execution.

        //Common Mistake: Writing a LINQ query in a loop without calling ToList() means the query re-executes every iteration! Always call 
        // .ToList() if you use the result more than once.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
 
        // DEFERRED — query built but NOT run yet
        var query = numbers.Where(n => n > 2);
        
        // Modify the source BEFORE iterating
        numbers.Add(6);
        
        // NOW the query runs — includes 6 because we added it before iteration
        foreach (var n in query)
            Console.WriteLine(n);  // 3, 4, 5, 6
        
        // IMMEDIATE — query runs right now and result is fixed
        List<int> snapshot = numbers.Where(n => n > 2).ToList();
        
        numbers.Add(99);  // Too late — snapshot was already taken
        
        foreach (var n in snapshot)
            Console.WriteLine(n);  // 3, 4, 5, 6 (no 99)
        
        // Force immediate with: ToList(), ToArray(), ToDictionary(), Count(), Sum() etc.
        
        // Convert query result to Dictionary
        var dict = products.ToDictionary(p => p.Id, p => p.Name);
        Console.WriteLine(dict[1]);  // Laptop
        
        // ToLookup — like dictionary but allows multiple values per key
        var lookup = products.ToLookup(p => p.Category);
        foreach (var p in lookup["Electronics"])
            Console.WriteLine(p.Name);
    }
}
*/










//*************************************************** File I/O (Input / Output) ******************************************************//
//File I/O means reading from and writing to files on disk. 
//C# provides powerful classes in System.IO for everything from simple text files to streams, directories, JSON, and more.
/*
// Key namespaces you'll need
using System.IO;           // File, Directory, Path, Stream classes
using System.Text;         // Encoding
using System.Text.Json;    // JSON reading/writing
*/

/*
 
class FileQuickExamples
{
    static void Main()
    {
        string path = "data.txt";
 
        // ── WRITE ─────────────────────────────────────────────
 
        // Write all text (creates or overwrites)
        File.WriteAllText(path, "Hello, File World!\nLine Two");
 
        // Append to existing file
        File.AppendAllText(path, "\nAppended line");
 
        // Write multiple lines
        string[] lines = { "Line 1", "Line 2", "Line 3" };
        File.WriteAllLines("lines.txt", lines);
 
        // Write bytes (binary data)
        byte[] data = { 72, 101, 108, 108, 111 };  // "Hello" in ASCII
        File.WriteAllBytes("bytes.bin", data);
 
        // ── READ ──────────────────────────────────────────────
 
        // Read entire file as one string
        string text = File.ReadAllText(path);
        Console.WriteLine(text);
 
        // Read all lines into an array
        string[] allLines = File.ReadAllLines("lines.txt");
        foreach (string line in allLines)
            Console.WriteLine(line);
 
        // Read bytes
        byte[] bytes = File.ReadAllBytes("bytes.bin");
        Console.WriteLine(System.Text.Encoding.ASCII.GetString(bytes)); // Hello
 
        // ── CHECK & DELETE ────────────────────────────────────
 
        // Check if file exists
        if (File.Exists(path))
            Console.WriteLine("File found!");
 
        // Copy file
        File.Copy(path, "data_backup.txt", overwrite: true);
 
        // Move (rename) file
        //File.Move("data_backup.txt", "backup/data_backup.txt", overwrite: true);
 
        // Delete file
        // File.Delete(path);
 
        // Get file info
        FileInfo info = new FileInfo(path);
        Console.WriteLine($"Size: {info.Length} bytes");
        Console.WriteLine($"Created: {info.CreationTime}");
        Console.WriteLine($"Modified: {info.LastWriteTime}");
    }
}
*/





/*
//FileStream & BinaryReader / BinaryWriter
//FileStream gives you raw byte access. BinaryReader/Writer let you read and write primitive types (int, double, bool) as bytes — great for custom file formats.
class BinaryExamples
{
    static void Main()
    {
        string path = "scores.bin";
 
        // ── Write with BinaryWriter ────────────────────────────
        using (FileStream fs = new FileStream(path, FileMode.Create))
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
            bw.Write("Alice");   // string
            bw.Write(92);        // int
            bw.Write(98.5);      // double
            bw.Write(true);      // bool
 
            bw.Write("Bob");
            bw.Write(85);
            bw.Write(91.0);
            bw.Write(true);
        }
 
        // ── Read with BinaryReader ─────────────────────────────
        using (FileStream fs = new FileStream(path, FileMode.Open))
        using (BinaryReader br = new BinaryReader(fs))
        {
            // Must read in SAME ORDER as written
            string name1   = br.ReadString();
            int    score1  = br.ReadInt32();
            double gpa1    = br.ReadDouble();
            bool   pass1   = br.ReadBoolean();
 
            Console.WriteLine($"{name1}: {score1} pts, GPA {gpa1}, Pass={pass1}");
 
            string name2   = br.ReadString();
            int    score2  = br.ReadInt32();
            double gpa2    = br.ReadDouble();
            bool   pass2   = br.ReadBoolean();
 
            Console.WriteLine($"{name2}: {score2} pts, GPA {gpa2}, Pass={pass2}");
        }
 
        // ── FileStream directly (raw bytes) ───────────────────
        byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello Raw!");
 
        using (FileStream raw = new FileStream("raw.bin", FileMode.Create))
        {
            raw.Write(buffer, 0, buffer.Length);
        }
 
        // Read back
        using (FileStream raw = new FileStream("raw.bin", FileMode.Open))
        {
            byte[] readBack = new byte[raw.Length];
            raw.Read(readBack, 0, readBack.Length);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(readBack));
        }
    }
}
*/




/*
class DirectoryExamples
{
    static void Main()
    {
        // ── Create directories ────────────────────────────────
        Directory.CreateDirectory("output");             // Creates if not exists
        Directory.CreateDirectory("output/reports/2024"); // Creates nested
 
        // ── Check if exists ───────────────────────────────────
        if (Directory.Exists("output"))
            Console.WriteLine("output folder exists");
 
        // ── List files in a folder ─────────────────────────────
        // Create some test files first
        File.WriteAllText("output/report1.txt", "Report 1");
        File.WriteAllText("output/report2.txt", "Report 2");
        File.WriteAllText("output/notes.md",    "Notes");
 
        // Get all files
        string[] allFiles = Directory.GetFiles("output");
        Console.WriteLine("All files:");
        foreach (string f in allFiles)
            Console.WriteLine("  " + f);
 
        // Get files matching a pattern
        string[] txtFiles = Directory.GetFiles("output", "*.txt");
        Console.WriteLine("TXT files:");
        foreach (string f in txtFiles)
            Console.WriteLine("  " + f);
 
        // Get files recursively (all subfolders too)
        string[] allRecursive = Directory.GetFiles("output", "*.*",
            SearchOption.AllDirectories);
 
        // ── List subdirectories ───────────────────────────────
        string[] subdirs = Directory.GetDirectories("output");
 
        // ── Directory info ─────────────────────────────────────
        DirectoryInfo di = new DirectoryInfo("output");
        Console.WriteLine($"Name:     {di.Name}");
        Console.WriteLine($"Full:     {di.FullName}");
        Console.WriteLine($"Parent:   {di.Parent?.Name}");
        Console.WriteLine($"Created:  {di.CreationTime}");
 
        foreach (FileInfo fi in di.GetFiles())
            Console.WriteLine($"  {fi.Name} ({fi.Length} bytes)");
 
        // ── Path utility ───────────────────────────────────────
        string full     = Path.Combine("output", "reports", "file.txt");
        string dir      = Path.GetDirectoryName(full);   // output\reports
        string filename = Path.GetFileName(full);        // file.txt
        string noExt    = Path.GetFileNameWithoutExtension(full); // file
        string ext      = Path.GetExtension(full);       // .txt
        string temp     = Path.GetTempPath();            // system temp
 
        Console.WriteLine(Path.Combine("output", "sub", "file.txt"));
 
        // ── Copy directory (manual — no built-in CopyDirectory) ─
        static void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(dest);
            foreach (string file in Directory.GetFiles(source))
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)), true);
            foreach (string subDir in Directory.GetDirectories(source))
                CopyDirectory(subDir, Path.Combine(dest, Path.GetFileName(subDir)));
        }
 
        // Delete directory (and everything inside)
        //Directory.Delete("output", recursive: true);
    }
}
*/


/*
//Reading & Writing CSV Files
//CSV (Comma Separated Values) is one of the most common file formats. No library needed — we can parse it manually.
using System;
using System.IO;
using System.Collections.Generic;
class CsvExamples
{
    record Student(string Name, int Age, double GPA);
 
    static void Main()
    {
        string csvPath = "students.csv";
 
        // ── Write CSV ─────────────────────────────────────────
        var students = new List<Student>
        {
            new ("Alice", 20, 3.9),
            new ("Bob",   22, 3.5),
            new ("Carol", 21, 3.7),
        };
 
        using (var writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("Name,Age,GPA");   // Header row
            foreach (var s in students)
                writer.WriteLine($"{s.Name},{s.Age},{s.GPA}");
        }
 
        // ── Read CSV ──────────────────────────────────────────
        var loaded = new List<Student>();
 
        using (var reader = new StreamReader(csvPath))
        {
            string header = reader.ReadLine();  // Skip header
            Console.WriteLine($"Headers: {header}");
 
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                loaded.Add(new Student(
                    parts[0],
                    int.Parse(parts[1]),
                    double.Parse(parts[2])
                ));
            }
        }
 
        Console.WriteLine("\nLoaded students:");
        foreach (var s in loaded)
            Console.WriteLine($"  {s.Name}, Age {s.Age}, GPA {s.GPA}");
 
        // ── Using LINQ on CSV data ─────────────────────────────
        var topStudents = loaded.Where(s => s.GPA >= 3.7).OrderByDescending(s => s.GPA);
        Console.WriteLine("\nTop students (GPA >= 3.7):");
        foreach (var s in topStudents)
            Console.WriteLine($"  {s.Name}: {s.GPA}");
    }
}
*/


/*
//JSON Files — System.Text.Json
//JSON is the most popular data format today. C# has built-in JSON support via System.Text.Json (no NuGet needed in .NET 5+).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

// 1. Define the JSON Serializer Context
// This static class tells the compiler what types to generate code for.
[JsonSerializable(typeof(Person))]
[JsonSerializable(typeof(List<Person>))]
[JsonSerializable(typeof(Dictionary<string, object>))]
public partial class CustomJsonContext : JsonSerializerContext
{
}

// 2. Define the Model (Annotated)
[JsonSerializable(typeof(Person))]
public class Person
{
    // NOTE: The attribute on the class level handles all types within it.
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public List<string> Hobbies { get; set; }
}

class JsonExamples
{
    static void Main()
    {
        // 3. Use the Generated Context
        // We pass the CustomJsonContext, which directs the serializer to the
        // optimized, pre-generated code, eliminating the reflection warning.
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            // Specify the context to use the generated code
            TypeInfoResolver = new CustomJsonContext() 
        };

        // ── Serialize (object → JSON string) ──────────────────
        var person = new Person
        {
            Name    = "Alice",
            Age     = 30,
            Email   = "alice@example.com",
            Hobbies = new List<string> { "Reading", "Coding", "Hiking" }
        };

        // NOTICE: We still use the option, but the warning is gone.
        string json = JsonSerializer.Serialize(person, options);
        Console.WriteLine("--- Single Person ---");
        Console.WriteLine(json);

        // ── Write JSON to file ────────────────────────────────
        File.WriteAllText("person.json", json);

        // ── Read JSON from file ───────────────────────────────
        string loadedJson = File.ReadAllText("person.json");
        
        // We MUST use the options context here too!
        Person loadedPerson = JsonSerializer.Deserialize<Person>(loadedJson, options);
        Console.WriteLine($"Loaded: {loadedPerson.Name}, {loadedPerson.Age}");

        // ── List of objects to/from JSON ──────────────────────
        var people = new List<Person>
        {
            new Person { Name="Alice", Age=30, Email="alice@x.com", Hobbies=new(){"Reading"} },
            new Person { Name="Bob",   Age=25, Email="bob@x.com",   Hobbies=new(){"Gaming"} },
        };

        string listJson = JsonSerializer.Serialize(people, options);
        File.WriteAllText("people.json", listJson);

        var loadedPeople = JsonSerializer.Deserialize<List<Person>>(
            File.ReadAllText("people.json"), options);

        Console.WriteLine("\n--- List of People ---");
        Console.WriteLine($"Loaded {loadedPeople.Count} people");
    }
}
*/







/*
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// =====================================================
// 1. THE STRUCTURE DEFINITION (The Model)
// =====================================================

// Level 2: The Student Object
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    
    // *** NESTED LIST ***
    // This is a list of strings (the courses)
    public List<string> EnrolledCourses { get; set; }
}

// Level 1: The Container (The list holding all students)
public class UniversityRoster
{
    // *** THE TOP-LEVEL LIST ***
    // This list holds multiple Student objects.
    public List<Student> Students { get; set; }
}

// =====================================================
// 2. JSON SERIALIZATION CONTEXT (For performance)
// =====================================================

// We must tell the serializer (the compiler) what types are nested.
[JsonSerializable(typeof(UniversityRoster))]
[JsonSerializable(typeof(Student))]
public partial class LibraryContext : JsonSerializerContext
{
    // This context tells the serializer how to handle the nested types.
}

// =====================================================
// 3. THE EXECUTION CODE
// =====================================================

class NestedListExample
{
    static void Main()
    {
        // 1. Initialize the structure
        var roster = new UniversityRoster
        {
            Students = new List<Student>() // Start with an empty outer list
        };

        // 2. Create Student 1 (Student with 3 courses)
        var student1 = new Student
        {
            StudentId = 1001,
            Name = "Alice Johnson",
            // Create the nested list of strings
            EnrolledCourses = new List<string> { "Computer Science", "Calculus I", "English Literature" }
        };

        // 3. Create Student 2 (Student with 2 courses)
        var student2 = new Student
        {
            StudentId = 1002,
            Name = "Bob Smith",
            // Create the nested list of strings
            EnrolledCourses = new List<string> { "Biology", "Chemistry" }
        };

        // 4. Add the created objects to the outer list
        roster.Students.Add(student1);
        roster.Students.Add(student2);

        // 5. Serialize the entire nested structure
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new LibraryContext() 
        };

        string json = JsonSerializer.Serialize(roster, options);
        
        Console.WriteLine("=================================================");
        Console.WriteLine("=== Generated JSON Output (The Nested Data) ===");
        Console.WriteLine("=================================================");
        Console.WriteLine(json);
    }
}

*/