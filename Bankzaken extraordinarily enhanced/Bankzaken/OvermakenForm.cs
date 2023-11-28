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
    public partial class OvermakenForm : Form {

        //fields
        string amount;

        //Constructors
        public OvermakenForm() {
            InitializeComponent();
            label_amount.Text = Convert.ToString(Bankrekeningenform.amount);
        }

        public Bankrekeningenform ParentForm { get; set; }
        //methods
        private void button1_Click(object sender, EventArgs e) {

            ParentForm.transfer(Convert.ToInt32(textBox1.Text));
            this.Hide();
            
        }
    }
}
