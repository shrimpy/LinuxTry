using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTry
{
    class Program
    {
        static void Main(string[] args)
        {

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            switch (pid)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    Console.WriteLine("Windows");
                    break;
                case PlatformID.Unix:
                    Console.WriteLine("Unix");
                    break;
                default:
                    Console.WriteLine("Others");
                    break;
            }

            Console.WriteLine(Environment.SpecialFolder.ProgramFilesX86 + " " + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine(Environment.GetEnvironmentVariable("HOME"));
            Console.WriteLine("Run on linux");
        }
    }
}
