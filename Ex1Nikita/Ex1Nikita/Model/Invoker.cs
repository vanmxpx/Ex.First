using Ex1Nikita.Units;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Ex1Nikita
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
            unitsList.Add(category1);
            unitsList.Add(category2);
            unitsList.Add(category3);
        }

        public void OpenExersize (int un, int ex)
        {
            if (-1 == un) MessageBox.Show("Choose an unit", "Oops!", MessageBoxButtons.OK);
            else CheckUnit(un, ex);
        }

        public void CheckUnit (int un, int ex)
        {
            Console.Clear();
            switch (un)
            {
                case 0:
                    Unit1.openExersize(ex);
                    break;
                case 1:
                    Unit2.openExersize(ex);
                    break;
                default:
                    Unit3.openExersize(ex);
                    break;
            }
            Console.WriteLine("*----------------------*");
            Console.WriteLine("Choose another exersize");
        }
    }
}
