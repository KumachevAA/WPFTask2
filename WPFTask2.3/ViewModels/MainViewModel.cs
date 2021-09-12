using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WPFTask2._1.Commands;
using WPFTask2._1.Models;
using WPFTask2._1.Util;

namespace WPFTask2._1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Card> Cards { get; } = new ObservableCollection<Card>();
        private Deck deck;

        private void GenDeck()
        {
            deck = new Deck();
            Cards.Clear();

            for (int i = 0; i < 52; i++)
            {
                Cards.Add(deck.GetCard(i));
            }
        }

        private void Shuffle()
        {
            if (deck != null)
            {
                deck.Shuffle();
                Cards.Clear();

                for (int i = 0; i < 52; i++)
                {
                    Cards.Add(deck.GetCard(i));
                }
            }
        }

        public ICommand GetDeck => new RelayCommand(GenDeck);
        public ICommand ShuffleDeck => new RelayCommand(Shuffle);
    }
}
