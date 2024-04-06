using System;

namespace Program;
internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my Shoe Closet!!!!");
        Console.WriteLine("Available Brands:");
        Console.WriteLine("1. Nike");
        Console.WriteLine("2. Adidas");
        Console.WriteLine("3. New Balance");

        Console.Write("Enter the number of the brand: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            Console.Write("Enter the number of the brand: ");
        }
        Closet closet = new Closet(); // Create an instance of the Closet class
        string brand;
        switch (choice)
        {
            case 1:
                brand = "Nike";
                closet.DisplayShoeInfo(brand); // Call the method using the instance
                break;
            case 2:
                brand = "Adidas";
                closet.DisplayShoeInfo(brand); // Call the method using the instance
                break;
            case 3:
                brand = "New Balance";
                closet.DisplayShoeInfo(brand); // Call the method using the instance
                break;
            default:
                brand = "";
                break;


        }
    }
}



    

