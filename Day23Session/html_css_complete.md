# HTML & CSS — 2-Day Intensive Course

> **Duration:** 2 Days (approx. 6–7 hours per day)  
> **Level:** Beginner — No prior experience required  
> **Tools Needed:** VS Code + Chrome/Firefox

---

## 📋 Course Outline

### Day 1 — HTML: Building the Structure

| Session | Topic | Duration |
|---------|-------|----------|
| 1.1 | Intro to Web Dev & How the Web Works | 30 min |
| 1.2 | HTML Document Structure & First Page | 45 min |
| 1.3 | Text Elements — Headings, Paragraphs, Formatting | 45 min |
| 1.4 | Links & Images | 45 min |
| 1.5 | Lists | 30 min |
| 1.6 | Tables | 45 min |
| 1.7 | Forms & Input Elements | 60 min |
| 1.8 | Semantic HTML5 | 30 min |
| 1.9 | **Project:** Build a Personal Profile Page | 60 min |

### Day 2 — CSS: Styling the Web

| Session | Topic | Duration |
|---------|-------|----------|
| 2.1 | Intro to CSS — What, Why, How | 30 min |
| 2.2 | Selectors, Properties & Values | 45 min |
| 2.3 | Colors, Backgrounds & Borders | 45 min |
| 2.4 | The Box Model | 45 min |
| 2.5 | Typography & Google Fonts | 30 min |
| 2.6 | Display & Positioning | 45 min |
| 2.7 | Flexbox Layout | 60 min |
| 2.8 | Responsive Design & Media Queries | 45 min |
| 2.9 | **Project:** Style the Profile into a Portfolio | 60 min |

---

## 🎯 Learning Objectives

By the end of this course, students will be able to:

1. Understand how the web works (browser → server → response)
2. Write valid, semantic HTML5 documents from scratch
3. Structure content with headings, paragraphs, lists, tables, and forms
4. Embed images and links
5. Apply CSS styles (inline, internal, external)
6. Use CSS selectors effectively
7. Understand the CSS Box Model
8. Build layouts with Flexbox
9. Make pages responsive with media queries
10. Build a complete, styled, responsive web page

---

## 🛠 Setup

