namespace Pizzeria
{
    partial class DodatekForm
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

        private void InitializeComponent()
        {
            lblNazwa = new Label();
            txtNazwa = new TextBox();
            lblCena = new Label();
            nudCena = new NumericUpDown();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCena).BeginInit();
            SuspendLayout();

            lblNazwa.AutoSize = true;
            lblNazwa.Location = new Point(20, 15);
            lblNazwa.Name = "lblNazwa";
            lblNazwa.Size = new Size(41, 15);
            lblNazwa.TabIndex = 0;
            lblNazwa.Text = "Nazwa";

            txtNazwa.Location = new Point(20, 38);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(320, 23);
            txtNazwa.TabIndex = 1;

            lblCena.AutoSize = true;
            lblCena.Location = new Point(20, 80);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(55, 15);
            lblCena.TabIndex = 2;
            lblCena.Text = "Cena (zł)";

            nudCena.DecimalPlaces = 2;
            nudCena.Location = new Point(20, 103);
            nudCena.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCena.Name = "nudCena";
            nudCena.Size = new Size(150, 23);
            nudCena.TabIndex = 3;

            btnZapisz.Location = new Point(60, 160);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(100, 32);
            btnZapisz.TabIndex = 4;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;

            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(190, 160);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(100, 32);
            btnAnuluj.TabIndex = 5;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(364, 221);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(nudCena);
            Controls.Add(lblCena);
            Controls.Add(txtNazwa);
            Controls.Add(lblNazwa);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodatekForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodatek";
            ((System.ComponentModel.ISupportInitialize)nudCena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNazwa;
        private TextBox txtNazwa;
        private Label lblCena;
        private NumericUpDown nudCena;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}