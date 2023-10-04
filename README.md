# _Best Restaurants_

#### By _Joey Palchak, Jake Elsberry, Moshe Atia_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MSTest
* MySQL

## Description

{DESCRIPTION}

## Setup/Installation Requirements

1. Copy the **[URL](https://github.com/jfpalchak/BestRestaurants.Solution.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/BestRestaurants.Solution.git
```
1. Open your terminal and navigate to this project's production directory called `BestRestaurants`.
2. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
3. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
4. In the command line, run the following command to compile and launch the web application:
   
```bash
$ dotnet run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.


## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _10/04/2023_ _Joey Palchak, Jake Elsberry, Moshe Atia_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.




-======

SETUP INSTRUCTIONS

Install Tools
Install the tools that are introduced in this series of lessons on LearnHowToProgram.com.

Set up the Databases
Follow the instructions in the LearnHowToProgram.com lesson "Creating a Test Database: Exporting and Importing Databases with MySQL Workbench" to use the todolist_with_ef_core_dump.sql file located at the top level of this repo to create a new database in MySQL Workbench with the name to_do_list_with_ef_core.

Set Up and Run Project
Clone this repo.
Open the terminal and navigate to this project's production directory called "ToDoList".
Within the production directory "ToDoList", create a new file called appsettings.json.
Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the uid is root and the pwd is epicodus.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
Within the production directory "ToDoList", run dotnet watch run in the command line to start the project in development mode with a watcher.
Open the browser to https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: Redirecting to HTTPS and Issuing a Security Certificate.


