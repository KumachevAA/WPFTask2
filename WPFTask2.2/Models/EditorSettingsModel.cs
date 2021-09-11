using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace WPFTask2._2.Models
{
    public class EditorSettingsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool boldPressed = false;
        public bool BoldPressed
        {
            get => boldPressed;
            set
            {
                boldPressed = value;
                OnPropertyChanged();
            }
        }

        private bool italicPressed = false;
        public bool ItalicPressed
        {
            get => italicPressed;
            set
            {
                italicPressed = value;
                OnPropertyChanged();
            }
        }

        private int fontSize = 12;
        public int FontSize
        {
            get => fontSize;
            set
            {
                fontSize = value;
                OnPropertyChanged();
            }
        }

        private FontFamily fontFamily = new FontFamily("Arial");
        public FontFamily FontFamily
        {
            get => fontFamily;
            set
            {
                fontFamily = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
