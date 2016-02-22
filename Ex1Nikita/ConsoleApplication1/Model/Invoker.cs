
using System.Collections.Generic;
using System;

namespace ConsoleModel
{
    public class Invoker
    {
        /// <summary>
        /// Класс для исполненительных методов
        /// </summary>

        #region Units
        MainConsole Unit1 = new MainConsole();
        TypeOfData Unit2 = new TypeOfData();
        Cycles Unit3 = new Cycles();

        public List<string[]> unitsList = new List<string[]>();
        string[] units = { "1. Console application",
            "2. Types of data",
            "3. Cycles" };

        internal void CheckSym(int v, string unit)
        {
            throw new NotImplementedException();
        }

        string[] category1 = { "1. Name on Screen" };
        string[] category2 = { "1. Larger of two",
            "2. \"Mew or Raf\"",
            "3. Month",
            "4. 1 or 0",
            "5. Day of week",
            "6. Taxi",
            "7. A prime number",
            "8. Lottery",
            "9. Currency converter" };
        string[] category3 = {"1. Multiplication table",
            "2. Digit",
            "3. Guess",
            "4. Cubes",
            "5. Average from console",
            "6. Average random",
            "7. Paws",
            "8. Password" };
        #endregion


        public Invoker()
        {
            unitsList.Add(units);
            unitsList.Add(category1);
            unitsList.Add(category2);
            unitsList.Add(category3);
        }


        public int ViewList(int num)
        {
            Console.WriteLine("-----*Choose an category*-----");
            Console.WriteLine("\tpress number");
            for (int i = 0; i < unitsList[num].Length; i++)
            {
                Console.WriteLine(unitsList[num][i]);
            }
            Console.Write("   ==> ");
            string let = Console.ReadLine();
            int ex;
            if(Int32.TryParse(let, out ex))
            {
                if (ex > 0 && ex <= unitsList[num].Length)
                {
                    return ex;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not match. Choose another");
                    OpenUnit();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Not match. Choose another");
                OpenUnit();
            }
            return 0;
        } 
        public void OpenUnit ()
        {
            int tmpUn = 0, tmpEx = 0;
            tmpUn = ViewList(0);
            if (tmpUn != 0) tmpEx = ViewList(tmpUn);
            if (tmpEx != 0) OpenExersize(tmpUn, tmpEx);
        }
        
        public void OpenExersize (int un, int ex)
        {
            Console.Clear();
            switch (un)
            {
                case 1:
                    Unit1.openExersize(ex);
                    break;
                case 2:
                    Unit2.openExersize(ex);
                    break;
                default:
                    Unit3.openExersize(ex);
                    break;
            }
            Console.WriteLine("*----------------------*");
            Console.WriteLine("If you want to retry press Enter");
            Console.WriteLine("If you want to chose another exersize press any button");
            if (Console.ReadKey().Key == ConsoleKey.Enter) OpenExersize(un, ex);
            else
            {
                Console.Clear();
                OpenUnit();
            }
        }
    }
}
