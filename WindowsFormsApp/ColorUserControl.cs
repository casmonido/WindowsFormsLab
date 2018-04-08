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
        private MarqueeLightShape lightShapeValue;

        [Category("Marquee")]
        [Browsable(true)]
        [EditorAttribute(typeof(LightShapeSelectionControl.LightShapeEditor),
        typeof(System.Drawing.Design.UITypeEditor))]
        public MarqueeLightShape LightShape
        {
            get
            {
                return this.lightShapeValue;
            }

            set
            {
                this.lightShapeValue = value;
            }
        }
        /*[EditorAttribute(typeof(AngleEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Color picker")]
        [BrowsableAttribute(true)]
        public DropDownListProperty Kolor
        {
            set
            {
                comboBox.SelectedItem = value;
                Invalidate();
            }
            get
            {
                return (DropDownListProperty) comboBox.SelectedItem;
            }
        }*/

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
