using System;
using System.Windows.Forms;

namespace _200425671A2
{
    /// <summary>
    /// Assignment 2 for COMP1098 of the Winter Semester. 
    /// Created by: Lindsay Hunter
    /// Completed: April 11, 2020
    /// A basic memory calaculator (the simpler one)
    /// </summary>
    public partial class frmCalculator : Form
    {
        /// <summary>
        /// The Global Variables for the form
        /// </summary>
        private String currentInput = "";
        private String operation = "";
        private decimal num1 = 0;
        private decimal num2 = 0;


        Calculator Calc = new Calculator(); //creating an instance of the Calculator class
        MemoryCalculator mc = new MemoryCalculator(); //creating an instance of the MemoryCalculator class

        public frmCalculator()
        {
            InitializeComponent();
        }

        #region NumberButtonsClick

        /// <summary>
        /// Using the AddCurrentInput method for all numeric valued buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn0_Click(object sender, EventArgs e)
        {
            AddCurrentInput('0');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddCurrentInput('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddCurrentInput('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddCurrentInput('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddCurrentInput('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddCurrentInput('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddCurrentInput('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddCurrentInput('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddCurrentInput('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddCurrentInput('9');
        }
        #endregion

        #region OtherButtonsClick
        /// <summary>
        /// Adding a decimal to a number with some error handling: 
        /// if there is already a decimal in the number don't add another one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (currentInput.IndexOf(".") == -1) //if there is not already a decimal in the number
            {
                AddCurrentInput('.');
            }
            else
            {
                txtInputField.Text = currentInput; //if there is already a decimal, do nothing
            }
        }


        /// <summary>
        /// Adding or removing a negative sign from the displayed text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (currentInput != "0") //if the number isn't a zero
            {

                if (currentInput.IndexOf("-") == -1) //if there is not a negative sign currently present
                {
                    currentInput = currentInput.Insert(0, "-"); //add one
                    txtInputField.Text = currentInput; //display it on the text box
                }
                else
                    currentInput = currentInput.Remove(0, 1); //if there is negative sign currently, remove it
                txtInputField.Text = currentInput; //display it on the textbox
            }
            else
            {
                txtInputField.Text = currentInput; //do nothing if number is zero
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
        /// When the button is pressed the entire calculator clears, excluding the memory stored
        /// By using the Clear() method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear("");
        }
        #endregion

        #region operationButtonsClick

        /// <summary>
        /// Using the SetOperation() method and passing it the parameter Divide
        /// </summary>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperation("Divide");

        }

        /// <summary>
        /// Using the SetOperation() method and passing it the parameter Multiply
        /// </summary>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperation("Multiply");
        }

        /// <summary>
        /// Using the SetOperation() method and passing it the parameter Subtract
        /// </summary>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetOperation("Subtract");
        }

        /// <summary>
        /// Using the SetOperation() method and passing it the parameter Add
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation("Add");
        }

