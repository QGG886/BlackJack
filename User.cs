using System;
using System.Collections.Generic;

namespace Blackjack
{
    class User
    {
        public string Name { get; set; }
        public double Count { get; set; }
        public bool IsWin { get; set; }
        public bool IsGain { get; set; }
        public List<Poker> UserPokers = new List<Poker>();
    }
}