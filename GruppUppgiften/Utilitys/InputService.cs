using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Utilitys
{
    class InputService : IInput
    {
        private int idCounter = 0;
        public int GetInt() //No in paramater
        {
            int integer;
            while (!int.TryParse(Console.ReadLine(), out integer))
            {
                Console.WriteLine("Input of type integer needed!");
                Console.Write("Try Again : ");
            }
            return integer;

        }

        public int GetRandomNumber(int min, int max)
        {
            Random rnd = new();
            int randomNr = rnd.Next(min, max);
            return randomNr;
        }

        public string GetRndRegNr()
        {

            int oneNum = 65; // A                
            int twoNum = 90; // Z
            string regNr = $"{++idCounter} ";
            Random rnd = new();

            for (int i = 0; i < 3; i++)
            {
                char temp = Convert.ToChar(rnd.Next(oneNum, twoNum));
                regNr += temp;
            }
            regNr += rnd.Next(100, 999);


            return regNr;
        }

        public string GetString()
        {
            string str = Console.ReadLine();
            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("The field can't be empty.");
                Console.Write("Try Again : ");
                str = Console.ReadLine();
            }
            return str;
        }

        public bool GetTrueOrFalse()
        {
            string str = Console.ReadLine().ToLower();
            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("The field can't be empty.");
                Console.Write("Try Again : ");
                str = Console.ReadLine();
            }
            if (str.Equals("yes"))
            {
                return true;
            }

            return false;
        }
    }
}