        /// <summary>
        /// Calculating and displaying the number after passing through the calculator class's
        /// SquareRoot() method. 
        /// Setting the displayed calculated number to the currentInput for potential futher calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num1);
            currentInput = "";
            txtInputField.Text = Calc.SquareRoot(num1);
            currentInput = txtInputField.Text;
        }

        /// <summary>
        /// Calculating and displaying the number after passing through the calculator class's
        /// Factor() method. 
        /// Setting the displayed calculated number to the currentInput for potential futher calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num1); //output number
            currentInput = "";
            txtInputField.Text = Calc.Factor(num1);
            currentInput = txtInputField.Text;
        }


        /// <summary>
        /// When the equal button in clicked parse the currentInput as a Deciaml to the num2 variable.
        /// Then check to make sure we won't get a divide by zero error
        /// If not then perform the proper calculatiosn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num2); //assign the currently displayed text to num2
            currentInput = ""; //set currentInput String to null

            if (num2 == 0 && operation == "Divide") //if num2 is zero and divide is the operation chosen
            {
                Clear("ERROR: CANNOT DIVIDE BY ZERO"); //throw an error message to the user, and reset all varaibles using the Clear() method.
            }
            else //if not call the calculator class and use the method corresponding to the operation chosen. 
            {
                switch (operation)
                {
                    case "Add":
                        txtInputField.Text = Calc.Add(num1, num2); //output result to textBox
                        currentInput = txtInputField.Text; //allows for further operations to be performed on the results
                        break;
                    case "Subtract":
                        txtInputField.Text = Calc.Subtract(num1, num2); //output result to textBox
                        currentInput = txtInputField.Text; //allows for further operations to be performed on the results
                        break;
                    case "Multiply":
                        txtInputField.Text = Calc.Multiply(num1, num2); //output result to textBox
                        currentInput = txtInputField.Text; //allows for further operations to be performed on the results
                        break;
                    case "Divide":
                        txtInputField.Text = Calc.Divide(num1, num2); //output result to textBox
                        currentInput = txtInputField.Text; //allows for further operations to be performed on the results
                        break;
                }
            }
        }

        #endregion

        #region HomeBrewMethods
        /// <summary>
        /// Method to add the argument to the end of the input box of the calculator
        /// </summary>
        /// <param name="s"></param>
        public void AddCurrentInput(Char s)
        {
            currentInput += s; //add string parameter to the String varaible currentInput
            txtInputField.Text = currentInput; //set the text box equal to the String varaible
        }

        /// <summary>
        /// Set the Operation variable to the String paramenter of the method. 
        /// The try parse the current input field to the first number variable
        /// Then set the current input back to null or Zero. 
        /// </summary>
        /// <param name="op"></param>
        public void SetOperation(String op)
        {
            operation = op; //set operation to the passed parameter
            Decimal.TryParse(currentInput, out num1); //parse it to a decimal and assign that decimal value to num1 
            currentInput = ""; //reset the String variable
        }

        /// <summary>
        /// Reset all the global variables back to null. 
        /// Set the txtInputField text box to the paramenter passed to the method. 
        /// </summary>
        /// <param name="s"></param>
        public void Clear(String s)
        {
            txtInputField.Text = s; //the txtbox will display the passed argument
            num1 = 0; //set everythign else back to null or zero. 
            num2 = 0;
            currentInput = "";
            operation = "";
        }
        #endregion

        #region MemoryButtonsClick
        /// <summary>
        /// When the MC button is clicked the memInput variable in the memoryCalculator class is set to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemClear_Click(object sender, EventArgs e)
        {
            txtMemoryBox.Text = ""; //clear the text box
            mc.MemInput = ""; //set the stored value to empty
        }

        /// <summary>
        /// set the displayed textbox equal to the String value of the memInput variable in the  memoryCalculator class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            txtInputField.Text = mc.MemInput; //use the getter and output it to the input field
            currentInput = mc.MemInput; //assign the current input to the stored memory value through the getter.
        }


        /// <summary>
        /// Save the current displayed value to the String value of the memInput variable in the  memoryCalculator class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemSave_Click(object sender, EventArgs e)
        {
            if (currentInput != "0") //as long as it isn't zero
            {
                txtMemoryBox.Text = "M"; //set the form label to M
                mc.MemInput = currentInput; //assigning the current input of the form to the memInput variable in MemoryCalculator class
                currentInput = ""; //reset the current input
            }
            else //if it is zero
            {
                txtInputField.Text = currentInput; //nothing happens
            }
        }
        /// <summary>
        /// Add the currently displayed value to the String value of the memInput variable in the  memoryCalculator class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemAdd_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(currentInput, out num1);
            Decimal.TryParse(mc.MemInput, out num2);
            mc.MemInput = mc.Add(num1, num2); //inheritinng the Add function from Calculator and implementing it here.      
        }
        #endregion


        #region TypableInput
        /// <summary>
        /// When the specific key is pressed we will do the same functionality as if the correlating
        /// buttin was pressed by executing the perfromClick() method. This is for number 0-9 and 
        /// the operations of the keyboard (+, -, *, /, =).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('0') || e.KeyChar.Equals(Keys.NumPad0))    //Input 0
            {
                btn0.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('1') || e.KeyChar.Equals(Keys.NumPad1)) //Input 1
            {
                btn1.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('2') || e.KeyChar.Equals(Keys.NumPad2)) //Input 2
            {
                btn2.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('3') || e.KeyChar.Equals(Keys.NumPad3)) //Input 3
            {
                btn3.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('4') || e.KeyChar.Equals(Keys.NumPad4))    //Input 4
            {
                btn4.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('5') || e.KeyChar.Equals(Keys.NumPad5))    //Input 5
            {
                btn5.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('6') || e.KeyChar.Equals(Keys.NumPad6))    //Input 6
            {
                btn6.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('7') || e.KeyChar.Equals(Keys.NumPad7))    //Input 7
            {
                btn7.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('8') || e.KeyChar.Equals(Keys.NumPad8))    //Input 8
            {
                btn8.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('9') || e.KeyChar.Equals(Keys.NumPad9))    //Input 9
            {
                btn9.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('-'))    //Input -
            {
                btnMinus.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('+'))    //Input +
            {
                btnAdd.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('/'))    //Input /
            {
                btnDivide.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('*'))    //Input *
            {
                btnMultiply.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyChar.Equals('='))    //Input =
            {
                btnEquals.PerformClick();
                e.Handled = true;
            }
        }

        /// <summary>
        /// if the Escape or Backspace Key is pressed then act as if the clear and back button
        /// on the calculator were pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInputField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)     //Input <- key
            {
                btnBack.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)     //Input ESC key
            {
                btnClear.PerformClick();
                e.Handled = true;
            }
        }
        #endregion


    }

} 



