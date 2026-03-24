# Equipment Rental System

## Author
Name: Bobozhon Mirkhabibov
Student ID: s34235  
Course: APBD

## Project Description
This is a console application written in C# that simulates a university equipment rental system.  
The system allows managing users, equipment, rentals, returns, and penalties.

## How to Run
Open the solution in Visual Studio and run the project.



## Project Structure

The project is divided into three main parts:

- Domain – contains core classes such as Equipment, User, and Rental
- Services – contains business logic such as RentalService and PenaltyCalculator
- Program – handles application execution and demonstration

## Design Decisions

The project follows separation of responsibilities by dividing logic into different layers.

Domain classes represent core entities, while services handle business logic such as renting equipment and calculating penalties.

Inheritance is used to model different types of equipment and users, such as Laptop, Student, and Employee.

This approach improves cohesion and reduces coupling, making the system easier to maintain and extend.