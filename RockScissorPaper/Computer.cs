using System;
using System.Collections.Generic;
using System.Text;

namespace RockScissorPaper
{
    public class Computer : Players
    {
        public static string systemInput { get; set; }
        public override void chooseWeapons()
        {
            int randomNum = 0;
            Random rnd = new Random();
            randomNum = rnd.Next(1, 4);

            switch (randomNum)
            {
                case 1:
                    systemInput = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    break;

                case 2:
                    systemInput = "Paper";
                    Console.WriteLine("Computer chose Paper");
                    break;

                case 3:

                    systemInput = "Scissor";
                    Console.WriteLine("Computer chose Scissor");
                    break;

                default:
                    Console.WriteLine("Invalid entry!");
                    break;

            }

        }

    }
}
