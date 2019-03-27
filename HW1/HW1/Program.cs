using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        public string MaxNumber(int[] n)
        {
            string max;
            int M = 0;

            for (int x = 0; x < 10; x++)
            {
                if (n[x] > M)
                {
                    M = n[x];
                }
            }

            max = Convert.ToString(M);

            return max;
        }

        public string Datatime()
        {
            DateTime Time = DateTime.Now;
            string date = Time.ToString();

            return date;
        }

        static void Main(string[] args)
        {
            Program myprogram = new Program();
            int[] n = new int[10];

            int R = 0;
            while (R != (-1))
            {
                Console.WriteLine("Menu :\n 1-Maximum of Numbers \n 2-Date and Time \n 0-EXIT\n\n Please enter the number : ");
                string NMenu = (Console.ReadLine());

                Console.Clear();


                if (NMenu == "1")
                {
                    Console.WriteLine("\nInter The  ten Numbers :");

                    for (int x = 0; x < 10; x++)
                    {
                        n[x] = Int32.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("\n\nMaximum of numbers is : {0}", myprogram.MaxNumber(n));
                    Console.ReadKey();
                }

                if (NMenu == "2")
                {
                    Console.WriteLine(myprogram.Datatime());
                    Console.ReadKey();
                }

                if (NMenu == "0")
                {
                    Environment.Exit(0);
                }

                if (NMenu != "1" && NMenu != "2" && NMenu != "0")
                {
                    Console.WriteLine("ERROR!\a");
                    Console.ReadKey();
                }

                Console.Clear();
            }

        }

    }
}
