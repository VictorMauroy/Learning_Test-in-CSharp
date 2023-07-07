# Testing CSharp

Objective => learn how to generate, manage and work with unit test in C#.
<br>
More informations about Tests [here](https://github.com/VictorMauroy/Testing-Lesson).
*(Note: This is an ongoing documentation link)*

## 1) Start a .NET console project.
### Linux
Download and install Dotnet (Include SDK & Runtime): 
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
1. Configure and create

-------------------------- 

***WORK IN PROGRESS***

--------------------------

## 2) Create functions or methods

## 3) Generate unit tests

[Best practices for Test in C#](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)

## 4) Automatic unit test
Unit test on build: 
Open the **Test** window > **Test Explorer** > **Options** > **Execute after build**.

Unit test when writing code: https://www.ncrunch.net/
