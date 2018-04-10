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
    //Delegate that will be the pointer for the event, contains two arguments 
    public delegate void ValueChangedEventHandler(object sender, ShapeChangedEventArgs e);
    public partial class ShapeUserControl : UserControl
    {
        public event ValueChangedEventHandler ShapeChanged;

        protected virtual void OnValueChanged(ShapeChangedEventArgs e)
        {
            if (ShapeChanged != null)
                ShapeChanged(this, e);
        }

        private ShapeEnum shapeVal;
        public ShapeEnum Typ
        {
            get
            {
                return this.shapeVal;
            }
            set
            {
                this.shapeVal = value;
                switch (shapeVal)
                {
                    case ShapeEnum.Koło:
                        button.BackgroundImage = global::WindowsFormsApp.
                            Properties.Resources.circle;
                        break;
                    case ShapeEnum.Trójkąt:
                        button.BackgroundImage = global::WindowsFormsApp.
                            Properties.Resources.triangle;
                        break;
                    case ShapeEnum.Kwadrat:
                        button.BackgroundImage = global::WindowsFormsApp.
                            Properties.Resources.sqare;
                        break;
                }
            }
        }

        public ShapeUserControl()
        {
            InitializeComponent();
            ShapeChanged += ShapeUserControl_ShapeChanged;
        }

        private void ShapeUserControl_ShapeChanged(object sender, ShapeChangedEventArgs e)
        {
            this.label.Text = e.Shape.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch (shapeVal)
            {
                case ShapeEnum.Koło:
                    shapeVal = ShapeEnum.Trójkąt;
                    button.BackgroundImage = global::WindowsFormsApp.Properties.Resources.triangle;
                    break;
                case ShapeEnum.Trójkąt:
                    shapeVal = ShapeEnum.Kwadrat;
                    button.BackgroundImage = global::WindowsFormsApp.Properties.Resources.sqare;
                    break;
                case ShapeEnum.Kwadrat:
                    shapeVal = ShapeEnum.Koło;
                    button.BackgroundImage = global::WindowsFormsApp.Properties.Resources.circle;
                    break;
            }
            OnValueChanged(new ShapeChangedEventArgs(shapeVal));
        }

        private void ShapeUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
