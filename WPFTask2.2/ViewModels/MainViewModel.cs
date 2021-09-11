using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WPFTask2._2.Commands;
using WPFTask2._2.Models;

namespace WPFTask2._2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public EditorSettingsModel Editor { get; set; } = new EditorSettingsModel();
        public ObservableCollection<FontFamily> FontFamilies { get; set; } = new ObservableCollection<FontFamily>();

        public Brush BoldButtonColor
        {
            get => Editor.BoldPressed ? Brushes.LightGray : Brushes.White;
        }

        public Brush ItalicButtonColor
        {
            get => Editor.ItalicPressed ? Brushes.LightGray : Brushes.White;
        }

        public FontStyle FontStyle
        {
            get => Editor.ItalicPressed ? FontStyles.Italic : FontStyles.Normal;
        }

        public FontWeight FontWeight
        {
            get => Editor.BoldPressed ? FontWeights.Bold : FontWeights.Normal;
        }

        public MainViewModel()
        {
            foreach (FontFamily font in Fonts.SystemFontFamilies.OrderBy(family => family.FamilyNames.First().Value))
            {
                FontFamilies.Add(font);
            }

            Editor.PropertyChanged += Editor_PropertyChanged;
        }

        private void Editor_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Editor.BoldPressed))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BoldButtonColor)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FontWeight)));
            }
            else if (e.PropertyName == nameof(Editor.ItalicPressed))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItalicButtonColor)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FontStyle)));
            }
        }

        private void PressBold()
        {
            Editor.BoldPressed = !Editor.BoldPressed;
        }

        private void PressItalic()
        {
            Editor.ItalicPressed = !Editor.ItalicPressed;
        }

        public ICommand BoldPressCommand => new RelayCommand(PressBold);
        public ICommand ItalicPressCommand => new RelayCommand(PressItalic);
    }
}