### Install VS Code
Download from [code.visualstudio.com](https://code.visualstudio.com). Install extensions:
- **Live Server** — Auto-refresh on save
- **Prettier** — Code formatting
- **Auto Rename Tag** — Renames paired HTML tags

### Project Folder Structure
```
html-css-course/
├── day1/
│   ├── 01-first-page.html
│   ├── ...
│   └── project/
│       └── profile.html
├── day2/
│   ├── 01-css-intro.html
│   ├── ...
│   └── project/
│       ├── portfolio.html
│       └── style.css
└── images/
```

### Browser DevTools
- Open: `Cmd + Option + I` (Mac) / `F12` (Windows)
- Get comfortable with the **Elements** tab early

---

## 📚 Resources

- [MDN Web Docs](https://developer.mozilla.org/en-US/)
- [W3Schools](https://www.w3schools.com/)
- [CSS-Tricks](https://css-tricks.com/)
- [Google Fonts](https://fonts.google.com/)


---

# Day 1 — HTML: Building the Structure (Part 1)

---

## Session 1.1 — Introduction to Web Development (30 min)

### What is the Web?

The World Wide Web is a system of interlinked documents accessed via the Internet.

**How it works (simplified):**

```
You (Browser)  →  Request  →  Web Server
You (Browser)  ←  Response ←  Web Server
                   (HTML, CSS, JS files)
```

### The Three Pillars of the Web

| Technology | Role | Analogy |
|-----------|------|---------|
| **HTML** | Structure & Content | The skeleton/bones of a building |
| **CSS** | Presentation & Styling | The paint, decoration, furniture |
| **JavaScript** | Behavior & Interactivity | The electricity, plumbing |

### What is HTML?

- **H**yper**T**ext **M**arkup **L**anguage
- NOT a programming language — it's a **markup** language
- Uses **tags** to describe the structure of a page
- Current version: **HTML5**

### What is a Tag?

Tags are labels that tell the browser what kind of content follows.

```html
<tagname>Content goes here</tagname>
```

- **Opening tag:** `<tagname>`
- **Closing tag:** `</tagname>`
- **Self-closing tag:** `<tagname />` (e.g., `<br />`, `<img />`)

> [!NOTE]
> **Instructor tip:** Open any website, right-click → "View Page Source" to show students real HTML.

---

## Session 1.2 — HTML Document Structure & First Page (45 min)

### The Minimal HTML Document

Every HTML page has this basic structure:

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>My First Page</title>
</head>
<body>
    <h1>Hello, World!</h1>
    <p>This is my first web page.</p>
</body>
</html>
```

### Breaking It Down

| Element | Purpose |
|---------|---------|
| `<!DOCTYPE html>` | Tells the browser this is an HTML5 document |
| `<html lang="en">` | Root element; `lang` sets the language |
| `<head>` | Metadata — not visible on the page |
| `<meta charset="UTF-8">` | Character encoding (supports emojis, special chars) |
| `<meta name="viewport" ...>` | Makes the page mobile-friendly |
| `<title>` | Text shown in the browser tab |
| `<body>` | All visible content goes here |

### 🏋️ Exercise 1.2

1. Create a file called `01-first-page.html`
2. Type out the full HTML structure (do NOT copy-paste — muscle memory matters!)
3. Add a heading with your name and a paragraph about yourself
4. Open it with Live Server

---

## Session 1.3 — Text Elements (45 min)

### Headings (`h1` through `h6`)

HTML provides 6 levels of headings. Use them for **hierarchy**, not for sizing.

```html
<h1>Main Title (use only once per page)</h1>
<h2>Section Title</h2>
<h3>Subsection Title</h3>
<h4>Sub-subsection</h4>
<h5>Fine detail</h5>
<h6>Smallest heading</h6>
```

> [!IMPORTANT]
> Only use **one `<h1>`** per page. Don't skip levels (e.g., don't go from `h1` to `h4`).

### Paragraphs

```html
<p>This is a paragraph. Browsers add space above and below paragraphs.</p>
<p>This is another paragraph. Notice the gap between them.</p>
```

### Line Break & Horizontal Rule

```html
<p>Line one<br>Line two (same paragraph, forced line break)</p>
<hr> <!-- Horizontal line / thematic break -->
```

### Text Formatting

```html
<p>This is <strong>bold (important)</strong> text.</p>
<p>This is <em>italic (emphasized)</em> text.</p>
<p>This is <mark>highlighted</mark> text.</p>
<p>This is <small>small</small> text.</p>
<p>This is <del>deleted</del> text.</p>
<p>This is <ins>inserted</ins> text.</p>
<p>This is <sub>subscript</sub> and <sup>superscript</sup>.</p>
```

### `<strong>` vs `<b>` and `<em>` vs `<i>`

| Tag | Meaning | Use When |
|-----|---------|----------|
| `<strong>` | Important text | Content that is semantically important |
| `<b>` | Bold text | Just visual boldness, no extra meaning |
| `<em>` | Emphasized text | Content with stress emphasis |
| `<i>` | Italic text | Alternate voice, technical terms, etc. |

### Block vs Inline Elements

```html
<!-- Block elements take full width, start on new line -->
<h1>I am a block element</h1>
<p>I am also a block element</p>

<!-- Inline elements only take the space they need -->
<p>This has an <strong>inline</strong> element inside.</p>
```

### Preformatted Text & Code

```html
<pre>
    This text preserves
    spaces    and
    line breaks exactly as written.
</pre>

<p>Use the <code>console.log()</code> function to debug.</p>
```

### 🏋️ Exercise 1.3

Create `02-text-elements.html` with:
1. An `h1` title: "My Favorite Recipe"
2. An `h2` subtitle: "Ingredients" and another `h2`: "Instructions"
3. A paragraph under each section
4. Use `<strong>`, `<em>`, and `<mark>` somewhere meaningful
5. Add a `<hr>` between the two sections

---

## Session 1.4 — Links & Images (45 min)

### Links (Anchor Tag)

```html
<!-- External link -->
<a href="https://www.google.com">Go to Google</a>

<!-- Open in new tab -->
<a href="https://www.google.com" target="_blank">Google (new tab)</a>

<!-- Link to another page in your project -->
<a href="about.html">About Page</a>

<!-- Link to a section on the same page -->
<a href="#section2">Jump to Section 2</a>

<!-- ... further down the page ... -->
<h2 id="section2">Section 2</h2>

<!-- Email link -->
<a href="mailto:hello@example.com">Send Email</a>

<!-- Phone link -->
<a href="tel:+1234567890">Call Us</a>
```

### Key Attributes of `<a>`

| Attribute | Purpose | Example |
|-----------|---------|---------|
| `href` | URL destination | `"https://example.com"` |
| `target` | Where to open | `"_blank"` (new tab) |
| `title` | Tooltip on hover | `"Visit our homepage"` |

### Images

```html
<!-- Basic image -->
<img src="photo.jpg" alt="A description of the photo">

<!-- Image with width -->
<img src="photo.jpg" alt="A sunset" width="400">

<!-- Image from the web -->
<img src="https://picsum.photos/400/300" alt="Random placeholder">
```

> [!WARNING]
> **Always include the `alt` attribute!** It's essential for:
> - Screen readers (accessibility)
> - SEO (search engines read it)
> - Broken images (text shows instead)

### Image as a Link

```html
<a href="https://www.google.com">
    <img src="logo.png" alt="Google Logo" width="100">
</a>
```

### Figure & Figcaption

```html
<figure>
    <img src="chart.png" alt="Sales data for 2024">
    <figcaption>Fig 1: Quarterly sales data for 2024</figcaption>
</figure>
```

### Relative vs Absolute Paths

```
project/
├── index.html
├── about.html
├── images/
│   ├── logo.png
│   └── banner.jpg
└── pages/
    └── contact.html
```

```html
<!-- From index.html -->
<img src="images/logo.png" alt="Logo">
<a href="pages/contact.html">Contact</a>

<!-- From contact.html back to index -->
<a href="../index.html">Home</a>

<!-- Absolute URL (full web address) -->
<img src="https://example.com/images/photo.jpg" alt="Photo">
```

### 🏋️ Exercise 1.4

Create `03-links-images.html` with:
1. A link to your favorite website (opens in new tab)
2. A link to your `01-first-page.html`
3. An image from `https://picsum.photos/600/400`
4. That image wrapped inside a link
5. A `<figure>` with a caption


---

# Day 1 — HTML: Building the Structure (Part 2)

---

## Session 1.5 — Lists (30 min)

### Unordered List (Bullets)

```html
<ul>
    <li>Apples</li>
    <li>Bananas</li>
    <li>Oranges</li>
</ul>
```

### Ordered List (Numbers)

```html
<ol>
    <li>Preheat oven to 180°C</li>
    <li>Mix the ingredients</li>
    <li>Pour into baking pan</li>
    <li>Bake for 30 minutes</li>
</ol>
```

### Ordered List Attributes

```html
<!-- Start from 5 -->
<ol start="5">
    <li>Item five</li>
    <li>Item six</li>
</ol>

<!-- Use letters -->
<ol type="A">
    <li>First</li>
    <li>Second</li>
</ol>

<!-- type="1" (default), "A", "a", "I", "i" -->
```

### Description List

```html
<dl>
    <dt>HTML</dt>
    <dd>HyperText Markup Language — structures web content</dd>

    <dt>CSS</dt>
    <dd>Cascading Style Sheets — styles web content</dd>

    <dt>JavaScript</dt>
    <dd>A programming language for web interactivity</dd>
</dl>
```

### Nested Lists

```html
<ul>
    <li>Frontend
        <ul>
            <li>HTML</li>
            <li>CSS</li>
            <li>JavaScript</li>
        </ul>
    </li>
    <li>Backend
        <ul>
            <li>Node.js</li>
            <li>Python</li>
            <li>C#</li>
        </ul>
    </li>
</ul>
```

### 🏋️ Exercise 1.5

Create `04-lists.html` with:
1. An unordered list of your top 5 movies
2. An ordered list of steps to make tea/coffee
3. A description list with 3 vocabulary words and definitions
4. A nested list showing countries → cities

---

## Session 1.6 — Tables (45 min)

### Basic Table Structure

```html
<table>
    <tr>
        <th>Name</th>
        <th>Age</th>
        <th>City</th>
    </tr>
    <tr>
        <td>Alice</td>
        <td>25</td>
        <td>Kathmandu</td>
    </tr>
    <tr>
        <td>Bob</td>
        <td>30</td>
        <td>Pokhara</td>
    </tr>
</table>
```

### Table Elements Explained

| Tag | Meaning |
|-----|---------|
| `<table>` | The table container |
| `<tr>` | Table Row |
| `<th>` | Table Header cell (bold, centered by default) |
| `<td>` | Table Data cell |

### Proper Table Structure with Sections

```html
<table>
    <caption>Student Grades — Semester 1</caption>
    <thead>
        <tr>
            <th>Student</th>
            <th>Subject</th>
            <th>Grade</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Alice</td>
            <td>Math</td>
            <td>A</td>
        </tr>
        <tr>
            <td>Bob</td>
            <td>Science</td>
            <td>B+</td>
        </tr>
    </tbody>
    <tfoot>
        <tr>
            <td colspan="2">Average Grade</td>
            <td>A-</td>
        </tr>
    </tfoot>
</table>
```

### Spanning Rows & Columns

```html
<!-- colspan: merge cells horizontally -->
<tr>
    <td colspan="3">This cell spans 3 columns</td>
</tr>

<!-- rowspan: merge cells vertically -->
<tr>
    <td rowspan="2">This cell spans 2 rows</td>
    <td>Data 1</td>
</tr>
<tr>
    <td>Data 2</td>
</tr>
```

### Complete Colspan/Rowspan Example

```html
<table border="1">
    <caption>Weekly Schedule</caption>
    <thead>
        <tr>
            <th>Time</th>
            <th>Monday</th>
            <th>Tuesday</th>
            <th>Wednesday</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>9:00 - 10:00</td>
            <td rowspan="2">Math</td>
            <td>English</td>
            <td>Science</td>
        </tr>
        <tr>
            <td>10:00 - 11:00</td>
            <td>History</td>
            <td>Art</td>
        </tr>
        <tr>
            <td>11:00 - 12:00</td>
            <td colspan="3">Lunch Break</td>
        </tr>
    </tbody>
</table>
```

### 🏋️ Exercise 1.6

Create `05-tables.html` with:
1. A table of 5 classmates (Name, Roll No, Email, Phone)
2. Use `<thead>`, `<tbody>`, and `<tfoot>`
3. Add a `<caption>`
4. Use `colspan` in the footer to show "Total Students: 5"

---

## Session 1.7 — Forms & Input Elements (60 min)

### Why Forms?

Forms are how users **send data** to a server — login, registration, search, contact, etc.

### Basic Form Structure

```html
<form action="/submit" method="POST">
    <label for="username">Username:</label>
    <input type="text" id="username" name="username">

    <button type="submit">Submit</button>
</form>
```

### Form Attributes

| Attribute | Purpose |
|-----------|---------|
| `action` | URL where form data is sent |
| `method` | `GET` (in URL) or `POST` (in body) |

### The `<label>` Element

```html
<!-- Method 1: for/id pairing (recommended) -->
<label for="email">Email:</label>
<input type="text" id="email" name="email">

<!-- Method 2: wrapping -->
<label>
    Email:
    <input type="text" name="email">
</label>
```

> [!TIP]
> Always use `<label>`. Clicking the label focuses the input — better UX and accessibility!

### Common Input Types

```html
<input type="text" placeholder="Your name">
<input type="email" placeholder="you@example.com">
<input type="password" placeholder="••••••••">
<input type="number" min="1" max="100">
<input type="tel" placeholder="9800000000">
<input type="url" placeholder="https://example.com">
<input type="date">
<input type="time">
<input type="color">
<input type="range" min="0" max="100">
<input type="file">
<input type="hidden" name="userId" value="42">
```

### Radio Buttons (Pick One)

```html
<p>Gender:</p>
<label>
    <input type="radio" name="gender" value="male"> Male
</label>
<label>
    <input type="radio" name="gender" value="female"> Female
</label>
<label>
    <input type="radio" name="gender" value="other"> Other
</label>
```

> [!IMPORTANT]
> Radio buttons with the **same `name`** form a group — only one can be selected.

### Checkboxes (Pick Multiple)

```html
<p>Hobbies:</p>
<label>
    <input type="checkbox" name="hobby" value="reading"> Reading
</label>
<label>
    <input type="checkbox" name="hobby" value="gaming"> Gaming
</label>
<label>
    <input type="checkbox" name="hobby" value="cooking"> Cooking
</label>
```

### Dropdown Select

```html
<label for="country">Country:</label>
<select id="country" name="country">
    <option value="">-- Select --</option>
    <option value="np">Nepal</option>
    <option value="in">India</option>
    <option value="us">United States</option>
</select>
```

### Textarea

```html
<label for="message">Message:</label>
<textarea id="message" name="message" rows="5" cols="40"
          placeholder="Write your message here..."></textarea>
```

### Fieldset & Legend

```html
<fieldset>
    <legend>Personal Information</legend>
    <label for="fname">First Name:</label>
    <input type="text" id="fname" name="fname">
    <br><br>
    <label for="lname">Last Name:</label>
    <input type="text" id="lname" name="lname">
</fieldset>
```

### Form Validation Attributes

```html
<input type="text" required>                  <!-- Must fill -->
<input type="text" minlength="3" maxlength="20">  <!-- Length limits -->
<input type="number" min="18" max="65">       <!-- Number range -->
<input type="email" required>                 <!-- Must be valid email -->
<input type="text" pattern="[A-Za-z]{3,}">    <!-- Regex pattern -->
<input type="text" readonly value="Cannot edit">
<input type="text" disabled value="Greyed out">
```

### Complete Registration Form Example

```html
<form action="/register" method="POST">
    <h2>Registration Form</h2>

    <fieldset>
        <legend>Account Details</legend>
        <label for="reg-email">Email:</label><br>
        <input type="email" id="reg-email" name="email" required><br><br>

        <label for="reg-pass">Password:</label><br>
        <input type="password" id="reg-pass" name="password"
               minlength="8" required><br><br>
    </fieldset>

    <fieldset>
        <legend>Personal Info</legend>
        <label for="reg-name">Full Name:</label><br>
        <input type="text" id="reg-name" name="fullname" required><br><br>

        <label for="reg-dob">Date of Birth:</label><br>
        <input type="date" id="reg-dob" name="dob"><br><br>

        <label for="reg-country">Country:</label><br>
        <select id="reg-country" name="country">
            <option value="">-- Select --</option>
            <option value="np">Nepal</option>
            <option value="in">India</option>
        </select><br><br>

        <label>Gender:</label><br>
        <label><input type="radio" name="gender" value="male"> Male</label>
        <label><input type="radio" name="gender" value="female"> Female</label>
        <br><br>

        <label for="reg-bio">Bio:</label><br>
        <textarea id="reg-bio" name="bio" rows="4" cols="40"></textarea>
    </fieldset>

    <br>
    <label>
        <input type="checkbox" name="terms" required>
        I agree to the Terms & Conditions
    </label>
    <br><br>

    <button type="submit">Register</button>
    <button type="reset">Clear Form</button>
</form>
```

### 🏋️ Exercise 1.7

Create `06-forms.html` — build a **Contact Us** form with:
1. Name (text, required)
2. Email (email, required)
3. Subject (dropdown: General, Support, Feedback)
4. Priority (radio: Low, Medium, High)
5. Subscribe to newsletter (checkbox)
6. Message (textarea)
7. Submit and Reset buttons

---

## Session 1.8 — Semantic HTML5 Elements (30 min)

### What is Semantic HTML?

Semantic elements clearly describe their **meaning** to both the browser and the developer.

| Non-Semantic | Semantic Equivalent |
|-------------|-------------------|
| `<div>` | `<header>`, `<main>`, `<section>`, `<article>`, `<aside>`, `<footer>` |
| `<span>` | `<mark>`, `<time>`, `<strong>`, `<em>` |

### Why Use Semantic HTML?

1. **Accessibility** — Screen readers understand the page structure
2. **SEO** — Search engines rank semantic pages better
3. **Readability** — Code is self-documenting
4. **Maintainability** — Easier for teams to work on

### Common Semantic Elements

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Semantic Page</title>
</head>
<body>

    <header>
        <h1>My Website</h1>
        <nav>
            <a href="/">Home</a>
            <a href="/about">About</a>
            <a href="/contact">Contact</a>
        </nav>
    </header>

    <main>
        <section>
            <h2>Latest Articles</h2>

            <article>
                <h3>Article Title</h3>
                <p>Published on <time datetime="2026-05-05">May 5, 2026</time></p>
                <p>Article content goes here...</p>
            </article>

            <article>
                <h3>Another Article</h3>
                <p>More content...</p>
            </article>
        </section>

        <aside>
            <h3>Related Links</h3>
            <ul>
                <li><a href="#">Link 1</a></li>
                <li><a href="#">Link 2</a></li>
            </ul>
        </aside>
    </main>

    <footer>
        <p>&copy; 2026 My Website. All rights reserved.</p>
    </footer>

</body>
</html>
```

### Semantic Element Reference

| Element | Purpose |
|---------|---------|
| `<header>` | Introductory content, logo, nav |
| `<nav>` | Navigation links |
| `<main>` | Primary content (one per page) |
| `<section>` | Thematic grouping of content |
| `<article>` | Self-contained, reusable content |
| `<aside>` | Sidebar, tangentially related content |
| `<footer>` | Footer info, copyright, links |
| `<figure>` | Image/diagram with optional caption |
| `<time>` | Date/time values |
| `<details>` | Expandable/collapsible content |

### The `<details>` and `<summary>` Elements

```html
<details>
    <summary>Click to see the answer</summary>
    <p>HTML stands for HyperText Markup Language.</p>
</details>
```

### 🏋️ Exercise 1.8

Create `07-semantic.html` — Rebuild your first page using proper semantic elements:
1. Wrap navigation in `<header>` and `<nav>`
2. Use `<main>` for primary content
3. Create at least two `<section>` blocks
4. Add an `<aside>` with fun facts
5. Add a `<footer>` with copyright


---

# Day 1 — Project: Build a Personal Profile Page

> **Time:** 60 minutes  
> **Goal:** Apply everything from Day 1 into a single, complete HTML page

---

## 📝 Project Requirements

Build a **Personal Profile Page** that includes ALL of the following:

### Must-Have Elements

| # | Requirement | HTML Concepts |
|---|------------|---------------|
| 1 | Page title in the browser tab | `<title>` |
| 2 | Your name as the main heading | `<h1>` |
| 3 | A profile picture | `<img>` with `alt` |
| 4 | A short bio paragraph | `<p>`, `<strong>`, `<em>` |
| 5 | Navigation links at the top | `<nav>`, `<a href="#id">` |
| 6 | An "About Me" section | `<section>`, `<h2>` |
| 7 | A list of hobbies/skills | `<ul>` or `<ol>` |
| 8 | An education table | `<table>`, `<thead>`, `<tbody>` |
| 9 | A contact form | `<form>`, `<input>`, `<textarea>` |
| 10 | A footer with copyright | `<footer>` |
| 11 | Use semantic elements throughout | `<header>`, `<main>`, `<section>`, `<footer>` |
| 12 | At least one external link | `<a target="_blank">` |

---

## 🗂 Step-by-Step Guide

### Step 1: Create the File

Create `project/profile.html` in your `day1` folder.

### Step 2: Start with the Structure

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Your Name — Profile</title>
</head>
<body>

    <!-- Header with navigation -->
    <header></header>

    <!-- Main content -->
    <main></main>

    <!-- Footer -->
    <footer></footer>

</body>
</html>
```

### Step 3: Fill in the Header

Add your name, a profile picture, and navigation.

### Step 4: Add Sections

Create sections for: About Me, Skills, Education, Contact.

### Step 5: Add Content to Each Section

- **About Me:** A few paragraphs with formatting
- **Skills:** An unordered list (or nested list)
- **Education:** A table with columns: Year, School, Degree
- **Contact:** A form with name, email, message, and submit

### Step 6: Add the Footer

Include copyright text and a link to your email.

---

## ✅ Reference Solution

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Jane Doe — Profile</title>
</head>
<body>

    <!-- ==================== HEADER ==================== -->
    <header>
        <h1>Jane Doe</h1>
        <p><em>Web Developer | Designer | Coffee Lover</em></p>
        <nav>
            <a href="#about">About</a> |
            <a href="#skills">Skills</a> |
            <a href="#education">Education</a> |
            <a href="#contact">Contact</a>
        </nav>
        <hr>
    </header>

    <!-- ==================== MAIN ==================== -->
    <main>

        <!-- Profile Picture -->
        <figure>
            <img src="https://picsum.photos/200" alt="Profile photo of Jane Doe"
                 width="200">
            <figcaption>That's me!</figcaption>
        </figure>

        <!-- About Section -->
        <section id="about">
            <h2>About Me</h2>
            <p>
                Hi! I'm <strong>Jane Doe</strong>, a passionate web developer
                from <mark>Kathmandu, Nepal</mark>. I love building beautiful
                and functional websites.
            </p>
            <p>
                When I'm not coding, you can find me
                <em>reading books</em>, hiking, or experimenting with
                new recipes in the kitchen.
            </p>

            <details>
                <summary>Fun fact about me</summary>
                <p>I once built a website in 24 hours during a hackathon!</p>
            </details>
        </section>

        <hr>

        <!-- Skills Section -->
        <section id="skills">
            <h2>My Skills</h2>
            <ul>
                <li>HTML5 &amp; Semantic Markup</li>
                <li>CSS3 &amp; Responsive Design</li>
                <li>JavaScript (ES6+)</li>
                <li>Tools:
                    <ul>
                        <li>VS Code</li>
                        <li>Git &amp; GitHub</li>
                        <li>Chrome DevTools</li>
                    </ul>
                </li>
            </ul>
        </section>

        <hr>

        <!-- Education Section -->
        <section id="education">
            <h2>Education</h2>
            <table border="1">
                <caption>Academic Background</caption>
                <thead>
                    <tr>
                        <th>Year</th>
                        <th>Institution</th>
                        <th>Degree</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>2018 - 2022</td>
                        <td>Tribhuvan University</td>
                        <td>BSc. CSIT</td>
                    </tr>
                    <tr>
                        <td>2016 - 2018</td>
                        <td>National College</td>
                        <td>+2 Science</td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="3">
                            <small>Currently pursuing further certifications</small>
                        </td>
                    </tr>
                </tfoot>
            </table>
        </section>

        <hr>

        <!-- Contact Section -->
        <section id="contact">
            <h2>Contact Me</h2>
            <form action="#" method="POST">
                <fieldset>
                    <legend>Send a Message</legend>

                    <label for="contact-name">Your Name:</label><br>
                    <input type="text" id="contact-name" name="name"
                           placeholder="John Smith" required>
                    <br><br>

                    <label for="contact-email">Your Email:</label><br>
                    <input type="email" id="contact-email" name="email"
                           placeholder="john@example.com" required>
                    <br><br>

                    <label>Reason for Contact:</label><br>
                    <label>
                        <input type="radio" name="reason" value="hire">
                        Hire me
                    </label>
                    <label>
                        <input type="radio" name="reason" value="collaborate">
                        Collaborate
                    </label>
                    <label>
                        <input type="radio" name="reason" value="other">
                        Just saying hi
                    </label>
                    <br><br>

                    <label for="contact-msg">Message:</label><br>
                    <textarea id="contact-msg" name="message" rows="5" cols="40"
                              placeholder="Your message here..."
                              required></textarea>
                    <br><br>

                    <button type="submit">Send Message</button>
                    <button type="reset">Clear</button>
                </fieldset>
            </form>
        </section>

    </main>

    <!-- ==================== FOOTER ==================== -->
    <footer>
        <hr>
        <p>
            &copy; 2026 Jane Doe. All rights reserved. |
            <a href="mailto:jane@example.com">jane@example.com</a> |
            <a href="https://github.com" target="_blank">My GitHub</a>
        </p>
    </footer>

</body>
</html>
```

---

## 🎯 Bonus Challenges

If students finish early:

1. Add a **"Projects"** section with a table of projects (Name, Description, Link)
2. Add an `<audio>` or `<video>` element
3. Create a **second page** (`hobbies.html`) and link to it from the profile
4. Add an `<iframe>` embedding a Google Maps location


---

# Day 2 — CSS: Styling the Web (Part 1)

---

## Session 2.1 — Introduction to CSS (30 min)

### What is CSS?

- **C**ascading **S**tyle **S**heets
- Controls the **visual presentation** of HTML elements
- Separates **content** (HTML) from **design** (CSS)
- "Cascading" = styles can override each other in a specific order

### CSS Syntax

```css
selector {
    property: value;
    property: value;
}
```

**Example:**
```css
h1 {
    color: blue;
    font-size: 36px;
    text-align: center;
}
```

### 3 Ways to Add CSS

#### 1. Inline CSS (directly on an element)

```html
<h1 style="color: red; font-size: 24px;">Hello</h1>
```

> ❌ **Avoid this!** Hard to maintain, mixes content with style.

#### 2. Internal CSS (in the `<head>` with `<style>`)

```html
<head>
    <style>
        h1 {
            color: blue;
        }
        p {
            font-size: 18px;
        }
    </style>
</head>
```

> ⚠️ OK for single-page demos, but doesn't scale.

#### 3. External CSS (separate `.css` file) ✅ RECOMMENDED

**HTML file:**
```html
<head>
    <link rel="stylesheet" href="style.css">
</head>
```

**style.css:**
```css
h1 {
    color: blue;
}
p {
    font-size: 18px;
}
```

> ✅ **Best practice!** Reusable, maintainable, cacheable.

### CSS Priority (Specificity Cascade)

When conflicting styles exist, priority is:

```
1. Inline styles              (highest priority)
2. ID selectors               (#myId)
3. Class selectors            (.myClass)
4. Element selectors          (h1, p, div)
5. Browser default styles     (lowest priority)
```

### 🏋️ Exercise 2.1

1. Create `01-css-intro.html` and `style.css`
2. Link the CSS file to the HTML
3. Add inline, internal, AND external styles to an `<h1>`
4. Observe which one wins!

---

## Session 2.2 — Selectors, Properties & Values (45 min)

### Element Selector

Targets **all** elements of that type.

```css
p {
    color: gray;
}
h2 {
    font-weight: bold;
}
```

### Class Selector (`.`)

Targets elements with a specific `class` attribute. **Reusable** on many elements.

```html
<p class="highlight">Important text</p>
<p>Normal text</p>
<p class="highlight">Also important</p>
```

```css
.highlight {
    background-color: yellow;
    font-weight: bold;
}
```

### ID Selector (`#`)

Targets a **single, unique** element. Use sparingly.

```html
<h1 id="page-title">Welcome</h1>
```

```css
#page-title {
    color: darkblue;
    text-decoration: underline;
}
```

> [!IMPORTANT]
> - **class** → reusable, use for styling (`.className`)
> - **id** → unique, use for JS or anchor links (`#idName`)

### Grouping Selector

Apply the same styles to multiple selectors.

```css
h1, h2, h3 {
    font-family: Arial, sans-serif;
    color: #333;
}
```

### Descendant Selector (space)

Targets elements **inside** another element.

```css
/* All <a> tags inside <nav> */
nav a {
    color: white;
    text-decoration: none;
}
```

### Child Selector (`>`)

Targets **direct children** only.

```css
/* Only <li> that are direct children of <ul> */
ul > li {
    list-style: square;
}
```

### Pseudo-Classes

Style elements based on their **state**.

```css
/* When mouse hovers over a link */
a:hover {
    color: red;
    text-decoration: underline;
}

/* When a link has been visited */
a:visited {
    color: purple;
}

/* When an input is focused */
input:focus {
    border-color: blue;
    outline: none;
}

/* First child of a parent */
li:first-child {
    font-weight: bold;
}

/* Last child */
li:last-child {
    color: gray;
}

/* Every other row */
tr:nth-child(even) {
    background-color: #f2f2f2;
}
```

### Pseudo-Elements

Style **parts** of an element.

```css
/* First line of a paragraph */
p::first-line {
    font-weight: bold;
}

/* First letter (drop cap effect) */
p::first-letter {
    font-size: 2em;
    color: red;
}

/* Add content before/after */
h2::before {
    content: "📌 ";
}

h2::after {
    content: " ✨";
}
```

### Attribute Selectors

```css
/* All inputs with type="email" */
input[type="email"] {
    border: 2px solid blue;
}

/* Links that open in new tab */
a[target="_blank"] {
    color: green;
}
```

### Selector Specificity Cheat Sheet

| Selector | Example | Specificity Score |
|----------|---------|-------------------|
| Element | `p` | 0-0-1 |
| Class | `.highlight` | 0-1-0 |
| ID | `#title` | 1-0-0 |
| Inline | `style=""` | 1-0-0-0 |
| `!important` | `color: red !important` | Overrides all |

> [!WARNING]
> Avoid `!important` — it makes debugging very difficult. Fix specificity issues by being more specific with selectors.

### 🏋️ Exercise 2.2

Create `02-selectors.html`:
1. Create 3 paragraphs: one with class `intro`, one with class `highlight`, one with id `special`
2. Style each differently using class and ID selectors
3. Add a nav with 3 links; style them with `a:hover`
4. Create a list and style `li:first-child` and `li:nth-child(odd)`

---

## Session 2.3 — Colors, Backgrounds & Borders (45 min)

### Color Systems in CSS

```css
/* Named colors (147 available) */
color: red;
color: tomato;
color: steelblue;

/* Hex (most common) */
color: #FF0000;        /* Red */
color: #333333;        /* Dark gray */
color: #333;           /* Shorthand for #333333 */

/* RGB */
color: rgb(255, 0, 0);           /* Red */
color: rgb(51, 51, 51);          /* Dark gray */

/* RGBA (with transparency) */
color: rgba(255, 0, 0, 0.5);     /* 50% transparent red */

/* HSL (Hue, Saturation, Lightness) */
color: hsl(0, 100%, 50%);        /* Red */
color: hsl(210, 80%, 50%);       /* Blue */

/* HSLA (with transparency) */
color: hsla(210, 80%, 50%, 0.7);
```

### `color` vs `background-color`

```css
.box {
    color: white;              /* Text color */
    background-color: #333;   /* Background color */
}
```

### Background Properties

```css
.hero {
    /* Solid color */
    background-color: #f0f0f0;

    /* Image */
    background-image: url("bg.jpg");
    background-repeat: no-repeat;    /* no-repeat, repeat-x, repeat-y */
    background-size: cover;          /* cover, contain, 100% 100% */
    background-position: center;     /* center, top left, 50% 50% */
    background-attachment: fixed;    /* fixed, scroll */
}

/* Shorthand */
.hero {
    background: #333 url("bg.jpg") no-repeat center/cover;
}
```

### Gradients

```css
/* Linear gradient */
.box1 {
    background: linear-gradient(to right, #ff6b6b, #feca57);
}

/* With angle */
.box2 {
    background: linear-gradient(135deg, #667eea, #764ba2);
}

/* Radial gradient */
.box3 {
    background: radial-gradient(circle, #ff6b6b, #feca57);
}
```

### Borders

```css
.card {
    /* Individual properties */
    border-width: 2px;
    border-style: solid;     /* solid, dashed, dotted, double, none */
    border-color: #333;

    /* Shorthand */
    border: 2px solid #333;

    /* Individual sides */
    border-top: 3px dashed red;
    border-bottom: 1px solid gray;

    /* Rounded corners */
    border-radius: 10px;           /* All corners */
    border-radius: 50%;            /* Circle (if equal width/height) */
    border-radius: 10px 0 10px 0;  /* top-left, top-right, bottom-right, bottom-left */
}
```

### Opacity

```css
.transparent-box {
    opacity: 0.5;   /* 0 = invisible, 1 = fully visible */
}
```

### 🏋️ Exercise 2.3

Create `03-colors-borders.html`:
1. Create 4 boxes (divs) with different background colors using hex, rgb, hsl
2. Add a gradient background to one box
3. Give each box a different border style (solid, dashed, dotted, double)
4. Round the corners of two boxes (one slightly, one as a circle)
5. Make one box 50% transparent

---

## Session 2.4 — The Box Model (45 min)

### Every Element is a Box

In CSS, every element is a rectangular box made of 4 layers:

```
┌─────────────────────────────────────┐
│             MARGIN                  │
│   ┌─────────────────────────────┐   │
│   │         BORDER              │   │
│   │   ┌─────────────────────┐   │   │
│   │   │     PADDING         │   │   │
│   │   │   ┌─────────────┐   │   │   │
│   │   │   │   CONTENT   │   │   │   │
│   │   │   │             │   │   │   │
│   │   │   └─────────────┘   │   │   │
│   │   └─────────────────────┘   │   │
│   └─────────────────────────────┘   │
└─────────────────────────────────────┘
```

| Layer | Purpose |
|-------|---------|
| **Content** | The actual text/image/stuff |
| **Padding** | Space between content and border |
| **Border** | The visible edge |
| **Margin** | Space outside the border (between elements) |

### Setting Padding & Margin

```css
.box {
    /* All 4 sides */
    padding: 20px;
    margin: 10px;

    /* Top and Bottom | Left and Right */
    padding: 10px 20px;

    /* Top | Right | Bottom | Left (clockwise) */
    padding: 10px 20px 10px 20px;

    /* Individual sides */
    padding-top: 10px;
    padding-right: 20px;
    padding-bottom: 10px;
    padding-left: 20px;

    margin-top: 10px;
    margin-bottom: 20px;
}
```

> [!TIP]
> **Memory trick for 4-value shorthand:** Think of a clock — **T**op, **R**ight, **B**ottom, **L**eft = **TR**ou**BL**e

### Width & Height

```css
.box {
    width: 300px;
    height: 200px;

    /* Percentage of parent */
    width: 50%;

    /* Min/Max constraints */
    min-width: 200px;
    max-width: 800px;
    min-height: 100px;
}
```

### The Default Box Model Problem

By default, `width` only sets the **content** width. Padding and border are **added on top**.

```css
.box {
    width: 300px;
    padding: 20px;
    border: 5px solid black;
}
/* Actual width = 300 + 20 + 20 + 5 + 5 = 350px! 😫 */
```

### The Fix: `box-sizing: border-box`

```css
/* Makes width INCLUDE padding and border */
.box {
    box-sizing: border-box;
    width: 300px;
    padding: 20px;
    border: 5px solid black;
}
/* Actual width = 300px exactly! 😊 */
```

### Universal Reset (use this in EVERY project)

```css
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
```

> [!IMPORTANT]
> Put this at the **top of every CSS file**. It removes browser default margins/padding and fixes the box model for all elements.

### Margin Collapse

When two vertical margins meet, they **collapse** into one (the larger one wins).

```css
.box1 { margin-bottom: 30px; }
.box2 { margin-top: 20px; }
/* Gap between them = 30px (not 50px!) */
```

### Centering a Block Element

```css
.container {
    width: 800px;
    margin: 0 auto;  /* 0 top/bottom, auto left/right = centered */
}
```

### 🏋️ Exercise 2.4

Create `04-box-model.html`:
1. Create 3 boxes with visible borders
2. Add different padding to each
3. Add margins between them
4. Open DevTools → Elements → inspect the box model visually
5. Try with and without `box-sizing: border-box` to see the difference
6. Center a container div on the page using `margin: 0 auto`


---

# Day 2 — CSS: Styling the Web (Part 2)

---

## Session 2.5 — Typography & Google Fonts (30 min)

### Font Properties

```css
p {
    font-family: Arial, Helvetica, sans-serif;  /* Font stack */
    font-size: 16px;
    font-weight: bold;        /* normal, bold, 100-900 */
    font-style: italic;       /* normal, italic, oblique */
    line-height: 1.6;         /* Space between lines */
    letter-spacing: 1px;      /* Space between characters */
    word-spacing: 3px;        /* Space between words */
}
```

### Font Size Units

| Unit | Description | Example |
|------|-------------|---------|
| `px` | Fixed pixels | `font-size: 16px` |
| `em` | Relative to parent | `font-size: 1.5em` (1.5x parent) |
| `rem` | Relative to root (`<html>`) | `font-size: 1.2rem` |
| `%` | Percentage of parent | `font-size: 120%` |

> [!TIP]
> Use `rem` for font sizes — it's consistent and accessible (respects user's browser settings).

### Text Properties

```css
h1 {
    text-align: center;        /* left, center, right, justify */
    text-decoration: underline; /* none, underline, line-through */
    text-transform: uppercase;  /* uppercase, lowercase, capitalize */
    text-indent: 30px;          /* First line indent */
    text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
}
```

### Using Google Fonts

1. Go to [fonts.google.com](https://fonts.google.com)
2. Pick a font (e.g., "Inter", "Poppins", "Roboto")
3. Click "Get font" → "Get embed code"
4. Copy the `<link>` tag into your HTML `<head>`

**HTML:**
```html
<head>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap"
          rel="stylesheet">
</head>
```

**CSS:**
```css
body {
    font-family: 'Inter', sans-serif;
}
```

### A Good Typography Setup

```css
html {
    font-size: 16px;   /* Base size — 1rem = 16px */
}

body {
    font-family: 'Inter', sans-serif;
    line-height: 1.6;
    color: #333;
}

h1 { font-size: 2.5rem; }
h2 { font-size: 2rem; }
h3 { font-size: 1.5rem; }
p  { font-size: 1rem; }
```

### 🏋️ Exercise 2.5

1. Add Google Fonts "Poppins" to your project
2. Apply it to the whole page
3. Set different font sizes for h1, h2, and p using `rem`
4. Center-align all headings
5. Add `text-shadow` to the `h1`

---

## Session 2.6 — Display & Positioning (45 min)

### The `display` Property

```css
/* Block: takes full width, starts on new line */
div     { display: block; }     /* default for div, p, h1-h6, section */

/* Inline: only takes content width, no new line */
span    { display: inline; }    /* default for span, a, strong, em */

/* Inline-block: inline but respects width/height */
.badge  { display: inline-block; width: 100px; height: 40px; }

/* None: completely hidden (removed from layout) */
.hidden { display: none; }
```

### Block vs Inline vs Inline-Block

| Feature | `block` | `inline` | `inline-block` |
|---------|---------|----------|----------------|
| New line? | ✅ Yes | ❌ No | ❌ No |
| Width/Height? | ✅ Yes | ❌ No | ✅ Yes |
| Top/Bottom margin? | ✅ Yes | ❌ No | ✅ Yes |

### CSS Positioning

#### `static` (Default)

```css
.box { position: static; }
/* Normal document flow. top/left/right/bottom have no effect. */
```

#### `relative`

```css
.box {
    position: relative;
    top: 20px;     /* Moves 20px DOWN from its normal position */
    left: 30px;    /* Moves 30px RIGHT from its normal position */
}
/* Element still occupies its original space in the flow */
```

#### `absolute`

```css
.parent {
    position: relative;  /* MUST set this on the parent! */
}
.child {
    position: absolute;
    top: 0;
    right: 0;
    /* Positioned relative to nearest positioned ancestor */
    /* Removed from normal document flow */
}
```

> [!IMPORTANT]
> `absolute` positioning looks for the nearest ancestor with `position: relative` (or any position other than `static`). If none found, it uses the `<body>`.

#### `fixed`

```css
.navbar {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    /* Stays in place even when scrolling */
    /* Removed from normal document flow */
}
```

#### `sticky`

```css
.sidebar-title {
    position: sticky;
    top: 0;
    /* Acts like relative until you scroll past it, then becomes fixed */
}
```

### `z-index` (Stacking Order)

```css
.behind  { position: relative; z-index: 1; }
.infront { position: relative; z-index: 10; }
/* Higher z-index = displayed on top */
/* Only works on positioned elements (not static) */
```

### Practical Example: Badge on an Image

```html
<div class="card">
    <img src="https://picsum.photos/300/200" alt="Product">
    <span class="badge">NEW</span>
</div>
```

```css
.card {
    position: relative;
    width: 300px;
}
.card img {
    width: 100%;
}
.badge {
    position: absolute;
    top: 10px;
    right: 10px;
    background: red;
    color: white;
    padding: 5px 10px;
    border-radius: 4px;
    font-size: 12px;
    font-weight: bold;
}
```

### 🏋️ Exercise 2.6

Create `06-display-position.html`:
1. Create a fixed navigation bar at the top
2. Create a card with a "SALE" badge (absolute positioned)
3. Add enough content to scroll; verify the navbar stays fixed
4. Use `z-index` to ensure the navbar appears above everything

---

## Session 2.7 — Flexbox Layout (60 min)

### What is Flexbox?

Flexbox is a **one-dimensional layout** system — it arranges items in a **row** or **column**.

### Enabling Flexbox

```css
.container {
    display: flex;
}
```

That's it! All **direct children** become flex items.

### Flex Direction

```css
.container {
    display: flex;
    flex-direction: row;             /* Default: left to right */
    flex-direction: row-reverse;     /* Right to left */
    flex-direction: column;          /* Top to bottom */
    flex-direction: column-reverse;  /* Bottom to top */
}
```

### Justify Content (Main Axis)

Controls spacing along the **main axis** (horizontal for row).

```css
.container {
    display: flex;
    justify-content: flex-start;     /* Default: pack to start */
    justify-content: flex-end;       /* Pack to end */
    justify-content: center;         /* Center items */
    justify-content: space-between;  /* Equal space between items */
    justify-content: space-around;   /* Equal space around items */
    justify-content: space-evenly;   /* Equal space everywhere */
}
```

### Align Items (Cross Axis)

Controls alignment on the **cross axis** (vertical for row).

```css
.container {
    display: flex;
    align-items: stretch;       /* Default: stretch to fill */
    align-items: flex-start;    /* Align to top */
    align-items: flex-end;      /* Align to bottom */
    align-items: center;        /* Center vertically */
    align-items: baseline;      /* Align text baselines */
}
```

### Perfect Centering (The Holy Grail)

```css
.container {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;    /* Full viewport height */
}
```

### Flex Wrap

```css
.container {
    display: flex;
    flex-wrap: nowrap;    /* Default: all in one line */
    flex-wrap: wrap;      /* Wrap to next line when needed */
}
```

### Gap

```css
.container {
    display: flex;
    gap: 20px;             /* Space between ALL items */
    row-gap: 20px;         /* Vertical gap */
    column-gap: 10px;      /* Horizontal gap */
}
```

### Flex Item Properties

```css
.item {
    flex-grow: 1;     /* How much the item grows (0 = don't grow) */
    flex-shrink: 1;   /* How much the item shrinks (0 = don't shrink) */
    flex-basis: 200px; /* Starting size before grow/shrink */

    /* Shorthand */
    flex: 1;          /* grow:1, shrink:1, basis:0 — equal sizing */
    flex: 0 0 200px;  /* Fixed 200px, no grow, no shrink */
}
```

### Common Flexbox Layouts

**Navigation Bar:**
```css
nav {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 10px 20px;
    background: #333;
}
nav a {
    color: white;
    text-decoration: none;
    padding: 10px;
}
```

**Card Grid:**
```css
.card-container {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
}
.card {
    flex: 1 1 300px;   /* Grow, shrink, min-width 300px */
    border: 1px solid #ddd;
    border-radius: 8px;
    padding: 20px;
}
```

**Footer with Columns:**
```css
.footer {
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
    gap: 20px;
    padding: 40px 20px;
}
.footer-column {
    flex: 1 1 200px;
}
```

### 🏋️ Exercise 2.7

Create `07-flexbox.html`:
1. Build a horizontal navbar with logo on the left and links on the right
2. Create a 3-card layout using flexbox with gap
3. Center a "Coming Soon" box perfectly in the middle of the page
4. Make the cards wrap on smaller screens using `flex-wrap: wrap`

---

## Session 2.8 — Responsive Design & Media Queries (45 min)

### What is Responsive Design?

Making websites look good on **all screen sizes** — desktop, tablet, mobile.

### The Viewport Meta Tag (Already in our HTML!)

```html
<meta name="viewport" content="width=device-width, initial-scale=1.0">
```

> Without this, mobile browsers render pages at desktop width and zoom out.

### Fluid vs Fixed Sizing

```css
/* ❌ Fixed — breaks on small screens */
.container { width: 1200px; }

/* ✅ Fluid — adapts to screen */
.container { width: 90%; max-width: 1200px; margin: 0 auto; }
```

### Responsive Images

```css
img {
    max-width: 100%;    /* Never wider than its container */
    height: auto;       /* Maintain aspect ratio */
}
```

### Media Queries

```css
/* Base styles (mobile-first) */
body {
    font-size: 16px;
}

/* Tablet (768px and wider) */
@media (min-width: 768px) {
    body {
        font-size: 18px;
    }
}

/* Desktop (1024px and wider) */
@media (min-width: 1024px) {
    body {
        font-size: 20px;
    }
}
```

### Common Breakpoints

| Device | Breakpoint |
|--------|-----------|
| Mobile | up to 767px |
| Tablet | 768px — 1023px |
| Desktop | 1024px+ |
| Large Desktop | 1200px+ |

### Mobile-First Approach ✅

Start with mobile styles, then **add** styles for larger screens.

```css
/* Mobile: single column */
.card-container {
    display: flex;
    flex-direction: column;
    gap: 20px;
    padding: 10px;
}

/* Tablet: 2 columns */
@media (min-width: 768px) {
    .card-container {
        flex-direction: row;
        flex-wrap: wrap;
    }
    .card {
        flex: 1 1 45%;
    }
}

/* Desktop: 3 columns */
@media (min-width: 1024px) {
    .card {
        flex: 1 1 30%;
    }
}
```

### Responsive Navigation Pattern

```css
/* Mobile: stack vertically */
nav {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 10px;
}

/* Desktop: horizontal */
@media (min-width: 768px) {
    nav {
        flex-direction: row;
        justify-content: space-between;
    }
}
```

### Hiding/Showing Elements

```css
/* Hide on mobile, show on desktop */
.desktop-only {
    display: none;
}
@media (min-width: 768px) {
    .desktop-only {
        display: block;
    }
}

/* Hide on desktop, show on mobile */
.mobile-only {
    display: block;
}
@media (min-width: 768px) {
    .mobile-only {
        display: none;
    }
}
```

### Testing Responsive Design

1. **Browser DevTools:** `Cmd + Option + I` → Click the device toggle icon
2. **Resize the browser window** manually
3. Common test widths: 375px (iPhone), 768px (iPad), 1024px, 1440px

### 🏋️ Exercise 2.8

Create `08-responsive.html`:
1. Build a page with a header, 3 cards, and a footer
2. **Mobile (default):** Cards stacked vertically
3. **Tablet (768px+):** Cards in 2 columns
4. **Desktop (1024px+):** Cards in 3 columns, larger font sizes
5. Make images responsive with `max-width: 100%`
6. Test in browser DevTools at different screen sizes


---

# Day 2 — Project: Style the Profile into a Portfolio

> **Time:** 60 minutes  
> **Goal:** Apply all CSS concepts to transform the Day 1 HTML profile page into a polished, responsive portfolio

---

## 📝 Project Requirements

| # | Requirement | CSS Concepts |
|---|------------|--------------|
| 1 | External CSS file linked | `<link>` |
| 2 | Universal reset | `*, box-sizing` |
| 3 | Google Font applied | `@import` or `<link>` |
| 4 | Styled navigation bar (horizontal, fixed) | Flexbox, position fixed |
| 5 | Hero section with gradient background | linear-gradient |
| 6 | Styled cards for content sections | border-radius, box-shadow |
| 7 | Styled table (alternating rows) | nth-child, borders |
| 8 | Styled form inputs | focus states, padding |
| 9 | Hover effects on links and buttons | :hover, transition |
| 10 | Responsive layout (mobile + desktop) | media queries, flexbox |

---

## 🗂 Step-by-Step Guide

### Step 1: Create the Files

```
day2/project/
├── portfolio.html    (copy from Day 1 profile, update)
└── style.css
```

### Step 2: Link the CSS and Add the Reset

```css
/* style.css */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
```

### Step 3: Add a Google Font

Add to the top of your CSS or in the HTML `<head>`.

### Step 4: Style Section by Section

Work through: navbar → hero → about → skills → education → contact → footer.

### Step 5: Add Responsiveness

Mobile-first: stack everything vertically, then adjust for larger screens.

---

## ✅ Reference Solution

### portfolio.html

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Jane Doe — Portfolio</title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap"
          rel="stylesheet">
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <!-- Navigation -->
    <nav class="navbar">
        <div class="nav-brand">Jane Doe</div>
        <div class="nav-links">
            <a href="#about">About</a>
            <a href="#skills">Skills</a>
            <a href="#education">Education</a>
            <a href="#contact">Contact</a>
        </div>
    </nav>

    <!-- Hero Section -->
    <header class="hero">
        <img src="https://picsum.photos/150" alt="Jane Doe" class="avatar">
        <h1>Jane Doe</h1>
        <p class="tagline">Web Developer | Designer | Coffee Lover</p>
    </header>

    <!-- Main Content -->
    <main class="container">

        <!-- About -->
        <section id="about" class="card">
            <h2>About Me</h2>
            <p>
                Hi! I'm <strong>Jane Doe</strong>, a passionate web developer
                from Kathmandu, Nepal. I love building beautiful and functional
                websites that make a difference.
            </p>
            <p>
                When I'm not coding, you can find me reading books, hiking
                in the mountains, or experimenting with new recipes.
            </p>
        </section>

        <!-- Skills -->
        <section id="skills" class="card">
            <h2>Skills</h2>
            <div class="skills-grid">
                <span class="skill-tag">HTML5</span>
                <span class="skill-tag">CSS3</span>
                <span class="skill-tag">JavaScript</span>
                <span class="skill-tag">Responsive Design</span>
                <span class="skill-tag">Git</span>
                <span class="skill-tag">VS Code</span>
            </div>
        </section>

        <!-- Education -->
        <section id="education" class="card">
            <h2>Education</h2>
            <table class="styled-table">
                <thead>
                    <tr>
                        <th>Year</th>
                        <th>Institution</th>
                        <th>Degree</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>2018 - 2022</td>
                        <td>Tribhuvan University</td>
                        <td>BSc. CSIT</td>
                    </tr>
                    <tr>
                        <td>2016 - 2018</td>
                        <td>National College</td>
                        <td>+2 Science</td>
                    </tr>
                </tbody>
            </table>
        </section>

        <!-- Contact -->
        <section id="contact" class="card">
            <h2>Contact Me</h2>
            <form class="contact-form">
                <div class="form-group">
                    <label for="name">Name</label>
                    <input type="text" id="name" placeholder="Your name" required>
                </div>
                <div class="form-group">
                    <label for="email">Email</label>
                    <input type="email" id="email" placeholder="you@example.com" required>
                </div>
                <div class="form-group">
                    <label for="message">Message</label>
                    <textarea id="message" rows="5"
                              placeholder="Your message..." required></textarea>
                </div>
                <button type="submit" class="btn">Send Message</button>
            </form>
        </section>

    </main>

    <!-- Footer -->
    <footer class="footer">
        <p>&copy; 2026 Jane Doe. Built with HTML & CSS.</p>
        <div class="footer-links">
            <a href="mailto:jane@example.com">Email</a>
            <a href="https://github.com" target="_blank">GitHub</a>
        </div>
    </footer>

</body>
</html>
```

### style.css

```css
/* ============================================
   RESET & BASE
   ============================================ */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: 'Inter', sans-serif;
    line-height: 1.6;
    color: #e0e0e0;
    background-color: #121212;
}

/* ============================================
   NAVIGATION
   ============================================ */
.navbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15px 30px;
    background-color: rgba(18, 18, 18, 0.95);
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    z-index: 1000;
    border-bottom: 1px solid #333;
}

.nav-brand {
    font-size: 1.4rem;
    font-weight: 700;
    color: #bb86fc;
}

.nav-links a {
    color: #e0e0e0;
    text-decoration: none;
    margin-left: 25px;
    font-size: 0.95rem;
    transition: color 0.3s ease;
}

.nav-links a:hover {
    color: #bb86fc;
}

/* ============================================
   HERO SECTION
   ============================================ */
.hero {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    min-height: 100vh;
    background: linear-gradient(135deg, #1a1a2e, #16213e, #0f3460);
    text-align: center;
    padding: 20px;
}

.avatar {
    width: 150px;
    height: 150px;
    border-radius: 50%;
    border: 4px solid #bb86fc;
    margin-bottom: 20px;
}

.hero h1 {
    font-size: 3rem;
    font-weight: 700;
    color: #ffffff;
    margin-bottom: 10px;
}

.tagline {
    font-size: 1.2rem;
    color: #bb86fc;
}

/* ============================================
   MAIN CONTAINER
   ============================================ */
.container {
    max-width: 800px;
    margin: 0 auto;
    padding: 40px 20px;
}

/* ============================================
   CARDS
   ============================================ */
.card {
    background-color: #1e1e1e;
    border: 1px solid #333;
    border-radius: 12px;
    padding: 30px;
    margin-bottom: 30px;
    transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.card:hover {
    transform: translateY(-3px);
    box-shadow: 0 8px 25px rgba(187, 134, 252, 0.15);
}

.card h2 {
    font-size: 1.8rem;
    color: #bb86fc;
    margin-bottom: 15px;
    padding-bottom: 10px;
    border-bottom: 2px solid #333;
}

.card p {
    margin-bottom: 10px;
    color: #ccc;
}

/* ============================================
   SKILLS
   ============================================ */
.skills-grid {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
}

.skill-tag {
    background: linear-gradient(135deg, #bb86fc, #6c63ff);
    color: white;
    padding: 8px 16px;
    border-radius: 20px;
    font-size: 0.85rem;
    font-weight: 600;
}

/* ============================================
   TABLE
   ============================================ */
.styled-table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 10px;
}

.styled-table th,
.styled-table td {
    padding: 12px 15px;
    text-align: left;
    border-bottom: 1px solid #333;
}

.styled-table thead th {
    background-color: #bb86fc;
    color: #121212;
    font-weight: 600;
}

.styled-table tbody tr:nth-child(even) {
    background-color: #2a2a2a;
}

.styled-table tbody tr:hover {
    background-color: #333;
}

/* ============================================
   FORM
   ============================================ */
.contact-form {
    display: flex;
    flex-direction: column;
    gap: 15px;
}

.form-group {
    display: flex;
    flex-direction: column;
}

.form-group label {
    margin-bottom: 5px;
    font-weight: 600;
    color: #ccc;
}

.form-group input,
.form-group textarea {
    padding: 12px;
    border: 1px solid #444;
    border-radius: 8px;
    background-color: #2a2a2a;
    color: #e0e0e0;
    font-family: inherit;
    font-size: 1rem;
    transition: border-color 0.3s ease;
}

.form-group input:focus,
.form-group textarea:focus {
    outline: none;
    border-color: #bb86fc;
}

.btn {
    padding: 12px 24px;
    background: linear-gradient(135deg, #bb86fc, #6c63ff);
    color: white;
    border: none;
    border-radius: 8px;
    font-size: 1rem;
    font-weight: 600;
    cursor: pointer;
    transition: opacity 0.3s ease, transform 0.2s ease;
    align-self: flex-start;
}

.btn:hover {
    opacity: 0.9;
    transform: translateY(-2px);
}

/* ============================================
   FOOTER
   ============================================ */
.footer {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 30px;
    background-color: #1e1e1e;
    border-top: 1px solid #333;
    font-size: 0.9rem;
    color: #888;
}

.footer-links a {
    color: #bb86fc;
    text-decoration: none;
    margin-left: 15px;
    transition: color 0.3s ease;
}

.footer-links a:hover {
    color: #fff;
}

/* ============================================
   RESPONSIVE DESIGN
   ============================================ */

/* Mobile */
@media (max-width: 767px) {
    .navbar {
        flex-direction: column;
        gap: 10px;
        padding: 10px 20px;
    }

    .nav-links a {
        margin-left: 10px;
        font-size: 0.85rem;
    }

    .hero h1 {
        font-size: 2rem;
    }

    .tagline {
        font-size: 1rem;
    }

    .container {
        padding: 20px 15px;
    }

    .card {
        padding: 20px;
    }

    .footer {
        flex-direction: column;
        text-align: center;
        gap: 10px;
    }

    .footer-links a {
        margin: 0 10px;
    }
}
```

---

## 🎯 Bonus Challenges

1. Add a **dark/light theme toggle** using a CSS class
2. Add `transition` and `transform` animations to cards and buttons
3. Add a **scroll-to-top** button (fixed positioned)
4. Create a **project gallery** section with image cards in a grid
5. Add a **CSS animation** (e.g., fade-in on the hero section)

```css
/* Example: Fade-in animation */
@keyframes fadeIn {
    from { opacity: 0; transform: translateY(20px); }
    to   { opacity: 1; transform: translateY(0); }
}

.hero {
    animation: fadeIn 1s ease-out;
}
```


---

# HTML & CSS Quick Reference Cheat Sheet

> Print this out and keep it handy while coding!

---

## 🟧 HTML Cheat Sheet

### Document Structure
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Page Title</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <!-- Content here -->
</body>
</html>
```

### Text Elements
| Tag | Purpose | Example |
|-----|---------|---------|
| `<h1>` to `<h6>` | Headings | `<h1>Title</h1>` |
| `<p>` | Paragraph | `<p>Text</p>` |
| `<br>` | Line break | `Line 1<br>Line 2` |
| `<hr>` | Horizontal rule | `<hr>` |
| `<strong>` | Bold (important) | `<strong>bold</strong>` |
| `<em>` | Italic (emphasis) | `<em>italic</em>` |
| `<mark>` | Highlight | `<mark>yellow</mark>` |
| `<small>` | Small text | `<small>fine print</small>` |
| `<del>` | Deleted text | `<del>removed</del>` |
| `<code>` | Inline code | `<code>x = 5</code>` |
| `<pre>` | Preformatted | Preserves spaces/newlines |

### Links & Images
```html
<a href="https://example.com" target="_blank">Link Text</a>
<a href="#section-id">Jump to Section</a>
<a href="mailto:me@email.com">Send Email</a>
<img src="photo.jpg" alt="Description" width="300">
<figure>
    <img src="img.jpg" alt="Caption text">
    <figcaption>Caption text</figcaption>
</figure>
```

### Lists
```html
<!-- Unordered -->        <!-- Ordered -->         <!-- Description -->
<ul>                      <ol>                     <dl>
    <li>Item</li>             <li>Step 1</li>          <dt>Term</dt>
    <li>Item</li>             <li>Step 2</li>          <dd>Definition</dd>
</ul>                     </ol>                    </dl>
```

### Tables
```html
<table>
    <caption>Title</caption>
    <thead>
        <tr><th>Header 1</th><th>Header 2</th></tr>
    </thead>
    <tbody>
        <tr><td>Data 1</td><td>Data 2</td></tr>
    </tbody>
    <tfoot>
        <tr><td colspan="2">Footer</td></tr>
    </tfoot>
</table>
```

### Forms
```html
<form action="/submit" method="POST">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name" required>

    <select name="option">
        <option value="a">Option A</option>
    </select>

    <textarea name="msg" rows="4"></textarea>

    <label><input type="radio" name="choice" value="1"> One</label>
    <label><input type="checkbox" name="agree"> I agree</label>

    <button type="submit">Submit</button>
</form>
```

**Input Types:** `text`, `email`, `password`, `number`, `tel`, `url`, `date`, `time`, `color`, `range`, `file`, `hidden`

### Semantic Elements
| Tag | Purpose |
|-----|---------|
| `<header>` | Page/section header |
| `<nav>` | Navigation links |
| `<main>` | Primary content |
| `<section>` | Thematic group |
| `<article>` | Self-contained content |
| `<aside>` | Sidebar content |
| `<footer>` | Page/section footer |
| `<figure>` | Image + caption |
| `<details>` | Expandable content |

---

## 🟦 CSS Cheat Sheet

### Selectors
| Selector | Example | What It Selects |
|----------|---------|-----------------|
| Element | `p { }` | All `<p>` |
| Class | `.card { }` | All `class="card"` |
| ID | `#hero { }` | The `id="hero"` element |
| Universal | `* { }` | Everything |
| Group | `h1, h2 { }` | All h1 AND h2 |
| Descendant | `nav a { }` | `<a>` inside `<nav>` |
| Child | `ul > li { }` | Direct `<li>` children of `<ul>` |
| `:hover` | `a:hover { }` | On mouse hover |
| `:focus` | `input:focus { }` | On keyboard focus |
| `:nth-child()` | `tr:nth-child(even)` | Even rows |
| `::before` | `h2::before { }` | Insert content before |

### Box Model
```
┌── Margin ──┐
│ ┌─ Border ─┐ │
│ │ ┌ Padding ┐ │ │
│ │ │ Content │ │ │
```
```css
* { margin: 0; padding: 0; box-sizing: border-box; }

.box {
    width: 300px;
    padding: 20px;          /* Inside space */
    border: 2px solid #333; /* Visible edge */
    margin: 10px;           /* Outside space */
    border-radius: 8px;     /* Rounded corners */
}
/* Shorthand: top right bottom left (clockwise / TRouBLe) */
padding: 10px 20px 10px 20px;
```

### Colors
```css
color: red;                         /* Named */
color: #FF6B6B;                     /* Hex */
color: rgb(255, 107, 107);          /* RGB */
color: rgba(255, 107, 107, 0.5);    /* RGBA (transparent) */
color: hsl(0, 100%, 71%);           /* HSL */
background: linear-gradient(135deg, #667eea, #764ba2);
```

### Typography
```css
font-family: 'Inter', sans-serif;
font-size: 1.2rem;
font-weight: 700;          /* 100-900 or bold */
line-height: 1.6;
text-align: center;        /* left, center, right, justify */
text-decoration: none;     /* underline, line-through */
text-transform: uppercase; /* lowercase, capitalize */
```

### Flexbox
```css
.container {
    display: flex;
    flex-direction: row;          /* row, column */
    justify-content: center;      /* flex-start, flex-end, space-between, space-around, space-evenly */
    align-items: center;          /* flex-start, flex-end, stretch, baseline */
    flex-wrap: wrap;              /* nowrap, wrap */
    gap: 20px;
}
.item {
    flex: 1;                      /* Grow equally */
    flex: 0 0 300px;              /* Fixed width */
}
```

### Positioning
```css
position: static;      /* Default */
position: relative;    /* Offset from normal position */
position: absolute;    /* Relative to nearest positioned ancestor */
position: fixed;       /* Relative to viewport, stays on scroll */
position: sticky;      /* Switches from relative to fixed */

top: 0; right: 0; bottom: 0; left: 0;
z-index: 10;           /* Stacking order (higher = on top) */
```

### Media Queries
```css
/* Mobile-first approach */
.cards { flex-direction: column; }

@media (min-width: 768px) {   /* Tablet */
    .cards { flex-direction: row; }
}

@media (min-width: 1024px) {  /* Desktop */
    .container { max-width: 1200px; }
}
```

### Common Patterns
```css
/* Center a div */
.centered { width: 800px; margin: 0 auto; }

/* Perfect center with flex */
.center-all {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

/* Responsive image */
img { max-width: 100%; height: auto; }

/* Smooth transitions */
.btn { transition: all 0.3s ease; }
.btn:hover { transform: translateY(-2px); }

/* Card shadow */
.card { box-shadow: 0 4px 15px rgba(0,0,0,0.1); }
```


---

