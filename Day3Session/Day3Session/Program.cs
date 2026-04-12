//Control Flow
/*
1. if else
2. switch case
3. loops (for, while, do-while, foreach)
4. break and continue
*/

//If else statement
/*
    if(condition)
    {
        //code to execute if condition is true
    }
    else if(condition2)
    {
        //code to execute if condition2 is true
    }
    else
    {
        //code to execute if condition is false
    }
*/

//If Else Example
/*
Console.WriteLine("Enter the color of the traffic light:");
string trafficLight = Console.ReadLine().ToUpper(); // Convert input to uppercase for case-insensitive comparison
if(trafficLight == "RED")
{
    Console.ForegroundColor = ConsoleColor.Red; // Change text color to red
    Console.WriteLine("Stop");
}
else if(trafficLight == "YELLOW")
{
    Console.ForegroundColor = ConsoleColor.Yellow; // Change text color to yellow
    Console.WriteLine("Get Ready");
}
else if(trafficLight == "GREEN")
{
    Console.ForegroundColor = ConsoleColor.Green; // Change text color to green
    Console.WriteLine("Go");
}
else
{
    Console.WriteLine("Invalid traffic light color");
}
*/


//Switch case statement
/*
    switch(expression)
    {
        case value1:
            //code to execute if expression equals value1
            break;
        case value2:
            //code to execute if expression equals value2
            break;
        default:
            //code to execute if expression does not match any case
            break;
    }
*/

// Switch Case Example
/*
string dayName;
Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");
int dayOfWeek = int.Parse(Console.ReadLine());
switch(dayOfWeek)
{
    case 1:
        dayName = "Sunday";
        break;
    case 2:
        dayName = "Monday";
        break;
    case 3:
        dayName = "Tuesday";
        break;
    case 4:
        dayName = "Wednesday";
        break;
    case 5:
        dayName = "Thursday";
        break;
    case 6:
        dayName = "Friday";
        break;
    case 7:
        dayName = "Saturday";
        break;
    default:
        dayName = "Invalid day of the week";
        break;
}
Console.WriteLine($"The day is {dayName}"); 
*/

//Loops
/*
1. For loop
2. While loop
3. Do-while loop
4. Foreach loop
*/

//For loop
/*
    int initialization = 0; // Initialize loop variable
    while(initialization < 5) // Condition to continue loop
    initizialization++; // Increment loop variable
    for(initialization; condition; increment/decrement)
    {
        //code to execute
    }

    for(int i = initialization; i < condition; i += increment/decrement)
    {
        //code to execute
    }

*/
//For Loop Example
/*
int sum = 0;
Console.WriteLine("Calculating the sum of the first user defined natural numbers...");
int maxNumber = int.Parse(Console.ReadLine());
for(int i = 1; i <= maxNumber; i++)
{
    sum += i; // Add i to sum
}
Console.WriteLine($"The sum of the first user defined natural numbers is: {sum}");
*/

//While loop
/*
    while(condition)
    {      
        //code to execute
    }
*/
//While Loop Example
/*
Console.WriteLine("Counting from 1 to user defined number using a while loop...");
int count = 0;
int maxCount = int.Parse(Console.ReadLine());
Console.WriteLine($"Counting from 1 to {maxCount} using a while loop...");
while(count < maxCount)
{           
    count++;
    Console.WriteLine(count); 
}
*/

//Do-while loop
/*
    do
    {
        //code to execute               
    } while(condition);
*/
//Do-While Loop Example
/*
Console.WriteLine("Counting from 1 to user defined number using a do-while loop...");           
int count = 0;
int maxCount = int.Parse(Console.ReadLine());
Console.WriteLine($"Counting from 1 to {maxCount} using a do-while loop...");
do
{
    count++;
    Console.WriteLine(count);
} while(count < maxCount);  
*/

//Foreach loop
/*
    foreach(var item in collection)
    {
        //code to execute
    }
*/
//Foreach Loop Example
/*
Console.WriteLine("Enter the number of elements in the array:");    
int arraySize = int.Parse(Console.ReadLine());
int[] numbers = new int[arraySize];
Console.WriteLine($"Enter {arraySize} integers:");
foreach(int i in numbers)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("The numbers you entered are:");
foreach(int i in numbers)
{
    Console.WriteLine(i);
}
*/


/*
string[] shoppingList = { "Milk", "Bread", "Eggs", "Butter", "Cheese" };
Console.WriteLine("Your shopping list:");
foreach(string item in shoppingList)
{
    Console.WriteLine(item);
}
*/


//Break and Continue
/*
1. break - exits the current loop or switch statement
2. continue - skips the current iteration of the loop and moves to the next iteration
*/

//break Example
/*
Console.WriteLine("Searching for a student named mentioned by the user in the class...");
string studentName = Console.ReadLine().ToUpper(); // Convert input to uppercase for case-insensitive comparison
string [] students = { "Alice", "Bob", "Charlie", "David", "Eve" };
Console.WriteLine("Students in the class:");
for(int i = 0; i < students.Length; i++)
{
    if(students[i].ToUpper() == studentName)
    {
        Console.WriteLine($"{studentName} is found, breaking the loop.");
        break; // Exit the loop when Charlie is found
    }
    Console.WriteLine(students[i]);
}
*/

//continue Example
/*
for(int i = 1; i <= 10; i++)
{
    if(i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i); // Print odd numbers
}
*/