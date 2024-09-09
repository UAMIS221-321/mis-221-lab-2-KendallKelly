//Lab 2
using System;
class totalCost 
 {
    static void Main()
    {
        Console.WriteLine("How many sandwiches are you going to get?");
        int sandwiches = int.Parse(Console.ReadLine());

        Console.WriteLine("How many toppings would you like?");
        int toppings = int.Parse(Console.ReadLine());

        Console.WriteLine("What would you like to tip?");
        double tip = double.Parse(Console.ReadLine());

        const double sandPrice = 4.75;
        const double toppingPrice = 0.55;
        const double discountPrice = 0.10; // Represents a 10% discount

        double sandCost = sandPrice * sandwiches;
        double topPrice = toppingPrice * toppings;

        double totalCost = sandCost + topPrice;
        double discountAmount = totalCost * discountPrice;
        double finalCost = totalCost - discountAmount;

        Console.WriteLine($"Your total is {finalCost:C}");
    }
}