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
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        //pictureBox1.Image = new Bitmap(Application.StartupPath.Replace(@"\bin\Debug", string.Empty) + @"\icon\PopCat.gif");

        private void btnSumSeries_Click(object sender, EventArgs e) {
            new FormSumSeries().Show();
        }

        private void btnSum2Para_Click(object sender, EventArgs e) {
            new FormSimpleCalculator().Show();
        }

        private void btnCheckMFO_Click(object sender, EventArgs e) {
            new FormCheckSex().Show();
        }

        private void btnAddName_Click(object sender, EventArgs e) {
            new FormAddNames().Show();
        }

        private void btnFindMaxAndMin_Click(object sender, EventArgs e) {
            new FormFindMinMax().Show();
        }

        private void btnReadNumbers_Click(object sender, EventArgs e) {
            new FormReadNumbers().Show();
        }

        private void btnCreateForm_Click(object sender, EventArgs e) {
            new FormCreateCustomForm().Show();
        }

        private void btnMenuFood_Click(object sender, EventArgs e) {
            new FormMenuFood().Show();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void maximunSizeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

    }
}
