
using System.Runtime.InteropServices;


namespace Ex1Nikita
{
    public class ConsoleLogic
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern bool FreeConsole();

    }
}
