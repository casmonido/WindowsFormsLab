using System;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public enum Colors
    {
        Czerwony = 0,
        Zielony = 1,
        Niebieski = 2
    }

    public class AngleControl : System.Windows.Forms.UserControl
    {

        private Colors color;
        [Category("Color picker")]
        [BrowsableAttribute(true)]
        public Colors Kolor
        {
            get { return color; }
            set { color = value; }
        }

        public AngleControl(string value)
        {
            Colors wdEnum;
            Enum.TryParse<Colors>(value, out wdEnum);
            color = wdEnum;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(125, 22);
            this.Load += new System.EventHandler(this.AngleControl_Load);
            this.ResumeLayout(false);

        }

        private void AngleControl_Load(object sender, System.EventArgs e)
        {

        }
    }
}