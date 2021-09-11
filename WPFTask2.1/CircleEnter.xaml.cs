using System.Windows;
using System.Windows.Controls;
using WPFTask2._1.Messaging;

namespace WPFTask2._1
{
    /// <summary>
    /// Логика взаимодействия для CircleEnter.xaml
    /// </summary>
    public partial class CircleEnter : UserControl
    {
        private GlobalEventManager eventManager = GlobalEventManager.GetInstance();

        public CircleEnter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(RadiusBox.Text, out double radius))
            {
                eventManager.OnShapeCreated(new Models.Circle(radius));
            }
        }
    }
}
