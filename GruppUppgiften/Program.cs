using GruppUppgiften.Utilitys;
using System;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            InputService regTest = new InputService();
            Menu run = new Menu();
            //run.Meny();
            //run.RollCredits();
            
            for (int i = 0; i < 10; i++)
            {
              regTest.GetRndRegNr();
            }
            
        }
    }
}
