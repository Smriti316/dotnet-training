/*
 1. LINQ
*/



//*************************************************** LINQ (Language Integrated Query) ******************************************************//
//LINQ lets you query any collection (arrays, lists, databases, XML) using a clean, readable syntax — similar to SQL but inside C#. 
//There are two ways to write LINQ:
//Query Syntax (SQL-like) and
//Method Syntax (using lambda functions). Both produce the same results.
// The same query written both ways — both give identical results
// Where -> OrderBy -> Skip/Take -> Select -> ToList

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

        //************************************************* Basic filter :Where — Filtering *************************************************/
        // var expensive = products.Where(p => p.Price > 200);
        // foreach (var p in expensive)
        //     Console.WriteLine($"{p.Name}: ${p.Price}");
        // // Laptop, Phone, Desk, Monitor
        //
        // // Multiple conditions
        // var electronics = products.Where(p => p.Category == "Electronics" && p.InStock);
        //
        // // Query syntax equivalent
        // var electronics2 = from p in products
        //                 where p.Category == "Electronics" && p.InStock
        //                 select p;
        //
        // // Filter with string methods
        // var containsO = products.Where(p => p.Name.Contains("o", StringComparison.OrdinalIgnoreCase));
        //
        // // Count filtered results
        // int outOfStock = products.Count(p => p.Stock == 0);
        // Console.WriteLine($"Out of stock: {outOfStock}");  // 2





        //************************************************* Select — Projection (Transform) *************************************************/
        // // Get just the names
        // var names = products.Select(p => p.Name);
        // Console.WriteLine(string.Join(", ", names));
        
        // // Get names as uppercase
        // var upperNames = products.Select(p => p.Name.ToUpper());
        
        // // Create a new anonymous object
        // var summary = products.Select(p => new { p.Name, p.Price, Discounted = p.Price * 0.9 });
        
        // foreach (var item in summary)
        //     Console.WriteLine($"{item.Name}: ${item.Price:F2} → ${item.Discounted:F2}");
        
        // // Select with index
        // var numbered = products.Select((p, i) => $"{i+1}. {p.Name}");
        // foreach (var n in numbered)
        //     Console.WriteLine(n);
        
        // // SelectMany — flatten nested collections
        // List<List<int>> nested = new List<List<int>>
        // {
        //     new List<int> { 1, 2, 3 },
        //     new List<int> { 4, 5 },
        //     new List<int> { 6, 7, 8, 9 }
        // };
        
        // var flat = nested.SelectMany(list => list);
        // Console.WriteLine(string.Join(", ", flat)); // 1,2,3,4,5,6,7,8,9




        

        //************************************************* OrderBy / OrderByDescending — Sorting *************************************************/
        // // Sort by price ascending
        // var cheapest = products.OrderBy(p => p.Price).ToList();
        //
        // // Sort by price descending
        // var mostExpensive = products.OrderByDescending(p => p.Price).ToList();
        //
        // // Sort by category, then by price within category
        // var sorted = products.OrderBy(p => p.Category).ThenBy(p => p.Price).ToList();
        //
        // foreach (var p in sorted)
        //     Console.WriteLine($"{p.Category,-15} {p.Name,-15} ${p.Price:F2}");
        //
        // // Sort strings: alphabetically
        // var byName = products.OrderBy(p => p.Name, StringComparer.OrdinalIgnoreCase);
        //
        // // Query syntax sort
        // var sorted2 = from p in products
        //             orderby p.Category ascending, p.Price descending
        //             select p;





        //************************************************* Aggregate Methods — Count, Sum, Min, Max, Average *************************************************/
        // // Count
        // int total    = products.Count();                           // 8
        // int inStock  = products.Count(p => p.Stock > 0);          // 6
        //
        // // Sum
        // double totalValue = products.Sum(p => p.Price);           // sum of all prices
        // int totalStock    = products.Sum(p => p.Stock);           // total items
        //
        // // Min & Max
        // double minPrice = products.Min(p => p.Price);             // 1.99
        // double maxPrice = products.Max(p => p.Price);             // 999.99
        //
        // // Find the actual cheapest/most expensive object
        // Product cheapest  = products.MinBy(p => p.Price);         // Pen
        // Product dearest   = products.MaxBy(p => p.Price);         // Laptop


        


        //************************************************* GroupBy — Grouping *************************************************/
        // // Group products by category
        // var byCategory = products.GroupBy(p => p.Category).ToList();
        //
        // foreach (var group in byCategory)
        // {
        //     Console.WriteLine($"\n=== {group.Key} ===");
        //     foreach (var p in group)
        //         Console.WriteLine($"  {p.Name}: ${p.Price}");
        // }
        //
        // // Group and get count/total per group
        // var stats = products.GroupBy(p => p.Category).Select(g => new
        // {
        //     Category  = g.Key,
        //     Count     = g.Count(),
        //     Total     = g.Sum(p => p.Price),
        //     Average   = g.Average(p => p.Price),
        //     MaxPrice  = g.Max(p => p.Price),
        // }).ToList();
        //
        // foreach (var stat in stats)
        //     Console.WriteLine($"{stat.Category}: {stat.Count} items, avg ${stat.Average:F2}");
        //
        // // Query syntax
        // var byCategory2 = from p in products
        //                 group p by p.Category into g
        //                 select new { Category = g.Key, Count = g.Count() };



        
        //************************************************* Element Access — First, Last, Single, Any, All *************************************************/
        // // First — gets first item (throws if empty)
        // Product first = products.First();
        // Product firstExpensive = products.First(p => p.Price > 500);  // Laptop
        //
        // // FirstOrDefault — returns null if not found (safe!)
        // Product found  = products.FirstOrDefault(p => p.Name == "Laptop");
        // Product notFound = products.FirstOrDefault(p => p.Price > 10000); // null
        //
        // if (found != null)
        //     Console.WriteLine($"Found: {found.Name}");
        //
        // // Last / LastOrDefault
        // Product last = products.Last();
        // Product lastCheap = products.LastOrDefault(p => p.Price < 10);
        //
        // // Single — expects EXACTLY ONE match (throws if 0 or 2+ found)
        // Product laptop = products.Single(p => p.Name == "Laptop");
        // Product safe   = products.SingleOrDefault(p => p.Id == 99); // null, no throw
        //
        // // Any — is there at least one match?
        // bool hasExpensive = products.Any(p => p.Price > 900);  // true
        // bool hasGames     = products.Any(p => p.Category == "Games"); // false
        //
        // // All — do ALL items match?
        // bool allPositive = products.All(p => p.Price > 0);  // true
        // bool allInStock  = products.All(p => p.Stock > 0);  // false
        //
        // // Contains (direct value check)
        // var names = new[] { "Alice", "Bob", "Carol" };
        // bool hasBob = names.Contains("Bob");  // true





        //************************************************* Skip, Take, Distinct — Paging & Deduplication *************************************************/
        // // Take — get first N items
        // var top3 = products.OrderByDescending(p => p.Price).Take(3);
        // foreach (var p in top3) Console.WriteLine(p.Name);
        //
        // // Skip — skip first N items
        // var after3 = products.Skip(3);
        //
        // // Skip + Take together = PAGINATION
        // int pageSize = 3;
        // int page = 0;  // 0-based
        //
        // var page1 = products.Skip(page * pageSize).Take(pageSize).ToList();  // items 1-3
        // var page2 = products.Skip(1   * pageSize).Take(pageSize).ToList();   // items 4-6
        //
        // // SkipWhile / TakeWhile — skip/take while condition is true
        // int[] numbers = { 2, 4, 6, 7, 8, 10 };
        // var evenThenStop = numbers.TakeWhile(n => n % 2 == 0).ToList(); // 2,4,6 (stops at 7)
        // var afterEven    = numbers.SkipWhile(n => n % 2 == 0).ToList(); // 7,8,10
        //
        // // Distinct — remove duplicates
        // int[] withDupes = { 1, 2, 2, 3, 3, 3, 4 };
        // var unique = withDupes.Distinct().ToList();
        // Console.WriteLine(string.Join(", ", unique));  // 1, 2, 3, 4
        //
        // // DistinctBy (C# 6+) — unique by a property
        // var distinctCategories = products.DistinctBy(p => p.Category);
        // foreach (var p in distinctCategories)
        //     Console.WriteLine(p.Category);  // Electronics, Furniture, Stationery





        //************************************************* Join — Combining Two Collections *************************************************/
        // // Two data sets to join
        // var products2 = new[]
        // {
        //     new { Id = 1, Name = "Laptop",  CategoryId = 1 },
        //     new { Id = 2, Name = "Desk",    CategoryId = 2 },
        //     new { Id = 3, Name = "Notebook",CategoryId = 3 },
        // };
        //
        // var categories = new[]
        // {
        //     new { Id = 1, Label = "Electronics" },
        //     new { Id = 2, Label = "Furniture"   },
        //     new { Id = 3, Label = "Stationery"  },
        // };
        //
        // // Inner Join — only matching items
        // var joined = products2.Join(
        //     categories,
        //     p => p.CategoryId,           // key from products
        //     c => c.Id,                   // key from categories
        //     (p, c) => new { p.Name, c.Label }  // result shape
        // );
        //
        // foreach (var item in joined)
        //     Console.WriteLine($"{item.Name} → {item.Label}");
        //
        // // Query syntax join
        // var joined2 = from p in products2
        //             join c in categories on p.CategoryId equals c.Id
        //             select new { p.Name, c.Label };
        //
        // // GroupJoin — left outer join equivalent
        // var leftJoin = categories.GroupJoin(
        //     products2,
        //     c => c.Id,
        //     p => p.CategoryId,
        //     (cat, prods) => new { cat.Label, Products = prods }
        // );
        //
        // foreach (var cat in leftJoin)
        // {
        //     Console.Write($"{cat.Label}: ");
        //     Console.WriteLine(string.Join(", ", cat.Products.Select(p => p.Name)));
        // }
        



        //************************************************* Set Operations — Union, Intersect, Except, Zip *************************************************/
        // int[] a = { 1, 2, 3, 4, 5 };
        // int[] b = { 3, 4, 5, 6, 7 };
        //
        // // Union — all unique items from both
        // var union = a.Union(b);
        // Console.WriteLine(string.Join(",", union));      // 1,2,3,4,5,6,7
        //
        // // Intersect — items in BOTH
        // var intersect = a.Intersect(b);
        // Console.WriteLine(string.Join(",", intersect));  // 3,4,5
        //
        // // Except — items in a NOT in b
        // var except = a.Except(b);
        // Console.WriteLine(string.Join(",", except));     // 1,2
        //
        // // Concat — join two sequences (keeps duplicates)
        // var concat = a.Concat(b);
        // Console.WriteLine(string.Join(",", concat));     // 1,2,3,4,5,3,4,5,6,7
        //
        // // Zip — pair items from two collections together
        // string[] names = { "Alice", "Bob", "Carol" };
        // int[]    scores = { 92,     85,    78 };
        //
        // var zipped = names.Zip(scores, (name, score) => $"{name}: {score}").ToList();
        // foreach (var z in zipped)
        //     Console.WriteLine(z);  // Alice: 92, Bob: 85, Carol: 78






        //************************************************* Deferred vs Immediate Execution *************************************************/
        //This is an important concept: 
        //LINQ queries don't run immediately when you write them — they run when you iterate over results (deferred). Use ToList() or ToArray() 
        //to force immediate execution.

        //Common Mistake: Writing a LINQ query in a loop without calling ToList() means the query re-executes every iteration! Always call 
        // // .ToList() if you use the result more than once.
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //
        // // DEFERRED — query built but NOT run yet
        // var query = numbers.Where(n => n > 2);
        //
        // // Modify the source BEFORE iterating
        // numbers.Add(6);
        //
        // // NOW the query runs — includes 6 because we added it before iteration
        // foreach (var n in query)
        //     Console.WriteLine(n);  // 3, 4, 5, 6
        //
        // // IMMEDIATE — query runs right now and result is fixed
        // List<int> snapshot = numbers.Where(n => n > 2).ToList();
        //
        // numbers.Add(99);  // Too late — snapshot was already taken
        //
        // foreach (var n in snapshot)
        //     Console.WriteLine(n);  // 3, 4, 5, 6 (no 99)
        //
        // // Force immediate with: ToList(), ToArray(), ToDictionary(), Count(), Sum() etc.
        //
        // // Convert query result to Dictionary
        // var dict = products.ToDictionary(p => p.Id, p => p.Name);
        // Console.WriteLine(dict[1]);  // Laptop
        //
        // // ToLookup — like dictionary but allows multiple values per key
        // var lookup = products.ToLookup(p => p.Category);
        // foreach (var p in lookup["Electronics"])
        //     Console.WriteLine(p.Name);
    //}
    
