namespace CoffeShop
{
    partial class frmAdmin
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.uyeTab = new System.Windows.Forms.TabPage();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPasword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.tabPage.SuspendLayout();
            this.uyeTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.uyeTab);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Location = new System.Drawing.Point(33, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(933, 649);
            this.tabPage.TabIndex = 0;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.tabPage_SelectedIndexChanged);
            // 
            // uyeTab
            // 
            this.uyeTab.BackColor = System.Drawing.Color.SandyBrown;
            this.uyeTab.Controls.Add(this.cmdDelete);
            this.uyeTab.Controls.Add(this.lstUsers);
            this.uyeTab.Controls.Add(this.cmdSave);
            this.uyeTab.Controls.Add(this.label2);
            this.uyeTab.Controls.Add(this.label1);
            this.uyeTab.Controls.Add(this.textPasword);
            this.uyeTab.Controls.Add(this.txtUserName);
            this.uyeTab.Location = new System.Drawing.Point(8, 39);
            this.uyeTab.Name = "uyeTab";
            this.uyeTab.Padding = new System.Windows.Forms.Padding(3);
            this.uyeTab.Size = new System.Drawing.Size(917, 602);
            this.uyeTab.TabIndex = 0;
            this.uyeTab.Text = "Kullanıcı İşlemleri";
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Sienna;
            this.cmdDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdDelete.Location = new System.Drawing.Point(423, 445);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(155, 71);
            this.cmdDelete.TabIndex = 17;
            this.cmdDelete.Text = "Sil";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.NavajoWhite;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 25;
            this.lstUsers.Location = new System.Drawing.Point(78, 199);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(593, 204);
            this.lstUsers.TabIndex = 16;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Sienna;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSave.Location = new System.Drawing.Point(607, 445);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(156, 71);
            this.cmdSave.TabIndex = 15;
            this.cmdSave.Text = "Kaydet";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parola          :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // textPasword
            // 
            this.textPasword.BackColor = System.Drawing.Color.NavajoWhite;
            this.textPasword.Location = new System.Drawing.Point(268, 136);
            this.textPasword.Name = "textPasword";
            this.textPasword.Size = new System.Drawing.Size(297, 31);
            this.textPasword.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtUserName.Location = new System.Drawing.Point(268, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(495, 31);
            this.txtUserName.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtFiyat);
            this.tabPage2.Controls.Add(this.cmbUrun);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fiyat Güncelleme";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(414, 261);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 66);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.Color.SeaShell;
            this.txtFiyat.Location = new System.Drawing.Point(227, 146);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(114, 31);
            this.txtFiyat.TabIndex = 5;
            // 
            // cmbUrun
            // 
            this.cmbUrun.BackColor = System.Drawing.Color.SeaShell;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(227, 77);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(324, 33);
            this.cmbUrun.TabIndex = 4;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(974, 677);
            this.Controls.Add(this.tabPage);
            this.Name = "frmAdmin";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabPage.ResumeLayout(false);
            this.uyeTab.ResumeLayout(false);
            this.uyeTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage uyeTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPasword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbUrun;
    }
}