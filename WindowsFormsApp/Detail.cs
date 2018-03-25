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
        public string Kolor { get; set; }
        public string Typ { get; set; }
        public string Etykieta { get; set; }

        public Detail()
        {
            InitializeComponent();
        }

        public Detail(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                this.Kolor = this.colorComboBox.SelectedItem.ToString();
                this.Typ = this.typeComboBox.SelectedItem.ToString();
            }
        }

        private void colorComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (colorComboBox.SelectedItem != null)
                return;
            e.Cancel = true;
            errorProvider1.SetError(colorComboBox, "Wybierz kolor.");
        }
        private void colorComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(colorComboBox, "");
        }

        private void typeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (typeComboBox.SelectedItem != null)
                return;
            e.Cancel = true;
            errorProvider1.SetError(typeComboBox, "Wybierz typ.");
        }

        private void typeComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(typeComboBox, "");
        }
    }
}
