using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detail d = new Detail();
            if (d.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem(d.Kolor);
                lvi.SubItems.Add(d.Typ);
                shapeList.Items.Add(lvi);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modyfikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems.Count < 1)
                return;
            Detail d = new Detail(shapeList.SelectedItems[0]);
            if (d.ShowDialog() == DialogResult.OK)
            {
                shapeList.SelectedItems[0].SubItems.Add("sdd");
            }
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems.Count < 1)
                return;
            shapeList.SelectedItems[0].Remove();
        }
    }
}
