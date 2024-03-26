using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main {
    public partial class FormAddNames : Form {
        public FormAddNames() {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e) {
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            string title = comboBoxTitle.Text;
            string nameToAdd = title + " " + firstName + " " + lastName;
            listBoxNames.Items.Add(nameToAdd);
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            comboBoxTitle.Text = "";
        }
    }
}
