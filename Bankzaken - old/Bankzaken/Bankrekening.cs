using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bankzaken {
    internal class Bankrekening {
        // Fields
        private int rekeningnummer;
        private string naam;
        private int saldo; // het saldo in hele centen
        private static int volgendeVrijeRekeningnummer = 2001;


        // Methods
        public void NeemOp(int bedrag) {
            if (bedrag > 0) {
                this.saldo -= bedrag;
            }
        }

        public void Stort(int bedrag) {
            if (bedrag > 0) {
                this.saldo += bedrag;
            }
        }

        public void MaakOver(Bankrekening andereRekening, int bedrag) {
            if (bedrag > 0) {
                //this.saldo -= bedrag;
                NeemOp(bedrag);
                andereRekening.Stort(bedrag);
            } else {
                Console.WriteLine("bedrag onder nul");
            }
        }

        public int showSaldo() {
            return this.saldo;
           // Console.WriteLine(this.saldo);
        }

        public string nextAccountNumber() {
            Console.WriteLine(this.rekeningnummer);
            return Convert.ToString(this.rekeningnummer);
        }


        // Constructors
        public Bankrekening(string naam) {
            this.naam = naam;
            this.saldo = 0;
            this.rekeningnummer = volgendeVrijeRekeningnummer;

            // we hogen het volgende vrije rekeningnummer met 1 op zodat de
            // volgende bankrekening een nummer krijgt dat 1 hoger is dan
            // deze bankrekening.
            ++volgendeVrijeRekeningnummer;
        }

        public Bankrekening(string naam, int saldo) {
            this.naam = naam;
            this.saldo = saldo;
        }
    }
}
