namespace dersTekrar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.Label();
            this.mesai = new System.Windows.Forms.Label();
            this.unvan = new System.Windows.Forms.Label();
            this.mesaiTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(149, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "PERSONEL OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adTxt
            // 
            this.adTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adTxt.Location = new System.Drawing.Point(304, 67);
            this.adTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(114, 27);
            this.adTxt.TabIndex = 1;
            // 
            // adresTxt
            // 
            this.adresTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adresTxt.Location = new System.Drawing.Point(304, 139);
            this.adresTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(114, 27);
            this.adresTxt.TabIndex = 2;
            // 
            // yasTxt
            // 
            this.yasTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yasTxt.Location = new System.Drawing.Point(304, 216);
            this.yasTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(114, 27);
            this.yasTxt.TabIndex = 3;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ad.Location = new System.Drawing.Point(31, 67);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(73, 20);
            this.ad.TabIndex = 4;
            this.ad.Text = "Ad Soyad";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adres.Location = new System.Drawing.Point(31, 139);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(47, 20);
            this.adres.TabIndex = 5;
            this.adres.Text = "Adres";
            // 
            // yas
            // 
            this.yas.AutoSize = true;
            this.yas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yas.Location = new System.Drawing.Point(31, 223);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(30, 20);
            this.yas.TabIndex = 6;
            this.yas.Text = "Yaş";
            // 
            // mesai
            // 
            this.mesai.AutoSize = true;
            this.mesai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mesai.Location = new System.Drawing.Point(31, 289);
            this.mesai.Name = "mesai";
            this.mesai.Size = new System.Drawing.Size(48, 20);
            this.mesai.TabIndex = 7;
            this.mesai.Text = "Mesai";
            // 
            // unvan
            // 
            this.unvan.AutoSize = true;
            this.unvan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.unvan.Location = new System.Drawing.Point(31, 358);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(50, 20);
            this.unvan.TabIndex = 8;
            this.unvan.Text = "Ünvan";
            // 
            // mesaiTxt
            // 
            this.mesaiTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesaiTxt.Location = new System.Drawing.Point(304, 289);
            this.mesaiTxt.Name = "mesaiTxt";
            this.mesaiTxt.Size = new System.Drawing.Size(114, 27);
            this.mesaiTxt.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 483);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mesaiTxt);
            this.Controls.Add(this.unvan);
            this.Controls.Add(this.mesai);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.yasTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Kullanıcı Sorgulama";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private Label ad;
        private Label adres;
        private Label yas;
        private Label mesai;
        private Label unvan;
        private TextBox mesaiTxt;
        private ComboBox comboBox1;
    }
}