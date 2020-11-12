using System;

namespace Blackjack
{
    public enum PokerColor
    {
        spade, heart, club, dianmond
    }
    class Poker
    {
        public PokerColor Color { get; set; }
        public double Count { get; set; }
    }
}