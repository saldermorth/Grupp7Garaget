using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class SearchMenu
    {
        public void PrintWithBorders(string k)//Grafisk utskrift. Tar emot ord eller korta meningar. Omringar ordet med en ram och skriver ut. Nollställer foreground färgen i slutet.
        {

            Console.Write($"{ "",40}{"╔"}");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗ \n");

            //Console.WriteLine($"{"║",-26} {"║"}");  // Use incase the box needs to be higher.
            Console.WriteLine($"{"",40}{"║",-10} {k,-30 }{"║"}");
            //Console.WriteLine($"{"║",-26} {"║"}");

            Console.Write($"{"",40}{"╚"}");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝ \n");
            Console.ResetColor();

        }
        public void SearchMeny()
        {   //Counter that starts att one and removes one if up arrow is pressed 
            //and  adds one if down arrow is pressed

            string[] menuItems = { "Find By RegNr", "Find All By Color", "Find All By Number Of Wheels", "Find All By Number Of Seats", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            PrintWithBorders("Search Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);
            PrintWithBorders(menuItems[4]);

            Menu run = new Menu();

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
                        counter = 5;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 5)
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
                    switch (counter)
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
                        case 5:
                            Console.WriteLine($"Menu {counter} selected");
                            run.Meny();
                            break;
                    }
                    counter = 6;
                }

                if (counter == 1)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 2)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (counter == 6)
                {
                    enterPressed = true;
                }
            }
        }
    }
}

