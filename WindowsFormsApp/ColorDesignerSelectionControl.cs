using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace WindowsFormsApp
{
    public partial class ColorDesignerSelectionControl : System.Windows.Forms.UserControl
    {
        private ColorEnum colorValue = ColorEnum.Czerwony;
        private IWindowsFormsEditorService editorService = null;
        
        // This constructor takes Color value from the 
        // design-time environment
        public ColorDesignerSelectionControl(
            ColorEnum colorVal,
            IWindowsFormsEditorService editorService)
        {
            InitializeComponent();
            this.colorValue = colorVal; 
            this.editorService = editorService;
            this.greenPanel.Click += new EventHandler(greenPanel_Click);
            this.redPanel.Click += new EventHandler(redPanel_Click);
            this.bluePanel.Click += new EventHandler(bluePanel_Click);
        }

        // the property for which this control provides 
        // a custom user interface in the Properties window. 
        public ColorEnum Kolor 
        {
            get
            {
                return this.colorValue;
            }

            set
            {
                if (this.colorValue != value)
                {
                    this.colorValue = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (
                Graphics gGreen = this.greenPanel.CreateGraphics(),
                gRed = this.redPanel.CreateGraphics(),
                gBlue = this.bluePanel.CreateGraphics())
            {
                // If the Square option has been selected, draw a  
                // border inside the squarePanel. 
                //if (this.colorValue == ColorEnum.Zielony)
                {
                    gGreen.DrawRectangle(
                        Pens.Green,
                        0,
                        0,
                        this.greenPanel.Width - 1,
                        this.greenPanel.Height - 1);
                }

                // If the Circle option has been selected, draw a  
                // border inside the circlePanel. 
                //if (this.colorValue == ColorEnum.Czerwony)
                {
                    gRed.DrawRectangle(
                        Pens.Red,
                        0,
                        0,
                        this.redPanel.Width - 1,
                        this.redPanel.Height - 1);
                }

                //if (this.colorValue == ColorEnum.Niebieski)
                {
                    gBlue.DrawRectangle(
                        Pens.Blue,
                        0,
                        0,
                        this.bluePanel.Width - 1,
                        this.bluePanel.Height - 1);
                }
            }
        }

        private void bluePanel_Click(object sender, EventArgs e)
        {
            this.colorValue = ColorEnum.Niebieski;
            this.Invalidate(false);
            this.editorService.CloseDropDown();
        }

        private void redPanel_Click(object sender, EventArgs e)
        {
            this.colorValue = ColorEnum.Czerwony;
            this.Invalidate(false);
            this.editorService.CloseDropDown();
        }

        private void greenPanel_Click(object sender, EventArgs e)
        {
            this.colorValue = ColorEnum.Zielony;
            this.Invalidate(false);
            this.editorService.CloseDropDown();
        }

        // This class demonstrates the use of a custom UITypeEditor.  
        // It allows the MarqueeBorder control's LightShape property 
        // to be changed at design time using a customized UI element 
        // that is invoked by the Properties window. The UI is provided 
        // by the LightShapeSelectionControl class. 
        internal class LightShapeEditor : UITypeEditor
        {
            IWindowsFormsEditorService editorService;
            public override UITypeEditorEditStyle GetEditStyle(
                System.ComponentModel.ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.DropDown;
            }

            public override object EditValue(
                ITypeDescriptorContext context,
                IServiceProvider provider, object value)
            {
                if (provider != null)
                {
                    editorService =
                        provider.GetService(
                        typeof(IWindowsFormsEditorService))
                        as IWindowsFormsEditorService;
                }
                if (editorService != null)
                {
                    ColorDesignerSelectionControl selectionControl =
                        new ColorDesignerSelectionControl(
                        (ColorEnum)value,
                        editorService);
                    editorService.DropDownControl(selectionControl);
                    value = selectionControl.Kolor;
                }
                return value;
            }

            // This method indicates to the design environment that 
            // the type editor will paint additional content in the 
            // LightShape entry in the PropertyGrid. 
            public override bool GetPaintValueSupported(
                ITypeDescriptorContext context)
            {
                return true;
            }

            // This method paints a graphical representation of the  
            // selected value of the LightShpae property. 
            public override void PaintValue(PaintValueEventArgs e)
            {
                ColorEnum shape = (ColorEnum)e.Value;
                Pen p = Pens.Violet;
                {
                    switch (shape)
                    {
                        case ColorEnum.Zielony:
                            p = Pens.Green;
                            break;
                        case ColorEnum.Czerwony:
                            p = Pens.Red;
                            break;
                        case ColorEnum.Niebieski:
                            p = Pens.Blue;
                            break;
                    }
                    e.Graphics.DrawRectangle(p, e.Bounds);
                    p.Dispose();
                }
            }
        }

        private void ColorDesignerSelectionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
