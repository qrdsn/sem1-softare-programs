using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDagWaarde {
    public class Auto {

        public int kmStand { get; private set; }
        private string kenteken;


        private int dagWaarde;
        private Program.BrandstofSoort brandstof;

        public Auto(string _kenteken, Program.BrandstofSoort _brandstof) {
            kenteken = _kenteken;
            kmStand = 1;
            brandstof = _brandstof;

            Console.WriteLine(ToString());
        }

        public void RijdKilometers(int kilometers) {
            if (kilometers > 0) {
                kmStand += kilometers;
            }

            Console.Write(ToString());
        }

        public override string ToString() {
            dagWaarde = (500000 / kmStand) * (int)brandstof;
            return (kenteken + " " + brandstof + " auto met " + kmStand + " km op de teller heeft een dagwaarde van " + dagWaarde + " euro");
            //return ("{0} {1} {3} km op de teller heeft een dagwaarde van {4} euro", kenteken, kmStand, dagWaarde, dagWaarde);
        }
    }
}
