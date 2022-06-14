# Coles.StringFun

Application is a simple program that can perform 3 functions:

1. Reverse the letters of words within the sentence
2. Detect if two sets of characters are anagrams
3. Remove the repeated elements of an array


Provides a command line interface

# To run (using VS) 

Restore the Nuget packages
Rebuild the solution

Set the start up project as `Coles.StringFun.Host` and press F5 or you could use swagger setting `Coles.StringFun.API` as start up project

# for cmd prompt: 

Navigate to the solution folder in command prompt, execute following commands:

1. dotnet restore 
2. dotnet build
3. dotnet Coles.StringFun.Host\bin\Debug\net6.0\Coles.StringFun.Host.dll


# About application - technical

The application is .NET Core 6 solution. To debug run - you would need minimum VS 2022

It uses onion architecture. The layers being: 

 - Coles.StringFun.Domain - this project is heart of the solution, contains the code which solves the problem that the service exists for

 - Coles.StringFun.Definitions - Any interfaces/ classes/ enums which are required for layers to communicate with each other within the solution are defined here. You may want contracts/interfaces etc as layers - but this being small project all are in one. 
 
 - Coles.StringFun.Application - This is essentially a coordination layer which allows the outside world to interact with the domain - none of the other layer should be accessing domain.

 - Coles.StringFun.API - All controllers reside here. It is another 'External' layer to serves as Back end API (if needed) is an overkill here :) but this was a test

 - Coles.StringFun.Host - Cmd line app - for bonus point.

 - Coles.StringFun.Domain.Tests - Tests for domain

 - Coles.StringFun.Application.Tests - Tests for application layer - any change in domain would effect this too, the tests are to make sure it is minimal 

# A little in depth 

The classes that actually do something are in 'domain' layer. 
These are very generic - 
	StringFunction works 'strings', no other type could be used here 
	ArrayFunction - work with arrays, there is no restriction on type of object in an array. So it has been made generic, with only constraint being that the class should implement `IEquatable` interface. This interface helps with comparison & equality check   


# Improvments 
Needs to be dockerised


