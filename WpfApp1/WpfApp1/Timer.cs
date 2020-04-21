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

        

        public void SetTimer(System.Timers.Timer aTimer,string milisecondtime)
        {
            int milisecondtimeint = Int32.Parse(milisecondtime);
            aTimer = new System.Timers.Timer(milisecondtimeint);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public void StopTimer(System.Timers.Timer aTimer)
        {
            try
            {
                aTimer.Enabled = false;
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
