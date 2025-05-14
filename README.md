# Microsoft Learn: C# Developer Certification Course 🚀

## **Notes and Code Snippets**

## **Perform basic string formatting in C# - *14/05/2025***

Combine literal and variable text data that contain special characters, formatting, and Unicode into meaningful messages for the end user.

## **Learning objectives**

After you complete this module, you'll be able to:

- Create string data containing tabs, new lines, and other special characters
- Create string data containing Unicode characters
- Combine string data into a new string value via concatenation
- Combine string data into a new string value via interpolation

### **Verbatim string literal**

A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the `@` directive before the literal string.

### **Format output using verbatim string literals**

Add the following line of code beneath the code that you created previously:

```
Console.Write(@"c:\invoices");
```
### **Unicode escape characters**

You can also add encoded characters in literal strings using the `\u` escape sequence, then a four-character code representing some character in Unicode (UTF-16).
```
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```
Output:
`こんにちは World!`

### **Format output using character escape sequences:**

![GenerateInvoice.png](/BasicStringFormatting/GenerateInvoice.png)
![output.png](/BasicStringFormatting/output.png)
![Format literal strings.png](/BasicStringFormatting/Format_literal_strings.png)

## **Write your first code using C# - 13/05/2025**

Let's focus on the following line of code you wrote:
```
Console.WriteLine("Hello World!");
```

When you ran your code, you saw that the message `Hello World!` was printed to the output console. When the phrase is surrounded by double-quotation marks in your C# code, it's called a **literal string**. In other words, you literally wanted the characters `H`, `e`, `l`, `l`, `o`, and so on, sent to the output.

The `Console` part is called a **class**. Classes "own" methods; or you could say that methods live inside of a class. To visit the method, you must know which class it's in. For now, think of a class as a way to represent an object. In this case, all of the methods that operate on your output console are defined inside of the `Console` class.

There's also a dot (or period) that separates the class name `Console` and the method name `WriteLine()`. The period is the *member access operator*. In other words, the dot is how you "navigate" from the class to one of its methods.

The `WriteLine()` part is called a **method**. You can always spot a method because it has a set of parentheses after it. Each method has one job. The `WriteLine()` method's job is to write a line of data to the output console. The data that's printed is sent in between the opening and closing parenthesis as an input parameter. Some methods need input parameters, while others don't. But if you want to invoke a method, you must always use the parentheses after the method's name. The parentheses are known as the *method invocation operator*.

Finally, the semicolon is the *end of statement operator*. A **statement** is a complete instruction in C#. The semicolon tells the compiler that you've finished entering the command.

Don't worry if all of these ideas and terms don't make sense. For now, all you need to remember is that if you want to print a message to the output console:

- Use `Console.WriteLine("Your message here");`
- Capitalize `Console`, `Write`, and `Line`
- Use the correct *punctuation* because it has a special role in C#
- If you make a mistake, just spot it, fix it and re-run

## **Check your knowledge**

**1. 
What is the difference between `Console.Write` and `Console.WriteLine`?**
`Console.Write` prints the output on a new line.
`Console.WriteLine` prints the output on a new line.
`Console.WriteLine` appends a new line after the output.**Correct! `Console.WriteLine` prints the output on the existing line and appends a new line after it.**

### **Use integer literals**

If you want to display a numeric whole number (no fractions) value in the output console, you can use an **int literal**. The term `int` is short for integer, which you may recognize from studying math. In C#, this data type is officially named "int", but frequently referred to as "integer". An `int` literal requires no other operators like the `string` or `char`.

```
Console.WriteLine(123);
```

### **Use floating-point literals**

A floating-point number is a number that contains a decimal, for example 3.14159. C# supports three data types to represent decimal numbers: `float`, `double`, and `decimal`. Each type supports varying degrees of precision.

```
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
```

Here, precision reflects the number of digits past the decimal that are accurate.

Add the following in the code editor:

```
Console.WriteLine(0.25F);
```

To create a `float` literal, append the letter `F` after the number. In this context, the `F` is called a *literal suffix*. The literal suffix tells the compiler you wish to work with a value of `float` type. You can use either a lower-case `f` or upper-case `F` as the literal suffix for a `float`.

### **Why emphasize data types?**

Data types play a central role in C#. In fact, the emphasis on data types is one of the key distinguishing features of C# compared to other languages like JavaScript. The designers of C# believed they can help developers avoid common software bugs by *enforcing* data types. You'll see this concept unfold as you learn more about C#.

### **Data types define capabilities**

Earlier, you saw that `string`s and `char`s are used for "presentation, not calculation". If you need to perform a mathematical operation on numeric values, you should use an `int` or `decimal`. If you have data that is used for presentation or text manipulation, you should use a `string` or `char` data type.

Suppose you needed to collect data from a user, like a phone number or postal code. Depending on the country/region where you live, that data may consist of numeric characters. However, since you rarely perform mathematical calculations on phone numbers and postal codes, you should prefer to use a `string` data type when working with them.

The same can be said of `bool`. If you need to work with the words `"true"` and `"false"` in your application, you would use a `string`. However, if you need to work with the concept of `true` or `false` when performing an evaluation, you use a `bool`.

It's important to know that these values may look like their string literal equivalents. In other words, you may think these statements are the same:

```
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);
```

However, it's only the displayed output that appears to be similar. The fact is that the kinds of things you can do with the underlying `int` or `bool` will be different than their `string` equivalent.

