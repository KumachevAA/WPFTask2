using System.Windows;
using System.Windows.Controls;
using WPFTask2._1.Messaging;

namespace WPFTask2._1
{
    /// <summary>
    /// Логика взаимодействия для RectEnter.xaml
    /// </summary>
    public partial class RectEnter : UserControl
    {
        private GlobalEventManager eventManager = GlobalEventManager.GetInstance();

        public RectEnter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(WidthBox.Text, out double width) && double.TryParse(HeightBox.Text, out double height))
            {
                eventManager.OnShapeCreated(new Models.Rect(width, height));
            }
        }
    }
}
