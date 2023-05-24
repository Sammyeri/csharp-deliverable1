using System;

public class Program
{
    public static void Main()
    {
        int soda_stock = 100;
        int chips_stock = 40;
        int candy_stock = 60;
        int soda_resotck = 40;
        int chips_restock = 20;
        int candy_restock = 40;

        Console.WriteLine("How many sodas have been sold today? " + soda_stock + " in stock.");
        int soda_sold = int.Parse(Console.ReadLine());
        if(soda_sold > soda_stock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        } else
        {
            soda_stock -= soda_sold;
            Console.WriteLine("There are " + soda_stock + " sodas left.");
        }

        Console.WriteLine("How many chips have been sold today? " +chips_stock + " in stock.");
        int chips_sold = int.Parse(Console.ReadLine());
        if (chips_sold > chips_stock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            chips_stock -= chips_sold;
            Console.WriteLine("There are " + chips_stock + " chips left.");
        }

        Console.WriteLine("How many Candy have been sold today? " + candy_stock + " in stock.");
        int candy_sold = int.Parse(Console.ReadLine());
        if (candy_sold > candy_stock)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            candy_stock -= candy_sold;
            Console.WriteLine("There are " + candy_stock + " candys left.");
        }

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked");
        if(soda_stock <= soda_resotck && chips_stock <= chips_restock && candy_stock <= candy_restock)
        {
            Console.WriteLine("Chips, Soda, and Candy need to be restocked");
        } else if (chips_stock <= chips_restock && soda_stock <= soda_resotck)
        {
            Console.WriteLine("Chips and Soda needs to be restocked");
        } else if (chips_stock <= chips_restock && candy_stock <= candy_restock)
        {
            Console.WriteLine("Chips and candy needs to be restocked");
        } else if (soda_stock <= soda_resotck && candy_stock <= candy_restock)
        {
            Console.WriteLine("Soda and candy needs to be restocked");
        } else if (chips_stock <= chips_restock)
        {
            Console.WriteLine("Chips need to be restocked");
        } else if (soda_stock <= soda_resotck)
        {
            Console.WriteLine("Soda needs to be restocked");
        }else if(candy_stock <= candy_restock)
        {
            Console.WriteLine("Candy needs to be restocked");
        }else
        {
            Console.WriteLine("Nothing needs to be restocked at this time");
        }

        Console.WriteLine("Goodbye!");
    }
}