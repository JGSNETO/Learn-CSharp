# Learn-C#

- C# is a modern, high-level, object-oriented programming language that was developed by Microsoft in the early 2000s. It was designed to be a simple, yet powerful language that can be used to develop a wide range of applications, including desktop applications, web applications, mobile apps, and games. 
- C# is based on .NET framework and provides features like garbage collection, type safety and automatic memory management.

## Features of C#

1. Type safety: Every variable and expression has a type. The compiler checks for type compatibility to prevent errors at runtime.
2. Garbage collection: C# uses garbage collection to automatically manage memory allocation and deallocation. This makes it easier to write memory-safe code and eliminates many common programming errors, such as memoy leaks.
3. Object-Oriented Programming: It supports encapsulation, inheritance, and polymorphism. This makes it easier to write reusable and maintainable code. 
4. Plataform Independence: It can run on any plataform that supports the .NET framework, such as linux, windows and macOS.
5. Asynchronous programming: C# Supports asynchronous programming which allows developers to write non-blocking code that can perform multiple tasks simultaneously. 
6. LINQ: Language Integrated Query, which is a powerful feature that allows developers to query data from different data sources such as databases, XML documents, and collections using a common syntax.
7. Delegates and Events: Allow developers to write event-driven code that responds to user actions, system events and other externam stimuli. 
8. Exception Handling:
9. Generic Programming:
10. Easy-to-learn syntax:

```
//Namespace
using System;
//Class definition: C# programs are organized into classes. The 'program' class is commonly sed as the entry point for the program. 
class{
    //class members
}
//Main Method: The 'main' method is the entry point of a c# program. it is where the program execution begin
static void Main(){

}
//Statements and Expressions: Perform actions, such as calling methods or assigning values.
Console.WriteLine("Hello, World");
```

### Static functions
- Defined with the 'static' keyword
- Belong to the class itself rather than individual instances of the class
- Can be called directly using the class name without creating an instance of the class
- Often used for utility methods or operations that don't require access to instance specific data

### Data types 

1. Numeric types:
- int
- float
- double
- decimal

2. Boolean type
- bool

3. Character type
- char

4. String type
- string

5. Enumerations
- enum

6. Arrays

- int[], folat[] ..

### Operations and Expressions

1. Arithmetic Operators:
- +
- -
- *
- /
- %
- =
- +=, -=, *=, /=, %=
- ==
- !=
- >,<, >=, <=
- &&
- ||
- !
- ++
- --
- ?
- &: and
- |: or
- ^: Bitwise XOR
- >>: Right shift
- <<: Left shift
- +: Concatenates two strings together
- .: Accesses members
- (): Call methods

### Control structures in C#

1. If statement:
```
if (condition){
    //
}
else if (condition){
    //
}
else {
    //
}
```
2. Switch statement:
```
switch(expression){
    case value1:
    //
    case value2:
    //
    default:
    //
        break;
}
```
3. Loops:
```
for(initialization, condition, iteration){
    //
}

while(condition){
    //
}

do{

}while(condition);

foreach(var item in collection){

}

```
