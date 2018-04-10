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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.detailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.etykietaLabel = new System.Windows.Forms.Label();
            this.poleLabel = new System.Windows.Forms.Label();
            this.wspolrzedneLabel = new System.Windows.Forms.Label();
            this.typLabel = new System.Windows.Forms.Label();
            this.kolorLabel = new System.Windows.Forms.Label();
            this.detailTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.typComboBox = new System.Windows.Forms.ComboBox();
            this.poleTextBox = new System.Windows.Forms.TextBox();
            this.etykietaTextBox = new System.Windows.Forms.TextBox();
            this.colorUserControl = new WindowsFormsApp.ColorUserControl();
            this.wspolrzedneTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.xtextBox = new System.Windows.Forms.TextBox();
            this.ytextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailErrorProvider)).BeginInit();
            this.detailTableLayoutPanel.SuspendLayout();
            this.wspolrzedneTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(77, 163);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(307, 164);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // detailErrorProvider
            // 
            this.detailErrorProvider.ContainerControl = this;
            // 
            // etykietaLabel
            // 
            this.etykietaLabel.AutoSize = true;
            this.etykietaLabel.Location = new System.Drawing.Point(3, 116);
            this.etykietaLabel.Name = "etykietaLabel";
            this.etykietaLabel.Size = new System.Drawing.Size(73, 13);
            this.etykietaLabel.TabIndex = 9;
            this.etykietaLabel.Text = "Tekst etykiety";
            // 
            // poleLabel
            // 
            this.poleLabel.AutoSize = true;
            this.poleLabel.Location = new System.Drawing.Point(3, 87);
            this.poleLabel.Name = "poleLabel";
            this.poleLabel.Size = new System.Drawing.Size(28, 13);
            this.poleLabel.TabIndex = 8;
            this.poleLabel.Text = "Pole";
            // 
            // wspolrzedneLabel
            // 
            this.wspolrzedneLabel.AutoSize = true;
            this.wspolrzedneLabel.Location = new System.Drawing.Point(3, 58);
            this.wspolrzedneLabel.Name = "wspolrzedneLabel";
            this.wspolrzedneLabel.Size = new System.Drawing.Size(106, 13);
            this.wspolrzedneLabel.TabIndex = 7;
            this.wspolrzedneLabel.Text = "Współrzędne środka";
            // 
            // typLabel
            // 
            this.typLabel.AutoSize = true;
            this.typLabel.Location = new System.Drawing.Point(3, 29);
            this.typLabel.Name = "typLabel";
            this.typLabel.Size = new System.Drawing.Size(25, 13);
            this.typLabel.TabIndex = 6;
            this.typLabel.Text = "Typ";
            // 
            // kolorLabel
            // 
            this.kolorLabel.AutoSize = true;
            this.kolorLabel.Location = new System.Drawing.Point(3, 0);
            this.kolorLabel.Name = "kolorLabel";
            this.kolorLabel.Size = new System.Drawing.Size(31, 13);
            this.kolorLabel.TabIndex = 5;
            this.kolorLabel.Text = "Kolor";
            // 
            // detailTableLayoutPanel
            // 
            this.detailTableLayoutPanel.ColumnCount = 2;
            this.detailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.23779F));
            this.detailTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.76221F));
            this.detailTableLayoutPanel.Controls.Add(this.typComboBox, 1, 1);
            this.detailTableLayoutPanel.Controls.Add(this.poleTextBox, 1, 3);
            this.detailTableLayoutPanel.Controls.Add(this.etykietaTextBox, 1, 4);
            this.detailTableLayoutPanel.Controls.Add(this.kolorLabel, 0, 0);
            this.detailTableLayoutPanel.Controls.Add(this.typLabel, 0, 1);
            this.detailTableLayoutPanel.Controls.Add(this.wspolrzedneLabel, 0, 2);
            this.detailTableLayoutPanel.Controls.Add(this.poleLabel, 0, 3);
            this.detailTableLayoutPanel.Controls.Add(this.etykietaLabel, 0, 4);
            this.detailTableLayoutPanel.Controls.Add(this.colorUserControl, 1, 0);
            this.detailTableLayoutPanel.Controls.Add(this.wspolrzedneTableLayoutPanel, 1, 2);
            this.detailTableLayoutPanel.Location = new System.Drawing.Point(1, 12);
            this.detailTableLayoutPanel.Name = "detailTableLayoutPanel";
            this.detailTableLayoutPanel.RowCount = 5;
            this.detailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.detailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.detailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.detailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.detailTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.detailTableLayoutPanel.Size = new System.Drawing.Size(452, 146);
            this.detailTableLayoutPanel.TabIndex = 0;
            // 
            // typComboBox
            // 
            this.typComboBox.FormattingEnabled = true;
            this.typComboBox.Items.AddRange(new object[] {
            "Trójkąt",
            "Kwadrat",
            "Koło"});
            this.typComboBox.Location = new System.Drawing.Point(130, 32);
            this.typComboBox.Name = "typComboBox";
            this.typComboBox.Size = new System.Drawing.Size(121, 21);
            this.typComboBox.TabIndex = 1;
            this.typComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.typComboBox_Validating);
            this.typComboBox.Validated += new System.EventHandler(this.typComboBox_Validated);
            // 
            // poleTextBox
            // 
            this.poleTextBox.Location = new System.Drawing.Point(130, 90);
            this.poleTextBox.Name = "poleTextBox";
            this.poleTextBox.Size = new System.Drawing.Size(121, 20);
            this.poleTextBox.TabIndex = 3;
            this.poleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.poleTextBox_Validating);
            this.poleTextBox.Validated += new System.EventHandler(this.poleTextBox_Validated);
            // 
            // etykietaTextBox
            // 
            this.etykietaTextBox.Location = new System.Drawing.Point(130, 119);
            this.etykietaTextBox.Name = "etykietaTextBox";
            this.etykietaTextBox.Size = new System.Drawing.Size(185, 20);
            this.etykietaTextBox.TabIndex = 4;
            // 
            // colorUserControl
            // 
            this.colorUserControl.CausesValidation = false;
            this.colorUserControl.Kolor = WindowsFormsApp.ColorEnum.Zielony;
            this.colorUserControl.Location = new System.Drawing.Point(130, 3);
            this.colorUserControl.Name = "colorUserControl";
            this.colorUserControl.Size = new System.Drawing.Size(251, 22);
            this.colorUserControl.TabIndex = 10;
            this.colorUserControl.Load += new System.EventHandler(this.colorUserControl_Load);
            // 
            // wspolrzedneTableLayoutPanel
            // 
            this.wspolrzedneTableLayoutPanel.ColumnCount = 4;
            this.wspolrzedneTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.wspolrzedneTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.wspolrzedneTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.wspolrzedneTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.wspolrzedneTableLayoutPanel.Controls.Add(this.xlabel, 0, 0);
            this.wspolrzedneTableLayoutPanel.Controls.Add(this.ylabel, 2, 0);
            this.wspolrzedneTableLayoutPanel.Controls.Add(this.xtextBox, 1, 0);
            this.wspolrzedneTableLayoutPanel.Controls.Add(this.ytextBox, 3, 0);
            this.wspolrzedneTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wspolrzedneTableLayoutPanel.Location = new System.Drawing.Point(130, 61);
            this.wspolrzedneTableLayoutPanel.Name = "wspolrzedneTableLayoutPanel";
            this.wspolrzedneTableLayoutPanel.RowCount = 1;
            this.wspolrzedneTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wspolrzedneTableLayoutPanel.Size = new System.Drawing.Size(319, 23);
            this.wspolrzedneTableLayoutPanel.TabIndex = 11;
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xlabel.Location = new System.Drawing.Point(3, 0);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(39, 23);
            this.xlabel.TabIndex = 0;
            this.xlabel.Text = "x:";
            this.xlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ylabel.Location = new System.Drawing.Point(161, 0);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(39, 23);
            this.ylabel.TabIndex = 1;
            this.ylabel.Text = "y:";
            this.ylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtextBox
            // 
            this.xtextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtextBox.Location = new System.Drawing.Point(48, 3);
            this.xtextBox.Name = "xtextBox";
            this.xtextBox.Size = new System.Drawing.Size(40, 20);
            this.xtextBox.TabIndex = 2;
            this.xtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wspolrzednaX_Validating);
            this.xtextBox.Validated += new System.EventHandler(this.wspolrzednaX_Validated);
            // 
            // ytextBox
            // 
            this.ytextBox.Location = new System.Drawing.Point(206, 3);
            this.ytextBox.Name = "ytextBox";
            this.ytextBox.Size = new System.Drawing.Size(40, 20);
            this.ytextBox.TabIndex = 3;
            this.ytextBox.Validating += new System.ComponentModel.CancelEventHandler(this.wspolrzednaY_Validating);
            this.ytextBox.Validated += new System.EventHandler(this.wspolrzednaY_Validated);
            // 
            // Detail
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(450, 194);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.detailTableLayoutPanel);
            this.Name = "Detail";
            this.Text = "Figura 2D";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailErrorProvider)).EndInit();
            this.detailTableLayoutPanel.ResumeLayout(false);
            this.detailTableLayoutPanel.PerformLayout();
            this.wspolrzedneTableLayoutPanel.ResumeLayout(false);
            this.wspolrzedneTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider detailErrorProvider;
        private System.Windows.Forms.TableLayoutPanel detailTableLayoutPanel;
        private System.Windows.Forms.Label kolorLabel;
        private System.Windows.Forms.Label typLabel;
        private System.Windows.Forms.Label wspolrzedneLabel;
        private System.Windows.Forms.Label poleLabel;
        private System.Windows.Forms.Label etykietaLabel;
        private System.Windows.Forms.ComboBox typComboBox;
        private System.Windows.Forms.TextBox poleTextBox;
        private System.Windows.Forms.TextBox etykietaTextBox;
        private ColorUserControl colorUserControl;
        private System.Windows.Forms.TableLayoutPanel wspolrzedneTableLayoutPanel;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.TextBox xtextBox;
        private System.Windows.Forms.TextBox ytextBox;
    }
}