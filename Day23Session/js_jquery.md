# JavaScript & jQuery — 2-Day Intensive Course

> **Duration:** 2 Days (approx. 6–7 hours per day)
> **Level:** Beginner to Intermediate — Assumes basic knowledge of HTML/CSS
> **Tools Needed:** VS Code, modern web browser (Chrome/Firefox)

---

## 📋 Course Outline

### Day 1 — JavaScript Fundamentals & The DOM

| Session | Topic | Duration |
|---------|-------|----------|
| 1.1 | Introduction to JS, Console, & Setup | 30 min |
| 1.2 | Variables, Data Types, & Operators | 45 min |
| 1.3 | Control Flow (If/Else, Switch, Loops) | 45 min |
| 1.4 | Functions & Scope | 45 min |
| 1.5 | Arrays & Objects | 60 min |
| 1.6 | The DOM: Selecting & Modifying Elements | 45 min |
| 1.7 | Events & Event Listeners | 45 min |
| 1.8 | **Project:** Interactive To-Do List (Vanilla JS) | 60 min |

### Day 2 — jQuery & API Integration

| Session | Topic | Duration |
|---------|-------|----------|
| 2.1 | Intro to jQuery & Setup | 30 min |
| 2.2 | jQuery Selectors & DOM Traversal | 45 min |
| 2.3 | jQuery Events & Effects (Animations) | 45 min |
| 2.4 | Modifying CSS & HTML with jQuery | 45 min |
| 2.5 | Asynchronous JS & AJAX (Fetch/$.ajax) | 60 min |
| 2.6 | Form Handling & Validation | 45 min |
| 2.7 | **Project:** Movie Search App (API + jQuery) | 90 min |

---

## 🎯 Learning Objectives

By the end of this course, students will be able to:

1. Write basic JavaScript logic (loops, conditionals, functions).
2. Store and manipulate data using Arrays and Objects.
3. Understand the Document Object Model (DOM).
4. Make web pages interactive by responding to user events (clicks, keypresses).
5. Include and use the jQuery library to simplify DOM manipulation.
6. Create smooth UI animations and effects using jQuery.
7. Fetch and display data from external APIs using AJAX.
8. Build a complete, interactive, data-driven web application.

---

## 🛠 Setup Instructions

### 1. Project Folder Structure
```
js-course/
├── day1/
│   ├── 01-basics.html
│   ├── 01-basics.js
│   └── project/
│       ├── index.html
│       ├── style.css
│       └── script.js
├── day2/
│   ├── 01-jquery.html
│   ├── 01-jquery.js
│   └── project/
│       ├── index.html
│       ├── style.css
│       └── script.js
└── lib/
    └── jquery-3.7.1.min.js
```

### 2. Browser Developer Tools
- Open DevTools: `Cmd + Option + I` (Mac) or `F12` (Windows)
- Students will spend 90% of their debugging time in the **Console** tab.

### 3. Including JavaScript
**Internal JS:**
```html
<script>
    console.log("Hello World");
</script>
```

**External JS (Recommended):**
```html
<!-- Place just before the closing </body> tag -->
<script src="script.js"></script>
```

---

## 📚 Resources

