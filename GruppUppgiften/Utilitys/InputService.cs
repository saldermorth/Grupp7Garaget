using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Utilitys
{
    class InputService : IInput
    {
        int num = 100;
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

        public string GetRndRegNr()
        {

            int oneNum = 65; // A                
            int twoNum = 90; // Z
            string regNr = "";
            Random rnd = new Random();
            regNr = "";
            for (int i = 0; i < 3; i++)
            {
                char temp = Convert.ToChar(rnd.Next(oneNum, twoNum));
                regNr += temp;
            }
            regNr += num.ToString();
            num++;
            
            return regNr;
        }

        public string GetString()
        {
            string str = Console.ReadLine();
            while (str.Any(char.IsDigit) || string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Input of type string needed");
                Console.Write("Try Again : ");
            }
            return str;
        }

    }
}
