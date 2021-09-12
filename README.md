Junior Accelerator Program Task 1 - Movie Application

Technologies used:
 - Angular on the frontend 
 - ASP .NET Core API on the backend 

What is this project about?
JAP Task 1 is a small Angular and .NET Core app trying to mimic imdb rating and search engine. 

Upon starting the application, user sees top 10 rated movies. Click on the TV Shows tab opens up top 10 TV Shows. User can seach through the list of movies by name, year or rating. For example, typing Harry should list all movies that have Harry in their title or description. If a use types 2015, user is presented with movies from 2015. Also, by clicking on the yellow stars, user can leave a 1-5 rating on a movie. Finally


How to start the application?

1. Download/clone this repository.
2. Open the folder in Visual Studio Code (or similar).
3. In the Terminal naviagte to API folder and run
dotnet watch run or dotnet run

Doing this should result in databse creation that is going to be seed by data in MovieSeedData.json (movieapp.db is added to this repository too)

4. In other Terminal window navigate to client folder and run 
ng serve

5. Try out the JAP Task 1 Movie App




