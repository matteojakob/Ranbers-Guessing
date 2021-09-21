using Figgle;
using Pastel;
using System;
using System.Linq;
using System.Text;

namespace Ranbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // UNICODE CONVERT

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // DEKLARIERUNGEN

            int Ranber = new Random().Next(1, 101);
            int attempts = 10;
            bool Continue = true;
            Console.ForegroundColor = ConsoleColor.Cyan;



            // INTRO

            Console.WriteLine(
                FiggleFonts.Slant.Render("Ranbers Guessing"));

            var spectrum = new (string color, string letter)[]
            {
                 ("#124542", "W"),
                 ("#185C58", "E"),
                 ("#1E736E", "L"),
                 ("#248A84", "C"),
                 ("#20B2AA", "O"),
                 ("#3FBDB6", "M"),
                 ("#5EC8C2", "E"),

            };

            Console.WriteLine(string.Join("", spectrum.Select(s => s.letter.Pastel(s.color))));

            Console.WriteLine("You are playing ranbers! To get started read below.");
            Console.WriteLine("The Computer chooses a random number from 1 to 100 and you have to guess it!");
            Console.WriteLine("Each time you guess, you may get closer to the actual number!");
            Console.WriteLine("Don't worry, the computer will give you hints ;)\n");
            Console.WriteLine("Press ENTER to start! \n\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Slant.Render("And it begins"));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The Computer saved a random number...");


            // INTRO ENDE
            



            while (Continue == true)
            {
                try
                {

                Console.WriteLine("\n\n");
                Console.WriteLine("Guess the number:");
                int Input = Int32.Parse(Console.ReadLine());


                    if (Ranber < Input)
                    {
                        attempts = attempts - 1;
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(FiggleFonts.Shadow.Render("WRONG"));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Try it with a < smaller > number!");
                        Console.WriteLine("You have " + attempts + " Attempts left");

                        if (attempts == 0)
                        {
                            Console.WriteLine("Huch! You have 0 tries left!");
                            Continue = false;
                        }

                    }

                    if (Ranber > Input)
                    {
                        attempts = attempts - 1;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(FiggleFonts.Shadow.Render("WRONG"));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Try it with a < bigger > number!");
                        Console.WriteLine("You have " + attempts + " Attempts left");


                        if (attempts == 0)
                        {
                            Console.WriteLine("Huch! You have 0 tries left!");
                            Continue = false;
                        }
                    }

                    if (Ranber == Input)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(FiggleFonts.Epic.Render("\nGOOD JOB!"));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You guessed the correct number! It was: " + Ranber);
                        Console.WriteLine("You had < " + attempts + " > tries left!\n");
                        Continue = false;

                    }
                }
                catch { Console.WriteLine("Invalid Input. lol."); }
            }


            Console.WriteLine("\n\n\n");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("\n\n");

            // ASCII ART
            string Kawaii = @"
           |`-.._____..-'|
           :  > .  ,  <  :
           `./ __`' __ \,'
            | (|_) (|_) |
            ; _  .  __  :
            `.,' - `-. ,'
              `, `_  .'
              /       \
             /         :
            :          |_
           ,|  .    .  | \
          : :   \   |  |  :
          |  \   :`-;  ;  |
          :   :  | /  /   ;
           :-.'  ;'  / _,'`------.
           `'`''-`'''-'-''--.---  )
                            `----'
            ";

            Console.WriteLine(Kawaii);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(FiggleFonts.Standard.Render("Hasta la vista"!));
            Console.WriteLine("Thank you for playing!\n");
            Console.WriteLine("Game made by Matteo Jakob (2021)\n");
            Console.WriteLine("Press ENTER to end");

            Console.Read();

        }
    }
}
