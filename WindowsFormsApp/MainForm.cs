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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void dodajFigure(string kolor, string typ,
                    string wspolrzedne, string pole, string etykieta)
        {
            Figura nowa = new Figura(kolor, typ, double.Parse(pole), new WspolrzedneSrodka(3, 4), etykieta);
            listaFigur.Add(nowa);
            foreach (RefreshableForm f in widoki)
                f.refreshInsert(nowa);
        }

        public void edytujFigure(Figura tag, string kolor, string typ,
                    string wspolrzedne, string pole, string etykieta)
        {
            foreach (Figura f in listaFigur)
                if (f == tag)
                {
                    f.Kolor = kolor;
                    f.Typ = typ;
                    f.WspolrzedneSrodka.X = 4;
                    f.WspolrzedneSrodka.X = 5;
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
    }
}
