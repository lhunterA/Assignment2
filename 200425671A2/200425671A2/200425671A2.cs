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
        String currentInput = "";
        String operation = "";

        double num1 = 0;
        double num2 = 0;

        Calculator Calc = new Calculator(); //creating an instance of the calculator class

        public frmCalculator()
        {
            InitializeComponent();
        }

        #region NumberButtonsClick

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

        #region OtherButtonsClick
        /// <summary>
        /// if there is already a decimal in the number don't do anything. 
        /// If it is the first input add a zero before the decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (currentInput.IndexOf(".") == -1)
            {
                if (currentInput.IndexOf(".") == 1)
                {
                    currentInput += "0.";
                    txtInputField.Text = currentInput;
                }
                else
                {
                    currentInput += ".";
                    txtInputField.Text = currentInput;
                }
            }
            else
            {
                txtInputField.Text = currentInput;
            }
        }


        /// <summary>
        /// Adding or removing a negative sign from the displayed text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (currentInput != "0")
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
            else
            {
                txtInputField.Text = currentInput;
            }
        }

        /// <summary>
        /// Remove the last added digit from the number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            currentInput = currentInput.Remove(currentInput.Length - 1);
            txtInputField.Text = currentInput;

        }

        /// <summary>
        /// When the button is pressed the entire calculator clears, excluding the memory stored. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            txtInputField.Text = currentInput;
        }
        #endregion

        #region OtherButtonsTypes
        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                currentInput = currentInput.Remove(currentInput.Length - 1);
                txtInputField.Text = currentInput;
            }
        }

        private void btnDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentInput.IndexOf(".") == -1)
            {
                if (currentInput.IndexOf(".") == 1)
                {
                    currentInput += "0.";
                    txtInputField.Text = currentInput;
                }
                else
                {
                    currentInput += ".";
                    txtInputField.Text = currentInput;
                }
            }
            else
            {
                txtInputField.Text = currentInput;
            }
        }
        #endregion

        #region NumberButtonsTyped
        private void btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentInput != "0")
            {
                currentInput += "0";
                txtInputField.Text = currentInput;
            }
            else
                txtInputField.Text = currentInput;
        }
        private void btn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "1";
            txtInputField.Text = currentInput;
        }

        private void btn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "2";
            txtInputField.Text = currentInput;
        }

        private void btn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "3";
            txtInputField.Text = currentInput;
        }
        private void btn4_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "4";
            txtInputField.Text = currentInput;
        }

        private void btn5_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "5";
            txtInputField.Text = currentInput;
        }

        private void btn6_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "6";
            txtInputField.Text = currentInput;
        }

        private void btn7_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "7";
            txtInputField.Text = currentInput;
        }

        private void btn8_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "8";
            txtInputField.Text = currentInput;
        }

        private void btn9_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentInput += "9";
            txtInputField.Text = currentInput;
        }
        #endregion

        #region operationClick
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "Divide";
            Double.TryParse(currentInput, out num1);
            currentInput = "";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "Multiply";
            Double.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "Minus";
            Double.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "Add";
            Double.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            Double.TryParse(currentInput, out num1);
            currentInput = "";
            txtInputField.Text = Calc.SquareRoot(num1).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            Double.TryParse(currentInput, out num1);
            currentInput = "";
            txtInputField.Text = Calc.Factor(num1).ToString();
        }


        #endregion

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Double.TryParse(currentInput, out num2);
            currentInput = "";

            if (num2 == 0 && operation == "Divide")
            {
                txtInputField.Text = "ERROR";
                num1 = 0;
                num2 = 0;
                operation = "";
            }
            else
            {
                switch (operation)
                {
                    case "Add":
                        txtInputField.Text = Calc.Add(num1, num2).ToString();
                        break;
                    case "Minus":
                        txtInputField.Text = Calc.Subtract(num1, num2).ToString();
                        break;
                    case "Multiply":
                        txtInputField.Text = Calc.Multiply(num1, num2).ToString();
                        break;
                    case "Divide":
                        txtInputField.Text = Calc.Divide(num1, num2).ToString();
                        break;
                }
            }
        }
    }
}



