using System;

namespace ConsoleModel
{ 
    class Cycles
    {
        public void openExersize(int ex)
        {
            switch (ex)
            {
                case 1:
                    MultiplicationTable();
                    break;
                case 2:
                    Digit();
                    break;
                case 3:
                    Guess();
                    break;
                case 4:
                    Cubes();
                    break;
                case 5:
                    AverageFromConsole();
                    break;
                case 6:
                    AverageRandom();
                    break;
                case 7:
                    Paws();
                    break;
                default:
                    Password();
                    break;
            }
        }

        #region Unit's methods
        private void MultiplicationTable()
        {
            Console.WriteLine("Enter your number:");
            Console.Write("==> ");
            int num = 0;
            if (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Wrong! Try another");
                MultiplicationTable();
            }
            else
            {
                Console.WriteLine("Multiplication table on {0}:", num);
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine("==> {0}*{1}={2}", num, i, num * i);
                }
            }
        }

        private void Digit()
        {
            Console.WriteLine("Enter a number:");
            Console.Write("==> ");
            long num = 0;
            if (!Int64.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Wrong! Try another");
                Digit();
            }
            else
            {
                int dig = 1;

                while (num > 10)
                {
                    num /= 10;
                    dig++;
                }
                Console.WriteLine("Digit is {0}", dig);
            }
        }

        private void Guess()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 146);
            bool answer = false;
            Console.WriteLine("I have conceived a number from 1 to 146\n What is it?");
            while (!answer)
            {
                Console.Write("==> ");
                int userNum = 0;
                if (!Int32.TryParse(Console.ReadLine(), out userNum))
                {
                    Console.WriteLine("Not a number, again");
                }
                else
                {
                    if (num > userNum)
                    {
                        Console.WriteLine("More");
                        Console.WriteLine("Try one more:");
                    }
                    else if (num < userNum)
                    {
                        Console.WriteLine("Less");
                        Console.WriteLine("Try one more:");
                    }
                    else
                    {
                        Console.WriteLine("Yes, it is {0}!", userNum);
                        answer = true;
                    }
                }
            }
        }

        private void Cubes()
        {
            Console.WriteLine("Enter a number for cubes:");
            Console.WriteLine("==> ");
            int num = 0;
            if (!Int32.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Wrong! Try another");
                Cubes();
            }
            else
            {
                Console.WriteLine("Cubes of numbers until {0}:", num);
                for (int i = 1; i * i < num; i++)
                {
                    if ((i + 1) * (i + 1) >= num) Console.WriteLine("{0}.", i * i);
                    else Console.Write("{0}, ", i * i);
                }
            }
        }

        private void AverageFromConsole()
        {
            Console.WriteLine("Enter 5 numbers by space:");
            Console.Write("==> ");
            string[] array = Console.ReadLine().Split(' ');
            int sum = 0;
            int num = 0;
            bool check = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (!Int32.TryParse(array[i], out num))
                {
                    check = false;
                }
                else sum += num;
            }
            if(check) Console.WriteLine("The arithmetic mean of these numbers: {0}", sum /= 5);
            else
            {
                Console.WriteLine("Wrong input, not numbers. Try again");
                AverageFromConsole();
            }
        }

        private void AverageRandom()
        {
            Random rnd = new Random();
            Console.WriteLine("I have conceived a 5 numbers from 1 to 200");
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sum += rnd.Next(1, 200));
            }
            Console.WriteLine("The arithmetic mean of these numbers: {0}", sum /= 5);
        }

        private void Paws()
        {
            Console.WriteLine("So, we have 64 paws\n it can be:");
            for (int gooses = 0, rabbits = 16; rabbits >= 0; rabbits--)
            {
                Console.WriteLine("{0} rabbits and {1} gooses", rabbits, gooses);
                gooses += 2;
            }
        }

        private void Password()
        {
            Console.WriteLine("Stop!\nEnter the password:");
            bool pass = false;
            while (!pass)
            {
                Console.Write("==> ");
                if(Console.ReadLine() == "root")
                {
                    Console.WriteLine("Correct. You passed.");
                    pass = true;
                }
                else
                {
                    Console.WriteLine("Incorect password, try again.");
                }
            }
        }


        #endregion
    }

}

    
