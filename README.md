# Incorrect Object Comparison in C#

This example demonstrates a common mistake in C#: comparing objects using the `==` operator. In C#, `==` for reference types (like classes) compares references, not the actual values of the objects' properties. 

The `bug.cs` file contains code that incorrectly compares two `MyClass` objects. The `bugSolution.cs` file shows the correct way to compare objects by comparing their properties.

## How to run

1. Save the code in two files named `bug.cs` and `bugSolution.cs`.
2. Compile and run the code using a C# compiler (like the one included with Visual Studio).