//}





//************************************ Practice Session ************************************//

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

1. You have a List<Transaction> (where each object has an Amount, Category, and Date). Write a logic that:
    a. Uses LINQ to filter transactions from the last 30 days.
    b. Groups these transactions by Category and calculates the total sum per category.
    c. Store these results into a Dictionary<string, decimal> (Category as key, Sum as value).
    d. Finally, uses LINQ to return a List of the top 3 categories with the highest spending, sorted descending.


2. Design a simple 'Recent Items' cache system.
    a. Use a Queue<string> to track the order of items added.
    b. Use a HashSet<string> to ensure that no duplicate items are ever added to the queue (check the set before enqueuing).
    c. When the queue exceeds 10 items, remove the oldest item from both the Queue and the HashSet.
    d. Write a method that returns the current cache items as a sorted string[] (Array) using LINQ.


3. You have a List<User> where each user has an Id, Username, and a List<int> of scores.
    a. Create a Dictionary<int, int> where the key is the UserId and the value is the sum of that user's scores (calculated via LINQ).
    b. Using this dictionary, write a LINQ query to find all Usernames whose total score is above the average of all users.
    c. Return the final list of usernames as a List<string> sorted alphabetically.


4. You have a Dictionary<string, List<Employee>> where the key is the Department Name and the value is a list of employees in that department.
    a. Use LINQ SelectMany to flatten all employees from all departments into one single sequence.
    b. Filter this sequence to find employees who earn more than $50,000.
    c. Transform (Project) these employees into a List of their full names (FirstName + LastName).
    d. Convert the final result into an Array.
*/




