﻿using System;

namespace Ex1Nikita.Units
{ 
    class Cycles
    {
        public void openExersize(int ex)
        {
            switch (ex)
            {
                case 0:
                    MultiplicationTable();
                    break;
                case 1:
                    Digit();
                    break;
                case 2:
                    Guess();
                    break;
                case 3:
                    Cubes();
                    break;
                case 4:
                    AverageFromConsole();
                    break;
                case 5:
                    AverageRandom();
                    break;
                case 6:
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
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Multiplication table on {0}:", num);
            for(int i = 1; i < 21; i++)
            {
                Console.WriteLine("==> {0}*{1}={2}", num, i, num*i);
            }
        }

        private void Digit()
        {
            Console.WriteLine("Enter a number:");
            Console.Write("==> ");
            int num = Convert.ToInt16(Console.ReadLine());
            int dig = 1;

            while (num > 10)
            {
                num /= 10;
                dig++;
            }
            Console.WriteLine("Digit is {0}", dig);
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
                int userNum = Convert.ToInt16(Console.ReadLine());
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

        private void Cubes()
        {
            Console.WriteLine("Enter a number:");
            Console.WriteLine("==> ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Cubes of numbers until {0}:", num);
            for(int i = 1; i*i < num; i++)
            {
                if( (i+1)*(i+1) >= num) Console.WriteLine("{0}.", i * i);
                else Console.Write("{0}, ", i * i);
            }
        }

        private void AverageFromConsole()
        {
            Console.WriteLine("Enter 5 numbers by space:");
            Console.Write("==> ");
            string[] array = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt16(array[i]);
            }
            Console.WriteLine("The arithmetic mean of these numbers: {0}", sum /= 5);
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

    
