namespace Bankzaken {
    partial class Bankrekeningenform {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button_storten = new System.Windows.Forms.Button();
            this.button_opnemen = new System.Windows.Forms.Button();
            this.button_Overmaken = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_saldo = new System.Windows.Forms.Label();
            this.button_createAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_rekeningNr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_switchAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_naam = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_storten
            // 
            this.button_storten.Location = new System.Drawing.Point(298, 199);
            this.button_storten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_storten.Name = "button_storten";
            this.button_storten.Size = new System.Drawing.Size(95, 23);
            this.button_storten.TabIndex = 2;
            this.button_storten.Text = "Storten";
            this.button_storten.UseVisualStyleBackColor = true;
            this.button_storten.Click += new System.EventHandler(this.button_storten_Click);
            // 
            // button_opnemen
            // 
            this.button_opnemen.Location = new System.Drawing.Point(298, 163);
            this.button_opnemen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_opnemen.Name = "button_opnemen";
            this.button_opnemen.Size = new System.Drawing.Size(95, 23);
            this.button_opnemen.TabIndex = 3;
            this.button_opnemen.Text = "Opnemen";
            this.button_opnemen.UseVisualStyleBackColor = true;
            this.button_opnemen.Click += new System.EventHandler(this.button_opnemen_Click);
            // 
            // button_Overmaken
            // 
            this.button_Overmaken.Location = new System.Drawing.Point(298, 235);
            this.button_Overmaken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Overmaken.Name = "button_Overmaken";
            this.button_Overmaken.Size = new System.Drawing.Size(95, 23);
            this.button_Overmaken.TabIndex = 4;
            this.button_Overmaken.Text = "Overmaken";
            this.button_Overmaken.UseVisualStyleBackColor = true;
            this.button_Overmaken.Click += new System.EventHandler(this.button_overmaken_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(298, 130);
            this.textBox_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(96, 22);
            this.textBox_amount.TabIndex = 5;
            // 
            // label_saldo
            // 
            this.label_saldo.AutoSize = true;
            this.label_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_saldo.Location = new System.Drawing.Point(552, 172);
            this.label_saldo.Name = "label_saldo";
            this.label_saldo.Size = new System.Drawing.Size(36, 39);
            this.label_saldo.TabIndex = 11;
            this.label_saldo.Text = "0";
            // 
            // button_createAccount
            // 
            this.button_createAccount.Location = new System.Drawing.Point(11, 10);
            this.button_createAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_createAccount.Name = "button_createAccount";
            this.button_createAccount.Size = new System.Drawing.Size(99, 63);
            this.button_createAccount.TabIndex = 13;
            this.button_createAccount.Text = "Nieuw account";
            this.button_createAccount.UseVisualStyleBackColor = true;
            this.button_createAccount.Click += new System.EventHandler(this.button_createAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "hoeveelheid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "rekening nr:";
            // 
            // label_rekeningNr
            // 
            this.label_rekeningNr.AutoSize = true;
            this.label_rekeningNr.Location = new System.Drawing.Point(294, 94);
            this.label_rekeningNr.Name = "label_rekeningNr";
            this.label_rekeningNr.Size = new System.Drawing.Size(0, 16);
            this.label_rekeningNr.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "saldo";
            // 
            // button_switchAccount
            // 
            this.button_switchAccount.Location = new System.Drawing.Point(11, 88);
            this.button_switchAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_switchAccount.Name = "button_switchAccount";
            this.button_switchAccount.Size = new System.Drawing.Size(99, 63);
            this.button_switchAccount.TabIndex = 18;
            this.button_switchAccount.Text = "Verander account";
            this.button_switchAccount.UseVisualStyleBackColor = true;
            this.button_switchAccount.Click += new System.EventHandler(this.button_switchAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "naam:";
            // 
            // label_naam
            // 
            this.label_naam.AutoSize = true;
            this.label_naam.Location = new System.Drawing.Point(298, 56);
            this.label_naam.Name = "label_naam";
            this.label_naam.Size = new System.Drawing.Size(0, 16);
            this.label_naam.TabIndex = 20;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(80, 270);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 16);
            this.label_error.TabIndex = 21;
            // 
            // Bankrekeningenform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_naam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_switchAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_rekeningNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_createAccount);
            this.Controls.Add(this.label_saldo);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button_Overmaken);
            this.Controls.Add(this.button_opnemen);
            this.Controls.Add(this.button_storten);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bankrekeningenform";
            this.Text = "Bankrekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_storten;
        private System.Windows.Forms.Button button_opnemen;
        private System.Windows.Forms.Button button_Overmaken;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_saldo;
        private System.Windows.Forms.Button button_createAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_rekeningNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_switchAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_naam;
        private System.Windows.Forms.Label label_error;
    }
}

