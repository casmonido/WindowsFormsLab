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
    public partial class AngleEditor : System.Drawing.Design.UITypeEditor
    {
        
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            Color color = Color.Red;
            switch (e.Value.ToString())
            {
                case "Czerwony":
                    color = Color.Red;
                    break;
                case "Zielony":
                    color = Color.Green;
                    break;
                case "Niebieski":
                    color = Color.Blue;
                    break;

            }
            // Fill background and ellipse and center point.
            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds.X, e.Bounds.Y,
            e.Bounds.Width, e.Bounds.Height);
            // Draw line along the current angle.
        }

        public override bool GetPaintValueSupported(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
        System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc =
            (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                AngleControl angleControl = new AngleControl((string)value);
                edSvc.DropDownControl(angleControl);
                return angleControl.Kolor;
            }
            return value;
        }

        public AngleEditor()
        {
        }
    }
}