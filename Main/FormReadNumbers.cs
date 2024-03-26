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
    public partial class FormReadNumbers : Form {
        public FormReadNumbers() {
            InitializeComponent();
        }

        string ConvertNumberToDigit(char cNumInput) {
            switch (cNumInput) {
                case '1':
                    return "một";
                case '2':
                    return "hai";
                case '3':
                    return "ba";
                case '4':
                    return "bốn";
                case '5':
                    return "năm";
                case '6':
                    return "sáu";
                case '7':
                    return "bảy";
                case '8':
                    return "tám";
                case '9':
                    return "chín";
                default:
                    return "";
            }
        }

        string ConvertBigNumberToDigit(int iNumInput) {
            switch (iNumInput) {
                case 1:
                    return "ngàn";
                case 2:
                    return "triệu";
                case 3:
                    return "tỷ";
                default:
                    return "";
            }
        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e) {
            StringBuilder strBReadNum = new StringBuilder();
            string strTemp = txtBoxInput.Text;
            if (strTemp == "") {
                strBReadNum.Append("");
            }
            else if (strTemp == "0") {
                strBReadNum.Append("không");
            }
            else if (strTemp.Length == 1) {
                strBReadNum.Append(ConvertNumberToDigit(strTemp[0]));
            }
            else if (strTemp == "10") {
                strBReadNum.Append("mười");
            }
            else {
                int iTemp = strTemp.Length / 3;
                for (int k = 1; k <= iTemp; k++) {
                    for (int i = strTemp.Length - 1; i >= 0; i -= 3) {
                        for (int j = i; j > i - 3 && j >= 0; j--) {
                            strBReadNum.Insert(0, ConvertNumberToDigit(strTemp[j]) + " ");
                        }
                        strBReadNum.Insert(0, ConvertBigNumberToDigit(strTemp[k]) + " ");
                    }
                }
            }
            if (strBReadNum.Length != 0) {
                txtBoxResult.Text = strBReadNum.Insert(0, char.ToUpper(strBReadNum[0])).Remove(1, 1).ToString();
            }
            else {
                txtBoxResult.Text = strBReadNum.ToString();
            }
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            KeyHandler.txtBoxNum_KeyPress(sender, e);
        }
    }
}
