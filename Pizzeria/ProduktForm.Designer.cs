namespace Pizzeria
{
    partial class ProduktForm
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
            lblTyp = new Label();
            cmbTyp = new ComboBox();
            lblNazwa = new Label();
            txtNazwa = new TextBox();
            lblCena = new Label();
            nudCena = new NumericUpDown();
            panelPizza = new Panel();
            lblRozmiar = new Label();
            cmbRozmiar = new ComboBox();
            lblDodatki = new Label();
            clbDodatki = new CheckedListBox();
            panelNapoj = new Panel();
            lblPojemnosc = new Label();
            nudPojemnosc = new NumericUpDown();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCena).BeginInit();
            panelPizza.SuspendLayout();
            panelNapoj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPojemnosc).BeginInit();
            SuspendLayout();
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(20, 15);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(26, 15);
            lblTyp.TabIndex = 0;
            lblTyp.Text = "Typ";
            // 
            // cmbTyp
            // 
            cmbTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(20, 38);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(320, 23);
            cmbTyp.TabIndex = 1;
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
            // 
            // lblNazwa
            // 
            lblNazwa.AutoSize = true;
            lblNazwa.Location = new Point(20, 80);
            lblNazwa.Name = "lblNazwa";
            lblNazwa.Size = new Size(41, 15);
            lblNazwa.TabIndex = 2;
            lblNazwa.Text = "Nazwa";
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(20, 103);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(320, 23);
            txtNazwa.TabIndex = 3;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(20, 145);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(98, 15);
            lblCena.TabIndex = 4;
            lblCena.Text = "Cena bazowa (zł)";
            // 
            // nudCena
            // 
            nudCena.DecimalPlaces = 2;
            nudCena.Location = new Point(20, 168);
            nudCena.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCena.Name = "nudCena";
            nudCena.Size = new Size(150, 23);
            nudCena.TabIndex = 5;
            // 
            // panelPizza
            // 
            panelPizza.Controls.Add(lblRozmiar);
            panelPizza.Controls.Add(cmbRozmiar);
            panelPizza.Controls.Add(lblDodatki);
            panelPizza.Controls.Add(clbDodatki);
            panelPizza.Location = new Point(20, 210);
            panelPizza.Name = "panelPizza";
            panelPizza.Size = new Size(320, 190);
            panelPizza.TabIndex = 6;
            // 
            // lblRozmiar
            // 
            lblRozmiar.AutoSize = true;
            lblRozmiar.Location = new Point(0, 0);
            lblRozmiar.Name = "lblRozmiar";
            lblRozmiar.Size = new Size(49, 15);
            lblRozmiar.TabIndex = 0;
            lblRozmiar.Text = "Rozmiar";
            // 
            // cmbRozmiar
            // 
            cmbRozmiar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRozmiar.FormattingEnabled = true;
            cmbRozmiar.Location = new Point(0, 23);
            cmbRozmiar.Name = "cmbRozmiar";
            cmbRozmiar.Size = new Size(320, 23);
            cmbRozmiar.TabIndex = 1;
            // 
            // lblDodatki
            // 
            lblDodatki.AutoSize = true;
            lblDodatki.Location = new Point(0, 62);
            lblDodatki.Name = "lblDodatki";
            lblDodatki.Size = new Size(124, 15);
            lblDodatki.TabIndex = 2;
            lblDodatki.Text = "Dodatki (maksymalnie 5)";
            // 
            // clbDodatki
            // 
            clbDodatki.CheckOnClick = true;
            clbDodatki.FormattingEnabled = true;
            clbDodatki.IntegralHeight = false;
            clbDodatki.Location = new Point(0, 85);
            clbDodatki.Name = "clbDodatki";
            clbDodatki.Size = new Size(320, 100);
            clbDodatki.TabIndex = 3;
            // 
            // panelNapoj
            // 
            panelNapoj.Controls.Add(lblPojemnosc);
            panelNapoj.Controls.Add(nudPojemnosc);
            panelNapoj.Location = new Point(20, 210);
            panelNapoj.Name = "panelNapoj";
            panelNapoj.Size = new Size(320, 70);
            panelNapoj.TabIndex = 7;
            // 
            // lblPojemnosc
            // 
            lblPojemnosc.AutoSize = true;
            lblPojemnosc.Location = new Point(0, 0);
            lblPojemnosc.Name = "lblPojemnosc";
            lblPojemnosc.Size = new Size(92, 15);
            lblPojemnosc.TabIndex = 0;
            lblPojemnosc.Text = "Pojemność (ml)";
            // 
            // nudPojemnosc
            // 
            nudPojemnosc.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudPojemnosc.Location = new Point(0, 23);
            nudPojemnosc.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPojemnosc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPojemnosc.Name = "nudPojemnosc";
            nudPojemnosc.Size = new Size(150, 23);
            nudPojemnosc.TabIndex = 1;
            nudPojemnosc.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(60, 420);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(100, 32);
            btnZapisz.TabIndex = 8;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(190, 420);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(100, 32);
            btnAnuluj.TabIndex = 9;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // ProduktForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(364, 471);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(panelNapoj);
            Controls.Add(panelPizza);
            Controls.Add(nudCena);
            Controls.Add(lblCena);
            Controls.Add(txtNazwa);
            Controls.Add(lblNazwa);
            Controls.Add(cmbTyp);
            Controls.Add(lblTyp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProduktForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produkt";
            ((System.ComponentModel.ISupportInitialize)nudCena).EndInit();
            panelPizza.ResumeLayout(false);
            panelPizza.PerformLayout();
            panelNapoj.ResumeLayout(false);
            panelNapoj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPojemnosc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTyp;
        private ComboBox cmbTyp;
        private Label lblNazwa;
        private TextBox txtNazwa;
        private Label lblCena;
        private NumericUpDown nudCena;
        private Panel panelPizza;
        private Label lblRozmiar;
        private ComboBox cmbRozmiar;
        private Label lblDodatki;
        private CheckedListBox clbDodatki;
        private Panel panelNapoj;
        private Label lblPojemnosc;
        private NumericUpDown nudPojemnosc;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}