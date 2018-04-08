using System;

namespace WindowsFormsApp
{
    partial class LightShapeSelectionControl
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
                this.squarePanel.Click -=
                    new EventHandler(squarePanel_Click);
                this.circlePanel.Click -=
                    new EventHandler(circlePanel_Click);
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
            this.squarePanel = new System.Windows.Forms.Panel();
            this.circlePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //  
            // squarePanel 
            //  
            this.squarePanel.Location = new System.Drawing.Point(8, 10);
            this.squarePanel.Name = "squarePanel";
            this.squarePanel.Size = new System.Drawing.Size(60, 60);
            this.squarePanel.TabIndex = 2;
            //  
            // circlePanel 
            //  
            this.circlePanel.Location = new System.Drawing.Point(80, 10);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(60, 60);
            this.circlePanel.TabIndex = 3;
            //  
            // LightShapeSelectionControl 
            //  
            this.Controls.Add(this.squarePanel);
            this.Controls.Add(this.circlePanel);
            this.Name = "LightShapeSelectionControl";
            this.Size = new System.Drawing.Size(150, 80);
            this.ResumeLayout(false);

        }
        #endregion

    }
}
