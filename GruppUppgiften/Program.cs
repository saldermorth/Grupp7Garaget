using GruppUppgiften.Service;
using GruppUppgiften;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using static System.Console;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            SetBufferSize(155, 40); // Ignores warning
#pragma warning restore CA1416 // Validate platform compatibility
#pragma warning disable CA1416 // Validate platform compatibility
            SetWindowSize(155, 40);// Ignores warning
#pragma warning restore CA1416 // Validate platform compatibility
            Menu main = new();
            main.MainMenu();
        }
    }
}
