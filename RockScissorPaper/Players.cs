using System;
using System.Collections.Generic;
using System.Text;

namespace RockScissorPaper
{
    public abstract class Players
    {
        public static int userPoint { get; set; }
        public static int CompPoint { get; set; }
        public abstract void chooseWeapons();
        public static void Play()
        {
            switch (Computer.systemInput)
            {
                case "Rock":

                    if (Human.userInput.ToLower() == "paper")
                    {
                        userPoint++;
                    }
                    else if (Human.userInput.ToLower() == "scissor")
                    {
                        CompPoint++;
                    }
                    Console.WriteLine($"Computer Point : {CompPoint} and Your Point:{userPoint}");
                    break;

                case "Paper":

                    if (Human.userInput.ToLower() == "rock")
                    {
                        CompPoint++;
                    }
                    else if (Human.userInput.ToLower() == "scissor")
                    {
                        userPoint++;
                    }
                    Console.WriteLine($"Computer Point : {CompPoint} and Your Point:{userPoint}");
                    break;

                case "Scissor":

                    if (Human.userInput.ToLower() == "rock")
                    {
                        userPoint++;
                    }
                    else if (Human.userInput.ToLower() == "paper")
                    {
                        CompPoint++;
                    }
                    Console.WriteLine($"Computer Point : {CompPoint} and Your Point:{userPoint}");
                    break;

                default:

                    Console.WriteLine("Invalid entry!");
                    break;

            }
        }
    }
}
