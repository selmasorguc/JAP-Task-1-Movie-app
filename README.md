# Junior Accelerator Program Task 1 - Movie Application

Technologies used:
 - Angular on the frontend
 - ASP .NET Core API on the backend

# What is this project about?

JAP Task 1 is a small Angular and .NET Core app trying to mimic imdb rating and search engine.

Upon starting the application, the user sees top 10 rated movies. Click on the TV Shows tab opens up top 10 TV Shows. Users can search through the list of movies/tv shows by name, year or rating. For example, typing Harry should list all movies and tv shows that have Harry in their title or description. If a user types 2015, the user is presented with movies from 2015. Search bar reacts to user's input automatically, but not before there's at least 2 characters entered in the search bar. When the search bar is cleared, top 10 movies/shows of all time reappear as results, depending on which tab/toggle switch value is selected.


Also, by clicking on the yellow stars, users can leave a 1-5 rating on a movie. 



![Screenshot_1](https://user-images.githubusercontent.com/89447689/132999618-eafe3f01-a636-4938-a79f-04e2389579b0.png)

![Screenshot_2](https://user-images.githubusercontent.com/89447689/132999674-352e5e5e-3e70-489e-a2b0-48cfc4d60451.png)


![Screenshot_3](https://user-images.githubusercontent.com/89447689/132999705-25b901bd-fe8d-4097-8f6c-f291c7e17f5c.png)


![Screenshot_4](https://user-images.githubusercontent.com/89447689/132999708-a5f0bf3c-c6c2-422a-8b6c-aae60f1bb73d.png)

# How to start the application?

1. Download/clone this repository.
2. Open the folder in Visual Studio Code (or similar).
3. In the Terminal navigate to API folder and run
dotnet watch run (or) dotnet run

Doing this should result in database creation that is going to be seeded by data in MovieSeedData.json (movieapp.db is added to this repository too).

4. In other Terminal window navigate to client folder and run
ng serve

5. Try out the JAP Task 1 Movie App



