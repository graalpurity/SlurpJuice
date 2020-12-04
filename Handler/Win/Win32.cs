using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Slurp_Juice.Handler
{
    public static class Win32
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

      

        public static class ConsoleH
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AllocConsole();

        public static void Welcome()
        {
            Console.Title = $"Slurp Juice {Slurp.Version} Debug Console";
            Console.WriteLine($"Welcome to Slurp Juice {Slurp.Version}");
        }

        public static void Attached()
        {
            Console.WriteLine("API Attached");
        }

        public static void Executed()
        {
            Console.WriteLine("API Executed");
        }

        public static void test()
        {

        }
        }
       
    }
}
