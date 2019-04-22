using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

                Console.WriteLine("Enter Width");
                decimal Width = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height");
                decimal Height = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Length");
                decimal Length = Decimal.Parse(Console.ReadLine());

                decimal Area = Width * Length;
                Console.WriteLine("Area: " + Area);

                decimal Perimeter = 2 * Width + 2 * Length;
                Console.WriteLine("Perimeter: " + Perimeter);

                decimal Volume = Width * Length * Height;
                Console.WriteLine("Volume: " + Volume);

                Console.WriteLine("Would you like to continue?");
                string Answer = Console.ReadLine();

                if (Answer == "Yes" || Answer == "yes" || Answer == "y" || Answer == "Y")
                {


                }
                else
                {
                    break;
                }
            
            }
            
              
        }
    }
}
