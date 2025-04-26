namespace KlasorVeClassGosterici
{
    partial class Form1
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
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelOdemeYontemi = new System.Windows.Forms.Label();
            this.cmbOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.labelTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnAciklamaGoster = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(142, 185);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(147, 68);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Klasör Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 132);
            this.listBox1.TabIndex = 1;
            // 
            // labelOdemeYontemi
            // 
            this.labelOdemeYontemi.AutoSize = true;
            this.labelOdemeYontemi.Location = new System.Drawing.Point(519, 12);
            this.labelOdemeYontemi.Name = "labelOdemeYontemi";
            this.labelOdemeYontemi.Size = new System.Drawing.Size(107, 16);
            this.labelOdemeYontemi.TabIndex = 2;
            this.labelOdemeYontemi.Text = "Ödeme Yöntemi:";
            // 
            // cmbOdemeYontemi
            // 
            this.cmbOdemeYontemi.FormattingEnabled = true;
            this.cmbOdemeYontemi.Location = new System.Drawing.Point(691, 12);
            this.cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            this.cmbOdemeYontemi.Size = new System.Drawing.Size(141, 24);
            this.cmbOdemeYontemi.TabIndex = 3;
            this.cmbOdemeYontemi.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeYontemi_SelectedIndexChanged);
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Location = new System.Drawing.Point(519, 46);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(41, 16);
            this.labelTutar.TabIndex = 4;
            this.labelTutar.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(721, 40);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 5;
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(522, 78);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(128, 45);
            this.btnOde.TabIndex = 6;
            this.btnOde.Text = "Ödeme Yap";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(535, 128);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(45, 16);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnAciklamaGoster
            // 
            this.btnAciklamaGoster.Location = new System.Drawing.Point(127, 423);
            this.btnAciklamaGoster.Name = "btnAciklamaGoster";
            this.btnAciklamaGoster.Size = new System.Drawing.Size(162, 51);
            this.btnAciklamaGoster.TabIndex = 8;
            this.btnAciklamaGoster.Text = "Açıklama Göster";
            this.btnAciklamaGoster.UseVisualStyleBackColor = true;
            this.btnAciklamaGoster.Click += new System.EventHandler(this.btnAciklamaGoster_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(191, 358);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(66, 16);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 515);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.btnAciklamaGoster);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.cmbOdemeYontemi);
            this.Controls.Add(this.labelOdemeYontemi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKlasorSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelOdemeYontemi;
        private System.Windows.Forms.ComboBox cmbOdemeYontemi;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnAciklamaGoster;
        private System.Windows.Forms.Label lblAciklama;
    }
}

