using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Effect
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Mateusz\Desktop\app\WpfApp1\WpfApp1\images\sound.wav");
        public void Play() 
        {
            player.Play();
        }
    }
}
