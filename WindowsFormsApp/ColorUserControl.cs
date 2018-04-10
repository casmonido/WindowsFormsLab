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

        [Category("Custom properties")]
        [Browsable(true)]
        [EditorAttribute(typeof(ColorDesignerSelectionControl.ColorEditor),
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
                comboBox.SelectedItem = colorVal.ToString();
                button.Text = colorVal.ToString();
                switch (colorVal)
                {
                    case ColorEnum.Czerwony:
                        button.BackColor = Color.Red;
                        break;
                    case ColorEnum.Zielony:
                        button.BackColor = Color.Green;
                        break;
                    case ColorEnum.Niebieski:
                        button.BackColor = Color.Blue;
                        break;
                }
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
            switch (colorVal)
            {
                case ColorEnum.Czerwony:
                    colorVal = ColorEnum.Zielony;
                    button.BackColor = Color.Green;
                    break;
                case ColorEnum.Zielony:
                    colorVal = ColorEnum.Niebieski;
                    button.BackColor = Color.Blue;
                    break;
                case ColorEnum.Niebieski:
                    colorVal = ColorEnum.Czerwony;
                    button.BackColor = Color.Red;
                    break;
            }
            comboBox.SelectedItem = colorVal.ToString();
            button.Text = colorVal.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorEnum colorV;
            Enum.TryParse<ColorEnum>(comboBox.SelectedItem.ToString(), out colorV);
            switch (colorV)
            {
                case ColorEnum.Czerwony:
                    button.BackColor = Color.Red;
                    break;
                case ColorEnum.Zielony:
                    button.BackColor = Color.Green;
                    break;
                case ColorEnum.Niebieski:
                    button.BackColor = Color.Blue;
                    break;
            }
            colorVal = colorV;
            button.Text = colorVal.ToString();
        }
    }
}
