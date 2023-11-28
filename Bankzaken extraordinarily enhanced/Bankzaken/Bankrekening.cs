using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankzaken {
    //internal class Bankrekening {
    public class Bankrekening {
        // Fields
        private int rekeningnummer;
        private string naam;
        private int saldo; //het saldo in hele centen


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
                NeemOp(bedrag);
                andereRekening.Stort(bedrag);
            } else {
                Console.WriteLine("bedrag onder nul");
            }
        }

        public int showSaldo() {
            return this.saldo;
        }

        public string showName() {
            return this.naam;
        }

        public int showAccountNumber() {
            return this.rekeningnummer;
        }


        // Constructors
        public Bankrekening(string naam, int accountNumber) {
            this.naam = naam;
            this.saldo = 0;
            this.rekeningnummer = accountNumber;
        }

        public Bankrekening(string naam, int accountNumber, int saldo) {
            this.naam = naam;
            this.saldo = saldo;
            this.rekeningnummer = accountNumber;
        }
    }
}
