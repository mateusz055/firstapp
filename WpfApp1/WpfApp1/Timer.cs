using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace WpfApp1
{
    class Timer
    {

        public static System.Timers.Timer tmpTimer;

        public void SetTimer(System.Timers.Timer aTimer)
        {
            tmpTimer = aTimer;
            tmpTimer = new System.Timers.Timer(5000);
            tmpTimer.Elapsed += OnTimedEvent;
            tmpTimer.AutoReset = true;
            tmpTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            MessageBox.Show("ffds");
        }
    }
}
