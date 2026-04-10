// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//identifiers
var name = "John";
var _name = "Doe";


//data type
int age = 30;
string city = "New York";
double salary = 50000.50;
bool isEmployed = true;

//value type
// photocopy
int x = 10;
int y = x; // y is a copy of x
y = 20; // changing y does not affect x
Console.WriteLine($"x: {x}, y: {y}"); // Output: x


//reference type
// abc = sdfdsf
// bcd = abc
// bcd = sadfdsf
//print abc;



//variables
int a;
string b;


//constants
//compile time constant
const double PI = 3.14159;
PI = 3.14; // This will cause a compile-time error because PI is a constantq


//readonly variables
readonly int MAX_VALUE = DateTime.Now.Year;


//operators
// +, - , *, / , % , ++, --, ==, !=, >, <, >=, <=, &&, ||, !, =, ?:

int num1 = 10;
int num2 = 5;
int sum = num1 + num2; // 15
int difference = num1 - num2; // 5
int product = num1 * num2; // 50
int quotient = num1 / num2; // 2
int remainder = num1 % num2; // 0

string str1 = "Hello";
string str2 = "World";


var abc = str1 == str2 ? "Strings are equal"; : "not equal"; // false

if(str1 == str2 || 1==2)
{
    Console.WriteLine("Strings are equal");
}
else
{
    Console.WriteLine("Strings are not equal");
}

string combined = str1 + " " + str2; // "Hello World"

int count = 0;
count++; // count is now 1
count--; // count is now 0


//keywords


var using = "sdf    dsf"; // This will cause a compile-time error because 'using' is a reserved keyword in C#.






//PascalCase
//class, method, namespace 


//camelCase
var firstName = "John";
//variable, parameter






