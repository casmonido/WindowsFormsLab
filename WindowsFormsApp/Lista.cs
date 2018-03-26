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
        private List<Figura> listaFigur; //ref?

        public Lista(ref List<Figura> listaFigur)
        {
            this.listaFigur = listaFigur;
            InitializeComponent();
        }

        public void refresh()
        {
            shapeList.Items.Clear();
            foreach (Figura d in listaFigur)
            {
                ListViewItem lvi = new ListViewItem(d.Kolor);
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
                shapeList.SelectedItems[0].SubItems[0].Text = d.Kolor;
                shapeList.SelectedItems[0].SubItems[1].Text = d.Typ;
                shapeList.SelectedItems[0].SubItems[2].Text = d.Wspolrzedne;
                shapeList.SelectedItems[0].SubItems[4].Text = d.Pole;
                shapeList.SelectedItems[0].SubItems[5].Text = d.Etykieta;
            }
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems.Count < 1)
                return;
            shapeList.SelectedItems[0].Remove();
        }

    }
}
