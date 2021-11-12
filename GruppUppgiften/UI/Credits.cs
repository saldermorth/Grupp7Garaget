using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    class Credits 
    {
        private readonly InputService input = new();
        public void CreditsLoop()
        {
            //for (int i = 0; i < 3960; i++)
            for (int i = 0; i < 6355; i++)
            {
                RandChar();
            }
            NameWriter();
        }
        public static void NameWriter()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            string[] theTeam = { "Anton Edholm", "Emre Ersoylu", "Gustav Berg", "Heja Leven Darwich", "Ronny Fagerlund", "Simon Hjulström" };

            Console.SetCursorPosition(65, 2);
            Console.Write("_______/THE TEAM\\_______");
            int posY = 4;
            for (int i = 0; i < theTeam.Length; i++)
            {
                Console.SetCursorPosition(70, posY);
                Console.Write("██ ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(theTeam[i]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" ██");
                posY += 3;
                Thread.Sleep(1000);
            }
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Environment.Exit(-1);
        }
        public void RandChar()
        {

            int randChar = input.GetRandomNumber(1, 5);
            var k = randChar switch
            {
                1 => '¥',
                2 => 'Œ',
                3 => 'Ŧ',
                4 => 'Ƣ',
                _ => ' ',
            };
            RgbPrint(k);
        }
        public void RgbPrint(char c)
        {
            Console.BackgroundColor = ConsoleColor.White;

            int randInt = input.GetRandomNumber(1, 9);
            
            double randInt2 = 3.14 * randInt;

            if (randInt2 < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (randInt2 < 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (randInt2 < 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (randInt2 < 45)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.Write(c);

        }
    }
}

