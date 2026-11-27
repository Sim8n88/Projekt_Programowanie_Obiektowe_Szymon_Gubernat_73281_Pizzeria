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
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            dgvStrefy = new DataGridView();
            panelPrzyciski = new Panel();
            btnUsunStrefe = new Button();
            btnEdytujStrefe = new Button();
            btnDodajStrefe = new Button();
            tabControl1.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStrefy).BeginInit();
            panelPrzyciski.SuspendLayout();
            SuspendLayout();

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

            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Zamówienia";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;

            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(974, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Klienci";
            tabPage2.UseVisualStyleBackColor = true;

            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(974, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dostawcy";
            tabPage3.UseVisualStyleBackColor = true;

            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(974, 520);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Produkty";
            tabPage4.UseVisualStyleBackColor = true;

            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(974, 520);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Dodatki";
            tabPage5.UseVisualStyleBackColor = true;

            tabPage6.Controls.Add(dgvStrefy);
            tabPage6.Controls.Add(panelPrzyciski);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(974, 520);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Strefy dostawy";
            tabPage6.UseVisualStyleBackColor = true;

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

            panelPrzyciski.Controls.Add(btnUsunStrefe);
            panelPrzyciski.Controls.Add(btnEdytujStrefe);
            panelPrzyciski.Controls.Add(btnDodajStrefe);
            panelPrzyciski.Dock = DockStyle.Bottom;
            panelPrzyciski.Location = new Point(3, 467);
            panelPrzyciski.Name = "panelPrzyciski";
            panelPrzyciski.Size = new Size(968, 50);
            panelPrzyciski.TabIndex = 0;

            btnUsunStrefe.Location = new Point(260, 9);
            btnUsunStrefe.Name = "btnUsunStrefe";
            btnUsunStrefe.Size = new Size(110, 32);
            btnUsunStrefe.TabIndex = 2;
            btnUsunStrefe.Text = "Usuń";
            btnUsunStrefe.UseVisualStyleBackColor = true;
            btnUsunStrefe.Click += btnUsunStrefe_Click;

            btnEdytujStrefe.Location = new Point(140, 9);
            btnEdytujStrefe.Name = "btnEdytujStrefe";
            btnEdytujStrefe.Size = new Size(110, 32);
            btnEdytujStrefe.TabIndex = 1;
            btnEdytujStrefe.Text = "Edytuj";
            btnEdytujStrefe.UseVisualStyleBackColor = true;
            btnEdytujStrefe.Click += btnEdytujStrefe_Click;

            btnDodajStrefe.Location = new Point(20, 9);
            btnDodajStrefe.Name = "btnDodajStrefe";
            btnDodajStrefe.Size = new Size(110, 32);
            btnDodajStrefe.TabIndex = 0;
            btnDodajStrefe.Text = "Dodaj";
            btnDodajStrefe.UseVisualStyleBackColor = true;
            btnDodajStrefe.Click += btnDodajStrefe_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzeria – System obsługi zamówień";
            tabControl1.ResumeLayout(false);
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
        private Panel panelPrzyciski;
        private Button btnUsunStrefe;
        private Button btnEdytujStrefe;
        private Button btnDodajStrefe;
        private DataGridView dgvStrefy;
    }
}