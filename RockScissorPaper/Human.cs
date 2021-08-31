using System;
using System.Collections.Generic;
using System.Text;

namespace RockScissorPaper
{
    public class Human : Players
    {
        public static string userInput { get; set; }
        public override void chooseWeapons()
        {
            Console.Write("Choose an input from Rock/ Paper/ Scissor ");
            userInput = Console.ReadLine();
        }

    }
}
