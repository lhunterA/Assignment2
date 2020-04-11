using System;
using System.Windows.Forms;

namespace _200425671A2
{
    public partial class frmCalculator : Form
    {
        /// <summary>
        /// The Global Variables for the form
        /// </summary>
        String currentInput = "";
        String operation = "";
        String memCurrentInput = "";

        decimal num1 = 0;
        decimal num2 = 0;

        Calculator Calc = new Calculator(); //creating an instance of the Calculator class
        MemoryCalculator mc = new MemoryCalculator(); //creating an instance of the MemoryCalculator class

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
        /// Adding a decimal to a number with some error handling: 
        /// if there is already a decimal in the number don't add another one, 
        /// and
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
            num1 = 0;
            num2 = 0;
        }


        /// <summary>
        /// When the equals button is clicked, it checks the current value of  the String variable operation
        /// and then performs the correct basic calculation.
        /// With divide by Zero error handling.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num2);
            currentInput = "";

            if (num2 == 0 && operation == "Divide")
            {
                txtInputField.Text = "ERROR: CANNOT DIVIDE BY ZERO";
                num1 = 0;
                num2 = 0;
                operation = "";
            }
            else
            {
                switch (operation)
                {
                    case "Add":
                        txtInputField.Text = Calc.Add(num1, num2);
                        currentInput = txtInputField.Text;
                        break;
                    case "Minus":
                        txtInputField.Text = Calc.Subtract(num1, num2);
                        currentInput = txtInputField.Text;
                        break;
                    case "Multiply":
                        txtInputField.Text = Calc.Multiply(num1, num2);
                        currentInput = txtInputField.Text;
                        break;
                    case "Divide":
                        txtInputField.Text = Calc.Divide(num1, num2);
                        currentInput = txtInputField.Text;
                        break;
                }
            }
        }
        #endregion

        #region operationButtonsClick
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "Divide";
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "Multiply";
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "Minus";
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = "Add";
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
            txtInputField.Text = Calc.SquareRoot(num1);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
            txtInputField.Text = Calc.Factor(num1);
        }


        #endregion


        #region MemoryButtonsClick

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            txtMemoryBox.Text = "";
            memCurrentInput = "";
            
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            txtInputField.Text = memCurrentInput;
            currentInput = memCurrentInput;
        }

        private void btnMemSave_Click(object sender, EventArgs e)
        {
            if (currentInput != "0")
            {
                txtMemoryBox.Text = "M";
                memCurrentInput = currentInput;
                currentInput = "";
            }
            else
            {
                txtInputField.Text = currentInput;
            }
        }

        private void btnMemAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}



