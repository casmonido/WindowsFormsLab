﻿using System;
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
        [EditorAttribute(typeof(AngleEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Color picker")]
        [BrowsableAttribute(true)]
        public string Kolor
        {
            set
            {
                comboBox.Text = value;
                Invalidate();
            }
            get
            {
                if (comboBox.SelectedItem != null)
                    return comboBox.SelectedItem.ToString();
                return "";
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
            button.BackColor = Color.Blue;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}