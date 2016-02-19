using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Nikita
{
    class Invoker
    {
        public List<string[]> unitsList = new List<string[]>();
        string[] unit1 = { "1. Name on Screen" };
        string[] unit2 = { "1. Larger of two", "2. \"Mew or Raf\"", " " };
        string[] unit3 = { };

        public Invoker()
        {
            unitsList.Add(unit1);
            unitsList.Add(unit2);
            unitsList.Add(unit3);
        }
    }
}
