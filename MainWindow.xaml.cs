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
using System.Windows.Shapes;
using System.Diagnostics;

namespace CPMTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Challenge c = new Challenge();


        public MainWindow()
        {
            InitializeComponent();
            Version.Text = "0.0.1";
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void clicker_Click(object sender, RoutedEventArgs e)
        {

            clickCount.Text = Convert.ToString(c.Count);
            centerText.Text = String.Empty;
            c.Count++;
        }


        private void reset_Click(object sender, RoutedEventArgs e)
        {
            c.test();

        }



        private void _10secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _10secsTest.Foreground = Brushes.LightGray;
            _30secsTest.Foreground = Brushes.DimGray;
        }

        private void _30secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            c.Type = 1;
            _30secsTest.Foreground = Brushes.LightGray;
            _10secsTest.Foreground = Brushes.DimGray;

        }

        private void close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}