- [MDN Web Docs (JavaScript)](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
- [jQuery Official Documentation](https://api.jquery.com/)
- [JavaScript.info](https://javascript.info/)
- [OMDb API](https://www.omdbapi.com/) — Used for Day 2 Project


---

# Day 1 — JavaScript Fundamentals (Part 1)

---

## Session 1.1 — Introduction & Setup (30 min)

### What is JavaScript?
- The programming language of the Web.
- **HTML** = Structure, **CSS** = Style, **JavaScript** = Behavior/Logic.
- Can run in the browser (Frontend) and on the server (Backend via Node.js).

### The Console
The console is your best friend. It's where you print messages and debug code.

```javascript
// This is a single-line comment

/*
   This is a 
   multi-line comment
*/

console.log("Hello, World!");
console.error("This is an error message!");
console.warn("This is a warning!");
```

### 🏋️ Exercise 1.1
1. Create `index.html` and `script.js`.
2. Link the JS file to the HTML using `<script src="script.js"></script>`.
3. Write a `console.log` in your JS file with your name.
4. Open the HTML file in the browser, open DevTools (F12), and check the Console tab.

---

## Session 1.2 — Variables, Data Types & Operators (45 min)

### Variables (`let` and `const`)
Variables store data. We use `let` for values that change, and `const` for values that don't.
*(Note: Avoid using the older `var` keyword).*

```javascript
let age = 25;
age = 26; // Valid: let can be reassigned

const name = "Alice";
// name = "Bob"; // ❌ ERROR: Assignment to constant variable
```

### Data Types
JavaScript is dynamically typed.

```javascript
// 1. String (Text)
let greeting = "Hello";
let template = `Hi, my name is ${name}`; // Template literal (backticks)

// 2. Number (Integers and Decimals)
let price = 19.99;
let count = 42;

// 3. Boolean (True or False)
let isLoggedIn = true;
let hasError = false;

// 4. Undefined (Declared, but no value assigned)
let futureValue; 
console.log(futureValue); // undefined

// 5. Null (Intentional empty value)
let emptyBox = null;
```

### Operators
```javascript
// Math
let sum = 10 + 5;
let remainder = 10 % 3; // 1
sum++; // sum is now 16
sum += 10; // sum is now 26

// Comparison (Always use === and !==)
console.log(5 === 5);   // true  (Strict equality: checks value AND type)
console.log(5 === "5"); // false 
console.log(5 == "5");  // true  (Loose equality: converts type. AVOID THIS!)
console.log(10 > 5);    // true
console.log(10 !== 5);  // true
```

### 🏋️ Exercise 1.2
1. Create a `const` for your birth year.
2. Create a `let` for the current year.
3. Calculate your age and store it in a variable.
4. `console.log` a sentence like: "I was born in 2000, so I am 26 years old" using template literals.

---

## Session 1.3 — Control Flow (45 min)

### If / Else Statements

```javascript
let score = 85;

if (score >= 90) {
    console.log("Grade: A");
} else if (score >= 80) {
    console.log("Grade: B");
} else {
    console.log("Grade: F");
}
```

### Logical Operators
- `&&` (AND) — Both must be true
- `||` (OR) — At least one must be true
- `!` (NOT) — Inverts the boolean

```javascript
let isWeekend = true;
let isRaining = false;

if (isWeekend && !isRaining) {
    console.log("Go to the park!");
} else {
    console.log("Stay home.");
}
```

### Loops (For & While)

**For Loop** (When you know how many times to loop)
```javascript
// for (initialization; condition; increment)
for (let i = 1; i <= 5; i++) {
    console.log(`Iteration number: ${i}`);
}
```

**While Loop** (When looping depends on a condition)
```javascript
let countdown = 3;
while (countdown > 0) {
    console.log(countdown);
    countdown--;
}
console.log("Liftoff! 🚀");
```

### 🏋️ Exercise 1.3
1. Write a `for` loop that prints all even numbers from 2 to 20.
2. Write an `if/else` block that checks a variable `temperature`. If it's above 30, print "It's hot". If below 15, print "It's cold". Otherwise, print "It's nice".

---

## Session 1.4 — Functions & Scope (45 min)

### Function Declaration
Functions are reusable blocks of code.

```javascript
function greet(name) {
    return `Hello, ${name}!`;
}

// Calling the function
let message = greet("John");
console.log(message); // "Hello, John!"
```

### Arrow Functions (Modern ES6+)
A shorter syntax for writing functions. Very common in modern JS.

```javascript
const add = (a, b) => {
    return a + b;
};

// Shorthand if it's just one return line:
const multiply = (a, b) => a * b;

console.log(add(5, 3)); // 8
console.log(multiply(4, 2)); // 8
```

### Scope
Where a variable is available in your code.
- **Global Scope:** Variables declared outside functions.
- **Local/Block Scope:** Variables declared inside `{ }` (like inside functions, if statements, loops).

```javascript
let globalVar = "I am everywhere";

function testScope() {
    let localVar = "I am trapped inside the function";
    console.log(globalVar); // Works!
}

testScope();
// console.log(localVar); // ❌ ERROR: localVar is not defined
```

### 🏋️ Exercise 1.4
1. Write a normal function called `calculateArea` that takes `width` and `height` and returns the area of a rectangle.
2. Convert that function into an Arrow Function.
3. Call the function with values `5` and `10` and `console.log` the result.


---

# Day 1 — JavaScript Fundamentals & The DOM (Part 2)

---

## Session 1.5 — Arrays & Objects (60 min)

### Arrays (Lists of Data)
Arrays hold multiple values in a specific order (0-indexed).

```javascript
let fruits = ["Apple", "Banana", "Orange"];

// Accessing items
console.log(fruits[0]); // "Apple"
console.log(fruits.length); // 3

// Adding and removing
fruits.push("Mango");    // Adds to the end
fruits.pop();            // Removes from the end
fruits.unshift("Kiwi");  // Adds to the beginning
fruits.shift();          // Removes from the beginning
```

### Array Iteration (Looping over arrays)

```javascript
let colors = ["Red", "Green", "Blue"];

// Using traditional for loop
for (let i = 0; i < colors.length; i++) {
    console.log(colors[i]);
}

// Using forEach (Modern approach)
colors.forEach((color, index) => {
    console.log(`${index}: ${color}`);
});
```

### Objects (Key-Value Pairs)
Objects hold data representing a single entity.

```javascript
let person = {
    firstName: "John",
    lastName: "Doe",
    age: 30,
    hobbies: ["Reading", "Gaming"],
    sayHi: function() {
        return `Hi, I am ${this.firstName}`;
    }
};

// Accessing properties (Dot notation is most common)
console.log(person.firstName);      // "John"
console.log(person["lastName"]);    // "Doe" (Bracket notation)

// Modifying and adding
person.age = 31;
person.city = "New York";

console.log(person.sayHi()); // "Hi, I am John"
```

### Arrays of Objects
This is how data usually comes from databases or APIs.

```javascript
let users = [
    { id: 1, name: "Alice", active: true },
    { id: 2, name: "Bob", active: false },
    { id: 3, name: "Charlie", active: true }
];

console.log(users[1].name); // "Bob"
```

### 🏋️ Exercise 1.5
1. Create an object `car` with properties `make`, `model`, and `year`.
2. Add a new property `color` to the `car` object.
3. Create an array `movies` containing 3 of your favorite movie titles.
4. Loop through the `movies` array using `.forEach()` and `console.log` each one.

---

## Session 1.6 — The DOM: Selecting & Modifying Elements (45 min)

### What is the DOM?
The **D**ocument **O**bject **M**odel is the browser's internal representation of your HTML as a tree of JavaScript objects. JavaScript can modify this tree to change the page dynamically.

```html
<!-- HTML Example -->
<h1 id="title">Hello World</h1>
<p class="text">Paragraph 1</p>
<p class="text">Paragraph 2</p>
```

### Selecting Elements

```javascript
// 1. By ID (Returns single element)
const titleEl = document.getElementById("title");

// 2. By CSS Selector (Modern, Returns first match)
const firstPara = document.querySelector(".text");
const heading = document.querySelector("h1");

// 3. Select ALL matching elements (Returns NodeList)
const allParas = document.querySelectorAll(".text");
```

### Modifying Elements

```javascript
const titleEl = document.querySelector("#title");

// Change text content
titleEl.textContent = "Welcome to JavaScript!";

// Change HTML inside an element
titleEl.innerHTML = "Welcome to <em>JavaScript</em>!";

// Modify CSS Styles
titleEl.style.color = "blue";
titleEl.style.fontSize = "3rem";

// Manage CSS Classes (Best Practice!)
titleEl.classList.add("highlight");
titleEl.classList.remove("hidden");
titleEl.classList.toggle("active"); // Adds if missing, removes if present

// Modify Attributes
const link = document.querySelector("a");
link.setAttribute("href", "https://google.com");
console.log(link.getAttribute("href"));
```

### 🏋️ Exercise 1.6
*(Needs an HTML file with an `<h1>` and a `<div>` with id "box")*
1. Select the `<h1>` and change its text to "DOM Manipulation is Fun!".
2. Select the `#box` div and change its background color to red using `.style`.
3. Add a class called `rounded` to the `#box`.

---

## Session 1.7 — Events & Event Listeners (45 min)

### Listening for User Interaction
We use `addEventListener` to run a function when a user interacts with the page (click, hover, typing, submitting forms).

```html
<button id="myBtn">Click Me!</button>
<p id="message"></p>
```

```javascript
const btn = document.querySelector("#myBtn");
const msg = document.querySelector("#message");

// syntax: element.addEventListener("event_type", function)
btn.addEventListener("click", () => {
    msg.textContent = "Button was clicked!";
    msg.style.color = "green";
});
```

### The Event Object (`e`)
When an event happens, JS creates an object with details about the event.

```html
<input type="text" id="username" placeholder="Type here...">
```

```javascript
const input = document.querySelector("#username");

input.addEventListener("keyup", (e) => {
    console.log("You pressed:", e.key);
    console.log("Current input value:", e.target.value);
});
```

### Common Event Types
- **Mouse:** `click`, `dblclick`, `mouseenter`, `mouseleave`
- **Keyboard:** `keydown`, `keyup`, `keypress`
- **Form:** `submit`, `change`, `focus`, `blur`
- **Window:** `DOMContentLoaded` (when HTML finishes loading), `resize`

### Creating New Elements
```javascript
// 1. Create the element in memory
const newPara = document.createElement("p");

// 2. Add content/styles
newPara.textContent = "I was created by JavaScript!";
newPara.classList.add("text-bold");

// 3. Append it to the page (inside an existing element)
const container = document.querySelector("#container");
container.appendChild(newPara);
```

### 🏋️ Exercise 1.7
1. Create an HTML button and a `<span>` containing the number `0`.
2. Write JS to select both.
3. Add a click event listener to the button.
4. Every time the button is clicked, increase the number in the `<span>` by 1 (A counter app!).


---

# Day 1 — Project: Interactive To-Do List

> **Time:** 60 minutes  
> **Goal:** Apply JS fundamentals, DOM manipulation, and event listeners to build a working To-Do list from scratch.

---

## 📝 Project Requirements

Build a **To-Do List application** that can:
1. Accept input from a text field.
2. Add a new task to a list when the "Add" button is clicked.
3. Prevent adding empty tasks.
4. Clear the input field after adding a task.
5. Have a "Delete" button next to each task to remove it from the DOM.
6. (Bonus) Click a task to strike it through (mark as completed).

---

## 🗂 Step-by-Step Guide

### Step 1: Create the UI (HTML/CSS)
- Create a container `div`.
- Add an `<input type="text">` and a `<button>Add</button>`.
- Add an empty `<ul>` where the tasks will live.
- Style it briefly so it looks decent.

### Step 2: Select Elements in JS
- Select the input field, the add button, and the `<ul>` element and store them in `const` variables.

### Step 3: Listen for the Click Event
- Add an `addEventListener("click", ...)` to the Add button.
- Inside the function, get the `value` of the input field.

### Step 4: Validate Input
- Check `if (inputValue === "")` — if it's empty, use `alert()` to warn the user and `return` to stop the function.

### Step 5: Create the List Item
- Use `document.createElement("li")`.
- Set its text content to the input value.
- Append the `<li>` to the `<ul>`.
- Clear the input field: `input.value = ""`.

### Step 6: Add Delete Functionality
- Inside the same Add function, create a delete `<button>`.
- Append the button to the `<li>`.
- Add an event listener to the delete button: when clicked, `li.remove()`.

---

## ✅ Reference Solution

### index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>JS To-Do List</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <div class="app-container">
        <h1>My Tasks</h1>
        
        <div class="input-group">
            <input type="text" id="taskInput" placeholder="What needs to be done?">
            <button id="addBtn">Add Task</button>
        </div>

        <ul id="taskList">
            <!-- Tasks will be injected here by JS -->
        </ul>
    </div>

    <script src="script.js"></script>
</body>
</html>
```

### style.css
```css
* {
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background-color: #f4f4f9;
    display: flex;
    justify-content: center;
    padding-top: 50px;
}

.app-container {
    background: white;
    padding: 30px;
    border-radius: 8px;
    box-shadow: 0 4px 10px rgba(0,0,0,0.1);
    width: 400px;
}

h1 {
    text-align: center;
    color: #333;
}

.input-group {
    display: flex;
    gap: 10px;
    margin-bottom: 20px;
}

input {
    flex: 1;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
}

button {
    padding: 10px 15px;
    background-color: #28a745;
    color: white;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

button:hover {
    background-color: #218838;
}

ul {
    list-style: none;
    padding: 0;
}

li {
    background: #eee;
    padding: 10px;
    margin-bottom: 8px;
    border-radius: 4px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    cursor: pointer;
}

.delete-btn {
    background-color: #dc3545;
    padding: 5px 10px;
    font-size: 12px;
}

.delete-btn:hover {
    background-color: #c82333;
}

/* Class added via JS for completed tasks */
.completed {
    text-decoration: line-through;
    opacity: 0.6;
}
```

### script.js
```javascript
// 1. Select the DOM elements
const taskInput = document.querySelector("#taskInput");
const addBtn = document.querySelector("#addBtn");
const taskList = document.querySelector("#taskList");

// 2. Function to add a task
function addTask() {
    // Get the text from the input and remove extra spaces
    const taskText = taskInput.value.trim();

    // Validate: Don't add empty tasks
    if (taskText === "") {
        alert("Please enter a task!");
        return;
    }

    // Create the <li> element
    const li = document.createElement("li");
    li.textContent = taskText;

    // Create the Delete Button
    const deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.classList.add("delete-btn");

    // Add event listener to delete button
    deleteBtn.addEventListener("click", function(e) {
        // e.stopPropagation() prevents the click from triggering the li click event
        e.stopPropagation(); 
        li.remove();
    });

    // Add event listener to li to mark as completed (Bonus)
    li.addEventListener("click", function() {
        li.classList.toggle("completed");
    });

    // Append delete button to li, then li to the ul
    li.appendChild(deleteBtn);
    taskList.appendChild(li);

    // Clear the input field and refocus it
    taskInput.value = "";
    taskInput.focus();
}

// 3. Listen for Click on Add Button
addBtn.addEventListener("click", addTask);

// 4. Listen for "Enter" keypress in the input field
taskInput.addEventListener("keypress", function(e) {
    if (e.key === "Enter") {
        addTask();
    }
});
```


---

# Day 2 — jQuery & API Integration (Part 1)

---

## Session 2.1 — Intro to jQuery & Setup (30 min)

### What is jQuery?
jQuery is a fast, small, and feature-rich JavaScript library. Its motto is **"Write Less, Do More."**
It makes DOM manipulation, event handling, animation, and AJAX much simpler across all browsers.

> **Note:** While modern Vanilla JS has caught up to many of jQuery's features, jQuery is still used on over 70% of the world's top websites and is an essential tool to know.

### How to Include jQuery
You must include the jQuery library BEFORE your custom `script.js`.

**Using a CDN (Content Delivery Network):**
```html
<head>
    <!-- Include jQuery first -->
    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
    <!-- Then your script -->
    <script src="script.js"></script>
</head>
```

### The Document Ready Event
We must wait for the HTML to fully load before trying to manipulate it with jQuery.

```javascript
// Vanilla JS way:
document.addEventListener("DOMContentLoaded", function() { ... });

// jQuery way (Standard):
$(document).ready(function() {
    console.log("Ready to go!");
});

// jQuery way (Shorthand - Most common):
$(function() {
    console.log("Ready to go!");
});
```

### The `$` Sign
In jQuery, the `$` sign is just an alias for the `jQuery` object.
`$("p")` is exactly the same as `jQuery("p")`.

---

## Session 2.2 — jQuery Selectors & DOM Traversal (45 min)

### Selectors
Selecting elements in jQuery is identical to CSS selectors, but much shorter than Vanilla JS.

```javascript
// Vanilla JS: document.querySelectorAll(".box");
// jQuery:
$(".box")

// Select by ID
$("#title")

// Select by element
$("p")

// Select specific descendants
$("ul li.active")
```

### DOM Traversal
Once you select an element, you can easily "walk" around the DOM tree to find related elements.

```javascript
const $item = $(".item"); // (Prefixing variables with $ is a common naming convention for jQuery objects)

// Parents and Children
$item.parent();       // The direct parent
$item.parents(".container"); // The nearest ancestor with this class
$item.children();     // All direct children
$item.find(".badge"); // Finds all descendants with this class

// Siblings
$item.siblings();     // All siblings
$item.next();         // The next sibling
$item.prev();         // The previous sibling
```

### 🏋️ Exercise 2.2
1. Create a `ul` with 5 `li` elements. Give the 3rd one a class of `active`.
2. Using jQuery, select the `.active` element.
3. Use `.prev()` to color the previous element red.
4. Use `.next()` to color the next element blue.
5. Use `.siblings()` to hide the other siblings (using `.hide()`).

---

## Session 2.3 — jQuery Events & Effects (45 min)

### Event Handling
jQuery makes adding event listeners incredibly concise.

```javascript
// Click event
$("#myBtn").click(function() {
    console.log("Button clicked!");
});

// Hover event (takes two functions: mouseenter, mouseleave)
$(".card").hover(
    function() {
        console.log("Mouse entered");
    },
    function() {
        console.log("Mouse left");
    }
);

// The 'on' method (best practice, allows multiple events)
$("input").on("keyup change", function(e) {
    console.log("Input changed: " + $(this).val());
});
```

> **Important:** Inside a jQuery event handler, `$(this)` refers to the specific element that triggered the event.

### Effects & Animations
This is where jQuery shines. Smooth animations with one line of code.

```javascript
// Show / Hide
$(".box").hide();       // Disappears immediately
$(".box").show(500);    // Appears over 500 milliseconds (0.5s)
$(".box").toggle();     // Toggles visibility

// Fade
$(".box").fadeOut();
$(".box").fadeIn(1000); // 1 second fade
$(".box").fadeToggle();

// Slide (Great for dropdown menus / accordions)
$(".menu").slideUp();
$(".menu").slideDown("slow");
$(".menu").slideToggle();

// Custom Animation (Animating CSS properties)
$(".box").animate({
    opacity: 0.5,
    width: "500px",
    padding: "20px"
}, 1000);
```

### 🏋️ Exercise 2.3
1. Create a button "Toggle Box" and a div with some height/width and a background color.
2. Use jQuery so that clicking the button runs `.slideToggle()` on the div.
3. Make the div `.fadeTo()` 50% opacity when you hover over it using `.hover()`.

---

## Session 2.4 — Modifying CSS & HTML with jQuery (45 min)

### Modifying Classes
```javascript
$("#box").addClass("highlight");
$("#box").removeClass("hidden");
$("#box").toggleClass("active");
```

### Modifying Inline CSS
```javascript
// Get a CSS property
let bgColor = $("#box").css("background-color");

// Set a CSS property
$("#box").css("color", "red");

// Set multiple CSS properties
$("#box").css({
    "font-size": "20px",
    "background-color": "blue",
    "margin-top": "15px"
});
```

### Modifying Content
```javascript
// Get / Set Text (ignores HTML tags inside)
let currentText = $("h1").text();
$("h1").text("New Title");

// Get / Set HTML (parses HTML tags)
$("div").html("<p>This replaces everything inside the div.</p>");

// Get / Set Form Input Values
let username = $("#user").val();
$("#user").val("DefaultName");
```

### Adding / Removing Elements
```javascript
// Append adds to the END inside the element
$("ul").append("<li>New item at the bottom</li>");

// Prepend adds to the BEGINNING inside the element
$("ul").prepend("<li>New item at the top</li>");

// Empty removes all children but keeps the parent
$("ul").empty();

// Remove deletes the element entirely from the DOM
$("#box").remove();
```

### 🏋️ Exercise 2.4
1. Refactor your Day 1 To-Do List project to use jQuery instead of Vanilla JS.
2. Notice how `document.createElement`, `textContent`, and `appendChild` can all be replaced by a single `$("ul").append("<li>...</li>")`.


---

# Day 2 — jQuery & API Integration (Part 2)

---

## Session 2.5 — Asynchronous JS & AJAX (60 min)

### What is AJAX?
**A**synchronous **J**avaScript **a**nd **X**ML (though today we use JSON, not XML).
It allows us to request data from a server *in the background* and update the webpage *without reloading it*.

### APIs and JSON
- **API** (Application Programming Interface): A service that returns data when you ask for it.
- **JSON** (JavaScript Object Notation): The format data usually comes back in. It looks exactly like JS objects.

```json
{
    "id": 1,
    "name": "Leanne Graham",
    "email": "Sincere@april.biz"
}
```

### The jQuery way: `$.ajax()` and `$.get()`
jQuery makes AJAX requests very straightforward.

```javascript
// A simple GET request
$.get("https://jsonplaceholder.typicode.com/users", function(data) {
    // data is the JSON returned from the server
    console.log(data);
    
    // Loop through the data and append to the DOM
    data.forEach(user => {
        $("#userList").append(`<li>${user.name} - ${user.email}</li>`);
    });
}).fail(function() {
    alert("Something went wrong!");
});
```

The more detailed `$.ajax()` method:
```javascript
$.ajax({
    url: "https://jsonplaceholder.typicode.com/users",
    type: "GET",
    success: function(response) {
        console.log("Success!", response);
    },
    error: function(xhr, status, error) {
        console.error("Error occurred: " + error);
    }
});
```

### The Modern Vanilla JS way: `fetch()`
While jQuery's `.ajax()` is great, modern JS has `fetch()`, which is built-in and uses "Promises".

```javascript
fetch("https://jsonplaceholder.typicode.com/users")
    .then(response => response.json()) // Convert the response to JSON
    .then(data => {
        console.log(data);
    })
    .catch(error => {
        console.error("Error fetching data:", error);
    });
```

### 🏋️ Exercise 2.5
1. Create a button "Get Users" and an empty `ul` with id `users`.
2. Use `$.get()` to fetch data from `https://jsonplaceholder.typicode.com/users`.
3. Loop through the returned array.
4. Append an `<li>` with the user's `name` and `company.name` to the `ul`.

---

## Session 2.6 — Form Handling & Validation (45 min)

### Handling Form Submission
When working with forms, we always want to prevent the default browser behavior (which is to refresh the page).

```html
<form id="loginForm">
    <input type="text" id="username" required>
    <input type="password" id="password" required>
    <button type="submit">Login</button>
</form>
<p id="errorMsg"></p>
```

```javascript
$("#loginForm").submit(function(e) {
    // 1. PREVENT PAGE REFRESH!
    e.preventDefault();

    // 2. Gather values
    let user = $("#username").val().trim();
    let pass = $("#password").val().trim();

    // 3. Custom Validation
    if (user.length < 3) {
        $("#errorMsg").text("Username must be at least 3 characters").css("color", "red");
        return; // Stop execution
    }

    if (pass.length < 6) {
        $("#errorMsg").text("Password must be at least 6 characters").css("color", "red");
        return;
    }

    // 4. Success state
    $("#errorMsg").text("Login successful!").css("color", "green");
    
    // Simulate sending data to server...
    console.log("Sending to server:", { username: user, password: pass });
});
```

### Key Form Events
- `.submit()` — Triggered when the form is submitted. Always bind this to the `<form>`, not the submit button.
- `.change()` — Triggered when a checkbox, radio, or select dropdown value changes.
- `.focus()` — When the user clicks into an input field.
- `.blur()` — When the user clicks out of an input field.

### 🏋️ Exercise 2.6
1. Build a Newsletter Signup form with Name and Email.
2. Use jQuery to intercept the submit event.
3. Prevent the page refresh.
4. Validate that the email contains an "@" symbol (hint: `email.includes("@")`).
5. Show a success message if valid, or a red error message if invalid.


---

# Day 2 — Project: Movie Search App

> **Time:** 90 minutes  
> **Goal:** Build a complete Movie Search Application that uses jQuery to fetch real data from the OMDb API and display it dynamically on the page.

---

## 📝 Project Requirements

Build a **Movie Search App** that:
1. Has a form with a text input for the movie title and a search button.
2. Prevents the default form submission (page reload).
3. Uses jQuery `$.get()` or `$.ajax()` to fetch data from the OMDb API.
4. Handles empty search queries by showing a validation error.
5. Displays the movie Poster, Title, Year, and Plot.
6. Handles errors (e.g., if the API returns "Movie not found").
7. Uses jQuery effects (e.g., `.fadeIn()`) to smoothly display the results.

### The API Info
- **URL:** `http://www.omdbapi.com/`
- **Query Parameters:** `?t={movie_title}&apikey={your_key}`
- **Test API Key:** `4a3b711b` *(Instructor note: Have students get their own free key from omdbapi.com if possible)*

---

## 🗂 Step-by-Step Guide

### Step 1: Create the UI (HTML/CSS)
- Create a simple, clean layout.
- Include a form with an input and button.
- Include an empty `div` with an ID like `#movieResults` where the data will go.
- **Don't forget to include the jQuery CDN script in the `<head>`!**

### Step 2: Form Submission & Validation
- Bind a `.submit()` event to the form.
- Use `e.preventDefault()`.
- Get the value from the search input. If empty, alert the user.

### Step 3: Make the AJAX Request
- Construct your URL: `http://www.omdbapi.com/?t=` + searchTerm + `&apikey=4a3b711b`.
- Use `$.get(url, function(data) { ... })`.

### Step 4: Handle the API Response
- Check `if (data.Response === "False")` to catch "Movie not found" errors.
- If true, extract `data.Title`, `data.Year`, `data.Plot`, and `data.Poster`.

### Step 5: Render the HTML
- Create a string of HTML interpolating the data variables.
- Use `$("#movieResults").hide().html(htmlString).fadeIn(1000);` to render it smoothly.

---

## ✅ Reference Solution

### index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Movie Search App</title>
    <link rel="stylesheet" href="style.css">
    
    <!-- Include jQuery -->
    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
</head>
<body>

    <div class="container">
        <h1>🍿 Movie Finder</h1>
        
        <form id="searchForm">
            <input type="text" id="searchInput" placeholder="Enter movie title (e.g., Matrix)">
            <button type="submit">Search</button>
        </form>

        <p id="message"></p>

        <div id="movieResults">
            <!-- Movie data injected here -->
        </div>
    </div>

    <script src="script.js"></script>
</body>
</html>
```

### style.css
```css
* {
    box-sizing: border-box;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

body {
    background-color: #2c3e50;
    color: white;
    display: flex;
    justify-content: center;
    padding-top: 50px;
}

.container {
    background: #34495e;
    padding: 30px;
    border-radius: 10px;
    box-shadow: 0 10px 20px rgba(0,0,0,0.3);
    width: 500px;
    max-width: 90%;
    text-align: center;
}

h1 {
    margin-top: 0;
    color: #f1c40f;
}

form {
    display: flex;
    gap: 10px;
    margin-bottom: 20px;
}

input {
    flex: 1;
    padding: 12px;
    border: none;
    border-radius: 4px;
    font-size: 16px;
}

button {
    padding: 12px 20px;
    background-color: #e74c3c;
    color: white;
    border: none;
    border-radius: 4px;
    font-size: 16px;
    cursor: pointer;
    font-weight: bold;
}

button:hover {
    background-color: #c0392b;
}

#message {
    color: #e74c3c;
    height: 20px;
}

.movie-card {
    background: #ecf0f1;
    color: #2c3e50;
    padding: 20px;
    border-radius: 8px;
    text-align: left;
    margin-top: 20px;
}

.movie-card img {
    max-width: 100%;
    border-radius: 4px;
    margin-bottom: 15px;
}

.movie-card h2 {
    margin: 0 0 10px 0;
}

.movie-card .meta {
    color: #7f8c8d;
    font-style: italic;
    margin-bottom: 15px;
}
```

### script.js
```javascript
$(document).ready(function() {
    
    // API Key (Instructor provided)
    const API_KEY = "4a3b711b"; 

    $("#searchForm").submit(function(e) {
        // 1. Prevent page reload
        e.preventDefault();

        // 2. Get search term and clear previous messages
        let searchTerm = $("#searchInput").val().trim();
        $("#message").text("");
        $("#movieResults").empty();

        // 3. Validation
        if (searchTerm === "") {
            $("#message").text("Please enter a movie title.");
            return;
        }

        // Show loading state
        $("#message").text("Searching...").css("color", "white");

        // 4. Construct URL
        let url = `https://www.omdbapi.com/?t=${encodeURIComponent(searchTerm)}&apikey=${API_KEY}`;

        // 5. Make AJAX request
        $.get(url, function(data) {
            
            // Clear loading message
            $("#message").text("");

            // 6. Check for API errors (e.g., Movie not found)
            if (data.Response === "False") {
                $("#message").text(data.Error).css("color", "#e74c3c");
                return;
            }

            // 7. Handle missing poster edge case
            let posterSrc = data.Poster !== "N/A" ? data.Poster : "https://via.placeholder.com/300x450?text=No+Poster";

            // 8. Build the HTML string
            let movieHTML = `
                <div class="movie-card">
                    <img src="${posterSrc}" alt="${data.Title} Poster">
                    <h2>${data.Title}</h2>
                    <p class="meta">${data.Year} | ${data.Genre} | ${data.Runtime}</p>
                    <p><strong>Director:</strong> ${data.Director}</p>
                    <p>${data.Plot}</p>
                </div>
            `;

            // 9. Inject HTML and animate
            $("#movieResults")
                .hide()
                .html(movieHTML)
                .fadeIn(800);
                
        }).fail(function() {
            // Handle network errors
            $("#message").text("Network error. Please try again.").css("color", "#e74c3c");
        });
    });

});
```


---

