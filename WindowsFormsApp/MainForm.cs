﻿using System;
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
        }

        private void otworzListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            widoki.Add(lista);
            lista.MdiParent = this;
            lista.Show();
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

        public void dodajFigure(string kolor, string typ,
                    string wspolrzedne, string pole, string etykieta)
        {
            listaFigur.Add(new Figura(kolor, typ, 3.4, new WspolrzedneSrodka(3, 4)));
            foreach (RefreshableForm f in widoki)
                f.refresh(ref listaFigur);
        }

        public void edytujFigure(object tag, string kolor, string typ,
                    string wspolrzedne, string pole, string etykieta)
        {

            foreach (RefreshableForm f in widoki)
                f.refresh(ref listaFigur);
        }

        public void usunFigure(Figura tag)
        {
            listaFigur.Remove(tag);
            foreach (RefreshableForm f in widoki)
                f.refresh(ref listaFigur);
        }
    }
}
