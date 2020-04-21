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
using System.Timers;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string milisecondtime;
        public static System.Timers.Timer aTimer;
        Timer timer1 = new Timer();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string to = mailbox.Text;
            Sendmail sendmail1 = new Sendmail("legitminecraft143@gmail.com",to);
            sendmail1.send();
            
        }

        private void timerbutton_Click(object sender, RoutedEventArgs e)
        {
            timer1.StopTimer(aTimer);
            timer1.SetTimer(aTimer,milisecondtime);
            
        }
        

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            milisecondtime = lbi.Content.ToString();
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
