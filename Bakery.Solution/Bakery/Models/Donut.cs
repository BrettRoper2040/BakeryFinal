using System.Collections;
using System.Collections.Generic;
using System;

namespace BakeryDonut
{
  public class Donut
  {
    public int HowMany { get; set; }
        public int DonutPrice(int food, int price)
        {      
             while (food > 0)
            { 
                if (food >= 4)
                {
                    if((food % 4) == 0)
                    {
                        price += ((food / 4) * 6);
                        food = 0;  
                    }
                    else
                    {
                        price = price + (((food -(food % 4)) / 4) * 6);
                        food = (food % 4);
                    }
                }
                else
                {
                    price = price + (food * 2);
                    food = 0;
                }       
            }
            return price;
        }
                public bool DealChecker(int amount)
        {
            if(amount % 4 == 3)
            {
                return true;
            }
            return false;
        }
  }
}