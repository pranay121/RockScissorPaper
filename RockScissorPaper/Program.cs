using System;

namespace RockScissorPaper
{
    public class Program
    {
        static void Main(string[] args)
        {
            int gameNo=0;

            while(gameNo<=2)
            {
                Players p1 = new Human();
                p1.chooseWeapons();
                Players p2 = new Computer();
                p2.chooseWeapons();
                Players.Play();
                gameNo++;
            }
            if (Human.userPoint > Computer.CompPoint)
                Console.WriteLine("You Win");
            else if (Human.userPoint < Computer.CompPoint)
                Console.WriteLine("You Loose");
            else
                Console.WriteLine("Its a draw");
        }
    }
}

