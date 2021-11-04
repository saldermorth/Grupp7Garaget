using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    public class Menu
    {
        //Mainmenu Knappen skriv ut som title. Fast större kanske. Print with borderMenu title nu metod. 
        public void PrintWithBorders(string k)//Grafisk utskrift. Tar emot ord eller korta meningar. Omringar ordet med en ram och skriver ut. Nollställer foreground färgen i slutet.
        {

            Console.Write($"{ "",40}{"╔"}");
            for (int i = 0; i < 36; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗ \n");

            //Console.WriteLine($"{"║",-26} {"║"}");  // Use incase the box needs to be higher.
            Console.WriteLine($"{"",40}{"║",-10} {k,-26 }{"║"}");
            //Console.WriteLine($"{"║",-26} {"║"}");

            Console.Write($"{"",40}{"╚"}");
            for (int i = 0; i < 36; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝ \n");
            Console.ResetColor();

        }
        public void Meny()
        {   //Counter that starts att oone and removes on if up arrow is pressed 
            //and  adds one if down arrow is pressed
           
            string[] menuItems = { "Search Vehicle", "List All Vehicle", "Park", "Exit" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up wen run. Default.
            Console.Clear();
            PrintWithBorders("Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);


            while (enterPressed == false)
            {
                keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (counter > 1)
                    {
                        counter--;
                    }
                    else
                    {
                        counter = 4;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 4)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                }

                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Exit");
                    //activate choice                   
                    switch (counter) // Här aktiveras valet.
                    {
                        case 1:
                            Console.WriteLine($"Menu {counter} selected");
                            break;
                        case 2:
                            Console.WriteLine($"Menu {counter} selected");
                            break;
                        case 3:
                            Console.WriteLine($"Menu {counter} selected");
                            break;
                        case 4:
                            Console.WriteLine($"Menu {counter} selected");
                            break;
                        
                    }
                    counter = 5; // Måste matcha slutvalet.
                }

                if (counter == 1)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[1]);                    
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 2)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");                    
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 4)
                {                    
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);                    
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;                    
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (counter == 5)
                {
                    enterPressed = true;
                }
            }
        }

        public void RollCredits()
        {
            Credits run = new Credits();
            run.CreditsLoop();
            Console.ReadLine();
        }

    }
}
