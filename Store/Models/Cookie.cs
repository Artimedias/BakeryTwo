using System.Collections;
using System.Collections.Generic;
using System;

namespace cookieMath
{
    public class cookieThing
    {
    private int price;
    private string CookieFlavors;

    public int HowMany { get; set; }


    public cookieThing(string a, int b, int c)
        {
            CookieFlavors = a; 
            HowMany = b;
            price = c;  
        }
        public int monster
        { 
        get
        {
            return price;
        }
           set
        {
        int food = value; 
            while (food > 0)
            { 
                if (food >= 3)
                {
                    if((food % 3) == 0)
                    {
                        price += ((food / 3) * 5);
                        food = 0;  
                    }
                    else
                    {
                        price = price + (((food -(food % 3)) / 3) * 5);
                        food = (food % 3);
                    }
                }
                else
                {
                    price = price + (food * 2);
                    food = 0;
                }
            }
        }
        }
        public string flavortown
        {
            get
            {
                return "Make sure that you got " + CookieFlavors + " cookies like they asked for.";
            }
            set
            {
                var rand = new Random();
                int a = int.Parse(value);
                if(a == 0)
                {
                    a = a + rand.Next(1, 5);
                }
                    switch(a)
                    {
                        case 1: CookieFlavors = "Chocolate Chip";
                            break;
                        case 2: CookieFlavors = "Smores";
                            break;
                        case 3: CookieFlavors = "SnickerDoodle";
                            break;
                        case 4: CookieFlavors = "Macadamia Nut";
                            break;
                    }
            }
        }
    }
}