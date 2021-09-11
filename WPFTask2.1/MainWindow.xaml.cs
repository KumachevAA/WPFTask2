using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WPFTask2._1.Messaging;
using WPFTask2._1.Models;

namespace WPFTask2._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GlobalEventManager manager = GlobalEventManager.GetInstance();
            manager.ShapeCreated += ShapeCreated;
        }

        private void ShapeCreated(Shape shape)
        {
            ShapeData.Text = shape.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShapeEnter.Content = new RectEnter();
        }

        private void RectSelect_Click(object sender, RoutedEventArgs e)
        {
            ShapeEnter.Content = new RectEnter();
        }

        private void SquareSelect_Click(object sender, RoutedEventArgs e)
        {
            ShapeEnter.Content = new SquareEnter();
        }

        private void CircleSelect_Click(object sender, RoutedEventArgs e)
        {
            ShapeEnter.Content = new CircleEnter();
        }
    }
}
