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
            OutputService run = new OutputService();
            run.PrintInfoOfAllVehicles();
            //InputService regTest = new InputService();
            //MainMenu run = new MainMenu();
            //run.Meny();
            //run.RollCredits();
            
            //for (int i = 0; i < 100; i++)
            //{
            //    string str = regTest.GetRndRegNr();
            //    Console.WriteLine(str);
            //}
            
        }
    }
}
