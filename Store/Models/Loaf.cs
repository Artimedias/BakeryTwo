using System.Collections;
using System.Collections.Generic;
using System;

namespace LoafMath
{
    public class LoafThing
    {
        public int oven(int food, int price)
        {      
            while (food > 0)
            { 
                if (food >= 3)
                {
                    if((food % 3) == 0)
                    {
                        price += ((food / 3) * 10);
                        food = 0;  
                    }
                    else
                    {
                        price = price + (((food -(food % 3)) / 3) * 10);
                        food = (food % 3);
                    }
                }
                else
                {
                    price = price + (food * 5);
                    food = 0;
                }
            }
            return price;
        }

        public int Discount(int a, string extra)
        {
            if ((a % 3) == 2)
            {
                Console.WriteLine("Let them know that they can get another loaf of bread at no extra charge");
                Console.WriteLine("Did they want the extra loaf? Hit y for yes, n for no");
                if (extra == " ")
                { 
                extra = Console.ReadLine();
                }
                if (extra == "y")
                {
                    a = a + 1;
                }

            }
            return a;
        }
    }
}