using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ColorUserControl : UserControl
    {
        private ColorEnum colorVal;

        [Category("Color picker")]
        [Browsable(true)]
        [EditorAttribute(typeof(ColorDesignerSelectionControl.LightShapeEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public ColorEnum Kolor
        {
            get
            {
                return this.colorVal;
            }

            set
            {
                this.colorVal = value;
            }
        }

        public ColorUserControl()
        {
            InitializeComponent();
        }

        private void ColorUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            button.BackColor = Color.Blue;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
