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
        }

        private void otworzListęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista(ref listaFigur);
            widoki.Add(lista);
            lista.MdiParent = this;
            lista.Show();
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void dodajFigure(string kolor, string typ,
                    string wspolrzedne, string pole, string etykieta)
        {
            listaFigur.Add(new Figura(kolor, typ, 3.4, new WspolrzedneSrodka(3, 4)));
            foreach (RefreshableForm f in widoki)
                f.refresh();
        }

        public void edytujFigure()
        {

            foreach (RefreshableForm f in widoki)
                f.refresh();
        }

        public void usunFigure()
        {

            foreach (RefreshableForm f in widoki)
                f.refresh();
        }
    }
}
