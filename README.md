# MyGarage
Learning Inheritance and Composition
## Instructions
This is an exercise in writing code that will only compile. You are not required to put any code inside of `Program.cs`

1. Create a Car class
    1. Include properties for fuel/battery capacity, color, and passenger occupancy
    2. Include methods for refueling, driving, and braking
2. Create an Aircraft class
    1. Include properties for fuel capacity, color, and passenger occupancy
    2. Include methods for refueling, flying, and landing
3. Create a Watercraft class
    1. Include properties for fuel capacity, color, and passenger occupancy
    2. Include methods for refueling and driving

### By this point, you probably see some repetition in your code.

Refactor your `Car`, `Aircraft`, and `Watercraft` classes to all inherit from a common `Vehicle` class that contains all the shared properties and/or methods

Now let's extend our inheritance chain to create specific types of Cars, Aircraft, and Watercraft.

For instance, a Nissan Leaf class inherits from the Car class and the Car class inherits from the Vehicle class.

Your specific types of cars, aircraft, and watercraft should implement properties or methods that are unique to that thing.

For instance, some luxury cars come with a self-parking feature, but that is not a feature common to all cars.

Replace your empty `Main` method with the `Main` method below and complete the commented out tasks.

```csharp
public static void Main()
{
    // Build a collection of all vehicles that fly
    // With a single `foreach`, have each vehicle Fly()

    // Build a collection of all vehicles that operate on roads
    // With a single `foreach`, have each road vehicle Drive()

    // Build a collection of all vehicles that operate on water
    // With a single `foreach`, have each water vehicle Drive()
}
```
