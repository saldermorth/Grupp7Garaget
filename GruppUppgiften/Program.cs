using GruppUppgiften.Utilitys;
using System;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            InputService regTest = new InputService();
            MainMenu run = new MainMenu();
            run.Meny();
            //run.RollCredits();
            
            //for (int i = 0; i < 100; i++)
            //{
            //    string str = regTest.GetRndRegNr();
            //    Console.WriteLine(str);
            //}
            
        }
    }
}
