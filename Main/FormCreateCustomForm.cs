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
    public partial class FormCreateCustomForm : Form {
        public FormCreateCustomForm() {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            int row, column;
            if (!int.TryParse(txtBoxRow.Text, out row)) {
                row = 1;
            }
            if (!int.TryParse(txtBoxColumn.Text, out column)) {
                column = 1;
            }
            FormOutputCreated frm = new FormOutputCreated(row, column);
            frm.ShowDialog();
        }
    }
}
