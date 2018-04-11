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
        private event EventHandler ListItemsCount;
        bool pow100 = true;
        bool pon100 = true; 

        public Lista(ref List<Figura> list)
        {
            reflist = list;
            InitializeComponent();
            this.Activated += new EventHandler(FrmChild_Activated);
            this.Deactivate += new EventHandler(FrmChild_Deactivate);
            this.ListItemsCount += ChangeStatusStripText;
            toolStripComboBox1.SelectedItem = filtr[0];
            refresh();
        }

        private void ChangeStatusStripText(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text =
                this.DisplayedListSize().ToString();
        }

        void FrmChild_Deactivate(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Visible = false;
            toolStripStatusLabel.Visible = false;
            statusStrip.Visible = false;
        }

        void FrmChild_Activated(object sender, EventArgs e)
        {
            menuToolStripMenuItem.Visible = true;
            toolStripStatusLabel.Visible = true;
            statusStrip.Visible = true;
        }

        private void refresh()
        {
            shapeList.Items.Clear();
            foreach (Figura d in reflist)
            {
                if ((pon100 && d.Pole < 100) ||
                    (pow100 && d.Pole >= 100))
                    addFigureToList(ref shapeList, d); 
            }
            emitEventNumOfVisibleElementsChanged();
        }

        private void addFigureToList(ref ListView list, Figura d)
        {
            ListViewItem lvi = new ListViewItem(d.Kolor.ToString());
            lvi.Tag = d;
            lvi.SubItems.Add(d.Typ.ToString());
            lvi.SubItems.Add(d.WspolrzedneSrodka.toString());
            lvi.SubItems.Add(d.Pole.ToString());
            lvi.SubItems.Add(d.Etykieta);
            list.Items.Add(lvi);
        }

        private void modifyFigureOnList(ListViewItem f, Figura d)
        {
            f.SubItems[0].Text = d.Kolor.ToString();
            f.SubItems[1].Text = d.Typ.ToString();
            f.SubItems[2].Text = d.WspolrzedneSrodka.toString();
            f.SubItems[3].Text = d.Pole.ToString();
            f.SubItems[4].Text = d.Etykieta;
        }

        public void refreshModify(Figura d)
        {
            if ((pon100 && d.Pole < 100) ||
                    (pow100 && d.Pole >= 100))
            {
                foreach (ListViewItem f in shapeList.Items)
                    if (f.Tag == d)
                    {// modyfikuj
                        modifyFigureOnList(f, d);
                        emitEventNumOfVisibleElementsChanged();
                        return;
                    }
                //nie znaleziono
                addFigureToList(ref shapeList, d);
                emitEventNumOfVisibleElementsChanged();
                return;
            }
            //else
            refreshDelete(d);
            emitEventNumOfVisibleElementsChanged();
        }

        private void emitEventNumOfVisibleElementsChanged()
        {
            if (ListItemsCount != null)
            {
                ListItemsCount(this, null);
            }
        }

        public void refreshInsert(Figura d)
        {
            if ((pon100 && d.Pole < 100) ||
                (pow100 && d.Pole >= 100))
                addFigureToList(ref shapeList, d);
            emitEventNumOfVisibleElementsChanged();
        }

        public void refreshDelete(Figura d)
        {
            foreach (ListViewItem f in shapeList.Items)
            if (f.Tag == d)
            {
                shapeList.Items.Remove(f);
                emitEventNumOfVisibleElementsChanged();
                return;
            }
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems != null && shapeList.SelectedItems.Count == 1)
            {
                //można modyfikować?
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modyfikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapeList.SelectedItems.Count < 1)
                return;
            Detail d = new Detail((Figura)shapeList.SelectedItems[0].Tag);
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private string[] filtr = { "Wszystkie",
            "Pokaż elementy do 100 pola",
            "Pokaż elementy powyżej 100 pola"};
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = toolStripComboBox1.SelectedItem.ToString();
            if (filtr[0].Equals(str))
            {
                pon100 = true;
                pow100 = true;
            }
            if (filtr[1].Equals(str))
            {
                pon100 = true;
                pow100 = false;
            }
            if (filtr[2].Equals(str))
            {
                pon100 = false;
                pow100 = true;
            }
            refresh();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