## **Recap**

The main takeaway is that there are many data types, but you'll focus on just a few for now:

- `string` for words, phrases, or any alphanumeric data for presentation, not calculation
- `char` for a single alphanumeric character
- `int` for a whole number
- `decimal` for a number with a fractional component
- `bool` for a `true`/`false` value

# **Declare variables**

A literal is *literally* a hard-coded value. Hard-coded values are values that are constant and unchanged throughout the execution of the program. However, most applications will require you to work with values that you don't know much about ahead of time. In other words, you'll need to work with data that comes from users, from files, or from across the network.

When you need to work with data that isn't hard-coded, you'll declare a variable.

## **What is a variable?**

A **variable** is a container for storing a type of value. Variables are important because their values can change, or vary, throughout the execution of a program. Variables can be assigned, read, and changed. You use variables to store values that you intend to use in your code.

A variable name is a human-friendly label that the compiler assigns to a memory address. When you want to store or change a value in that memory address, or whenever you want to retrieve the stored value, you just use the variable name you created.

### **Declare a variable**

To create a new variable, you must first declare the data type of the variable, and then give it a name.

```
string firstName;
```

In this case, you're creating a new variable of type `string` called `firstName`. From now on, this variable can only hold string values.

You can choose any name as long as it adheres to a few C# syntax rules for naming variables.

### **Variable name rules and conventions**

A software developer once famously said "The hardest part of software development is naming things." Not only does the name of a variable have to follow certain syntax rules, it should also be used to make the code more human-readable and understandable. That's a lot to ask of one line of code!

Here's a few important considerations about variable names:

- Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol `#` (also known as the number symbol or pound symbol) or dollar symbol `$` are not allowed.
- Variable names must begin with an alphabetical letter or an underscore, not a number.
- Variable names are case-sensitive, meaning that `string Value;` and `string value;` are two different variables.
- Variable names must **not** be a C# keyword. For example, you cannot use the following variable declarations: `decimal decimal;` or `string string;`.

There are coding conventions that help keep variables readable and easy to identify. As you develop larger applications, these coding conventions can help you keep track of variables among other text.

Here are some coding conventions for variables:

- Variable names should use **camel case**, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example, `string thisIsCamelCase;`.
- Variable names should begin with an alphabetical letter. Developers use the underscore for a special purpose, so try to not use that for now.
- Variable names should be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
- Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
- Variable names shouldn't include the data type of the variable. You might see some advice to use a style like `string strValue;`. That advice is no longer current.

The example `string firstName;` follows all of these rules and conventions, assuming you want to use this variable to store data that represents someone's first name.

### **Variable name examples**

Here's a few examples of variable declarations using the data types you learned about thus far:

```
char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;
```

## **Recap**

Here's what you've learned so far about variables:

- Variables are temporary values you store in the computer's memory.
- Before you can use a variable, you have to declare it.
- To declare a variable, you first select a data type for the kind of data you want to store, and then give the variable a name that follows the rules.

Now that you know how to declare a variable, let's learn how to set, retrieve, and initialize the value of a variable.

## **What are implicitly typed local variables?**

An implicitly typed local variable is created by using the `var` keyword followed by a variable initialization. For example:

```
var message = "Hello world!";
```

In this example, a string variable was created using the `var` keyword instead of the `string` keyword.

The `var` keyword tells the C# compiler that the data type is *implied* by the assigned value. After the type is implied, the variable acts the same as if the actual data type had been used to declare it. The `var` keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.

In the example:

```
var message = "Hello world!";
```

Because the variable `message` is immediately set to the `string` value `"Hello World!"`, the C# compiler understands the intent and treats every instance of `message` as an instance of type `string`.

In fact, the `message` variable is typed to be a `string` and can never be changed. For example, consider the following code:

```
var message = "Hello World!";
message = 10.703m;
```
If you run this code, you'll see the following error message.

OutputCopy

```
(2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'
```

**Note**

Other programming languages use the `var` keyword differently. In C#, variables are assigned a type by the compiler regardless of whether you use the actual data type name or allow the compiler to imply the data type. In other words, the type is locked in at the time of declaration and therefore will never be able to hold values of a different data type.

### **Variables using the `var` keyword must be initialized**

It's important to understand that the `var` keyword is dependent on the value you use to initialize the variable. If you try to use the `var` keyword without initializing the variable, you'll receive an error when you attempt to compile your code.

```
var message;
```

If you attempt to run this code, as it compiles, you'll see the following output:

OutputCopy

```
(1,5): error CS0818: Implicitly-typed variables must be initialized
```
### **Why use the `var` keyword?**

The `var` keyword has been widely adopted in the C# community. It's likely that if you look at a code example in a book or online, you'll see the `var` keyword used instead of the actual data type name, so it's important to understand its usage.

The `var` keyword has an important use in C#. Many times, the type of a variable is obvious from its initialization. In those cases, it's simpler to use the `var` keyword. The `var` keyword can also be useful when planning the code for an application. When you begin developing code for a task, you may not immediately know what data type to use. Using `var` can help you develop your solution more dynamically.

As you get started, it is recommended that you continue to use the actual data type name when you declare variables until you become more comfortable working with code. Using the data type when you declare variables will help you be purposeful as you write your code.

## **Recap**

Here's what you've learned about the `var` keyword so far:

- The `var` keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
- You'll likely see the `var` keyword as you read other people's code; however, you should use the data type when possible.
