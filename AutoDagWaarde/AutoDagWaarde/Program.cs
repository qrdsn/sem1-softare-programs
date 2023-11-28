using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDagWaarde {
    public class Program {

        static void Main(string[] args) {
            var FiatPanda = new Auto("AB-12-CD", BrandstofSoort.LPG);
            var AudiR8Spyder = new Auto("XJ-SV-08", BrandstofSoort.benzine);
            var TeslaModelX = new Auto("EF-34-GH", BrandstofSoort.elektrische);
            var ToyotaHilux = new Auto("IJ-56-KL", BrandstofSoort.diesel);


            Random random = new Random();
            while (FiatPanda.kmStand < 100000 || AudiR8Spyder.kmStand < 100000 || TeslaModelX.kmStand < 100000 || ToyotaHilux.kmStand < 100000) {
                FiatPanda.RijdKilometers(random.Next(1000, 20000));
                AudiR8Spyder.RijdKilometers(random.Next(1000, 20000));
                TeslaModelX.RijdKilometers(random.Next(1000, 20000));
                ToyotaHilux.RijdKilometers(random.Next(1000, 20000));
            }            
            Console.ReadKey();
            
        }

        public enum BrandstofSoort: int {
            benzine = 100,
            diesel = 150,
            LPG = 90,
            elektrische = 130
        }
    }
}