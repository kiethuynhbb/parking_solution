Requirement:
The city of Vence needs help with the implementation of a new parking garage and asks you for your support.
The garage should support different types of vehicles: Cars, Motorbikes

Every vehicle has a unique identifier (the license plate), and can exist only once – thus being either within the garage or
outside of it.

The planned garage should support multiple parking levels – the city of Vence is currently undecided how high they will
be able to build for stability reasons. As a result, your implementation should allow for arbitrary numbers of parking levels
– at least 1 level, but keep it flexible.

The same goes for the number of parking spaces per level – the area where the garage will be built is not yet decided
upon. So again, keep this flexible and configurable.

Your task is to develop a simulation program for the garage. Vehicles should be able to enter and exit the garage – the
garage should then assign a free space or reject the vehicle if there are no more free parking lots. 

![image](https://user-images.githubusercontent.com/71831162/172992404-26f278cb-5399-4da5-9e37-eb858bcd0f79.png)

How to build:
- Open and build on Visual Studio
- For DB: find the Parking.bak to restore it or run the script (migration_db.sql) in SQL server.
