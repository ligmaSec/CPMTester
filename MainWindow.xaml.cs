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

namespace CPMTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
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

            clickCount.Text = Convert.ToString(Count);
            centerText.Text = String.Empty;
            Count++;
        }


        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("reset");

        }


        /*
        private void centerText_Click(object sender, RoutedEventArgs e)
        {
            _10secsTest.Foreground = Brushes.Black;
        } */


        private void Close_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            //throw new NotImplementedException();
        }

        private void _10secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _10secsTest.Foreground = Brushes.LightGray;
            _30secsTest.Foreground = Brushes.DimGray;
        }

        private void _30secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _30secsTest.Foreground = Brushes.LightGray;
            _10secsTest.Foreground = Brushes.DimGray;
        }
    }
}
