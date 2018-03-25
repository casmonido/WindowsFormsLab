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
        public MainForm()
        {
            InitializeComponent();
        }

        private void otwórzListęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
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
    }
}
