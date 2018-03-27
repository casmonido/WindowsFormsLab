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
        List<Figura> reflist;

        public Lista(ref List<Figura> list)
        {
            reflist = list;
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            shapeList.Items.Clear();
            foreach (Figura d in reflist)
            {
                if ((filtrLowerCheckBox.Checked && d.Pole < 100) ||
                    (filtrUpperCheckBox.Checked && d.Pole >= 100))
                    addFigureToList(ref shapeList, d); //hurr
            }
        }

        private void addFigureToList(ref ListView list, Figura d)
        {
            ListViewItem lvi = new ListViewItem(d.Kolor);
            lvi.Tag = d;
            lvi.SubItems.Add(d.Typ);
            lvi.SubItems.Add(d.WspolrzedneSrodka.toString());
            lvi.SubItems.Add(d.Pole.ToString());
            lvi.SubItems.Add(d.Etykieta);
            list.Items.Add(lvi);
        }

        private void modifyFigureOnList(ListViewItem f, Figura d)
        {
            f.SubItems[0].Text = d.Kolor;
            f.SubItems[1].Text = d.Typ;
            f.SubItems[2].Text = d.WspolrzedneSrodka.toString();
            f.SubItems[3].Text = d.Pole.ToString();
            f.SubItems[4].Text = d.Etykieta;
        }

        public void refreshModify(Figura d)
        {
            if ((filtrLowerCheckBox.Checked && d.Pole < 100) ||
                    (filtrUpperCheckBox.Checked && d.Pole >= 100))
            {
                foreach (ListViewItem f in shapeList.Items)
                    if (f.Tag == d)
                    {// modyfikuj
                        modifyFigureOnList(f, d);
                        return;
                    }
                //nie znaleziono
                addFigureToList(ref shapeList, d);
                return;
            }
            //else
            refreshDelete(d);
        }

        public void refreshInsert(Figura d)
        {
            if ((filtrLowerCheckBox.Checked && d.Pole < 100) ||
                (filtrUpperCheckBox.Checked && d.Pole >= 100))
                addFigureToList(ref shapeList, d);
        }

        public void refreshDelete(Figura d)
        {
            foreach (ListViewItem f in shapeList.Items)
            if (f.Tag == d)
            {
                shapeList.Items.Remove(f);
                return;
            }
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detail d = new Detail();
            if (d.ShowDialog() == DialogResult.OK)
                ((MainForm) this.MdiParent).dodajFigure(d.Kolor, d.Typ,
                    d.Wspolrzedne, d.Pole, d.Etykieta);
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
                ((MainForm)this.MdiParent).edytujFigure((Figura)shapeList.SelectedItems[0].Tag, 
                    d.Kolor, d.Typ, d.Wspolrzedne, d.Pole, d.Etykieta);
        }

        public int DisplayedListSize()
        {
            return shapeList.Items.Count;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filtrUpperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void filtrLowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
