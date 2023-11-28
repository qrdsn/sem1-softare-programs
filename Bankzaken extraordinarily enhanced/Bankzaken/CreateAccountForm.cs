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
    public partial class CreateAccountForm : Form {
        //constructors
        public CreateAccountForm() {
            InitializeComponent();
        }

        //fields
        //public Bankrekeningenform parentForm;
        int accountNumber;
        private string name;

        public Bankrekeningenform ParentForm { get; set; }

        //methods
        private void button1_Click(object sender, EventArgs e) {
            name = textBox1.Text;

            ParentForm.createAccount(name);

            this.Hide();
        }
    }
}
