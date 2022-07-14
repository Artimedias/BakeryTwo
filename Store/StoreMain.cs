using System;
using System.Collections;
using System.Collections.Generic;
using cookieMath;
using LoafMath;


//Writing this as if it's to be used as a cash register that only the employee will see so the phrasing might be a bit odd
class bakery
{
    static void Main()
    {
        Console.WriteLine("Enter Employee ID");
        string user = Console.ReadLine();
        Console.WriteLine("Is this your Employee ID? " + user);
        Console.WriteLine("Hit y to confirm");
        string input = Console.ReadLine();

        if (input != "y")
        {
            Console.WriteLine("Restarting");
            Main();
        }
        Console.WriteLine("Ask if they are ready to checkout. Hit y if yes, n if they are asking for a different sort of help");
        Begin(user);
    }

    static void Begin(string user)
    {
        string input = Console.ReadLine();
        if (input == "y")
        {
            Console.WriteLine("How many loaves of bread did they buy, " + user + "?");
            Console.WriteLine("Only enter a number, no funny business");
            Loaf(user);
        }
        else if (input == "n")
        {
            Console.WriteLine("Go help them " + user + " and then come back when they are read to checkout.");
            Main();
        }
        else
        {
            Console.WriteLine("Hit the y or n key " + user);
            Begin(user);
        }
    }

    static void Loaf(string user)
    {
        string input = Console.ReadLine();
        bool checker = IsOnlyNumbers(input);

        if (checker == true)
        {
            int bread = int.Parse(input);
            LoafThing LoafCost = new LoafThing();
            bread = LoafCost.Discount(bread, " ");
            int price = (LoafCost.oven(bread, 0));
            Console.WriteLine("How many cookies did they buy, " + user + "?");
            Sweet(user, price);
        }
        else
        {
            Console.WriteLine("Please only enter a number " + user);
            Loaf(user);
        }
    }

    static void Sweet(string user, int price)
    {
        string input = Console.ReadLine();
        bool checker = IsOnlyNumbers(input);

        if (checker == true)
        {
            int cookie = int.Parse(input);
            if (cookie > 0)
            {
            cookieThing Cookie = new cookieThing("0", cookie, price);
            Console.WriteLine("Ask them what type of cookie they want, then enter \n 0) for any type \n 1) for Chocolate Chip \n 2) for Smores \n 3) for SnickerDoodles \n 4) for Macadamia nut");
            Cookie.flavortown = Console.ReadLine();
            Cookie.monster = Cookie.HowMany;
            price = Cookie.monster;
            Console.WriteLine(Cookie.flavortown);
            Finish(user, price);
            }
        }
        else
        {
            Console.WriteLine("Please only enter a number " + user);
            Sweet(user, price);
        }
    }

    static void Finish(string user, int price)
    {
        Console.WriteLine("Their total comes up to $" + price + ".00");
        Console.WriteLine("Don't forget to tell them goodbye and wish them a good day");
        Console.WriteLine("Excellent work " + user);
        Main();
    }


    static bool IsOnlyNumbers(string value)
    {
        foreach (char c in value)
        {
            if (c < '0' || c > '9')
                return false;
        }

        return true;
    }
}