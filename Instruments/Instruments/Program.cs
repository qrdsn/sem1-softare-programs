using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Instruments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Marimba marimba = new Marimba();
            BassGuitar bassGuitar = new BassGuitar();

            bassGuitar.PlayNote("a");
            Thread.Sleep(500);

            marimba.PlayNote("e");
            Thread.Sleep(500);

            bassGuitar.PlayNote("g");
            Thread.Sleep(500);

            marimba.PlayNote("d#");
            Thread.Sleep(500);

            bassGuitar.PlayNote("f");
            Thread.Sleep(500);

            marimba.PlayNote("e");
            Thread.Sleep(500);

            marimba.PlayNote("d#");
            Thread.Sleep(500);

            bassGuitar.PlayNote("e");
            Thread.Sleep(500);

            marimba.PlayNote("e");
            Thread.Sleep(500);


            Console.ReadKey();
        }
    }
}
