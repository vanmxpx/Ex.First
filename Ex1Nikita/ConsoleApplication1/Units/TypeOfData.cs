using System;

namespace ConsoleModel
{
    public class TypeOfData
    {
        public void openExersize(int ex)
        {
            switch (ex)
            {
                case 1:
                    LargerOfTwo();
                    break;
                case 2:
                    MewOrRaw();
                    break;
                case 3:
                    Month();
                    break;
                case 4:
                    OneOrZero();
                    break;
                case 5:
                    DayOfWeek();
                    break;
                case 6:
                    Taxi();
                    break;
                case 7:
                    APrimeNumber();
                    break;
                case 8:
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
            Console.WriteLine("Enter first number:");
            Console.Write("==> ");
            int a = 0;
            int b = 0;
            if (!Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Wrong! Try another");
                LargerOfTwo();
            }
            else {
                Console.WriteLine("Enter secound number:");
                Console.Write("==> ");
                if (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Wrong! Try another");
                    LargerOfTwo();
                }
                else Console.WriteLine("Maximum {0}", (a > b) ? a : b);
            }
        }

        private void MewOrRaw()
        {
            Console.WriteLine("Mew or Raw?");
            string voice = Console.ReadLine();
            if (voice == "Mew" || voice == "mew") Console.WriteLine("Feed the cat");
            else if (voice == "Raw" || voice == "raw") Console.WriteLine("Walk the dog");
            else
            {
                Console.WriteLine("Wrong! Try another");
                MewOrRaw();
            }
        }

        private void Month()
        {
            Console.WriteLine("Enter number of month:");
            Console.Write("==>");
            int month=0;
            if (!Int32.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Wrong! Try another");
                Month();
            }
            else
            {
                if (month > 2 && month < 6) Console.WriteLine("Spring");
                else if (month > 5 && month < 9) Console.WriteLine("Summer");
                else if (month > 8 && month < 12) Console.WriteLine("Autumn");
                else Console.WriteLine("Winter");
            }
        }

        public void OneOrZero()
        {
            Console.WriteLine("Write 1 or 0:");
            Console.Write("==>");
            int number = 0;
            if (!Int32.TryParse(Console.ReadLine(), out number) || number > 1 || number < 0)
            {
                Console.WriteLine("Wrong! Try another");
                OneOrZero();
            }
            else  Console.WriteLine("{0}", (1 == number) ? "Good" : "Bad");
        }

        private void DayOfWeek()
        {
            Console.WriteLine("Enter number of week");
            Console.Write("==>");
            int day = 0;
            if (!Int32.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Wrong! Try another");
                DayOfWeek();
            }
            else
            {
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
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                }
            }
        }

        private void Taxi()
        {
            Console.WriteLine("How many km gone?");
            Console.Write("==> ");
            int km = 0;
            int min = 0;
            if (!Int32.TryParse(Console.ReadLine(), out km))
            {
                Console.WriteLine("Wrong! Try another");
                Taxi();
            }
            else
            {
                Console.WriteLine("How many minutes lost?");
                Console.Write("==> ");
                if (!Int32.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("Wrong! Try another");
                    Taxi();
                }
                else
                {
                    int cost = 0;
                    for (int i = 0; i <= km; i++)
                    {
                        if (i <= 5) cost = 20;
                        else cost += 3;
                    }
                    cost += min;
                    Console.WriteLine("The final price: \n {0} grn", cost);
                }
            }
        }

        private void APrimeNumber()
        {
            Console.WriteLine("Enter a number");
            Console.Write("==> ");
            int num = 0;
            if (!Int32.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Wrong! Try another");
                APrimeNumber();
            }
            else
            {
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
            }
        }

        private void Lottery()
        {
            Console.WriteLine("*---Lottery---*");
            Console.WriteLine("Enter your beat:");
            Console.Write("==> ");
            int beat = 0;
            if (!Int32.TryParse(Console.ReadLine(), out beat) || beat < 0)
            {
                Console.WriteLine("Wrong! Try another");
                Lottery();
            }
            else
            {
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
            }
        }

        private void CurrencyConverter()
        {
            Console.WriteLine("Enter your sum:");
            Console.Write("==> ");
            double sum = 0;
            if (!Double.TryParse(Console.ReadLine(), out sum) || sum < 0)
            {
                Console.WriteLine("Wrong! Try another");
                CurrencyConverter();
            }
            else
            {
                Console.WriteLine("Press '1' if it is UAN\n   '2' if it is USD\n   '3' if it is EUR");
                if (Console.ReadKey().Key == ConsoleKey.D1)
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
            }
        }
        #endregion
    }
}
