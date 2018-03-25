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
    public partial class Detail : Form
    {
        private ListViewItem listViewItem;

        public string Kolor { get; set; }
        public string Typ { get; set; }
        public string Etykieta { get; set; }
        public string Wspolrzedne { get; set; }
        public string Pole { get; set; }

        public Detail()
        {
            InitializeComponent();
        }

        public Detail(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
            InitializeComponent();
            kolorComboBox.Text = listViewItem.SubItems[0].Text;
            typComboBox.Text = listViewItem.SubItems[1].Text;
            wspolrzedneTextBox.Text = listViewItem.SubItems[2].Text;
            poleTextBox.Text = listViewItem.SubItems[3].Text;
            etykietaTextBox.Text = listViewItem.SubItems[4].Text;
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                this.Kolor = this.kolorComboBox.SelectedItem.ToString();
                this.Typ = this.typComboBox.SelectedItem.ToString();
                this.Wspolrzedne = this.wspolrzedneTextBox.Text;
                this.Pole = this.poleTextBox.Text;
                this.Etykieta = this.etykietaTextBox.Text;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void wspolrzedneTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void kolorComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (kolorComboBox.SelectedItem != null)
                return;
            e.Cancel = true;
            detailErrorProvider.SetError(kolorComboBox, "Wybierz kolor.");
        }
        private void kolorComboBox_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(kolorComboBox, "");
        }

        private void typComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (typComboBox.SelectedItem != null)
                return;
            e.Cancel = true;
            detailErrorProvider.SetError(typComboBox, "Wybierz typ.");
        }
        private void typComboBox_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(typComboBox, "");
        }

        private void wspolrzedneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (wspolrzedneTextBox.Text != null)
                return;
            e.Cancel = true;
            detailErrorProvider.SetError(wspolrzedneTextBox, "Uzupełnij położenie współrzędnych.");
        }
        private void wspolrzedneTextBox_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(wspolrzedneTextBox, "");
        }

        private void poleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (poleTextBox.Text != null)
                return;
            e.Cancel = true;
            detailErrorProvider.SetError(poleTextBox, "Uzupełnij pole.");
        }
        private void poleTextBox_Validated(object sender, EventArgs e)
        {
            detailErrorProvider.SetError(poleTextBox, "");
        }
    }
}

