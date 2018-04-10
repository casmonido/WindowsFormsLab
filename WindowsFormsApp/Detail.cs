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
    public partial class Detail : Form
    {
        private ListViewItem listViewItem;

        public ColorEnum Kolor { get; set; }
        public ShapeEnum Typ { get; set; }
        public string Etykieta { get; set; }
        public WspolrzedneSrodka Wspolrzedne { get; set; }
        public string Pole { get; set; }

        public Detail()
        {
            InitializeComponent();
        }

        private void copyToControls(ListViewItem listViewItem)
        {
            Figura f = (Figura) listViewItem.Tag;
            colorUserControl.Kolor = f.Kolor;
            shapeUserControl.Typ = f.Typ;
            xtextBox.Text = f.WspolrzedneSrodka.X.ToString();
            ytextBox.Text = f.WspolrzedneSrodka.Y.ToString();
            poleTextBox.Text = f.Pole.ToString();
            etykietaTextBox.Text = f.Etykieta;
        }

        private void copyToPublicAttributes()
        {
            this.Kolor = this.colorUserControl.Kolor;
            this.Typ = shapeUserControl.Typ;
            this.Wspolrzedne = new WspolrzedneSrodka(this.xtextBox.Text, this.ytextBox.Text);
            this.Pole = this.poleTextBox.Text;
            this.Etykieta = this.etykietaTextBox.Text;
        }

        public Detail(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
            InitializeComponent();
            copyToControls(listViewItem);
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                copyToPublicAttributes();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void wspolrzedneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wspolrzednaY_Validating(object sender, CancelEventArgs e)
        {
            if (ytextBox.Text != null)
            {
                bool ok = true;
                try
                {
                    int.Parse(ytextBox.Text);
                }
                catch
                {
                    ok = false;
                }
                if (ok)
                    return;
            }
            e.Cancel = true;
            detailErrorProvider.SetError(ytextBox, "Uzupełnij położenie współrzędnej (int).");
        }
        private void wspolrzednaY_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(ytextBox, "");
        }
        private void wspolrzednaX_Validating(object sender, CancelEventArgs e)
        {
            if (xtextBox.Text != null)
            {
                bool ok = true; 
                try
                {
                    int.Parse(xtextBox.Text);
                }
                catch
                {
                    ok = false;
                }
                if (ok)
                    return;
            }
            e.Cancel = true;
            detailErrorProvider.SetError(xtextBox, "Uzupełnij położenie współrzędnej (int).");
        }
        private void wspolrzednaX_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(xtextBox, "");
        }

        private void poleTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double.Parse(poleTextBox.Text);
            } catch
            {
                detailErrorProvider.SetError(poleTextBox, "Kontrolka zawiera nieprawidłowe znaki.");
                e.Cancel = true;
            }  
        }
        private void poleTextBox_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(poleTextBox, "");
        }

        private void colorUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

