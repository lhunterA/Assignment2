using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200425671A2
{
    public partial class frmCalculator : Form
    {
        /// <summary>
        /// The Global Variables for the Calculator Class
        /// </summary>
        String[] input = new String[10]; //make an array of 10 inputs
        String operation = "";
        String currentInput = "";

        public frmCalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the button is pressed the entire calculator clears, excluding the memory stored. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";

        }

        /// <summary>
        /// Remove the last added digit from the number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            currentInput = currentInput.Remove(currentInput.Length-1);
            txtInputField.Text = currentInput;

        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                currentInput = currentInput.Remove(currentInput.Length - 1);
                txtInputField.Text = currentInput;
            }
        }

        #region NumberButtons

        private void btn0_Click(object sender, EventArgs e)
        {
            currentInput += "0";
            txtInputField.Text = currentInput;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            currentInput += "1";
            txtInputField.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentInput += "2";
            txtInputField.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentInput += "3";
            txtInputField.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentInput += "4";
            txtInputField.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentInput += "5";
            txtInputField.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            currentInput += "6";
            txtInputField.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            currentInput += "7";
            txtInputField.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            currentInput += "8";
            txtInputField.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            currentInput += "9";
            txtInputField.Text = currentInput;
        }
        #endregion
        /// <summary>
        /// if there is already a decimal in the number don't do anything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (currentInput.IndexOf(".") == -1)
            {
                currentInput += ".";
                txtInputField.Text = currentInput;
            }
            else
                txtInputField.Text = currentInput;

        }
        /// <summary>
        /// Adding or removing a negative sign from the displayed text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (currentInput.IndexOf("-") == -1)
            {
                currentInput = currentInput.Insert(0, "-");
                txtInputField.Text = currentInput;
            }
            else
                currentInput = currentInput.Remove(0, 1);
                txtInputField.Text = currentInput;
        }

        
    }
}
