namespace CoffeShop
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextOredrs = new System.Windows.Forms.RichTextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numFiltre = new System.Windows.Forms.NumericUpDown();
            this.numEspresso = new System.Windows.Forms.NumericUpDown();
            this.numAmericano = new System.Windows.Forms.NumericUpDown();
            this.numLatte = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmericano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatte)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextOredrs
            // 
            this.richTextOredrs.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextOredrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextOredrs.Location = new System.Drawing.Point(271, 88);
            this.richTextOredrs.Name = "richTextOredrs";
            this.richTextOredrs.Size = new System.Drawing.Size(869, 457);
            this.richTextOredrs.TabIndex = 18;
            this.richTextOredrs.Text = "";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYazdir.Location = new System.Drawing.Point(984, 593);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(156, 55);
            this.btnYazdir.TabIndex = 15;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.PrintOrders);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.Location = new System.Drawing.Point(602, 593);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(156, 55);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHesapla.Location = new System.Drawing.Point(271, 593);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(156, 55);
            this.btnHesapla.TabIndex = 17;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtToplam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numFiltre);
            this.panel1.Controls.Add(this.numEspresso);
            this.panel1.Controls.Add(this.numAmericano);
            this.panel1.Controls.Add(this.numLatte);
            this.panel1.Location = new System.Drawing.Point(14, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 458);
            this.panel1.TabIndex = 19;
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.PeachPuff;
            this.txtToplam.Location = new System.Drawing.Point(52, 418);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(100, 31);
            this.txtToplam.TabIndex = 24;
            this.txtToplam.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Filtre Kahve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Espresso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Americano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cafe Latte";
            // 
            // numFiltre
            // 
            this.numFiltre.BackColor = System.Drawing.Color.PeachPuff;
            this.numFiltre.Location = new System.Drawing.Point(48, 302);
            this.numFiltre.Name = "numFiltre";
            this.numFiltre.Size = new System.Drawing.Size(120, 31);
            this.numFiltre.TabIndex = 15;
            this.numFiltre.ValueChanged += new System.EventHandler(this.addCaffe);
            // 
            // numEspresso
            // 
            this.numEspresso.BackColor = System.Drawing.Color.PeachPuff;
            this.numEspresso.Location = new System.Drawing.Point(49, 211);
            this.numEspresso.Name = "numEspresso";
            this.numEspresso.Size = new System.Drawing.Size(120, 31);
            this.numEspresso.TabIndex = 16;
            this.numEspresso.ValueChanged += new System.EventHandler(this.addCaffe);
            // 
            // numAmericano
            // 
            this.numAmericano.BackColor = System.Drawing.Color.PeachPuff;
            this.numAmericano.Location = new System.Drawing.Point(52, 128);
            this.numAmericano.Name = "numAmericano";
            this.numAmericano.Size = new System.Drawing.Size(120, 31);
            this.numAmericano.TabIndex = 17;
            this.numAmericano.ValueChanged += new System.EventHandler(this.addCaffe);
            // 
            // numLatte
            // 
            this.numLatte.BackColor = System.Drawing.Color.PeachPuff;
            this.numLatte.Location = new System.Drawing.Point(52, 46);
            this.numLatte.Name = "numLatte";
            this.numLatte.Size = new System.Drawing.Size(120, 31);
            this.numLatte.TabIndex = 18;
            this.numLatte.ValueChanged += new System.EventHandler(this.addCaffe);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1168, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextOredrs);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUser_FormClosed);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmericano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextOredrs;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFiltre;
        private System.Windows.Forms.NumericUpDown numEspresso;
        private System.Windows.Forms.NumericUpDown numAmericano;
        private System.Windows.Forms.NumericUpDown numLatte;
    }
}