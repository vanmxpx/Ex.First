using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1Nikita.Units
{
    public class TypeOfData
    {
        public void openExersize(int ex)
        {
            switch (ex)
            {
                case 0:
                    LargerOfTwo();
                    break;
                case 1:
                    MewOrRaw();
                    break;
                case 2:
                    Month();
                    break;
                case 3:
                    OneOrZero();
                    break;
                case 4:
                    DayOfWeek();
                    break;
                case 5:
                    Taxi();
                    break;
                case 6:
                    APrimeNumber();
                    break;
                case 7:
                    Lottery();
                    break;
                default:
                    CurrencyConverter();
                    break;
            }
        }

        #region Unit's methods
        private void LargerOfTwo()
        {
            Console.Clear();

            Console.WriteLine("Enter first number:");
            Console.Write("==> ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter secound number:");
            Console.Write("==> ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Maximum {0}", ( a > b ) ? a : b);

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void MewOrRaw()
        {
            Console.Clear();

            Console.WriteLine("Mew or Raw?");
            string voice = Console.ReadLine();
            if (voice == "Mew" || voice == "mew") Console.WriteLine("Feed the cat");
            else Console.WriteLine("Walk the dog");

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void Month()
        {
            Console.Clear();

            Console.WriteLine("Enter number of month:");
            Console.Write("==>");
            int mounth = Convert.ToInt16(Console.ReadLine());
            if (mounth > 2 && mounth < 6) Console.WriteLine("Spring");
            else if (mounth > 5 && mounth < 9) Console.WriteLine("Summer");
            else if (mounth > 8 && mounth < 12) Console.WriteLine("Autumn");
            else Console.WriteLine("Winter");

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        public void OneOrZero()
        {
            Console.Clear();

            Console.WriteLine("Write 1 or 0:");
            Console.Write("==>");
            int number = Console.Read();
            Console.WriteLine("{0}", (1 == number) ? "Good" : "Bad");

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void DayOfWeek()
        {
            Console.Clear();

            Console.WriteLine("Enter number of week");
            Console.Write("==>");
            int day = Convert.ToInt16(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Thuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Saturday");
                    break;
            }

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void Taxi()
        {
            Console.Clear();

            Console.WriteLine("How many km gone?");
            Console.Write("==> ");
            int km = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("How many minutes lost?");
            Console.Write("==> ");
            int min = Convert.ToInt16(Console.ReadLine());
            int cost = 0;
            for (int i = 0; i <= km; i++)
            {
                if (i <= 5) cost = 20;
                else cost += 3;
            }
            cost += min;
            Console.WriteLine("The final price: \n {0} grn", cost);

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void APrimeNumber()
        {
            Console.Clear();

            Console.WriteLine("Enter a number");
            Console.Write("==> ");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num > 0 && num < 4) Console.WriteLine("This is a prime number");
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("This is not a prime number");
                        break;
                    }
                    if (i == num / 2) Console.WriteLine("This is a prime number");
                }
            }

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void Lottery()
        {
            Console.Clear();

            Console.WriteLine("*---Lottery---*");
            Console.WriteLine("Enter your beat:");
            Console.Write("==> ");
            int beat = Convert.ToInt16(Console.ReadLine());

            Random rnd = new Random();
            int dice = rnd.Next(1, 12);
            Console.WriteLine("The number on the dice is {0}", dice);
            if (dice > 0 && dice < 6) Console.WriteLine("You lost");
            else if (dice > 5 && dice < 9)
            {
                Console.WriteLine("You do not win anything");
                Console.WriteLine("Final win: {0}", beat);
            }
            else if (dice > 8 && dice < 12)
            {
                Console.WriteLine("Your beat is doubled");
                Console.WriteLine("Final win: {0}", beat * 2);
            }
            else
            {
                Console.WriteLine("Your win! Beat x10");
                Console.WriteLine("Final win: {0}", beat * 10);
            }

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }

        private void CurrencyConverter()
        {
            Console.Clear();

            Console.WriteLine("Enter your sum:");
            Console.Write("==> ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Press '1' if it is UAN\n '2' if it is USD\n '3' if it is EUR");
            if(Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine("to USD: {0}", sum / 27);
                Console.WriteLine("to EUR: {0}", sum / 30);
            }
            else if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                Console.WriteLine("to UAN: {0}", sum * 27);
                Console.WriteLine("to EUR: {0}", sum * 0.87);
            }
            else
            {
                Console.WriteLine("to USD: {0}", sum * 1.07);
                Console.WriteLine("to UAN: {0}", sum * 30);
            }

            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }
        #endregion
    }
}
