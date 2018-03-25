namespace WindowsFormsApp
{
    partial class Detail
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.shapeDetailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typLabel = new System.Windows.Forms.Label();
            this.kolorLabel = new System.Windows.Forms.Label();
            this.wspolrzedneLabel = new System.Windows.Forms.Label();
            this.polePowLabel = new System.Windows.Forms.Label();
            this.tekstEtykietyLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.wspolrzedneTextBox = new System.Windows.Forms.TextBox();
            this.poleTextBox = new System.Windows.Forms.TextBox();
            this.shapeDetailTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 0;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski"});
            this.colorComboBox.Location = new System.Drawing.Point(146, 3);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 1;
            this.colorComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.colorComboBox_Validating);
            this.colorComboBox.Validated += new System.EventHandler(this.colorComboBox_Validated);
            // 
            // shapeDetailTableLayoutPanel
            // 
            this.shapeDetailTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeDetailTableLayoutPanel.ColumnCount = 2;
            this.shapeDetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.43137F));
            this.shapeDetailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.56863F));
            this.shapeDetailTableLayoutPanel.Controls.Add(this.colorComboBox, 1, 0);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.textBox1, 1, 4);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.typeComboBox, 1, 1);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.typLabel, 0, 1);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.kolorLabel, 0, 0);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.wspolrzedneLabel, 0, 2);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.polePowLabel, 0, 3);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.tekstEtykietyLabel, 0, 4);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.wspolrzedneTextBox, 1, 2);
            this.shapeDetailTableLayoutPanel.Controls.Add(this.poleTextBox, 1, 3);
            this.shapeDetailTableLayoutPanel.Location = new System.Drawing.Point(-2, 12);
            this.shapeDetailTableLayoutPanel.Name = "shapeDetailTableLayoutPanel";
            this.shapeDetailTableLayoutPanel.RowCount = 5;
            this.shapeDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shapeDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shapeDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shapeDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shapeDetailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.shapeDetailTableLayoutPanel.Size = new System.Drawing.Size(505, 177);
            this.shapeDetailTableLayoutPanel.TabIndex = 2;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Prostokąt",
            "Trójkąt"});
            this.typeComboBox.Location = new System.Drawing.Point(146, 38);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.typeComboBox_Validating);
            this.typeComboBox.Validated += new System.EventHandler(this.typeComboBox_Validated);
            // 
            // typLabel
            // 
            this.typLabel.AutoSize = true;
            this.typLabel.Location = new System.Drawing.Point(3, 35);
            this.typLabel.Name = "typLabel";
            this.typLabel.Size = new System.Drawing.Size(25, 13);
            this.typLabel.TabIndex = 3;
            this.typLabel.Text = "Typ";
            // 
            // kolorLabel
            // 
            this.kolorLabel.AutoSize = true;
            this.kolorLabel.Location = new System.Drawing.Point(3, 0);
            this.kolorLabel.Name = "kolorLabel";
            this.kolorLabel.Size = new System.Drawing.Size(31, 13);
            this.kolorLabel.TabIndex = 4;
            this.kolorLabel.Text = "Kolor";
            // 
            // wspolrzedneLabel
            // 
            this.wspolrzedneLabel.AutoSize = true;
            this.wspolrzedneLabel.Location = new System.Drawing.Point(3, 70);
            this.wspolrzedneLabel.Name = "wspolrzedneLabel";
            this.wspolrzedneLabel.Size = new System.Drawing.Size(106, 13);
            this.wspolrzedneLabel.TabIndex = 5;
            this.wspolrzedneLabel.Text = "Współrzędne środka";
            // 
            // polePowLabel
            // 
            this.polePowLabel.AutoSize = true;
            this.polePowLabel.Location = new System.Drawing.Point(3, 105);
            this.polePowLabel.Name = "polePowLabel";
            this.polePowLabel.Size = new System.Drawing.Size(87, 13);
            this.polePowLabel.TabIndex = 6;
            this.polePowLabel.Text = "Pole powierzchni";
            // 
            // tekstEtykietyLabel
            // 
            this.tekstEtykietyLabel.AutoSize = true;
            this.tekstEtykietyLabel.Location = new System.Drawing.Point(3, 140);
            this.tekstEtykietyLabel.Name = "tekstEtykietyLabel";
            this.tekstEtykietyLabel.Size = new System.Drawing.Size(45, 13);
            this.tekstEtykietyLabel.TabIndex = 7;
            this.tekstEtykietyLabel.Text = "Etykieta";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(120, 210);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(336, 209);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // wspolrzedneTextBox
            // 
            this.wspolrzedneTextBox.Location = new System.Drawing.Point(146, 73);
            this.wspolrzedneTextBox.Name = "wspolrzedneTextBox";
            this.wspolrzedneTextBox.Size = new System.Drawing.Size(100, 20);
            this.wspolrzedneTextBox.TabIndex = 8;
            // 
            // poleTextBox
            // 
            this.poleTextBox.Location = new System.Drawing.Point(146, 108);
            this.poleTextBox.Name = "poleTextBox";
            this.poleTextBox.Size = new System.Drawing.Size(100, 20);
            this.poleTextBox.TabIndex = 9;
            // 
            // Detail
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(501, 245);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.shapeDetailTableLayoutPanel);
            this.Name = "Detail";
            this.Text = "Figura 2D";
            this.shapeDetailTableLayoutPanel.ResumeLayout(false);
            this.shapeDetailTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.TableLayoutPanel shapeDetailTableLayoutPanel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typLabel;
        private System.Windows.Forms.Label kolorLabel;
        private System.Windows.Forms.Label wspolrzedneLabel;
        private System.Windows.Forms.Label polePowLabel;
        private System.Windows.Forms.Label tekstEtykietyLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox wspolrzedneTextBox;
        private System.Windows.Forms.TextBox poleTextBox;
    }
}