using System;

namespace Lucky
{
    class MainClass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter your ticket number here: \n");
                string a;
                a = Convert.ToString(Console.ReadLine());
                if (a.Length < 4 || a.Length > 8)
                {
                    Console.Write("The ticket number must be from 4 to 8 digits long. \n");
                }
                if (a.Length % 2 != 0 && a.Length >= 4)
                {
                    a = "0" + a;
                }
                if (a.Length == 4)
                {
                    int l = Convert.ToInt32(a);
                    int l1 = ((l / 1000) % 10);
                    int l2 = ((l / 100) % 10);
                    int l3 = ((l / 10) % 10);
                    int l4 = ((l / 1) % 10);
                    if (l1 + l2 == l3 + l4)
                    {
                        Console.Write("You have lucky ticket number! \n");
                    }
                    else
                    {
                        Console.Write("Sorry but your ticket number is not lucky. \n");
                    }

                }
                if (a.Length == 6)
                {
                    int l = Convert.ToInt32(a);
                    int l1 = ((l / 100000) % 10);
                    int l2 = ((l / 10000) % 10);
                    int l3 = ((l / 1000) % 10);
                    int l4 = ((l / 100) % 10);
                    int l5 = ((l / 10) % 10);
                    int l6 = ((l / 1) % 10);
                    if (l1 + l2 + l3 == l4 + l5 + l6)
                    {
                        Console.Write("You have lucky ticket number! \n");
                    }
                    else
                    {
                        Console.Write("Sorry but your ticket number is not lucky. \n");
                    }

                }
                if (a.Length == 8)
                {
                    int l = Convert.ToInt32(a);
                    int l1 = ((l / 10000000) % 10);
                    int l2 = ((l / 1000000) % 10);
                    int l3 = ((l / 100000) % 10);
                    int l4 = ((l / 10000) % 10);
                    int l5 = ((l / 1000) % 10);
                    int l6 = ((l / 100) % 10);
                    int l7 = ((l / 10) % 10);
                    int l8 = ((l / 1) % 10);
                    if (l1 + l2 + l3 + l4 == l5 + l6 + l7 + l8)
                    {
                        Console.Write("You have lucky ticket number! \n");
                    }
                    else
                    {
                        Console.Write("Sorry but your ticket number is not lucky. \n");
                    }

                }
            }
        }
    }
}
