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
    public partial class AngleEditorTestControl : UserControl
    {
        public AngleEditorTestControl()
        {
            InitializeComponent();
        }

        private void AngleEditorTestControl_Load(object sender, EventArgs e)
        {

        }

        private string color;
        [EditorAttribute(typeof(AngleEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Color picker")]
        [BrowsableAttribute(true)]
        public string Kolor
        {
            get { return color; }
            set { color = value; }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            /*if (this.DesignMode)
                e.Graphics.DrawString("Use the Properties Window.", … );
            else
                e.Graphics.DrawString("This example requires design mode.", … );*/
        }

        private void angleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
