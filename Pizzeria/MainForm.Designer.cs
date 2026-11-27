namespace Pizzeria
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvKlienci = new DataGridView();
            panelKlienci = new Panel();
            btnUsunKlienta = new Button();
            btnEdytujKlienta = new Button();
            btnDodajKlienta = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            dgvDodatki = new DataGridView();
            panelDodatki = new Panel();
            btnUsunDodatek = new Button();
            btnEdytujDodatek = new Button();
            btnDodajDodatek = new Button();
            tabPage6 = new TabPage();
            dgvStrefy = new DataGridView();
            panelPrzyciski = new Panel();
            btnUsunStrefe = new Button();
            btnEdytujStrefe = new Button();
            btnDodajStrefe = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlienci).BeginInit();
            panelKlienci.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDodatki).BeginInit();
            panelDodatki.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStrefy).BeginInit();
            panelPrzyciski.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 553);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Zamówienia";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvKlienci);
            tabPage2.Controls.Add(panelKlienci);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(974, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Klienci";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKlienci
            // 
            dgvKlienci.AllowUserToAddRows = false;
            dgvKlienci.AllowUserToDeleteRows = false;
            dgvKlienci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKlienci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlienci.Dock = DockStyle.Fill;
            dgvKlienci.Location = new Point(3, 3);
            dgvKlienci.MultiSelect = false;
            dgvKlienci.Name = "dgvKlienci";
            dgvKlienci.ReadOnly = true;
            dgvKlienci.RowHeadersWidth = 51;
            dgvKlienci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKlienci.Size = new Size(968, 464);
            dgvKlienci.TabIndex = 1;
            // 
            // panelKlienci
            // 
            panelKlienci.Controls.Add(btnUsunKlienta);
            panelKlienci.Controls.Add(btnEdytujKlienta);
            panelKlienci.Controls.Add(btnDodajKlienta);
            panelKlienci.Dock = DockStyle.Bottom;
            panelKlienci.Location = new Point(3, 467);
            panelKlienci.Name = "panelKlienci";
            panelKlienci.Size = new Size(968, 50);
            panelKlienci.TabIndex = 0;
            // 
            // btnUsunKlienta
            // 
            btnUsunKlienta.Location = new Point(260, 9);
            btnUsunKlienta.Name = "btnUsunKlienta";
            btnUsunKlienta.Size = new Size(110, 32);
            btnUsunKlienta.TabIndex = 2;
            btnUsunKlienta.Text = "Usuń";
            btnUsunKlienta.UseVisualStyleBackColor = true;
            btnUsunKlienta.Click += btnUsunKlienta_Click;
            // 
            // btnEdytujKlienta
            // 
            btnEdytujKlienta.Location = new Point(140, 9);
            btnEdytujKlienta.Name = "btnEdytujKlienta";
            btnEdytujKlienta.Size = new Size(110, 32);
            btnEdytujKlienta.TabIndex = 1;
            btnEdytujKlienta.Text = "Edytuj";
            btnEdytujKlienta.UseVisualStyleBackColor = true;
            btnEdytujKlienta.Click += btnEdytujKlienta_Click;
            // 
            // btnDodajKlienta
            // 
            btnDodajKlienta.Location = new Point(20, 9);
            btnDodajKlienta.Name = "btnDodajKlienta";
            btnDodajKlienta.Size = new Size(110, 32);
            btnDodajKlienta.TabIndex = 0;
            btnDodajKlienta.Text = "Dodaj";
            btnDodajKlienta.UseVisualStyleBackColor = true;
            btnDodajKlienta.Click += btnDodajKlienta_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(974, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dostawcy";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(974, 520);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Produkty";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvDodatki);
            tabPage5.Controls.Add(panelDodatki);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(974, 520);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Dodatki";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvDodatki
            // 
            dgvDodatki.AllowUserToAddRows = false;
            dgvDodatki.AllowUserToDeleteRows = false;
            dgvDodatki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDodatki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDodatki.Dock = DockStyle.Fill;
            dgvDodatki.Location = new Point(3, 3);
            dgvDodatki.MultiSelect = false;
            dgvDodatki.Name = "dgvDodatki";
            dgvDodatki.ReadOnly = true;
            dgvDodatki.RowHeadersWidth = 51;
            dgvDodatki.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDodatki.Size = new Size(968, 464);
            dgvDodatki.TabIndex = 1;
            // 
            // panelDodatki
            // 
            panelDodatki.Controls.Add(btnUsunDodatek);
            panelDodatki.Controls.Add(btnEdytujDodatek);
            panelDodatki.Controls.Add(btnDodajDodatek);
            panelDodatki.Dock = DockStyle.Bottom;
            panelDodatki.Location = new Point(3, 467);
            panelDodatki.Name = "panelDodatki";
            panelDodatki.Size = new Size(968, 50);
            panelDodatki.TabIndex = 0;
            // 
            // btnUsunDodatek
            // 
            btnUsunDodatek.Location = new Point(260, 9);
            btnUsunDodatek.Name = "btnUsunDodatek";
            btnUsunDodatek.Size = new Size(110, 32);
            btnUsunDodatek.TabIndex = 2;
            btnUsunDodatek.Text = "Usuń";
            btnUsunDodatek.UseVisualStyleBackColor = true;
            btnUsunDodatek.Click += btnUsunDodatek_Click;
            // 
            // btnEdytujDodatek
            // 
            btnEdytujDodatek.Location = new Point(140, 9);
            btnEdytujDodatek.Name = "btnEdytujDodatek";
            btnEdytujDodatek.Size = new Size(110, 32);
            btnEdytujDodatek.TabIndex = 1;
            btnEdytujDodatek.Text = "Edytuj";
            btnEdytujDodatek.UseVisualStyleBackColor = true;
            btnEdytujDodatek.Click += btnEdytujDodatek_Click;
            // 
            // btnDodajDodatek
            // 
            btnDodajDodatek.Location = new Point(20, 9);
            btnDodajDodatek.Name = "btnDodajDodatek";
            btnDodajDodatek.Size = new Size(110, 32);
            btnDodajDodatek.TabIndex = 0;
            btnDodajDodatek.Text = "Dodaj";
            btnDodajDodatek.UseVisualStyleBackColor = true;
            btnDodajDodatek.Click += btnDodajDodatek_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dgvStrefy);
            tabPage6.Controls.Add(panelPrzyciski);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(974, 520);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Strefy dostawy";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvStrefy
            // 
            dgvStrefy.AllowUserToAddRows = false;
            dgvStrefy.AllowUserToDeleteRows = false;
            dgvStrefy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStrefy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStrefy.Dock = DockStyle.Fill;
            dgvStrefy.Location = new Point(3, 3);
            dgvStrefy.MultiSelect = false;
            dgvStrefy.Name = "dgvStrefy";
            dgvStrefy.ReadOnly = true;
            dgvStrefy.RowHeadersWidth = 51;
            dgvStrefy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStrefy.Size = new Size(968, 464);
            dgvStrefy.TabIndex = 1;
            // 
            // panelPrzyciski
            // 
            panelPrzyciski.Controls.Add(btnUsunStrefe);
            panelPrzyciski.Controls.Add(btnEdytujStrefe);
            panelPrzyciski.Controls.Add(btnDodajStrefe);
            panelPrzyciski.Dock = DockStyle.Bottom;
            panelPrzyciski.Location = new Point(3, 467);
            panelPrzyciski.Name = "panelPrzyciski";
            panelPrzyciski.Size = new Size(968, 50);
            panelPrzyciski.TabIndex = 0;
            // 
            // btnUsunStrefe
            // 
            btnUsunStrefe.Location = new Point(260, 9);
            btnUsunStrefe.Name = "btnUsunStrefe";
            btnUsunStrefe.Size = new Size(110, 32);
            btnUsunStrefe.TabIndex = 2;
            btnUsunStrefe.Text = "Usuń";
            btnUsunStrefe.UseVisualStyleBackColor = true;
            btnUsunStrefe.Click += btnUsunStrefe_Click;
            // 
            // btnEdytujStrefe
            // 
            btnEdytujStrefe.Location = new Point(140, 9);
            btnEdytujStrefe.Name = "btnEdytujStrefe";
            btnEdytujStrefe.Size = new Size(110, 32);
            btnEdytujStrefe.TabIndex = 1;
            btnEdytujStrefe.Text = "Edytuj";
            btnEdytujStrefe.UseVisualStyleBackColor = true;
            btnEdytujStrefe.Click += btnEdytujStrefe_Click;
            // 
            // btnDodajStrefe
            // 
            btnDodajStrefe.Location = new Point(20, 9);
            btnDodajStrefe.Name = "btnDodajStrefe";
            btnDodajStrefe.Size = new Size(110, 32);
            btnDodajStrefe.TabIndex = 0;
            btnDodajStrefe.Text = "Dodaj";
            btnDodajStrefe.UseVisualStyleBackColor = true;
            btnDodajStrefe.Click += btnDodajStrefe_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzeria – System obsługi zamówień";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKlienci).EndInit();
            panelKlienci.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDodatki).EndInit();
            panelDodatki.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStrefy).EndInit();
            panelPrzyciski.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dgvKlienci;
        private Panel panelKlienci;
        private Button btnUsunKlienta;
        private Button btnEdytujKlienta;
        private Button btnDodajKlienta;
        private DataGridView dgvDodatki;
        private Panel panelDodatki;
        private Button btnUsunDodatek;
        private Button btnEdytujDodatek;
        private Button btnDodajDodatek;
        private Panel panelPrzyciski;
        private Button btnUsunStrefe;
        private Button btnEdytujStrefe;
        private Button btnDodajStrefe;
        private DataGridView dgvStrefy;
    }
}