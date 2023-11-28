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
    public partial class SwitchAccountForm : Form {
        public SwitchAccountForm() {
            InitializeComponent();
        }

        int accountNumber;
        public Bankrekeningenform ParentForm { get; set; }

        private void button1_Click(object sender, EventArgs e) {

            accountNumber = Convert.ToInt32(textBox1.Text);
            ParentForm.updateCredentials(accountNumber);

            this.Hide();
            
        }
    }
}
