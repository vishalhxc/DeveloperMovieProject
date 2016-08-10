## Overview
Create a basic ASP.NET/C# MVC movie management application. The application can be used in two modes - public and admin. The public mode is what a normal user would use to browse/search for movies stored in the database. The admin mode is for an authenticated user who can add/edit/delete movies in the database.

This project is meant to test the developer's overall familiarity of  using .NET technologies (MVC, Entity Framework, ASP.NET Identity) as well as determine their comfort level with front-end coding through HTML/CSS/Javascript. Once the project is complete, the result will be reviewed for:
* Meeting all the requirements as set forth below
* Code organization, quality and cleanliness
* Use of any design patterns

Based on the review, a code review session will be conducted with the candidate with any questions and feedback over a screen share or in-person.

## Prerequisites
### Github Account
You will need a GitHub account to complete and submit the project. If you do not have a GitHub account, [it is easy to set up and free](https://github.com/join).

### Visual Studio Community 2015 And IIS Express
Please download the latest version of [Visual Studio Community 2015](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx).  If you already have access to a non-community version of Visual Studio 2015, please feel free to use it.  Visual Studio should come packaged with IIS Express.

## Project Requirements
This section highlights the overall requirements for the project. If you are not familiar with any of these concepts, we have provided [reference links](#References) below for more information.

### General Requirements
You will use ASP.NET MVC to manage the user interface and page access. To manage access to the application you will use ASP.NET Identity. To manage the database you will use Entity Framework with Code First Migrations.

### Public Mode
- Show a list of all genres from your database, with the 5 most recently added movies to that genre
- Clicking a genre will navigate to a page that shows all movies for a particular genre
- Ability to search for movies by title.  This search should be done using AJAX, so that entering text into the search will automatically suggest titles

### Admin Mode
- Authentication should be handled using ASP.NET Identity
- Ability to add/edit/delete genres
- Genre should at least include a *Name*, but feel free to include any other information you think is relevant
- If a genre contains any movies, then the user should not be able to delete that genre until all of the movies are removed from that genre
- Ability to add/edit/delete movies
- Movie should include a *Title*, *Year*, and *Genre*, but feel free to include any other information you think is relevant
- Ability to add/edit/delete all admin users, but they should not have the ability to delete themselves

NOTE: Please add one Admin User to the Seed method of your database so that we can log in and test your application.

## Deliverables
Please fork the DeveloperMovieProject to your own GitHub account. Commit all of your project work to this forked repository.

Once you finish the project, make sure to push all of your code to the repository and then send us a link.

## <a name="References"></a>References
* [Coding Standards](http://www.dofactory.com/reference/csharp-coding-standards)
* [ASP.NET MVC Main Page](http://www.asp.net/mvc)
* [ASP.NET MVC Tutorials](http://www.tutorialsteacher.com/mvc/asp.net-mvc-tutorials)
* [Entity Framework Tutorials](http://www.entityframeworktutorial.net/)
* [ASP.NET Identity Main Page](http://www.asp.net/identity)
* [ASP.NET Identity Tutorial](http://tektutorialshub.com/asp-net-identity-tutorial-basics/)