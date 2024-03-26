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
    public partial class FormCheckSex : Form {
        public FormCheckSex() {
            InitializeComponent();
            txtBoxOutput.Text = "You are other";
        }

        private void checkBox_CheckedStateChanged(object sender, EventArgs e) {
            string choose;

            switch (checkBox.CheckState) {
            case CheckState.Unchecked:
                choose = "famale";
                break;
            case CheckState.Checked:
                choose = "male";
                break;
            default:
                choose = "other";
                break;
            }

            txtBoxOutput.Text = string.Format("You are {0}", choose);
        }
    }
}
