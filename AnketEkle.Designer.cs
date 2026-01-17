namespace BMT110PROJE
{
    partial class AnketEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnketEkle));
            this.labelAnket = new System.Windows.Forms.Label();
            this.labelAnketSoru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoru = new System.Windows.Forms.TextBox();
            this.textBoxSecenek = new System.Windows.Forms.TextBox();
            this.labelSecenek = new System.Windows.Forms.Label();
            this.listBoxSecenek = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelKayitliSecenek = new System.Windows.Forms.Label();
            this.secenekEkleButon = new System.Windows.Forms.Button();
            this.anketKaydetButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnket
            // 
            this.labelAnket.AutoSize = true;
            this.labelAnket.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnket.Location = new System.Drawing.Point(320, 26);
            this.labelAnket.Name = "labelAnket";
            this.labelAnket.Size = new System.Drawing.Size(133, 51);
            this.labelAnket.TabIndex = 0;
            this.labelAnket.Text = "Anket";
            // 
            // labelAnketSoru
            // 
            this.labelAnketSoru.AutoSize = true;
            this.labelAnketSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnketSoru.Location = new System.Drawing.Point(163, 101);
            this.labelAnketSoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnketSoru.Name = "labelAnketSoru";
            this.labelAnketSoru.Size = new System.Drawing.Size(150, 25);
            this.labelAnketSoru.TabIndex = 1;
            this.labelAnketSoru.Text = "Anket Sorusu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // textBoxSoru
            // 
            this.textBoxSoru.Location = new System.Drawing.Point(328, 101);
            this.textBoxSoru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSoru.Name = "textBoxSoru";
            this.textBoxSoru.Size = new System.Drawing.Size(132, 22);
            this.textBoxSoru.TabIndex = 3;
            this.textBoxSoru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterabasma_soru);
            // 
            // textBoxSecenek
            // 
            this.textBoxSecenek.Location = new System.Drawing.Point(328, 165);
            this.textBoxSecenek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSecenek.Name = "textBoxSecenek";
            this.textBoxSecenek.Size = new System.Drawing.Size(132, 22);
            this.textBoxSecenek.TabIndex = 4;
            this.textBoxSecenek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterabasma_secenek);
            // 
            // labelSecenek
            // 
            this.labelSecenek.AutoSize = true;
            this.labelSecenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSecenek.Location = new System.Drawing.Point(215, 165);
            this.labelSecenek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecenek.Name = "labelSecenek";
            this.labelSecenek.Size = new System.Drawing.Size(104, 25);
            this.labelSecenek.TabIndex = 5;
            this.labelSecenek.Text = "Seçenek:";
            // 
            // listBoxSecenek
            // 
            this.listBoxSecenek.FormattingEnabled = true;
            this.listBoxSecenek.ItemHeight = 16;
            this.listBoxSecenek.Location = new System.Drawing.Point(279, 231);
            this.listBoxSecenek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSecenek.Name = "listBoxSecenek";
            this.listBoxSecenek.Size = new System.Drawing.Size(212, 196);
            this.listBoxSecenek.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelKayitliSecenek
            // 
            this.labelKayitliSecenek.AutoSize = true;
            this.labelKayitliSecenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayitliSecenek.Location = new System.Drawing.Point(63, 231);
            this.labelKayitliSecenek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKayitliSecenek.Name = "labelKayitliSecenek";
            this.labelKayitliSecenek.Size = new System.Drawing.Size(193, 25);
            this.labelKayitliSecenek.TabIndex = 8;
            this.labelKayitliSecenek.Text = "Kayıtlı Seçenekler:";
            // 
            // secenekEkleButon
            // 
            this.secenekEkleButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secenekEkleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secenekEkleButon.Location = new System.Drawing.Point(469, 161);
            this.secenekEkleButon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secenekEkleButon.Name = "secenekEkleButon";
            this.secenekEkleButon.Size = new System.Drawing.Size(128, 30);
            this.secenekEkleButon.TabIndex = 5;
            this.secenekEkleButon.Text = "Ekle";
            this.secenekEkleButon.UseVisualStyleBackColor = true;
            this.secenekEkleButon.Click += new System.EventHandler(this.SecenegiKaydetButonu);
            // 
            // anketKaydetButon
            // 
            this.anketKaydetButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anketKaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anketKaydetButon.Location = new System.Drawing.Point(500, 278);
            this.anketKaydetButon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anketKaydetButon.Name = "anketKaydetButon";
            this.anketKaydetButon.Size = new System.Drawing.Size(173, 79);
            this.anketKaydetButon.TabIndex = 9;
            this.anketKaydetButon.Text = "Anketi Kaydet";
            this.anketKaydetButon.UseVisualStyleBackColor = true;
            this.anketKaydetButon.Click += new System.EventHandler(this.anketKaydetButon_Click);
            // 
            // AnketEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anketKaydetButon);
            this.Controls.Add(this.secenekEkleButon);
            this.Controls.Add(this.labelKayitliSecenek);
            this.Controls.Add(this.listBoxSecenek);
            this.Controls.Add(this.labelSecenek);
            this.Controls.Add(this.textBoxSecenek);
            this.Controls.Add(this.textBoxSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAnketSoru);
            this.Controls.Add(this.labelAnket);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnketEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnketEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnket;
        private System.Windows.Forms.Label labelAnketSoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoru;
        private System.Windows.Forms.TextBox textBoxSecenek;
        private System.Windows.Forms.Label labelSecenek;
        private System.Windows.Forms.ListBox listBoxSecenek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelKayitliSecenek;
        private System.Windows.Forms.Button secenekEkleButon;
        private System.Windows.Forms.Button anketKaydetButon;
    }
}