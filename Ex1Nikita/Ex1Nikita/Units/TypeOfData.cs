using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
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
        }

        private void MewOrRaw()
        {
            Console.Clear();
            Console.WriteLine("Mew or Raw?");
            string voice = Console.ReadLine();
            if (voice == "Mew" || voice == "mew") Console.WriteLine("Feed the cat");
            else Console.WriteLine("Walk the dog");
        }

        public void Month()
        {
            Console.Clear();
            Console.WriteLine("Enter number of mounth:");
            Console.Write("==>");
            int mounth = Convert.ToInt16(Console.ReadLine());
            if (mounth > 2 && mounth < 6) Console.WriteLine("Spring");
            if (mounth > 5 && mounth < 9) Console.WriteLine("Summer");
            if (mounth > 8 && mounth < 12) Console.WriteLine("Autumn");
            else Console.WriteLine("Winter");
        }
        #endregion
    }
}
