using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFTask2._1.Models
{
    public class Card
    {
        private string suit;
        public string Suit { get => suit; }

        private string rank;
        public string Rank { get => rank; }

        public string Image { get; }

        public string StringName { get => ToString(); }

        private Card()
        {

        }

        public Card(string rank, string suit)
        {
            this.suit = suit;
            this.rank = rank;
            Image = Path.Combine(Environment.CurrentDirectory, $@"Pictures\{suit}_{rank}.png");
        }

        public override string ToString()
        {
            return $"{Rank} {Suit}";
        }
    }
}
