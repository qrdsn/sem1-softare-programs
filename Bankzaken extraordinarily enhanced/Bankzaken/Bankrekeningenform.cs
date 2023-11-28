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
    public partial class Bankrekeningenform : Form {
        // Fields
        //private Bankrekening bankrekening;
        private AccountNumbers account;
        public List<Bankrekening> rekeningen = new List<Bankrekening>();
        private int activeRekeningNr;


        //Constructor
        public Bankrekeningenform() {
            InitializeComponent();
            account = new AccountNumbers();

            CreateAccountForm frm = new CreateAccountForm();
            frm.ParentForm = this;
            frm.ShowDialog();
        }


        public void createAccount(string name) {
            int accountNumber = account.getAccountNumber();
            rekeningen.Add(new Bankrekening(name, accountNumber));
            updateCredentials(accountNumber);
        }

        public void updateCredentials(int currentRekening) {
            try {
                label_naam.Text = Convert.ToString(rekeningen[currentRekening].showName());
                label_rekeningNr.Text = Convert.ToString(rekeningen[currentRekening].showAccountNumber());
                Console.WriteLine("this is the account Number: " + currentRekening);
                activeRekeningNr = currentRekening;
                updateSaldo();
                label_error.Text = "";
            } catch {
                label_error.Text = "Account doesn't exist";
            }
        }

        public void transfer(int transferAccount) {
            rekeningen[activeRekeningNr].MaakOver(rekeningen[transferAccount], amount);
            updateSaldo();
        }

        private void updateSaldo() {
            label_saldo.Text = Convert.ToString(rekeningen[activeRekeningNr].showSaldo());
            textBox_amount.Text = "";
        }

        private void button_opnemen_Click(object sender, EventArgs e) {
            if (textBox_amount.Text.Length > 0) {
                rekeningen[activeRekeningNr].NeemOp(Convert.ToInt32(textBox_amount.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul een hoeveelheid in");
            }
        }

        private void button_storten_Click(object sender, EventArgs e) {
            if (textBox_amount.Text.Length > 0) {
                rekeningen[activeRekeningNr].Stort(Convert.ToInt32(textBox_amount.Text));
                updateSaldo();
            } else {
                Console.WriteLine("vul een hoeveelheid in");
            }
        }

        public static int amount;

        private void button_overmaken_Click(object sender, EventArgs e) {
            if (textBox_amount.Text.Length > 0) {
                amount = Convert.ToInt32(textBox_amount.Text);
                //textBox_amount.Text = Convert.ToString(amount);
                OvermakenForm frm = new OvermakenForm();
                frm.ParentForm = this;
                frm.ShowDialog();
            } else {
                Console.WriteLine("vul een hoeveelheid in");
            }
        }

        private void button_switchAccount_Click(object sender, EventArgs e) {
            //SwitchAccountForm newForm = new SwitchAccountForm();
            //newForm.ShowDialog();

            SwitchAccountForm frm = new SwitchAccountForm();
            frm.ParentForm = this;
            frm.ShowDialog();
        }

        private void button_createAccount_Click(object sender, EventArgs e) {
            CreateAccountForm frm = new CreateAccountForm();
            frm.ParentForm = this;
            frm.ShowDialog();
        }
    }
}
