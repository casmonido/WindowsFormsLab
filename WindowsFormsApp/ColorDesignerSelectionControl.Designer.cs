using System;

namespace WindowsFormsApp
{
    partial class ColorDesignerSelectionControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                // Be sure to unhook event handlers 
                // to prevent "lapsed listener" leaks.
                this.greenPanel.Click -=
                    new EventHandler(greenPanel_Click);
                this.redPanel.Click -=
                    new EventHandler(redPanel_Click);
                this.bluePanel.Click -=
                    new EventHandler(bluePanel_Click);
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników
     
        /// <summary>  
        /// Required method for Designer support - do not modify  
        /// the contents of this method with the code editor. 
        /// </summary> 
        private void InitializeComponent()
        {
            this.greenPanel = new System.Windows.Forms.Panel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // squarePanel
            // 
            this.greenPanel.Location = new System.Drawing.Point(8, 10);
            this.greenPanel.Name = "squarePanel";
            this.greenPanel.Size = new System.Drawing.Size(60, 60);
            this.greenPanel.TabIndex = 2;
            // 
            // circlePanel
            // 
            this.redPanel.Location = new System.Drawing.Point(80, 10);
            this.redPanel.Name = "circlePanel";
            this.redPanel.Size = new System.Drawing.Size(60, 60);
            this.redPanel.TabIndex = 3;
            // 
            // ColorDesignerSelectionControl
            // 
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.redPanel);
            this.Name = "ColorDesignerSelectionControl";
            this.Size = new System.Drawing.Size(150, 80);
            this.Load += new System.EventHandler(this.ColorDesignerSelectionControl_Load);
            this.ResumeLayout(false);

        }
        #endregion

    }
}
