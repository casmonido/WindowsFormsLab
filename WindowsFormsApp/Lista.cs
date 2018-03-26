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
    public partial class Lista : Form, RefreshableForm
    {
        public Lista()
        {
            InitializeComponent();
        }

        public void refresh(ref List<Figura> list)
        {
            shapeList.Items.Clear();
            foreach (Figura d in list)
            {
                ListViewItem lvi = new ListViewItem(d.Kolor);
                lvi.Tag = d;
                lvi.SubItems.Add(d.Typ);
                lvi.SubItems.Add(d.WspolrzedneSrodka.toString());
                lvi.SubItems.Add(d.Pole.ToString());
                lvi.SubItems.Add(d.Etykieta);
                shapeList.Items.Add(lvi);
            }
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detail d = new Detail();
            if (d.ShowDialog() == DialogResult.OK)
            {
                ((MainForm) this.MdiParent).dodajFigure(d.Kolor, d.Typ,
                    d.Wspolrzedne, d.Pole, d.Etykieta);
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
                ((MainForm)this.MdiParent).edytujFigure(shapeList.SelectedItems[0].Tag, 
                    d.Kolor, d.Typ, d.Wspolrzedne, d.Pole, d.Etykieta);
            }
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems.Count < 1)
                return;
            ((MainForm)this.MdiParent).usunFigure((Figura)shapeList.SelectedItems[0].Tag);
        }

    }
}
