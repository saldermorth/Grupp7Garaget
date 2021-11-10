using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    public class Credits
    {
        public void CreditsLoop()
        {
            //for (int i = 0; i < 3960; i++)
                for (int i = 0; i < 6355; i++)
                {
                    randChar();
                }
            NameWriter();
        }
        public void NameWriter()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            string[] theTeam = { "Anton Edholm", "Emre Ersoylu", "Gustav Berg", "Heja Leven Darwich", "Ronny Fagerlund", "Simon Hjulström" };
            
            Console.SetCursorPosition(65,2);
            Console.Write("_______/THE TEAM\\_______");
            int posY = 4;
            for (int i = 0; i < theTeam.Length; i++)
            {
                Console.SetCursorPosition(70, posY);
                Console.Write("█ ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(theTeam[i]);
               Console.BackgroundColor = ConsoleColor.White;
               Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" █");
                posY += 3;
                Thread.Sleep(1000);
                }
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Environment.Exit(-1);
        }
        public void randChar()
        {           
            Random rnd2 = new Random();
            int randChar = rnd2.Next(1, 5);
            char k = ' ';

            switch (randChar)
            {
                case 1:
                    k = '¥';
                    break;
                case 2:
                    k = 'Œ';
                    break;
                case 3:
                    k = 'Ŧ';
                    break;
                case 4:
                    k = 'Ƣ';
                    break;
                default:
                    k = ' ';
                    break;
            }

            rgbPrint(k);
            

        }
        public void rgbPrint(char c)
        {
            Random rnd = new Random();            
            Console.BackgroundColor = ConsoleColor.White;

            int randInt = rnd.Next(1, 9);
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

