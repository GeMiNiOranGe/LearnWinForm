using System;
using System.Windows.Forms;

namespace Main {
    public static class KeyHandler {
        /// <summary>
        /// Allow number keys and control keys to pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void txtBoxNum_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
    public static class InputHandler {
        /// <summary>
        /// If the string input is empty, return integer zero and otherwise
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static int ParseIntNumber(string strInput) {
            if (strInput != "") {
                return int.Parse(strInput);
            }
            return 0;
        }
    }
}