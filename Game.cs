using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    class Game
    {
        public void InitGame()
        {
            // foreach (var item in userManager.users)
            // {
            //     System.Console.WriteLine(item.Name);
            //     System.Console.WriteLine(item.Count);
            //     System.Console.WriteLine(item.IsWin);
            //     System.Console.WriteLine(item.UserPokers);
            // }
            // foreach (var item in pokerManager.PokerJack)
            // {
            //     System.Console.WriteLine(@"{0}:{1}", item.Color, item.Count);
            // }
        }
        public void Start(UserManager userManager, PokerManager pokerManager, int numOfUser)
        {
            int gameEnd = 0;
            while (true)
            {
                foreach (var user in userManager.users)
                {
                    if (user.IsGain == true)
                    {
                        System.Console.WriteLine("请{0}输入1获取卡牌，输入2停止获取卡牌", user.Name);
                        int instruct = int.Parse(Console.ReadLine());
                        // int instruct = 1;
                        if (instruct == 1 && pokerManager.PokerJack.Count > 0)
                        {
                            Poker poker = pokerManager.GetPoker();
                            userManager.AddPoker(user, poker);
                            System.Console.WriteLine("{0}获取的牌是{1}:{2}", user.Name, poker.Color.ToString(), poker.Count.ToString());
                            userManager.ShowPokers(user);
                        }
                        else
                        {
                            user.IsGain = false;
                            gameEnd++;
                        }
                    }
                }
                if (gameEnd == numOfUser)
                    break;
            }
        }
        public void End(UserManager userManager, PokerManager pokerManager, int numOfUser)
        {
            foreach (var user in userManager.users)
            {
                user.Count = userManager.CalculateScore(user);
                if (user.Count > 21)
                {
                    System.Console.WriteLine("{0}的分数为{1},超出21点，BOOM！！！", user.Name, user.Count);
                    // userManager.users.Remove(user);
                }
                else
                    Console.WriteLine("{0}的分数为{1}", user.Name, user.Count);
            }
        }
        public void FindWin(UserManager userManager, PokerManager pokerManager, int numOfUser)
        {
            List<double> userCounts = new List<double>();
            userCounts.Add(0);
            double max;
            foreach (var user in userManager.users)
            {
                if (user.Count < 21)
                {
                    userCounts.Add(user.Count);
                }
            }
            max = userCounts.Max();
            // Console.WriteLine(max);
            foreach (var user in userManager.users)
            {
                if (max == user.Count)
                {
                    Console.WriteLine("{0} WIN!!!", user.Name);
                    userManager.ShowPokers(user);
                }
            }
        }
    }

}