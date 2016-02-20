using System;

namespace Ex1Nikita
{
    public class MainConsole: Invoker.IOpenExersize
    {
        public void openExersize(int ex)
        {
            nameOnScreen();
        }

        void nameOnScreen()
        {
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("Tsyhankov Nikita Dmitriyevich");
            Console.WriteLine("+-------------------------------+");
            Console.Read();
        }
    }
}
