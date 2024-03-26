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
    public partial class FormMenuFood : Form {
        public FormMenuFood() {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e) {
            listBoxMenuAdded.Items.Add(txtBoxNameFood.Text);
            txtBoxNameFood.Text = "";
        }

        private void btnAddOne_Click(object sender, EventArgs e) {
            foreach (string item1 in listBoxMenuAdded.SelectedItems) {
                bool isDuplicate = false;
                foreach (string item2 in listBoxMenuChoose.Items) {
                    if (item1 == item2) {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) {
                    listBoxMenuChoose.Items.Add(item1);
                }
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e) {
            foreach (string item1 in listBoxMenuAdded.Items) {
                bool isDuplicate = false;
                foreach (string item2 in listBoxMenuChoose.Items) {
                    if (item1 == item2) {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) {
                    listBoxMenuChoose.Items.Add(item1);
                }
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e) {
            listBoxMenuChoose.Items.Remove(listBoxMenuChoose.SelectedItem);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e) {
            listBoxMenuChoose.Items.Clear();
        }
    }
}

