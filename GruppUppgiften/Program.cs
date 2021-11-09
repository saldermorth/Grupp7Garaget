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
            Menu main = new Menu();
            main.MainMenu();
        }
    }
}
