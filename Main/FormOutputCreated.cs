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
    public partial class FormOutputCreated : Form {
        private int row, column;

        public int Row {
            get => row;
            set => row = value;
        }
        public int Column {
            get => column;
            set => column = value;
        }

        const int iButtonSize = 35, margin = 5;

        public FormOutputCreated(int _row, int _column) {
            InitializeComponent();

            this.Row = _row;
            this.Column = _column;

            Button btnTemp = null;

            for (int i = 0; i < this.Row; i++) {
                for (int j = 0; j < this.Column; j++) {
                    btnTemp = new Button();
                    btnTemp.Width = iButtonSize;
                    btnTemp.Height = iButtonSize;
                    btnTemp.Text = (i * Column + j + 1).ToString();
                    btnTemp.Left = margin * (i + 1) + iButtonSize * i;
                    btnTemp.Top = margin * (j + 1) + iButtonSize * j;
                    btnTemp.Click += BtnTemp_Click;
                    btnTemp.MouseHover += BtnTemp_MouseHover;
                    btnTemp.Tag = string.Format("Row {0} | Column {1}", i, j);
                    this.Controls.Add(btnTemp);
                }
            }
            this.ClientSize = new Size(Row * (iButtonSize + margin + 1) - Row + margin,
                Column * (iButtonSize + margin + 1) - Column + margin);
        }

        private void frmOutputCreated_MouseClick(object sender, MouseEventArgs e) {
            this.Close();
        }

        private void BtnTemp_MouseHover(object sender, EventArgs e) {
            this.Text = (sender as Button).Tag.ToString();
        }

        private void BtnTemp_Click(object sender, EventArgs e) {
            MessageBox.Show((sender as Button).Text);
        }
    }
}
