# Testing CSharp

Objective => learn how to generate, manage and work with unit test in C#.
<br>
More informations about Tests [here](https://github.com/VictorMauroy/Testing-Lesson).
*(Note: This is an ongoing documentation link)*

## 1) Start a .NET console project.
### Linux
Download and install **Visual Studio Code**. <br>
Download and install **Dotnet** (Include SDK & Runtime): 
```bash
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0
```

Recommanded extensions:
* C# *Extension* (Nugget, Test, Build/Run, Add project, etc.)
* *IntelliCode* (Autocomplete and suggestions)
* C# *Dev Kit* (Include intelliCode and C# Extension)

Create a .NET console project:
```bash 
dotnet new console -o <MyProject>
```
### Windows
Download and install [Dotnet](https://dotnet.microsoft.com/en-us/download) (Include SDK & Runtime).

Download and install [Visual Studio Community](https://visualstudio.microsoft.com/fr/free-developer-offers/).
<br> You can also install Enterprise or Professionnal (Paid version).

Create a console project:
1. Open Visual Studio
1. New Project
1. Select "Console Application"
1. Customize your project and create it

-------------------------- 

***WORK IN PROGRESS***

--------------------------

## 2) Create functions or methods
In order to perform test, you'll need to create a few functions or a class with methods.

Let's create a static class which can be called without defining an object, and another which is a public class with properties and methods.

### Static class
A **static** class is a special type of class which doesn't need to define an object to access the methods.
```csharp
public static class Computation
{
    public static float GetDivision(int dividend, int divisor)
    {
        return dividend / (float)divisor;
        // Note: Convert divisor as float to avoid getting a rounded integer
    }
}
```
For that specific class, you can call the methods by doing so:
```csharp
float quotient = Computation.GetDivision(19, 13);
```
*Note: do not forget to import it with a "using" statement.
You can also use a namespace.*

### Public class with properties and methods
By defining a class as **public**, you make it accessible from outside the script.

Here is an example:
```csharp
public class Cat
{
    public string Name { get; set; }
    public float Weigth { get; set; }

    // Constructor for the Cat class.
    public Cat(string name, float weigth) 
    {
        Name = name;
        Weigth = weigth;
    }
        
    public float RaiseWeigth(float weigthToAdd)
    {
        Weigth+= weigthToAdd;
        return Weigth;
    }
}
```
We defined a class to create Cat objects. 
Our cats can get a customized name and weigth.
<br> 
There is also a method to increase its weigth that we are going to use for our tests.

You can define a new cat by doing so:
```csharp
string myCatName = "Kitty";
float myCatWeigth = 1.5f;

Cat kitty = new Cat(
    myCatName,
    myCatWeigth
);

kitty.RaiseWeigth(0.5f); //This is how to use the RaiseWeigth method.
```

## 3) Generate unit tests

[Best practices for Test in C#](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

## 4) Automatic unit test
Unit test on build: 
Open the **Test** window > **Test Explorer** > **Options** > **Execute after build**.

Unit test when writing code: https://www.ncrunch.net/



***Project note:*** <br> 
To be able to add my unit test on Github, I had to move the folder corresponding to my Project "Testing CSharpTests" into the folder of "Testing CSharp". Otherwise, github won't see the files because they aren't in the target repository.
