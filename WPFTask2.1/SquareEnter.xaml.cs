using System.Windows;
using System.Windows.Controls;
using WPFTask2._1.Messaging;

namespace WPFTask2._1
{
    /// <summary>
    /// Логика взаимодействия для SquareEnter.xaml
    /// </summary>
    public partial class SquareEnter : UserControl
    {
        private GlobalEventManager eventManager = GlobalEventManager.GetInstance();

        public SquareEnter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(SizeBox.Text, out double size))
            {
                eventManager.OnShapeCreated(new Models.Square(size));
            }
        }
    }
}
