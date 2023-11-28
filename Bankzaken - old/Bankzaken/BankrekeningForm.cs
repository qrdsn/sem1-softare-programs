using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankzaken {
    public partial class BankrekeningForm : Form {
        // Fields
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;

        //Constructor
        public BankrekeningForm() {
            InitializeComponent();
            bankrekeningLinks = new Bankrekening("Duck, Dagobert");
            bankrekeningRechts = new Bankrekening("Gans, Gijs");
            bankrekeningLinks.nextAccountNumber();
            bankrekeningRechts.nextAccountNumber();
        }

        private void updateSaldo() {
            saldoLinks.Text = Convert.ToString(bankrekeningLinks.showSaldo());
            saldoRechts.Text = Convert.ToString(bankrekeningRechts.showSaldo());
        }

        private void btn_opnemenLinks_Click(object sender, EventArgs e) {
            if (textBoxLinks.Text.Length > 0) {
                bankrekeningLinks.NeemOp(Convert.ToInt32(textBoxLinks.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul een hoeveelheid in");
            }
        }

        private void btn_stortenLinks_Click(object sender, EventArgs e) {
            if (textBoxLinks.Text.Length > 0) {
                bankrekeningLinks.Stort(Convert.ToInt32(textBoxLinks.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul een hoeveelheid in");
            }
        }

        private void btn_opnemenRechts_Click(object sender, EventArgs e) {
            if (textBoxRechts.Text.Length > 0) {
                bankrekeningRechts.NeemOp(Convert.ToInt32(textBoxRechts.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul hoeveelheid in");
            }
        }

        private void btn_stortenRechts_Click(object sender, EventArgs e) {
            if (textBoxRechts.Text.Length > 0) {
                bankrekeningRechts.Stort(Convert.ToInt32(textBoxRechts.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul hoeveelheid in");
            }
        }

        private void btn_OvermakenRechts_Click(object sender, EventArgs e) {
            if (textBoxRechts.Text.Length > 0) {
                bankrekeningLinks.MaakOver(bankrekeningRechts, Convert.ToInt32(textBoxLinks.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul hoeveelheid in");
            }
        }

        private void btn_overmakenLinks_Click(object sender, EventArgs e) {
            if (textBoxLinks.Text.Length > 0) {
                bankrekeningRechts.MaakOver(bankrekeningLinks, Convert.ToInt32(textBoxRechts.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul hoeveelheid in");
            }
        }
    }
}
