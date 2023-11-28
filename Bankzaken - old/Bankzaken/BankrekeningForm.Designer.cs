namespace Bankzaken {
    partial class BankrekeningForm {
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
            this.textBoxRechts = new System.Windows.Forms.TextBox();
            this.btn_stortenLinks = new System.Windows.Forms.Button();
            this.btn_opnemenLinks = new System.Windows.Forms.Button();
            this.btn_OvermakenRechts = new System.Windows.Forms.Button();
            this.textBoxLinks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_opnemenRechts = new System.Windows.Forms.Button();
            this.btn_stortenRechts = new System.Windows.Forms.Button();
            this.btn_overmakenLinks = new System.Windows.Forms.Button();
            this.saldoLinks = new System.Windows.Forms.Label();
            this.saldoRechts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRechts
            // 
            this.textBoxRechts.Location = new System.Drawing.Point(549, 147);
            this.textBoxRechts.Name = "textBoxRechts";
            this.textBoxRechts.Size = new System.Drawing.Size(100, 26);
            this.textBoxRechts.TabIndex = 0;
            // 
            // btn_stortenLinks
            // 
            this.btn_stortenLinks.Location = new System.Drawing.Point(167, 235);
            this.btn_stortenLinks.Name = "btn_stortenLinks";
            this.btn_stortenLinks.Size = new System.Drawing.Size(99, 29);
            this.btn_stortenLinks.TabIndex = 2;
            this.btn_stortenLinks.Text = "Storten";
            this.btn_stortenLinks.UseVisualStyleBackColor = true;
            this.btn_stortenLinks.Click += new System.EventHandler(this.btn_stortenLinks_Click);
            // 
            // btn_opnemenLinks
            // 
            this.btn_opnemenLinks.Location = new System.Drawing.Point(167, 190);
            this.btn_opnemenLinks.Name = "btn_opnemenLinks";
            this.btn_opnemenLinks.Size = new System.Drawing.Size(99, 29);
            this.btn_opnemenLinks.TabIndex = 3;
            this.btn_opnemenLinks.Text = "Opnemen";
            this.btn_opnemenLinks.UseVisualStyleBackColor = true;
            this.btn_opnemenLinks.Click += new System.EventHandler(this.btn_opnemenLinks_Click);
            // 
            // btn_OvermakenRechts
            // 
            this.btn_OvermakenRechts.Location = new System.Drawing.Point(347, 200);
            this.btn_OvermakenRechts.Name = "btn_OvermakenRechts";
            this.btn_OvermakenRechts.Size = new System.Drawing.Size(99, 29);
            this.btn_OvermakenRechts.TabIndex = 4;
            this.btn_OvermakenRechts.Text = ">>";
            this.btn_OvermakenRechts.UseVisualStyleBackColor = true;
            this.btn_OvermakenRechts.Click += new System.EventHandler(this.btn_OvermakenRechts_Click);
            // 
            // textBoxLinks
            // 
            this.textBoxLinks.Location = new System.Drawing.Point(167, 136);
            this.textBoxLinks.Name = "textBoxLinks";
            this.textBoxLinks.Size = new System.Drawing.Size(100, 26);
            this.textBoxLinks.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "bankrekening links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "bankrekening rechts";
            // 
            // btn_opnemenRechts
            // 
            this.btn_opnemenRechts.Location = new System.Drawing.Point(549, 190);
            this.btn_opnemenRechts.Name = "btn_opnemenRechts";
            this.btn_opnemenRechts.Size = new System.Drawing.Size(99, 29);
            this.btn_opnemenRechts.TabIndex = 8;
            this.btn_opnemenRechts.Text = "Opnemen";
            this.btn_opnemenRechts.UseVisualStyleBackColor = true;
            this.btn_opnemenRechts.Click += new System.EventHandler(this.btn_opnemenRechts_Click);
            // 
            // btn_stortenRechts
            // 
            this.btn_stortenRechts.Location = new System.Drawing.Point(549, 235);
            this.btn_stortenRechts.Name = "btn_stortenRechts";
            this.btn_stortenRechts.Size = new System.Drawing.Size(99, 29);
            this.btn_stortenRechts.TabIndex = 9;
            this.btn_stortenRechts.Text = "Storten";
            this.btn_stortenRechts.UseVisualStyleBackColor = true;
            this.btn_stortenRechts.Click += new System.EventHandler(this.btn_stortenRechts_Click);
            // 
            // btn_overmakenLinks
            // 
            this.btn_overmakenLinks.Location = new System.Drawing.Point(347, 235);
            this.btn_overmakenLinks.Name = "btn_overmakenLinks";
            this.btn_overmakenLinks.Size = new System.Drawing.Size(99, 29);
            this.btn_overmakenLinks.TabIndex = 10;
            this.btn_overmakenLinks.Text = "<<";
            this.btn_overmakenLinks.UseVisualStyleBackColor = true;
            this.btn_overmakenLinks.Click += new System.EventHandler(this.btn_overmakenLinks_Click);
            // 
            // saldoLinks
            // 
            this.saldoLinks.AutoSize = true;
            this.saldoLinks.Location = new System.Drawing.Point(180, 298);
            this.saldoLinks.Name = "saldoLinks";
            this.saldoLinks.Size = new System.Drawing.Size(18, 20);
            this.saldoLinks.TabIndex = 11;
            this.saldoLinks.Text = "0";
            // 
            // saldoRechts
            // 
            this.saldoRechts.AutoSize = true;
            this.saldoRechts.Location = new System.Drawing.Point(578, 298);
            this.saldoRechts.Name = "saldoRechts";
            this.saldoRechts.Size = new System.Drawing.Size(18, 20);
            this.saldoRechts.TabIndex = 12;
            this.saldoRechts.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "hoeveelheid";
            // 
            // Bankrekeningenform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saldoRechts);
            this.Controls.Add(this.saldoLinks);
            this.Controls.Add(this.btn_overmakenLinks);
            this.Controls.Add(this.btn_stortenRechts);
            this.Controls.Add(this.btn_opnemenRechts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLinks);
            this.Controls.Add(this.btn_OvermakenRechts);
            this.Controls.Add(this.btn_opnemenLinks);
            this.Controls.Add(this.btn_stortenLinks);
            this.Controls.Add(this.textBoxRechts);
            this.Name = "Bankrekeningenform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRechts;
        private System.Windows.Forms.Button btn_stortenLinks;
        private System.Windows.Forms.Button btn_opnemenLinks;
        private System.Windows.Forms.Button btn_OvermakenRechts;
        private System.Windows.Forms.TextBox textBoxLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_opnemenRechts;
        private System.Windows.Forms.Button btn_stortenRechts;
        private System.Windows.Forms.Button btn_overmakenLinks;
        private System.Windows.Forms.Label saldoLinks;
        private System.Windows.Forms.Label saldoRechts;
        private System.Windows.Forms.Label label3;
    }
}

