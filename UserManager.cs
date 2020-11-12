using System;
using System.Collections.Generic;
namespace Blackjack
{

    class UserManager
    {
        public List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void UserInit(int numberOfUsers)
        {
            for (int i = 1; i <= numberOfUsers; i++)
            {
                User user = new User() { Name = "用户" + i, Count = 0, IsWin = false, IsGain = true };
                users.Add(user);
            }
        }
        public void ShowPokers(User user)
        {
            System.Console.Write("{0}的手牌为:", user.Name);
            foreach (var poker in user.UserPokers)
            {
                System.Console.Write("{0}:{1}, ", poker.Color.ToString(), poker.Count.ToString());
            }
            System.Console.WriteLine("\n");
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
        public void AddPoker(User user, Poker poker)
        {
            user.UserPokers.Add(poker);
        }
        public double CalculateScore(User user)
        {
            double score = 0;
            foreach (var poker in user.UserPokers)
            {
                if (poker.Count > 10)
                    score += 0.5;
                else
                    score += poker.Count;
            }
            return score;
        }

        public User GetUser(string name)
        {
            foreach (var item in users)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
        public void GetUser(string name, out User user)
        {
            user = null;
            foreach (var item in users)
            {
                if (item.Name == name)
                    user = item;
            }

        }
    }
}