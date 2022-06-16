namespace IP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResimEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PictureBoxSol = new System.Windows.Forms.PictureBox();
            this.PictureBoxSag = new System.Windows.Forms.PictureBox();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griTonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eşiklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EsiklemeButton = new System.Windows.Forms.Button();
            this.KarsitlikButton = new System.Windows.Forms.Button();
            this.karşıtlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometrikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taşımaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TasimaButton = new System.Windows.Forms.Button();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AynalamaButton = new System.Windows.Forms.Button();
            this.bulanıklaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeanFiltresiButton = new System.Windows.Forms.Button();
            this.medyanFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedyanFiltresi = new System.Windows.Forms.Button();
            this.gausFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenarBelirlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertCrossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSag)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkToolStripMenuItem,
            this.geometrikToolStripMenuItem,
            this.bulanıklaştırmaToolStripMenuItem,
            this.kenarBelirlemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResimEkle,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // ResimEkle
            // 
            this.ResimEkle.Name = "ResimEkle";
            this.ResimEkle.Size = new System.Drawing.Size(180, 22);
            this.ResimEkle.Text = "Resim Ekle";
            this.ResimEkle.Click += new System.EventHandler(this.ResimEkle_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // PictureBoxSol
            // 
            this.PictureBoxSol.Location = new System.Drawing.Point(12, 27);
            this.PictureBoxSol.Name = "PictureBoxSol";
            this.PictureBoxSol.Size = new System.Drawing.Size(400, 300);
            this.PictureBoxSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxSol.TabIndex = 1;
            this.PictureBoxSol.TabStop = false;
            // 
            // PictureBoxSag
            // 
            this.PictureBoxSag.Location = new System.Drawing.Point(451, 27);
            this.PictureBoxSag.Name = "PictureBoxSag";
            this.PictureBoxSag.Size = new System.Drawing.Size(400, 300);
            this.PictureBoxSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxSag.TabIndex = 2;
            this.PictureBoxSag.TabStop = false;
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negatifToolStripMenuItem,
            this.griTonToolStripMenuItem,
            this.parlaklıkToolStripMenuItem,
            this.eşiklemeToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.karşıtlıkToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.Negatif_Click);
            // 
            // griTonToolStripMenuItem
            // 
            this.griTonToolStripMenuItem.Name = "griTonToolStripMenuItem";
            this.griTonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.griTonToolStripMenuItem.Text = "Gri Ton";
            this.griTonToolStripMenuItem.Click += new System.EventHandler(this.Gri_Ton_Click);
            // 
            // parlaklıkToolStripMenuItem
            // 
            this.parlaklıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arttırToolStripMenuItem,
            this.azaltToolStripMenuItem});
            this.parlaklıkToolStripMenuItem.Name = "parlaklıkToolStripMenuItem";
            this.parlaklıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parlaklıkToolStripMenuItem.Text = "Parlaklık";
            // 
            // arttırToolStripMenuItem
            // 
            this.arttırToolStripMenuItem.Name = "arttırToolStripMenuItem";
            this.arttırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arttırToolStripMenuItem.Text = "Arttır";
            this.arttırToolStripMenuItem.Click += new System.EventHandler(this.Parlaklik_Arttır_Click);
            // 
            // azaltToolStripMenuItem
            // 
            this.azaltToolStripMenuItem.Name = "azaltToolStripMenuItem";
            this.azaltToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azaltToolStripMenuItem.Text = "Azalt";
            this.azaltToolStripMenuItem.Click += new System.EventHandler(this.Parlaklik_Azalt_Click);
            // 
            // eşiklemeToolStripMenuItem
            // 
            this.eşiklemeToolStripMenuItem.Name = "eşiklemeToolStripMenuItem";
            this.eşiklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eşiklemeToolStripMenuItem.Text = "Eşikleme";
            this.eşiklemeToolStripMenuItem.Click += new System.EventHandler(this.Esikleme_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(857, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 303);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Değer Giriniz:";
            this.label1.Visible = false;
            // 
            // EsiklemeButton
            // 
            this.EsiklemeButton.Location = new System.Drawing.Point(213, 344);
            this.EsiklemeButton.Name = "EsiklemeButton";
            this.EsiklemeButton.Size = new System.Drawing.Size(75, 23);
            this.EsiklemeButton.TabIndex = 6;
            this.EsiklemeButton.Text = "Uygula";
            this.EsiklemeButton.UseVisualStyleBackColor = true;
            this.EsiklemeButton.Visible = false;
            this.EsiklemeButton.Click += new System.EventHandler(this.EsiklemeButton_Click);
            // 
            // KarsitlikButton
            // 
            this.KarsitlikButton.Location = new System.Drawing.Point(213, 346);
            this.KarsitlikButton.Name = "KarsitlikButton";
            this.KarsitlikButton.Size = new System.Drawing.Size(75, 23);
            this.KarsitlikButton.TabIndex = 7;
            this.KarsitlikButton.Text = "Uygula";
            this.KarsitlikButton.UseVisualStyleBackColor = true;
            this.KarsitlikButton.Visible = false;
            this.KarsitlikButton.Click += new System.EventHandler(this.KarsitlikButton_Click);
            // 
            // karşıtlıkToolStripMenuItem
            // 
            this.karşıtlıkToolStripMenuItem.Name = "karşıtlıkToolStripMenuItem";
            this.karşıtlıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.karşıtlıkToolStripMenuItem.Text = "Karşıtlık";
            this.karşıtlıkToolStripMenuItem.Click += new System.EventHandler(this.Karsitlik_Click);
            // 
            // geometrikToolStripMenuItem
            // 
            this.geometrikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taşımaToolStripMenuItem,
            this.aynalamaToolStripMenuItem});
            this.geometrikToolStripMenuItem.Name = "geometrikToolStripMenuItem";
            this.geometrikToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.geometrikToolStripMenuItem.Text = "Geometrik";
            // 
            // taşımaToolStripMenuItem
            // 
            this.taşımaToolStripMenuItem.Name = "taşımaToolStripMenuItem";
            this.taşımaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taşımaToolStripMenuItem.Text = "Taşıma";
            this.taşımaToolStripMenuItem.Click += new System.EventHandler(this.Tasima_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 351);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // TasimaButton
            // 
            this.TasimaButton.Location = new System.Drawing.Point(340, 344);
            this.TasimaButton.Name = "TasimaButton";
            this.TasimaButton.Size = new System.Drawing.Size(75, 23);
            this.TasimaButton.TabIndex = 9;
            this.TasimaButton.Text = "Taşı";
            this.TasimaButton.UseVisualStyleBackColor = true;
            this.TasimaButton.Visible = false;
            this.TasimaButton.Click += new System.EventHandler(this.TasimaButton_Click);
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.Aynalama_Click);
            // 
            // AynalamaButton
            // 
            this.AynalamaButton.Location = new System.Drawing.Point(213, 344);
            this.AynalamaButton.Name = "AynalamaButton";
            this.AynalamaButton.Size = new System.Drawing.Size(75, 23);
            this.AynalamaButton.TabIndex = 10;
            this.AynalamaButton.Text = "Uygula";
            this.AynalamaButton.UseVisualStyleBackColor = true;
            this.AynalamaButton.Visible = false;
            this.AynalamaButton.Click += new System.EventHandler(this.AynalamaButton_Click);
            // 
            // bulanıklaştırmaToolStripMenuItem
            // 
            this.bulanıklaştırmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanFiltresiToolStripMenuItem,
            this.medyanFiltresiToolStripMenuItem,
            this.gausFiltresiToolStripMenuItem});
            this.bulanıklaştırmaToolStripMenuItem.Name = "bulanıklaştırmaToolStripMenuItem";
            this.bulanıklaştırmaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.bulanıklaştırmaToolStripMenuItem.Text = "Bulanıklaştırma";
            // 
            // meanFiltresiToolStripMenuItem
            // 
            this.meanFiltresiToolStripMenuItem.Name = "meanFiltresiToolStripMenuItem";
            this.meanFiltresiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meanFiltresiToolStripMenuItem.Text = "Mean Filtresi";
            this.meanFiltresiToolStripMenuItem.Click += new System.EventHandler(this.MeanFiltresi_Click);
            // 
            // MeanFiltresiButton
            // 
            this.MeanFiltresiButton.Location = new System.Drawing.Point(213, 346);
            this.MeanFiltresiButton.Name = "MeanFiltresiButton";
            this.MeanFiltresiButton.Size = new System.Drawing.Size(75, 23);
            this.MeanFiltresiButton.TabIndex = 11;
            this.MeanFiltresiButton.Text = "Uygula";
            this.MeanFiltresiButton.UseVisualStyleBackColor = true;
            this.MeanFiltresiButton.Visible = false;
            this.MeanFiltresiButton.Click += new System.EventHandler(this.MeanFiltresiButton_Click);
            // 
            // medyanFiltresiToolStripMenuItem
            // 
            this.medyanFiltresiToolStripMenuItem.Name = "medyanFiltresiToolStripMenuItem";
            this.medyanFiltresiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medyanFiltresiToolStripMenuItem.Text = "Medyan Filtresi";
            this.medyanFiltresiToolStripMenuItem.Click += new System.EventHandler(this.Medyan_Filtresi_Click);
            // 
            // MedyanFiltresi
            // 
            this.MedyanFiltresi.Location = new System.Drawing.Point(213, 348);
            this.MedyanFiltresi.Name = "MedyanFiltresi";
            this.MedyanFiltresi.Size = new System.Drawing.Size(75, 23);
            this.MedyanFiltresi.TabIndex = 12;
            this.MedyanFiltresi.Text = "Uygula";
            this.MedyanFiltresi.UseVisualStyleBackColor = true;
            this.MedyanFiltresi.Visible = false;
            this.MedyanFiltresi.Click += new System.EventHandler(this.MedyannFiltresi_Button_Click);
            // 
            // gausFiltresiToolStripMenuItem
            // 
            this.gausFiltresiToolStripMenuItem.Name = "gausFiltresiToolStripMenuItem";
            this.gausFiltresiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gausFiltresiToolStripMenuItem.Text = "Gaus Filtresi";
            this.gausFiltresiToolStripMenuItem.Click += new System.EventHandler(this.GausFiltresiClick);
            // 
            // kenarBelirlemeToolStripMenuItem
            // 
            this.kenarBelirlemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelMaskToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.robertCrossToolStripMenuItem});
            this.kenarBelirlemeToolStripMenuItem.Name = "kenarBelirlemeToolStripMenuItem";
            this.kenarBelirlemeToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.kenarBelirlemeToolStripMenuItem.Text = "Kenar Belirleme";
            // 
            // sobelMaskToolStripMenuItem
            // 
            this.sobelMaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xYToolStripMenuItem,
            this.xToolStripMenuItem,
            this.yToolStripMenuItem});
            this.sobelMaskToolStripMenuItem.Name = "sobelMaskToolStripMenuItem";
            this.sobelMaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobelMaskToolStripMenuItem.Text = "Sobel Mask";
            // 
            // xYToolStripMenuItem
            // 
            this.xYToolStripMenuItem.Name = "xYToolStripMenuItem";
            this.xYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xYToolStripMenuItem.Text = "XY";
            this.xYToolStripMenuItem.Click += new System.EventHandler(this.xYToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yToolStripMenuItem.Text = "Y";
            this.yToolStripMenuItem.Click += new System.EventHandler(this.yToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.prewittToolStripMenuItem_Click);
            // 
            // robertCrossToolStripMenuItem
            // 
            this.robertCrossToolStripMenuItem.Name = "robertCrossToolStripMenuItem";
            this.robertCrossToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.robertCrossToolStripMenuItem.Text = "Robert Cross";
            this.robertCrossToolStripMenuItem.Click += new System.EventHandler(this.robertCrossToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 392);
            this.Controls.Add(this.MedyanFiltresi);
            this.Controls.Add(this.MeanFiltresiButton);
            this.Controls.Add(this.AynalamaButton);
            this.Controls.Add(this.TasimaButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.KarsitlikButton);
            this.Controls.Add(this.EsiklemeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PictureBoxSag);
            this.Controls.Add(this.PictureBoxSol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox PictureBoxSol;
        private System.Windows.Forms.PictureBox PictureBoxSag;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griTonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eşiklemeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EsiklemeButton;
        private System.Windows.Forms.Button KarsitlikButton;
        private System.Windows.Forms.ToolStripMenuItem karşıtlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometrikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taşımaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TasimaButton;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.Button AynalamaButton;
        private System.Windows.Forms.ToolStripMenuItem bulanıklaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFiltresiToolStripMenuItem;
        private System.Windows.Forms.Button MeanFiltresiButton;
        private System.Windows.Forms.ToolStripMenuItem medyanFiltresiToolStripMenuItem;
        private System.Windows.Forms.Button MedyanFiltresi;
        private System.Windows.Forms.ToolStripMenuItem gausFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kenarBelirlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertCrossToolStripMenuItem;
    }
}

