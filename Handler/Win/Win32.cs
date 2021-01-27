using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

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

        public static void Directory()
        {
            listFilesInDirectory(@"C:\Visual Studio Projects\Slurp Juice\Lua");
        }

        public static void listFilesInDirectory(string WorkingDirectory)
        {
            string[] filePaths = System.IO.Directory.GetFiles(WorkingDirectory);

            foreach (string filePath in filePaths)
            {
                Slurp form = new Slurp();
            }
        }

        public static void Directory2()
        {
            listFilesInDirectory(@"C:\Visual Studio Projects\Slurp Juice\Lua");
        }

        public static void listFilesInDirectory2(string WorkingDirectory)
        {
            string[] filePaths = System.IO.Directory.GetFiles(WorkingDirectory);

            foreach (string filePath in filePaths)
            {
                Console.WriteLine(filePaths);
            }
        }

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

        public static void hide()
        {
             Console.WriteLine("The console cannot be hidden yet");
        }

        }
    }
}
