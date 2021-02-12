namespace rss_reader
{
    partial class RSS_TekHaber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.RichTextBox();
            this.link_lbl_url = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_index = new System.Windows.Forms.Label();
            this.pic_gorsel = new System.Windows.Forms.PictureBox();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_baslik.Location = new System.Drawing.Point(70, 10);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(56, 19);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Baslık";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_aciklama.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.Location = new System.Drawing.Point(242, 37);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(752, 125);
            this.txt_aciklama.TabIndex = 1;
            this.txt_aciklama.Text = "";
            // 
            // link_lbl_url
            // 
            this.link_lbl_url.AutoSize = true;
            this.link_lbl_url.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.link_lbl_url.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.link_lbl_url.Location = new System.Drawing.Point(239, 170);
            this.link_lbl_url.Name = "link_lbl_url";
            this.link_lbl_url.Size = new System.Drawing.Size(16, 15);
            this.link_lbl_url.TabIndex = 2;
            this.link_lbl_url.TabStop = true;
            this.link_lbl_url.Text = "...";
            this.link_lbl_url.VisitedLinkColor = System.Drawing.Color.DeepPink;
            this.link_lbl_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_url_LinkClicked);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 190);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(50, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 200);
            this.label2.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_index.Location = new System.Drawing.Point(10, 85);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(31, 19);
            this.lbl_index.TabIndex = 6;
            this.lbl_index.Text = "99.";
            // 
            // pic_gorsel
            // 
            this.pic_gorsel.Location = new System.Drawing.Point(74, 50);
            this.pic_gorsel.Name = "pic_gorsel";
            this.pic_gorsel.Size = new System.Drawing.Size(162, 99);
            this.pic_gorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_gorsel.TabIndex = 7;
            this.pic_gorsel.TabStop = false;
            this.pic_gorsel.DoubleClick += new System.EventHandler(this.pic_gorsel_DoubleClick);
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tarih.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Tarih.Location = new System.Drawing.Point(71, 171);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(16, 14);
            this.lbl_Tarih.TabIndex = 8;
            this.lbl_Tarih.Text = "...";
            // 
            // RSS_TekHaber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.pic_gorsel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_lbl_url);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.label1);
            this.Name = "RSS_TekHaber";
            this.Size = new System.Drawing.Size(1015, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pic_gorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_baslik;
        public System.Windows.Forms.RichTextBox txt_aciklama;
        public System.Windows.Forms.LinkLabel link_lbl_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label lbl_index;
        public System.Windows.Forms.Label lbl_Tarih;
        public System.Windows.Forms.PictureBox pic_gorsel;
    }
}
