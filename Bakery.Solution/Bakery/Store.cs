using System;
using System.Collections;
using System.Collections.Generic;
using BakeryBread;
using BakeryDonut;


namespace Bakery
{
  public class BakeryFront
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Donut newDonut = new Donut();

      Console.WriteLine("Welcome to the Bakery! We have breads and donuts for sale today. Bread is buy 2 get one free at a price of 5 dollars a loaf. Can I interest you in any loaves of bread? Y/N");
      string userInput = Console.ReadLine();

      if (userInput == "Y" || userInput == "y")
      {
        Console.WriteLine("Fantatstic! How many loaves of bread would you like?");
        

        newBread.HowMany = int.Parse(Console.ReadLine());

        if(newBread.DealChecker(newBread.HowMany))
        {
          Console.WriteLine("You are eligiable for an extra free loaf of bread, would you like it? Y/N");
            userInput = Console.ReadLine();
             if (userInput == "Y" || userInput == "y")
             {
              Console.WriteLine("Adding it now!");
               newBread.HowMany =  newBread.HowMany + 1;
             }
             else
             {
              Console.WriteLine("No? Alright.");
             }
        }
      }
      else
      {
        Console.WriteLine("No bread today, got it!");
      }

      Console.WriteLine("Can I interest you in some donuts today perhaps? 2 dollars apeice, but if you buy 3, you get one free! Y/N");
        userInput = Console.ReadLine();
          if (userInput == "Y" || userInput == "y")
          {
            Console.WriteLine("Wonderful! How many donuts would you like?");
        
        
        newDonut.HowMany = int.Parse(Console.ReadLine());

        if(newDonut.DealChecker(newDonut.HowMany))
        {
          Console.WriteLine("You are eligiable for an extra donut for free, would you like it? Y/N");
            userInput = Console.ReadLine();
             if (userInput == "Y" || userInput == "y")
             {
              Console.WriteLine("Adding it now!");
             }
             else
             {
              Console.WriteLine("No? Alright.");
             }
        }
          }

        else
        {
          Console.WriteLine("No Dounuts then? Got it!");
        }

      int price = newBread.BreadPrice(newBread.HowMany, 0);
      price = newDonut.DonutPrice(newDonut.HowMany, price);

      Console.WriteLine($"You purchased {newBread.HowMany} loaves of bread, and {newDonut.HowMany} donuts. Your total is {price} dollars. Thank you for shopping with us today.");
    }
  }
}