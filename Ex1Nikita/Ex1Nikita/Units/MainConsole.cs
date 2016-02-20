using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Ex1Nikita
{
    public class MainConsole: ConsoleLogic
    {
        public void openExersize(int ex)
        {
            nameOnScreen();
        }

        public void nameOnScreen()
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("Tsyhankov Nikita Dmitriyevich");
            Console.WriteLine("+-------------------------------+");
        }
    }
}
