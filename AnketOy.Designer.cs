namespace BMT110PROJE
{
    partial class AnketOy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnketOy));
            this.labelSoru = new System.Windows.Forms.Label();
            this.flowLayoutPanelSecenekler = new System.Windows.Forms.FlowLayoutPanel();
            this.OyVer = new System.Windows.Forms.Button();
            this.radioButtonAlfabetik = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.oyKaydedildi = new System.Windows.Forms.Label();
            this.labelSıralama = new System.Windows.Forms.Label();
            this.flowLayoutPanelYuzde = new System.Windows.Forms.FlowLayoutPanel();
            this.toplamOylabel = new System.Windows.Forms.Label();
            this.Toplam_Oy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoru.Location = new System.Drawing.Point(24, 30);
            this.labelSoru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(126, 54);
            this.labelSoru.TabIndex = 0;
            this.labelSoru.Text = "Soru";
            // 
            // flowLayoutPanelSecenekler
            // 
            this.flowLayoutPanelSecenekler.AutoScroll = true;
            this.flowLayoutPanelSecenekler.Location = new System.Drawing.Point(33, 86);
            this.flowLayoutPanelSecenekler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelSecenekler.Name = "flowLayoutPanelSecenekler";
            this.flowLayoutPanelSecenekler.Size = new System.Drawing.Size(280, 591);
            this.flowLayoutPanelSecenekler.TabIndex = 1;
            // 
            // OyVer
            // 
            this.OyVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OyVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OyVer.Location = new System.Drawing.Point(947, 410);
            this.OyVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OyVer.Name = "OyVer";
            this.OyVer.Size = new System.Drawing.Size(191, 105);
            this.OyVer.TabIndex = 2;
            this.OyVer.Text = "OY VER";
            this.OyVer.UseVisualStyleBackColor = true;
            this.OyVer.Click += new System.EventHandler(this.OyVer_Click);
            // 
            // radioButtonAlfabetik
            // 
            this.radioButtonAlfabetik.AutoSize = true;
            this.radioButtonAlfabetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonAlfabetik.Location = new System.Drawing.Point(947, 244);
            this.radioButtonAlfabetik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAlfabetik.Name = "radioButtonAlfabetik";
            this.radioButtonAlfabetik.Size = new System.Drawing.Size(210, 33);
            this.radioButtonAlfabetik.TabIndex = 4;
            this.radioButtonAlfabetik.TabStop = true;
            this.radioButtonAlfabetik.Text = "Alfabetik Sırala";
            this.radioButtonAlfabetik.UseVisualStyleBackColor = true;
            this.radioButtonAlfabetik.CheckedChanged += new System.EventHandler(this.radioButtonAlfabetik_CheckedChanged);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonNormal.Location = new System.Drawing.Point(947, 213);
            this.radioButtonNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(194, 33);
            this.radioButtonNormal.TabIndex = 5;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal Sırala";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // oyKaydedildi
            // 
            this.oyKaydedildi.AutoSize = true;
            this.oyKaydedildi.Location = new System.Drawing.Point(945, 532);
            this.oyKaydedildi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oyKaydedildi.Name = "oyKaydedildi";
            this.oyKaydedildi.Size = new System.Drawing.Size(15, 16);
            this.oyKaydedildi.TabIndex = 6;
            this.oyKaydedildi.Text = "--";
            this.oyKaydedildi.Visible = false;
            // 
            // labelSıralama
            // 
            this.labelSıralama.AutoSize = true;
            this.labelSıralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSıralama.Location = new System.Drawing.Point(944, 180);
            this.labelSıralama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSıralama.Name = "labelSıralama";
            this.labelSıralama.Size = new System.Drawing.Size(174, 29);
            this.labelSıralama.TabIndex = 3;
            this.labelSıralama.Text = "Sıralama türü:";
            // 
            // flowLayoutPanelYuzde
            // 
            this.flowLayoutPanelYuzde.Location = new System.Drawing.Point(320, 86);
            this.flowLayoutPanelYuzde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelYuzde.Name = "flowLayoutPanelYuzde";
            this.flowLayoutPanelYuzde.Size = new System.Drawing.Size(413, 591);
            this.flowLayoutPanelYuzde.TabIndex = 8;
            // 
            // toplamOylabel
            // 
            this.toplamOylabel.AutoSize = true;
            this.toplamOylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamOylabel.Location = new System.Drawing.Point(896, 652);
            this.toplamOylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamOylabel.Name = "toplamOylabel";
            this.toplamOylabel.Size = new System.Drawing.Size(76, 26);
            this.toplamOylabel.TabIndex = 9;
            this.toplamOylabel.Text = "label1";
            // 
            // Toplam_Oy
            // 
            this.Toplam_Oy.AutoSize = true;
            this.Toplam_Oy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Toplam_Oy.Location = new System.Drawing.Point(740, 652);
            this.Toplam_Oy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Toplam_Oy.Name = "Toplam_Oy";
            this.Toplam_Oy.Size = new System.Drawing.Size(141, 26);
            this.Toplam_Oy.TabIndex = 10;
            this.Toplam_Oy.Text = "Toplam Oy :";
            // 
            // AnketOy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1181, 703);
            this.Controls.Add(this.Toplam_Oy);
            this.Controls.Add(this.toplamOylabel);
            this.Controls.Add(this.flowLayoutPanelYuzde);
            this.Controls.Add(this.flowLayoutPanelSecenekler);
            this.Controls.Add(this.oyKaydedildi);
            this.Controls.Add(this.labelSoru);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.radioButtonAlfabetik);
            this.Controls.Add(this.labelSıralama);
            this.Controls.Add(this.OyVer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnketOy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnketOy";
            this.Load += new System.EventHandler(this.AnketOy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSecenekler;
        private System.Windows.Forms.Button OyVer;
        private System.Windows.Forms.RadioButton radioButtonAlfabetik;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Label oyKaydedildi;
        private System.Windows.Forms.Label labelSıralama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelYuzde;
        private System.Windows.Forms.Label toplamOylabel;
        private System.Windows.Forms.Label Toplam_Oy;
    }
}