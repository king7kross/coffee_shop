using System;
class Program
{
    static void Main(String[] args)
    {
        int totalCountOfCoffee = 0;
        int finalPriceOfCoffee = 0;
        
    Start:
        Console.WriteLine("""               
        {enter your choice from 1/2/3
        1 - small 2 - medium 3 - large}                 
        """);
        int choice = int.Parse(Console.ReadLine()!);
        int price_of_coffee = 0;
        switch (choice)
        {

            case 1:
                Console.WriteLine("your picked small");
                price_of_coffee += 100;
                Console.WriteLine($" price of the coffee is= {price_of_coffee}");
                break;
            case 2:
                Console.WriteLine("your picked medium");
                price_of_coffee += 200;
                Console.WriteLine($" price of the coffee is= {price_of_coffee}");
                break;
            case 3:
                Console.WriteLine("your picked large");
                price_of_coffee += 300;
                Console.WriteLine($" price of the coffee is= {price_of_coffee}");
                break;
            default:
                Console.WriteLine("enter valid choice");
                break;
        }
        totalCountOfCoffee += 1;
        finalPriceOfCoffee += price_of_coffee;
        Console.WriteLine(""" 
        {do you want to order again yes/no} 
        """);
        string decision = Console.ReadLine()!;
        if (decision == "yes") {
            goto Start;
        }
        else {
            Console.WriteLine($"the total no of coffee you bought = {totalCountOfCoffee}");
            Console.WriteLine($"the total price of your coffee = {finalPriceOfCoffee}");
            Console.WriteLine("thank you for ordering coffee from us");
        }
    }
}
