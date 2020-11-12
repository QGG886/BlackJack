using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            UserManager userManager = new UserManager();
            PokerManager pokerManager = new PokerManager();

            while (true)
            {
                userManager.users.Clear();
                pokerManager.PokerJack.Clear();
                System.Console.WriteLine("请输入玩家数量");
                int numOfUser = int.Parse(Console.ReadLine());

                userManager.UserInit(numOfUser);
                pokerManager.JackInit();

                game.Start(userManager, pokerManager, numOfUser);
                game.End(userManager, pokerManager, numOfUser);
                game.FindWin(userManager, pokerManager, numOfUser);
            }


        }
    }
}
