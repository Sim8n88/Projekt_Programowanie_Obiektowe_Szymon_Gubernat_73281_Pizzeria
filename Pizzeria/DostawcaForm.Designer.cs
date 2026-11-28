namespace Pizzeria
{
    partial class DostawcaForm
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
            lblPojazd = new Label();
            txtPojazd = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
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
            // lblPojazd
            // 
            lblPojazd.AutoSize = true;
            lblPojazd.Location = new Point(20, 210);
            lblPojazd.Name = "lblPojazd";
            lblPojazd.Size = new Size(45, 15);
            lblPojazd.TabIndex = 6;
            lblPojazd.Text = "Pojazd";
            // 
            // txtPojazd
            // 
            txtPojazd.Location = new Point(20, 233);
            txtPojazd.Name = "txtPojazd";
            txtPojazd.Size = new Size(320, 23);
            txtPojazd.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 275);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(20, 298);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(320, 23);
            cmbStatus.TabIndex = 9;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(60, 345);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(100, 32);
            btnZapisz.TabIndex = 10;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(190, 345);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(100, 32);
            btnAnuluj.TabIndex = 11;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // DostawcaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(364, 406);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtPojazd);
            Controls.Add(lblPojazd);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtNazwisko);
            Controls.Add(lblNazwisko);
            Controls.Add(txtImie);
            Controls.Add(lblImie);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DostawcaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dostawca";
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
        private Label lblPojazd;
        private TextBox txtPojazd;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}