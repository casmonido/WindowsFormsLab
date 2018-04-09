namespace WindowsFormsApp
{
    partial class Lista
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modyfikujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shapeList = new System.Windows.Forms.ListView();
            this.Kolor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wspolrzedne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etykieta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filtrLowerCheckBox = new System.Windows.Forms.CheckBox();
            this.filtrUpperCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoToolTip = true;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.modyfikujToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShowShortcutKeys = false;
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // modyfikujToolStripMenuItem
            // 
            this.modyfikujToolStripMenuItem.Name = "modyfikujToolStripMenuItem";
            this.modyfikujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modyfikujToolStripMenuItem.Text = "Modyfikuj";
            this.modyfikujToolStripMenuItem.Click += new System.EventHandler(this.modyfikujToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.shapeList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.topTableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 163);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // shapeList
            // 
            this.shapeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kolor,
            this.Typ,
            this.Wspolrzedne,
            this.Pole,
            this.Etykieta});
            this.shapeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapeList.FullRowSelect = true;
            this.shapeList.GridLines = true;
            this.shapeList.Location = new System.Drawing.Point(3, 30);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(584, 130);
            this.shapeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.shapeList.TabIndex = 4;
            this.shapeList.UseCompatibleStateImageBehavior = false;
            this.shapeList.View = System.Windows.Forms.View.Details;
            // 
            // Kolor
            // 
            this.Kolor.Text = "Kolor";
            // 
            // Typ
            // 
            this.Typ.Text = "Typ";
            this.Typ.Width = 133;
            // 
            // Wspolrzedne
            // 
            this.Wspolrzedne.Text = "Współrzędne środka";
            this.Wspolrzedne.Width = 152;
            // 
            // Pole
            // 
            this.Pole.Text = "Pole";
            // 
            // Etykieta
            // 
            this.Etykieta.Text = "Etykieta";
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 3;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.topTableLayoutPanel.Controls.Add(this.filtrLowerCheckBox, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.filtrUpperCheckBox, 1, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(584, 21);
            this.topTableLayoutPanel.TabIndex = 5;
            // 
            // filtrLowerCheckBox
            // 
            this.filtrLowerCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtrLowerCheckBox.AutoSize = true;
            this.filtrLowerCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.filtrLowerCheckBox.Location = new System.Drawing.Point(42, 3);
            this.filtrLowerCheckBox.Name = "filtrLowerCheckBox";
            this.filtrLowerCheckBox.Size = new System.Drawing.Size(160, 15);
            this.filtrLowerCheckBox.TabIndex = 1;
            this.filtrLowerCheckBox.Text = "Pokaż elementy do 100 pola";
            this.filtrLowerCheckBox.UseVisualStyleBackColor = true;
            this.filtrLowerCheckBox.CheckedChanged += new System.EventHandler(this.filtrLowerCheckBox_CheckedChanged);
            // 
            // filtrUpperCheckBox
            // 
            this.filtrUpperCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtrUpperCheckBox.AutoSize = true;
            this.filtrUpperCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.filtrUpperCheckBox.Location = new System.Drawing.Point(273, 3);
            this.filtrUpperCheckBox.Name = "filtrUpperCheckBox";
            this.filtrUpperCheckBox.Size = new System.Drawing.Size(186, 15);
            this.filtrUpperCheckBox.TabIndex = 2;
            this.filtrUpperCheckBox.Text = "Pokaż elementy powyżej 100 pola";
            this.filtrUpperCheckBox.UseVisualStyleBackColor = true;
            this.filtrUpperCheckBox.CheckedChanged += new System.EventHandler(this.filtrUpperCheckBox_CheckedChanged);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 187);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modyfikujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView shapeList;
        private System.Windows.Forms.ColumnHeader Kolor;
        private System.Windows.Forms.ColumnHeader Typ;
        private System.Windows.Forms.ColumnHeader Wspolrzedne;
        private System.Windows.Forms.ColumnHeader Pole;
        private System.Windows.Forms.ColumnHeader Etykieta;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.CheckBox filtrLowerCheckBox;
        private System.Windows.Forms.CheckBox filtrUpperCheckBox;
    }
}