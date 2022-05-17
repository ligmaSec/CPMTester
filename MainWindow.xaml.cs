using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Threading;

namespace CPMTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private bool _isclicked = false;

        private int secondsType = 10;
        private int seconds = 10;
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

        private DispatcherTimer Timer;


        private int Count = 0;
        private void clicker_Click(object sender, RoutedEventArgs e)
        {
            Count++;
            clickCount.Text = Convert.ToString(Count);
            centerText.Text = String.Empty;

            if (_isclicked == false)
            {

                Timer = new DispatcherTimer();
                Timer.Interval = new TimeSpan(0,0,0,0,1000);
                Timer.Tick += Timer_Tick;

                Timer.Start();
                _isclicked = true;
            }
            else
            {

            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                if (seconds < 5)
                {
                    countdown.Foreground = Brushes.DarkRed;
                }
                seconds--;
                countdown.Text = Convert.ToString(seconds);
            }
            else if(seconds == 0)
            {
                Timer.Stop();

                float resultat = (float)Count / secondsType;
                cps.Text = Convert.ToString(resultat);
                Count = 0;
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            
        }



        private void _10secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            secondsType = 10;
            seconds = 10;
            _10secsTest.Foreground = Brushes.LightGray;
            _30secsTest.Foreground = Brushes.DimGray;
        }

        private void _30secsTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            seconds = 30;
            secondsType = 30;
            _30secsTest.Foreground = Brushes.LightGray;
            _10secsTest.Foreground = Brushes.DimGray;

        }

        private void close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

    }
}




