# _C#-Word Counter MVC _

#### _Single Webpage for Epicodus, 11.16.2018_

#### By _**Glen Sale**_

## Description

_Create a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)_


### _Basic Structure of Directory for Program and Testing_

__Word-Counter.Solution
├── WordCounter
│   ├── WordCounter.csproj
│   └── obj
│       ├── WordCounter.csproj.nuget.cache
│       ├── WordCounter.csproj.nuget.g.props
│       ├── WordCounter.csproj.nuget.g.targets
│       └── project.assets.json
└── WordCounter.Tests
    ├── WordCounter.Tests.csproj
    └── obj
        ├── WordCounter.Tests.csproj.nuget.cache
        ├── WordCounter.Tests.csproj.nuget.g.props
        ├── WordCounter.Tests.csproj.nuget.g.targets
        └── project.assets.json__

* _For More click the link :_ ** https://www.learnhowtoprogram.com/c/c-basics-and-testing/mstest-configuration-and-setup_        


### _Basic Structure of Directory for MVC and Controll Testing
ToDoList.Solution
├── ToDoList
│   ├── Controllers
│   │   ├── HomeController.cs
│   │   └── ItemsController.cs
│   ├── Models
│   │   ├── Category.cs
│   │   └── Item.cs
│   ├── Program.cs
│   ├── Startup.cs
│   ├── ToDoList.csproj
│   └── Views
│       ├── Home
│       │   └── Index.cshtml
│       └── Items
│           ├── DeleteAll.cshtml
│           ├── Index.cshtml
│           ├── New.cshtml
│           └── Show.cshtml
└── ToDoList.Tests
    ├── ControllerTests
    │   ├── HomeControllerTests.cs
    │   └── ItemsControllerTests.cs
    ├── ModelTests
    │   ├── CategoryTests.cs
    │   └── ItemTests.cs
    └── ToDoList.Tests.csproj

    * _For More click the link : _https://www.learnhowtoprogram.com/c/mvc-web-applications/objects-within-objects-setup_  

### Specs
| Spec | Search | Text | Result |
| :-------------     | :------------- | :------------- | :------------- |
| **Program matches lowercase or uppercase Letters** | Search: "basketball" | Text: "Basketball is my favorite sport" |  Result: No match found |
| **Program Counts The Word that matches in the sentence** | Search: "test" | Text: "This test is a sample testing" |  Result: "matches 1" |
| **Program Gathers Sentence** | Search : "This sample is a sample" | Text: "This sample is a sample"|  Result: matches 1 |
| **Program Gathers List of Words** | Search: "sample" | Text: "sample, sample, sample"|  Result: "sample matches 3" |


## Setup/Installation Requirements
* Clone this repository https://github.com/glenpogz36/Csharp-WordCounter.Solutions-MVC
* _To edit the project, open the project in your preferred text editor._
* _Download
 "Microsoft.AspNetCore" Version="1.1.2"
  "Microsoft.AspNetCore.Http" Version="1.1.2"
  "Microsoft.AspNetCore.Mvc" Version="1.1.3"._
* _To download create A file inside the Project Directory creating Program.cs and Startup.cs>
* _To run the program, first navigate to the location of the Program.cs and Startup.cs file then compile and execute:
$ dotnet restore : to download AspNetCore
$ dotnet build : to check for errors
$ dotnet run : to run localhost:5000
* _To run the tests, use these commands inside WordCounter.Tests directory using: $ cd WordCounter.Tests $ dotnet test_

## Technologies Used

* _C#_
* _.NET_
* _AspNETCore_
* _Atom_
* _GitHub_


### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 ** _Glen Sale_ **
