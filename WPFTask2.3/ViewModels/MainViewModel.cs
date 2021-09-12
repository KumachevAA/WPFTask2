using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTask2._1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double itemWidth  = 0;
        public double ItemWidth
        {
            get => itemWidth;

            set
            {
                itemWidth = value / 13;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemWidth)));
            }
        }
    }
}
