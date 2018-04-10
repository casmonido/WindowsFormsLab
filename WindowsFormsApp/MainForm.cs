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
    public partial class MainForm : Form
    {
        private List<Figura> listaFigur = new List<Figura>();
        private List<RefreshableForm> widoki = new List<RefreshableForm>();

        public MainForm()
        {
            InitializeComponent();
            LayoutMdi(MdiLayout.Cascade);
            this.MdiChildActivate += MdiChildActiveChanged;
            otworzListe();
        }

        private Form mPrevChild;

        private void MdiChildActiveChanged(object sender, EventArgs e)
        {
            //toolStripStatusLabel
            if (mPrevChild != null && !mPrevChild.IsDisposed && this.statusStrip.Items.Count > 0)
            {
                // Move them back
                StatusStrip dest = (StatusStrip)mPrevChild.Controls["statusStrip"];
                StatusStrip srce = this.statusStrip;
                while (srce.Items.Count > 0)
                {
                    ToolStripItem item = srce.Items[0];
                    srce.Items.RemoveAt(0);
                    dest.Items.Add(item);
                }
            }
            mPrevChild = this.ActiveMdiChild;
            if (mPrevChild != null)
            {
                // Move status strip items from child to our status strip
                StatusStrip srce = (StatusStrip)mPrevChild.Controls["statusStrip"];
                StatusStrip dest = this.statusStrip;
                if (srce != null)
                {
                    while (srce.Items.Count > 0)
                    {
                        ToolStripItem item = srce.Items[0];
                        srce.Items.RemoveAt(0);
                        dest.Items.Add(item);
                    }
                    srce.Visible = false;
                }
            }
        
        }

        private void otworzListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otworzListe();
        }

        private void otworzListe()
        {
            Lista lista = new Lista(ref listaFigur);
            widoki.Add(lista);
            lista.MdiParent = this;
            lista.FormClosing += Frame_FormClosing;
            lista.Show();
        }

        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.MdiFormClosing))
            {
                widoki.Remove((RefreshableForm)sender);
                return;
            }
            if (widoki.Count == 1)
            {
                e.Cancel = true;
                return;
            }
            widoki.Remove((RefreshableForm)sender);
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void dodajFigure(ColorEnum kolor, string typ,
                    WspolrzedneSrodka wspolrzedne, string pole, string etykieta)
        {
            Figura nowa = new Figura(kolor, typ, double.Parse(pole), wspolrzedne, etykieta);
            listaFigur.Add(nowa);
            foreach (RefreshableForm f in widoki)
                f.refreshInsert(nowa);
        }

        public void edytujFigure(Figura tag, ColorEnum kolor, string typ,
                    WspolrzedneSrodka wspolrzedne, string pole, string etykieta)
        {
            foreach (Figura f in listaFigur)
                if (f == tag)
                {
                    f.Kolor = kolor;
                    f.Typ = typ;
                    f.WspolrzedneSrodka = wspolrzedne;
                    f.Pole = double.Parse(pole);
                    f.Etykieta = etykieta;
                }
            foreach (RefreshableForm rf in widoki)
                rf.refreshModify(tag);
        }

        public void usunFigure(Figura tag)
        {
            listaFigur.Remove(tag);
            foreach (RefreshableForm f in widoki)
                f.refreshDelete(tag);
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
