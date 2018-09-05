using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What countrycode should i look up? You can try with dk - Type exit to exit..");
                string cc = Console.ReadLine().ToLower();
                if (cc == "exit")
                {
                    break;
                }

                string country;
                switch (cc)
                {
                    case "dk":
                        country = "Denmark";
                        break;
                    case "se":
                        country = "Sweden";
                        break;
                    case "no":
                        country = "Norway";
                        break;
                    default:
                        country = "unknown";
                        break;
                }
                Console.WriteLine("Country code " + cc + " is " + country);
            }

        }
    }
}
