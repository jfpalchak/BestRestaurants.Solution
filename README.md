# _Best Restaurants_

#### By _Joey Palchak, Jake Elsberry, Moshe Atia_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

A simple website where users can add their favorite restaurants based on the type of cuisine they offer. Users can search for restaurants by the cuisine they offer, or otherwise search through a list of all available restaurants.

Schema diagram:
<img src="https://github.com/jfpalchak/BestRestaurants.Solution/blob/assets/schema-draw.png" />

Available Routes:
```
https://localhost:5001
https://localhost:5001/Cuisines
https://localhost:5001/Cuisines/Create
https://localhost:5001/Cuisines/Details/{id}
https://localhost:5001/Cuisines/Edit/{id}
https://localhost:5001/Cuisines/Delete/{id}
https://localhost:5001/Restaurants
https://localhost:5001/Restaurants/Create
https://localhost:5001/Restaurants/Details/{id}
https://localhost:5001/Restaurants/Edit/{id}
https://localhost:5001/Restaurants/Delete/{id}

```

## Setup/Installation Requirements

#### Install Tools
This project assumes you have MySQL Server and MySQL Workbench installed on your system. If necessary, follow along with the installation steps for the tools introduced in these series of lessons on [LearnHowToProgram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

#### Set Up the Database
To set up a new database to run with this application, follow the instructions in this [LearnHowToProgram Lesson](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench). You'll need to import the `best_restaurants_dump.sql` file located at the top level of this repository to create a new database in MySQL Workbench with the name `best_restaurants`.

#### Install and Run the Project

1. Copy the **[URL](https://github.com/jfpalchak/BestRestaurants.Solution.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/BestRestaurants.Solution.git
```
5. Open your terminal and navigate to this project's production directory called `BestRestaurants`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
8. In the command line, run the following command to compile and run web application in development mode with a watcher:
   
```bash
$ dotnet watch run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

9. Open the browser to https://localhost:5001 to use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.


## Known Bugs

* If any bugs are discovered, please contact the author(s).

## License

MIT License

Copyright (c) _10/04/2023_ _Joey Palchak, Jake Elsberry, Moshe Atia_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.