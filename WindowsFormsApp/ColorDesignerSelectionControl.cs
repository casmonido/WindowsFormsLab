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

            using (Graphics gBlue = this.bluePanel.CreateGraphics(),
                gGreen = this.greenPanel.CreateGraphics(),
                gRed = this.redPanel.CreateGraphics())

            {
                SolidBrush brush = new SolidBrush(Color.Ivory);
                /*gGreen.FillRectangle(
                Brushes.Green,
                0, 0,
                this.greenPanel.Width,
                this.greenPanel.Height
                );*/
                gGreen.DrawString(ColorEnum.Zielony.ToString(),
                     this.greenPanel.Font, brush,
                    0, 0);
                /*gRed.FillRectangle(
                Brushes.Red,
                0, 0,
                this.redPanel.Width,
                this.redPanel.Height
                );*/
                gRed.DrawString(ColorEnum.Czerwony.ToString(),
                    this.redPanel.Font, brush,
                    0, 0);
                gBlue.DrawString(ColorEnum.Niebieski.ToString(),
                    this.bluePanel.Font, brush,
                    0, 0);
                brush.Dispose();
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
                Brush b = Brushes.Violet;
                Pen p = Pens.Violet;
                {
                    switch (shape)
                    {
                        case ColorEnum.Zielony:
                            b = Brushes.Green;
                            p = Pens.Green;
                            break;
                        case ColorEnum.Czerwony:
                            b = Brushes.Red;
                            p = Pens.Red;
                            break;
                        case ColorEnum.Niebieski:
                            b = Brushes.Blue;
                            p = Pens.Blue;
                            break;
                    }
                    e.Graphics.DrawRectangle(p, e.Bounds);
                    //e.Graphics.FillRectangle(b, e.Bounds);
                    p.Dispose();
                    b.Dispose();
                }
            }
        }

        private void ColorDesignerSelectionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
