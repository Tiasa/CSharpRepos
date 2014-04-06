using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4 {
    public partial class NumericInputDialog : Form {
        private double result = 0;
        public NumericInputDialog(IWin32Window owner) {
            InitializeComponent();
            
            if (this.ShowDialog(owner) == DialogResult.OK) {
                result = Double.Parse(numTextBox.Text);
            }
            this.Dispose();
        }
        public TextBox numText;

        private void clearBtn_Click(object sender, EventArgs e) {
            numTextBox.Text = "";
        }

        private void numBtn_Click(object sender, EventArgs e) {
            if (numTextBox.Text.Length >= 8) return;
            Button pushedButton = (Button)sender;
            if (pushedButton.Text.Length == 2 && numTextBox.Text.Length >= 7) return;
            numTextBox.Text += pushedButton.Text;
            Console.Beep(); // NOT WORKEY ON x64 SYSTEM.
        }

        private void backspaceBtn_Click(object sender, EventArgs e) {
            if (numTextBox.Text == "") return;
            numTextBox.Text = numTextBox.Text.Remove(numTextBox.Text.Length - 1, 1);
        }

        public double getResult() {
            return result;
        }
    }
}
