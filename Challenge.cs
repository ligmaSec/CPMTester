using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Controls;

namespace CPMTester
{

    public class Challenge
    {
        private Button reset;
        private Button clicker;


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

        private double time;

        public double Time
        {
            get { return time; }
            set { time = value; }
        }



        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Challenge()
        {
            
        }

        public Challenge(Button reset,Button clicker)
        {
            this.reset = reset;
            this.clicker = clicker;
        }



        public void test()
        {


        }

    }
}
