using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinosaur {
    internal class Coin {
        //field
        public int value { get; }
        public int[] location = new int[2] { 0, 0 };

        //constructor
        public Coin(int formWidth, int formHeight) {
            Random random = new Random();
            value = random.Next(1, 10);
            //test = random.Next(0, formWidth);
            location[0] = random.Next(0, formWidth);
            location[1] = random.Next(0, formHeight);
        }

        //methods
        public void remove() {

        }

    }
}
