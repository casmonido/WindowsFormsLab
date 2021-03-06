﻿using System;
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
    public partial class ShapeDesignerSelectionControl : UserControl
    {
        public ShapeDesignerSelectionControl()
        {
            InitializeComponent();
        }
        private ShapeEnum shapeValue = ShapeEnum.Koło;
        private IWindowsFormsEditorService editorService = null;

        public ShapeDesignerSelectionControl(
            ShapeEnum shapeVal,
            IWindowsFormsEditorService editorService)
        {
            InitializeComponent();
            this.shapeValue = shapeVal;
            this.editorService = editorService;
            //this.greenPanel.Click += new EventHandler(greenPanel_Click);
            //this.redPanel.Click += new EventHandler(redPanel_Click);
            //this.bluePanel.Click += new EventHandler(bluePanel_Click);
        }

        public ShapeEnum Typ
        {
            get
            {
                return this.shapeValue;
            }

            set
            {
                if (this.shapeValue != value)
                {
                    this.shapeValue = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /*
            using (Graphics gBlue = this.bluePanel.CreateGraphics(),
                gGreen = this.greenPanel.CreateGraphics(),
                gRed = this.redPanel.CreateGraphics())

            {
                SolidBrush brush = new SolidBrush(Color.Ivory);
                gGreen.FillRectangle(
                Brushes.Green,
                0, 0,
                this.greenPanel.Width,
                this.greenPanel.Height
                );*/
            /*gRed.FillRectangle(
            Brushes.Red,
            0, 0,
            this.redPanel.Width,
            this.redPanel.Height
            );
            brush.Dispose();
        }*/
        }
        /*
        private void bluePanel_Click(object sender, EventArgs e)
        {
            this.shapeValue = ColorEnum.Niebieski;
            this.Invalidate(false);
            this.editorService.CloseDropDown();
        }*/

        private void ShapeDesignerSelectionControl_Load(object sender, EventArgs e)
        {

        }
        internal class ShapeEditor : UITypeEditor
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
                    ShapeDesignerSelectionControl selectionControl =
                        new ShapeDesignerSelectionControl(
                        (ShapeEnum)value,
                        editorService);
                    editorService.DropDownControl(selectionControl);
                    value = selectionControl.Typ;
                }
                return value;
            }

            public override bool GetPaintValueSupported(
                ITypeDescriptorContext context)
            {
                return true;
            }

            public override void PaintValue(PaintValueEventArgs e)
            {
                ShapeEnum shape = (ShapeEnum)e.Value;
                Pen p = Pens.Ivory;
                {
                    switch (shape)
                    {
                        case ShapeEnum.Koło:
                            e.Graphics.DrawEllipse(p, e.Bounds);
                            break;
                        case ShapeEnum.Kwadrat:
                            e.Graphics.DrawRectangle(p, e.Bounds);
                            break;
                        case ShapeEnum.Trójkąt:
                            e.Graphics.DrawImage(global::WindowsFormsApp.Properties.Resources.triangle, e.Bounds);
                            break;
                    }
                    p.Dispose();
                }
            }
        }
    }
}
