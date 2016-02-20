using Ex1Nikita.Units;
using System.Collections.Generic;
using System.Windows.Forms;

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
        string[] category3 = {"1. ",
            "2. ",
            "3. ",
            "4. ",
            "5. ",
            "6. ",
            "7. ",
            "8. " };
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
            else checkUnit(un, ex);
        }

        public void checkUnit (int un, int ex)
        {
            switch (un)
            {
                case 0:
                    Unit1.openExersize(ex);
                    break;
                case 1:
                    Unit2.openExersize(ex);
                    break;
                default:
                    //Unit3.openExersize(ex);
                    break;
            }
        }
    }
}
