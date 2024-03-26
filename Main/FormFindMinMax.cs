using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace Main {
    public partial class FormFindMinMax : Form {
        public FormFindMinMax() {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e) {
            int a = InputHandler.ParseIntNumber(txtBoxInputA.Text);
            int b = InputHandler.ParseIntNumber(txtBoxInputB.Text);
            int c = InputHandler.ParseIntNumber(txtBoxInputC.Text);
            List<int> iList = new List<int>() { a, b, c };
            txtBoxOutputMax.Text = iList.Max().ToString();
            txtBoxOutputMin.Text = iList.Min().ToString();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            KeyHandler.txtBoxNum_KeyPress(sender, e);
        }
    }
}
