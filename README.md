## Overview
Create a basic ASP.NET/C# MVC movie management application. The application can be used in two modes - public and admin. The public mode is what a normal user would use to browse/search for movies stored in the database. The admin mode is for an authenticated user who can add/edit/delete movies in the database.

This project is meant to test overall familiarity of the developer using .NET technologies (MVC, Entity Framework, ASP.NET Identity) as well as determine the comfort level of the developer with front-end coding through HTML/CSS/Javascript. Once the project is complete, the result will be reviewed for:
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
You will use ASP.NET MVC to manage the user interface and page access. To manage access to application you will use ASP.NET Identity. To manage the database you will use Entity Framework with Code First Migrations.

### Public Mode
The public mode is the default mode that unauthenticated users will see in your application. The main page of this mode should show a list of all genres from your database.  Within each genre, display the 5 most recently added movies to that genre. Clicking a genre will navigate the user to a page that shows all movies for a particular genre. Also on the main page, add the ability to search for movies by title.  This search should be done using AJAX, so that entering text into the search will automatically suggest titles. Finally, there should be a link to bring the user to a login page.  This page should use ASP.NET Identity to authenticate the user and navigate them to the admin mode of the application.

### Admin Mode
Admin pages should only be available to users with valid credentials to your application. Once in admin mode, an admin user should have to ability to add/edit/remove genres. A genre should at least include a *Name*, but feel free to include any other information you think is relevant.  If a genre contains any movies, then the user should not be able to delete that genre until all of the movies are removed from that genre.  The user should also have the ability to add/edit/remove movies. A movie should include a *Title*, *Year*, and *Genre*, but feel free to include any other information you think is relevant.  Finally, admin users should have to ability to add/edit/delete all admin users, but they should not have the ability to delete themselves.  An admin user should include an *E-mail address/Username* and *Password*, but feel free to include any other information you think is relevant.

NOTE: Please add one Admin User to the Seed method of your database so that we can log in and test your application.

## Deliverables
Please fork the DeveloperMovieProject to your own GitHub account. You will then have a clean copy of the beginning template to build your project.

Once you finish the project, make sure to push all of your code to the repository and then send us a link.

## <a name="References"></a>References
* [Coding Standards](http://www.dofactory.com/reference/csharp-coding-standards)
* [ASP.NET MVC Main Page](http://www.asp.net/mvc)
* [ASP.NET MVC Tutorials](http://www.tutorialsteacher.com/mvc/asp.net-mvc-tutorials)
* [Entity Framework Tutorials](http://www.entityframeworktutorial.net/)
* [ASP.NET Identity Main Page](http://www.asp.net/identity)
* [ASP.NET Identity Tutorial](http://tektutorialshub.com/asp-net-identity-tutorial-basics/)