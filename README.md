# REIZ TECH Homework Assignment - .NET Developer Intern
This repository contains two console applications that were created for REIZ TECH's homework assignment for the .NET Developer Intern position. The details of the assignment are as follows:



## 1. Analogue Clock Task
The Analogue Clock Task application is a console app that allows users to input hours and minutes of an analogue clock, and then calculates the lesser angle in degrees between the hour and minute arrows of the clock. 

The application uses the `AnalogueClock.cs` to represent the clock, and the `TimeFormatEnum.cs` enumeration to specify whether the input time is in regular or military format.

### Files:
* **`Program.cs`**: Contains **`Main`** method for the console application.
* **`AnalogueClock.cs`**: Contains the **`AnalogueClock`** class that represents the analogue clock
* **`TimeFormatEnum.cs`**: Contains the **`TimeFormatEnum`** enumeration that specifies wheter the input time is in regular or military format.



## 2. Hierarchical Structure Task
This program calculates the maximum depth of a hierarchical structure represented as a tree using a recursive method and alternatively with LINQ .Aggregate method. The tree structure is created in the initializeTree() method with a maximum depth of 5.

### Methods exaplined:

The `RecursiveMethodMeasureDepth` method uses a regular `for` loop to iterate through the branches of the tree and recursively calls itself on each branch until it reaches the end of the tree. The method returns the highest depth it has reached.

The `RecursiveMethodMeasureDepthLINQ` method uses the LINQ `.Aggregate` method to iterate through the branches of the tree and recursively calls itself on each branch until it reaches the end of the tree. The method returns the highest depth it has reached.

### Files:
* **`Program.cs`**: Contains **`Main`** method for the console application and `Branch` class for object declaration.

### Note:
The List<Branch> property of the Branch class was initially kept private for encapsulation, but had to be made public for the use of LINQ. Alternatively, a method could have been created to copy the elements of the immutable array and put them into a new mutable one with return.


Both applications were written in C# and built using Visual Studio 2019.

# Running the Applications

## Requirements
To run this program, you will need:

+ Microsoft Visual Studio or another C# compiler
+ .NET Framework installed on your computer

## How to Run
To run either of the applications, simply follow the instructions as follows:

1. Clone or download the repository to your computer.
2. Open a command prompt or terminal window and navigate to the **`./AnalogueClockTask`** (Analogue Clock Task) or **`./ReizTechAssignments`** (Hierarchical Structure Task) directory that contains the **`Program.cs`** file.
2. Compile the program by running the command ``dotnet build``.
3. Run the program by running the command ``dotnet run``.
3. Follow the on-screen instructions to input the hours and minutes of the analogue clock.
