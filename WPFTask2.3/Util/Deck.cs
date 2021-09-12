using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTask2._1.Models;

namespace WPFTask2._1.Util
{
    public class Deck
    {
        private readonly Card[] cards;

        private static string[] suits = new string[] { "червы", "крести", "буби", "вини" };
        private static string[] ranks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Deck()
        {
            cards = new Card[52];
            int index = 0;

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards[index++] = new Card(rank, suit);
                }
            }
        }

        public Card GetCard(int index)
        {
            if (index >= 0 && index <= 52)
            {
                return cards[index];
            }
            else
            {
                return null;
            }
        }

        public void SetCard(string suit, string rank, int index)
        {
            if (index >= 0 && index <= 52)
            {
                cards[index] = new Card(rank, suit);
            }
        }

        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void Shuffle()
        {
            lock (cards)
            {
                Random rng = new Random();

                for(int i = 0; i < 52; i++)
                {
                    int rand = rng.Next(52);
                    Swap(ref cards[i], ref cards[rand]);
                }
            }
        }
    }
}
