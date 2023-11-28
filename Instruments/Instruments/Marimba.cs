using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class Marimba
    {
        public Marimba()
        {

        }

        public void PlayNote(string note)
        {
            Console.WriteLine("marimba plays note: " + note);

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Quinn\School\programs\Instruments\Notes\" + note + ".wav");
            //player.Play();
        }

    }
}
