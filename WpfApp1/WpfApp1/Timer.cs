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
        public static System.Timers.Timer aTimer;
        

        public void SetTimer(string milisecondtime)
        {
           
            int milisecondtimeint = Int32.Parse(milisecondtime);
            aTimer = new System.Timers.Timer(milisecondtimeint);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            
        }
        public void StopTimer()
        {
            try
            {
                aTimer.Stop();
                aTimer.Dispose();
            }
            catch(NullReferenceException e)
            {

            }
            
            


        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            MessageBox.Show("ffds");
        }
    }
}
