namespace Pizzeria
{
    partial class KlientForm
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
            lblImie = new Label();
            txtImie = new TextBox();
            lblNazwisko = new Label();
            txtNazwisko = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblAdres = new Label();
            txtAdres = new TextBox();
            chkStaly = new CheckBox();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(20, 15);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(30, 15);
            lblImie.TabIndex = 0;
            lblImie.Text = "Imię";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(20, 38);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(320, 23);
            txtImie.TabIndex = 1;
            // 
            // lblNazwisko
            // 
            lblNazwisko.AutoSize = true;
            lblNazwisko.Location = new Point(20, 80);
            lblNazwisko.Name = "lblNazwisko";
            lblNazwisko.Size = new Size(57, 15);
            lblNazwisko.TabIndex = 2;
            lblNazwisko.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(20, 103);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(320, 23);
            txtNazwisko.TabIndex = 3;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(20, 145);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(46, 15);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(20, 168);
            txtTelefon.MaxLength = 9;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(320, 23);
            txtTelefon.TabIndex = 5;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(20, 210);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(38, 15);
            lblAdres.TabIndex = 6;
            lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(20, 233);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(320, 23);
            txtAdres.TabIndex = 7;
            // 
            // chkStaly
            // 
            chkStaly.AutoSize = true;
            chkStaly.Location = new Point(20, 275);
            chkStaly.Name = "chkStaly";
            chkStaly.Size = new Size(89, 19);
            chkStaly.TabIndex = 8;
            chkStaly.Text = "Stały klient";
            chkStaly.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(60, 320);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(100, 32);
            btnZapisz.TabIndex = 9;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(190, 320);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(100, 32);
            btnAnuluj.TabIndex = 10;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // KlientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(364, 381);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(chkStaly);
            Controls.Add(txtAdres);
            Controls.Add(lblAdres);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtNazwisko);
            Controls.Add(lblNazwisko);
            Controls.Add(txtImie);
            Controls.Add(lblImie);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KlientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Klient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImie;
        private TextBox txtImie;
        private Label lblNazwisko;
        private TextBox txtNazwisko;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblAdres;
        private TextBox txtAdres;
        private CheckBox chkStaly;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}