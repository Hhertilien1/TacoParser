# Taco Parser Kata

An exercise in geolocation, csv parsing, and logging

Objective: Find the two Taco Bells that are the farthest apart from one another.

## Kata Overview
    1. Started with writing a Unit Test to Test the Parse method
    2. Implemented the Parse Method
    3. Used the [GeoCoordinate.NetCore](https://www.nuget.org/packages/GeoCoordinate.NetCore/) NuGet package to calculate distance between two points
Completed the tests with Arrange, Act, Assert 
Created parse methods to extract the Longitude and latitude from my file that represents Taco Bell locations.
Created unit tests to test methods
Parsed a POI file to locate all the Taco Bells
Took lines and used line.Split(',') to split it up into an array of strings, separated by the char ','
Used File.ReadAllLines(path) to grab all the lines from your csv file. 
Used the Select LINQ method to parse every line in lines collection
Add the Geolocation library to enable location comparisons: using GeoCoordinatePortable;
Finally, I create a loop to go through each item in my collection of locations. This loop let me select one location at a time to act as the "starting point" or "origin" location.
I then created another loop to iterate through locations again. This allowed me to pick a "destination" location for each "origin" location from the first loop.
Ran the method to find the distance and store into a variable. The greatest distance was kept and displayed to the console.
