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
        IWindowsFormsEditorService _service;


        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            Color color = Color.Black;
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
            e.Graphics.FillRectangle(new SolidBrush(color), 
                e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width, e.Bounds.Height);
        }

        public override bool GetPaintValueSupported(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
        System.IServiceProvider provider, object value)
        {
            if (provider == null)
                return value;
            _service =
                ((IWindowsFormsEditorService)provider.GetService(
                    typeof(IWindowsFormsEditorService)));

            if (_service != null && value is DropDownListProperty)
            {
                //AngleControl angleControl = new AngleControl((string)value);

                var property = (DropDownListProperty)value;
                DropDownListProperty p = new DropDownListProperty();
                var list = new ListBox();
                list.Click += ListBox_Click;

                foreach (string item in property.Values)
                {
                    list.Items.Add(item);
                }
                // Drop the list control.
                _service.DropDownControl(list);

                if (list.SelectedItem != null && list.SelectedIndices.Count == 1)
                {
                    property.SelectedItem = list.SelectedItem.ToString();
                    value = property;
                }
            }

            return value;
        }

        private void ListBox_Click(object sender, EventArgs e)
        {
            if (_service != null)
                _service.CloseDropDown();
        }

        /// <summary>
        /// Gets the editing style of the <see cref="EditValue"/> method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns>Returns the DropDown style, since this editor uses a drop down list.</returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            // We're using a drop down style UITypeEditor.
            return UITypeEditorEditStyle.DropDown;
        }
    }
}