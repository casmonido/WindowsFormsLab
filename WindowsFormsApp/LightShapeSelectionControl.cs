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
    // This control provides the custom UI for the LightShape property 
    // of the MarqueeBorder. It is used by the LightShapeEditor. 
    public partial class LightShapeSelectionControl : System.Windows.Forms.UserControl
    {
        private MarqueeLightShape lightShapeValue = MarqueeLightShape.Square;
        private IWindowsFormsEditorService editorService = null;
        private System.Windows.Forms.Panel squarePanel;
        private System.Windows.Forms.Panel circlePanel;



        // This constructor takes a MarqueeLightShape value from the 
        // design-time environment, which will be used to display 
        // the initial state. 
        public LightShapeSelectionControl(
            MarqueeLightShape lightShape,
            IWindowsFormsEditorService editorService)
        {
            // This call is required by the designer.
            InitializeComponent();

            // Cache the light shape value provided by the  
            // design-time environment. 
            this.lightShapeValue = lightShape;

            // Cache the reference to the editor service. 
            this.editorService = editorService;

            // Handle the Click event for the two panels.  
            this.squarePanel.Click += new EventHandler(squarePanel_Click);
            this.circlePanel.Click += new EventHandler(circlePanel_Click);
        }

        // LightShape is the property for which this control provides 
        // a custom user interface in the Properties window. 
        public MarqueeLightShape LightShape
        {
            get
            {
                return this.lightShapeValue;
            }

            set
            {
                if (this.lightShapeValue != value)
                {
                    this.lightShapeValue = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (
                Graphics gSquare = this.squarePanel.CreateGraphics(),
                gCircle = this.circlePanel.CreateGraphics())
            {
                // Draw a filled square in the client area of 
                // the squarePanel control.
                gSquare.FillRectangle(
                    Brushes.Red,
                    0,
                    0,
                    this.squarePanel.Width,
                    this.squarePanel.Height
                    );

                // If the Square option has been selected, draw a  
                // border inside the squarePanel. 
                if (this.lightShapeValue == MarqueeLightShape.Square)
                {
                    gSquare.DrawRectangle(
                        Pens.Black,
                        0,
                        0,
                        this.squarePanel.Width - 1,
                        this.squarePanel.Height - 1);
                }

                // Draw a filled circle in the client area of 
                // the circlePanel control.
                gCircle.Clear(this.circlePanel.BackColor);
                gCircle.FillEllipse(
                    Brushes.Blue,
                    0,
                    0,
                    this.circlePanel.Width,
                    this.circlePanel.Height
                    );

                // If the Circle option has been selected, draw a  
                // border inside the circlePanel. 
                if (this.lightShapeValue == MarqueeLightShape.Circle)
                {
                    gCircle.DrawRectangle(
                        Pens.Black,
                        0,
                        0,
                        this.circlePanel.Width - 1,
                        this.circlePanel.Height - 1);
                }
            }
        }

        private void squarePanel_Click(object sender, EventArgs e)
        {
            this.lightShapeValue = MarqueeLightShape.Square;

            this.Invalidate(false);

            this.editorService.CloseDropDown();
        }

        private void circlePanel_Click(object sender, EventArgs e)
        {
            this.lightShapeValue = MarqueeLightShape.Circle;

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
                IServiceProvider provider,
                object value)
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
                    LightShapeSelectionControl selectionControl =
                        new LightShapeSelectionControl(
                        (MarqueeLightShape)value,
                        editorService);

                    editorService.DropDownControl(selectionControl);

                    value = selectionControl.LightShape;
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
                MarqueeLightShape shape = (MarqueeLightShape)e.Value;
                using (Pen p = Pens.Black)
                {
                    if (shape == MarqueeLightShape.Square)
                    {
                        e.Graphics.DrawRectangle(p, e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawEllipse(p, e.Bounds);
                    }
                }
            }
        }

    }
}
