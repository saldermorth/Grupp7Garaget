using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Utilitys
{
    class InputService : IInput
    {
        public int GetInt() //No in paramater
        {
            int integer;
            while (!int.TryParse(Console.ReadLine(), out integer))
            {
                Console.WriteLine("Input of type integer needed");
                Console.Write("Try Again : ");
            }
            return integer;
        }

        public string GetString()
        {
            string str = Console.ReadLine();
            while (str.Any(char.IsDigit)  || string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Input of type string needed");
                Console.Write("Try Again : ");
            }
            return str;
        }
    }
}
