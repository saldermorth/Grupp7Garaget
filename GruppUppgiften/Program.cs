using GruppUppgiften.Service;
using GruppUppgiften;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using static System.Console;
using GruppUppgiften.UI;
using GruppUppgiften.Data;
using System.IO;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            string CreatPath = null;
#pragma warning disable CA1416 // Validate platform compatibility
            SetBufferSize(155, 40); // To remove the warning msg
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            SetWindowSize(155, 40); // To remove the warning msg
#pragma warning restore CA1416 // Validate platform compatibility

            CreatPath = AppDomain.CurrentDomain.BaseDirectory + @"GustavsNyaFil.json";
            if (!File.Exists(CreatPath))
            {
                File.Create(CreatPath);

            }
            
            Run();

            

        }
        public static void Run()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Gray;
            Menu main = new();
            main.MainMenu();
        }
    }
}
