# Assignment 1 – File Write and Read Using C#

## Problem Statement
Write a C# program that:
1. Accepts multiple lines of text from the user.
2. Stops taking input when the user enters `STOP`.
3. Saves the entered lines into a file named `output.txt`.
4. Reads the contents of the file and displays them on the console.
5. Implements proper exception handling for file and I/O operations.

---

## Description
This project is a C# Console Application that demonstrates file handling using the `System.IO` namespace.  
The program continuously reads user input from the console and writes it to a text file until the keyword `STOP` is entered.  
After writing is complete, the program reads the file content and displays it back to the user.

The implementation includes structured exception handling to gracefully manage file access and unexpected runtime errors.

---

## Features
- Accepts multi-line user input
- Uses a sentinel value (`STOP`) to terminate input
- Writes text data to a file (`output.txt`)
- Reads and displays file contents
- Handles file-related and runtime exceptions
- Uses `using` statements for proper resource management

---

## Folder Structure
ASSIGNMENT1_output.txt
│
├── Task1_output.txt.sln
├── Task1_output.txt
│ ├── Program.cs
│ ├── Task1_output.txt.csproj
│ └── Properties



---

## Technologies Used
- C#
- .NET Framework
- System.IO
- Console Application
- Visual Studio

---

## How to Run the Program
1. Clone the repository from GitHub
2. Open the solution file (`.sln`) in Visual Studio
3. Build and run the project
4. Enter multiple lines of text in the console
5. Type `STOP` to finish input and view the file contents

---

## Exception Handling
The program handles:
- `IOException` for file-related errors
- General `Exception` for unexpected runtime issues

This ensures the program does not crash and provides meaningful error messages.

---

## Learning Outcomes
- Understanding file read/write operations in C#
- Using `StreamWriter` and `StreamReader`
- Implementing exception handling
- Working with Git and GitHub repositories
- Writing clean, structured console applications

---

## Author
**Aishwarya M B**

GitHub: https://github.com/aishwaryamb1997-boop
