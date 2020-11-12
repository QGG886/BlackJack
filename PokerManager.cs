using System;
using System.Collections.Generic;

namespace Blackjack
{
    class PokerManager
    {
        public List<Poker> PokerJack = new List<Poker>();

        public void JackInit()
        {
            for (int i = 1; i <= 13; i++)
            {
                PokerJack.Add(new Poker() { Count = i, Color = PokerColor.club });
                PokerJack.Add(new Poker() { Count = i, Color = PokerColor.dianmond });
                PokerJack.Add(new Poker() { Count = i, Color = PokerColor.heart });
                PokerJack.Add(new Poker() { Count = i, Color = PokerColor.spade });
            }
        }
        public Poker GetPoker()
        {
            int num = new Random().Next(PokerJack.Count);
            Poker poker = PokerJack[num];
            PokerJack.RemoveAt(num);
            Console.WriteLine("当前牌组剩余卡数为{0}", PokerJack.Count);
            return poker;
        }

    }

}