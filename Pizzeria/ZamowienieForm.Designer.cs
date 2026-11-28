namespace Pizzeria
{
    partial class ZamowienieForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblKlient = new Label();
            cmbKlient = new ComboBox();
            lblTyp = new Label();
            cmbTyp = new ComboBox();
            panelWynos = new Panel();
            lblOdbior = new Label();
            dtpOdbior = new DateTimePicker();
            panelDostawa = new Panel();
            lblAdres = new Label();
            txtAdres = new TextBox();
            lblStrefa = new Label();
            cmbStrefa = new ComboBox();
            lblProdukt = new Label();
            cmbProdukt = new ComboBox();
            lblIlosc = new Label();
            nudIlosc = new NumericUpDown();
            btnDodajPozycje = new Button();
            lstPozycje = new ListBox();
            btnUsunPozycje = new Button();
            lblPodsumowanie = new Label();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            panelWynos.SuspendLayout();
            panelDostawa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIlosc).BeginInit();
            SuspendLayout();
            // 
            // lblKlient
            // 
            lblKlient.AutoSize = true;
            lblKlient.Location = new Point(20, 15);
            lblKlient.Name = "lblKlient";
            lblKlient.Size = new Size(37, 15);
            lblKlient.TabIndex = 0;
            lblKlient.Text = "Klient";
            // 
            // cmbKlient
            // 
            cmbKlient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKlient.FormattingEnabled = true;
            cmbKlient.Location = new Point(20, 38);
            cmbKlient.Name = "cmbKlient";
            cmbKlient.Size = new Size(440, 23);
            cmbKlient.TabIndex = 1;
            cmbKlient.SelectedIndexChanged += cmbKlient_SelectedIndexChanged;
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(20, 80);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(26, 15);
            lblTyp.TabIndex = 2;
            lblTyp.Text = "Typ";
            // 
            // cmbTyp
            // 
            cmbTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(20, 103);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(440, 23);
            cmbTyp.TabIndex = 3;
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
            // 
            // panelWynos
            // 
            panelWynos.Controls.Add(lblOdbior);
            panelWynos.Controls.Add(dtpOdbior);
            panelWynos.Location = new Point(20, 145);
            panelWynos.Name = "panelWynos";
            panelWynos.Size = new Size(440, 120);
            panelWynos.TabIndex = 4;
            // 
            // lblOdbior
            // 
            lblOdbior.AutoSize = true;
            lblOdbior.Location = new Point(0, 0);
            lblOdbior.Name = "lblOdbior";
            lblOdbior.Size = new Size(88, 15);
            lblOdbior.TabIndex = 0;
            lblOdbior.Text = "Godzina odbioru";
            // 
            // dtpOdbior
            // 
            dtpOdbior.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpOdbior.Format = DateTimePickerFormat.Custom;
            dtpOdbior.Location = new Point(0, 23);
            dtpOdbior.Name = "dtpOdbior";
            dtpOdbior.Size = new Size(200, 23);
            dtpOdbior.TabIndex = 1;
            // 
            // panelDostawa
            // 
            panelDostawa.Controls.Add(lblAdres);
            panelDostawa.Controls.Add(txtAdres);
            panelDostawa.Controls.Add(lblStrefa);
            panelDostawa.Controls.Add(cmbStrefa);
            panelDostawa.Location = new Point(20, 145);
            panelDostawa.Name = "panelDostawa";
            panelDostawa.Size = new Size(440, 120);
            panelDostawa.TabIndex = 5;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(0, 0);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(79, 15);
            lblAdres.TabIndex = 0;
            lblAdres.Text = "Adres dostawy";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(0, 23);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(440, 23);
            txtAdres.TabIndex = 1;
            // 
            // lblStrefa
            // 
            lblStrefa.AutoSize = true;
            lblStrefa.Location = new Point(0, 65);
            lblStrefa.Name = "lblStrefa";
            lblStrefa.Size = new Size(94, 15);
            lblStrefa.TabIndex = 2;
            lblStrefa.Text = "Strefa dostawy";
            // 
            // cmbStrefa
            // 
            cmbStrefa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStrefa.FormattingEnabled = true;
            cmbStrefa.Location = new Point(0, 88);
            cmbStrefa.Name = "cmbStrefa";
            cmbStrefa.Size = new Size(440, 23);
            cmbStrefa.TabIndex = 3;
            cmbStrefa.SelectedIndexChanged += cmbStrefa_SelectedIndexChanged;
            // 
            // lblProdukt
            // 
            lblProdukt.AutoSize = true;
            lblProdukt.Location = new Point(20, 285);
            lblProdukt.Name = "lblProdukt";
            lblProdukt.Size = new Size(47, 15);
            lblProdukt.TabIndex = 6;
            lblProdukt.Text = "Produkt";
            // 
            // cmbProdukt
            // 
            cmbProdukt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdukt.FormattingEnabled = true;
            cmbProdukt.Location = new Point(20, 308);
            cmbProdukt.Name = "cmbProdukt";
            cmbProdukt.Size = new Size(280, 23);
            cmbProdukt.TabIndex = 7;
            // 
            // lblIlosc
            // 
            lblIlosc.AutoSize = true;
            lblIlosc.Location = new Point(310, 285);
            lblIlosc.Name = "lblIlosc";
            lblIlosc.Size = new Size(33, 15);
            lblIlosc.TabIndex = 8;
            lblIlosc.Text = "Ilość";
            // 
            // nudIlosc
            // 
            nudIlosc.Location = new Point(310, 308);
            nudIlosc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudIlosc.Name = "nudIlosc";
            nudIlosc.Size = new Size(70, 23);
            nudIlosc.TabIndex = 9;
            nudIlosc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDodajPozycje
            // 
            btnDodajPozycje.Location = new Point(390, 305);
            btnDodajPozycje.Name = "btnDodajPozycje";
            btnDodajPozycje.Size = new Size(70, 28);
            btnDodajPozycje.TabIndex = 10;
            btnDodajPozycje.Text = "Dodaj";
            btnDodajPozycje.UseVisualStyleBackColor = true;
            btnDodajPozycje.Click += btnDodajPozycje_Click;
            // 
            // lstPozycje
            // 
            lstPozycje.FormattingEnabled = true;
            lstPozycje.Location = new Point(20, 345);
            lstPozycje.Name = "lstPozycje";
            lstPozycje.Size = new Size(440, 124);
            lstPozycje.TabIndex = 11;
            // 
            // btnUsunPozycje
            // 
            btnUsunPozycje.Location = new Point(20, 478);
            btnUsunPozycje.Name = "btnUsunPozycje";
            btnUsunPozycje.Size = new Size(140, 30);
            btnUsunPozycje.TabIndex = 12;
            btnUsunPozycje.Text = "Usuń pozycję";
            btnUsunPozycje.UseVisualStyleBackColor = true;
            btnUsunPozycje.Click += btnUsunPozycje_Click;
            // 
            // lblPodsumowanie
            // 
            lblPodsumowanie.Location = new Point(20, 520);
            lblPodsumowanie.Name = "lblPodsumowanie";
            lblPodsumowanie.Size = new Size(440, 80);
            lblPodsumowanie.TabIndex = 13;
            lblPodsumowanie.Text = "Podsumowanie";
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(110, 615);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(110, 32);
            btnZapisz.TabIndex = 14;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(260, 615);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(110, 32);
            btnAnuluj.TabIndex = 15;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // ZamowienieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(484, 666);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(lblPodsumowanie);
            Controls.Add(btnUsunPozycje);
            Controls.Add(lstPozycje);
            Controls.Add(btnDodajPozycje);
            Controls.Add(nudIlosc);
            Controls.Add(lblIlosc);
            Controls.Add(cmbProdukt);
            Controls.Add(lblProdukt);
            Controls.Add(panelDostawa);
            Controls.Add(panelWynos);
            Controls.Add(cmbTyp);
            Controls.Add(lblTyp);
            Controls.Add(cmbKlient);
            Controls.Add(lblKlient);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZamowienieForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nowe zamówienie";
            panelWynos.ResumeLayout(false);
            panelWynos.PerformLayout();
            panelDostawa.ResumeLayout(false);
            panelDostawa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIlosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKlient;
        private ComboBox cmbKlient;
        private Label lblTyp;
        private ComboBox cmbTyp;
        private Panel panelWynos;
        private Label lblOdbior;
        private DateTimePicker dtpOdbior;
        private Panel panelDostawa;
        private Label lblAdres;
        private TextBox txtAdres;
        private Label lblStrefa;
        private ComboBox cmbStrefa;
        private Label lblProdukt;
        private ComboBox cmbProdukt;
        private Label lblIlosc;
        private NumericUpDown nudIlosc;
        private Button btnDodajPozycje;
        private ListBox lstPozycje;
        private Button btnUsunPozycje;
        private Label lblPodsumowanie;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}