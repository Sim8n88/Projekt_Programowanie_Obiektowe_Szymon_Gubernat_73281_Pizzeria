namespace Pizzeria
{
    partial class StrefaForm
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
            lblKoszt = new Label();
            nudKoszt = new NumericUpDown();
            lblMinimalna = new Label();
            nudMinimalna = new NumericUpDown();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            ((System.ComponentModel.ISupportInitialize)nudKoszt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimalna).BeginInit();
            SuspendLayout();
            // 
            // lblNazwa
            // 
            lblNazwa.AutoSize = true;
            lblNazwa.Location = new Point(23, 20);
            lblNazwa.Name = "lblNazwa";
            lblNazwa.Size = new Size(54, 20);
            lblNazwa.TabIndex = 0;
            lblNazwa.Text = "Nazwa";
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(23, 51);
            txtNazwa.Margin = new Padding(3, 4, 3, 4);
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(365, 27);
            txtNazwa.TabIndex = 1;
            // 
            // lblKoszt
            // 
            lblKoszt.AutoSize = true;
            lblKoszt.Location = new Point(23, 107);
            lblKoszt.Name = "lblKoszt";
            lblKoszt.Size = new Size(127, 20);
            lblKoszt.TabIndex = 2;
            lblKoszt.Text = "Koszt dowozu (zł)";
            // 
            // nudKoszt
            // 
            nudKoszt.DecimalPlaces = 2;
            nudKoszt.Location = new Point(23, 137);
            nudKoszt.Margin = new Padding(3, 4, 3, 4);
            nudKoszt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudKoszt.Name = "nudKoszt";
            nudKoszt.Size = new Size(171, 27);
            nudKoszt.TabIndex = 3;
            // 
            // lblMinimalna
            // 
            lblMinimalna.AutoSize = true;
            lblMinimalna.Location = new Point(23, 193);
            lblMinimalna.Name = "lblMinimalna";
            lblMinimalna.Size = new Size(148, 20);
            lblMinimalna.TabIndex = 4;
            lblMinimalna.Text = "Minimalna kwota (zł)";
            // 
            // nudMinimalna
            // 
            nudMinimalna.DecimalPlaces = 2;
            nudMinimalna.Location = new Point(23, 224);
            nudMinimalna.Margin = new Padding(3, 4, 3, 4);
            nudMinimalna.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMinimalna.Name = "nudMinimalna";
            nudMinimalna.Size = new Size(171, 27);
            nudMinimalna.TabIndex = 5;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(69, 293);
            btnZapisz.Margin = new Padding(3, 4, 3, 4);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(114, 43);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.DialogResult = DialogResult.Cancel;
            btnAnuluj.Location = new Point(217, 293);
            btnAnuluj.Margin = new Padding(3, 4, 3, 4);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(114, 43);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // StrefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(416, 375);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(nudMinimalna);
            Controls.Add(lblMinimalna);
            Controls.Add(nudKoszt);
            Controls.Add(lblKoszt);
            Controls.Add(txtNazwa);
            Controls.Add(lblNazwa);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StrefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Strefa dostawy";
            ((System.ComponentModel.ISupportInitialize)nudKoszt).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimalna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNazwa;
        private TextBox txtNazwa;
        private Label lblKoszt;
        private NumericUpDown nudKoszt;
        private Label lblMinimalna;
        private NumericUpDown nudMinimalna;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}