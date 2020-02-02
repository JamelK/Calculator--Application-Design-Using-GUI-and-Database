using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Calculator HW 4
namespace Calculator
{
    public partial class Calculator : Form
    {
        //variables for double values
        double Operand1, Operand2, result;
        //placeholder for doing calculations for each operand 1 and 2 are for each number 3 is for the
        //operation and E is was required to not confuse the program when I adding restrictions to the input

        String placeholder, placeholder2,placeholder3,placeholderE, result1;
        //boolean to test if the user has already inputed a operation so no double operations can be inputed
        Boolean OperandE = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtboxOutput.Focus();
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            equal.Focus();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.NumPad1))
            {

                btn1.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad2))
            {

                btn2.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad3))
            {

                btn3.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad4))
            {

                btn4.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad5))
            {

                btn5.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad6))
            {

                btn6.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad7))
            {

                btn7.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad8))
            {

                btn8.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad9))
            {

                btn9.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad0))
            {

                btn0.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Add))
            {

                btnAdd.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Subtract))
            {

                btnSubstract.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.X) || (e.KeyCode.Equals(Keys.Multiply)))
            {

                btnMultiply.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Divide))
            {

                btnDivide.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Enter))
            {

                equal.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                txtboxOutput.Text = "";
            }
            if (e.KeyCode.Equals(Keys.Back))
            {

                if (txtboxOutput.Text.Length > 0)
                {
                    txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                }


            }
           


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this is copied and modified for each operation
            //prevents user from adding the operation when the box is empty
            if (txtboxOutput.Text.Length > 0)
            {   // if its the first operation print it
                if (OperandE == false)
                {
                    txtboxOutput.Text += "+";
                    placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                    placeholderE = placeholder;
                    OperandE = true;
                }
                //if its a new operation replace it
                else
                {
                    if (txtboxOutput.Text.Substring(txtboxOutput.Text.Length-1, 1)== "+"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "-"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "x"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "/") 
                    {
                        txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        txtboxOutput.Text += "+";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                    }
                    else
                    {
                        txtboxOutput.Text += "+";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                        OperandE = true;

                    }
                }
            }
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (txtboxOutput.Text.Length > 0)
            {
                if (OperandE == false)
                {
                    txtboxOutput.Text += "-";
                    placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                    placeholderE = placeholder;
                    OperandE = true;
                }
                else
                {
                    if (txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "+"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "-"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "x"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "/")
                    {
                        txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        txtboxOutput.Text += "-";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                    }
                    else
                    {
                        txtboxOutput.Text += "-";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                        OperandE = true;

                    }
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtboxOutput.Text.Length > 0)
            {
                if (OperandE == false)
                {
                    txtboxOutput.Text += "x";
                    placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                    placeholderE = placeholder;
                    OperandE = true;
                }
                else
                {
                    if (txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "+"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "-"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "x"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "/")
                    {
                        txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        txtboxOutput.Text += "x";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                    }
                    else
                    {
                        txtboxOutput.Text += "x";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                        OperandE = true;

                    }
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtboxOutput.Text.Length > 0)
            {
                if (OperandE == false)
                {
                    txtboxOutput.Text += "/";
                    placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                    placeholderE = placeholder;
                    OperandE = true;
                }
                else
                {
                    if (txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "+"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "-"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "x"
                        || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "/")
                    {
                        txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        txtboxOutput.Text += "/";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                    }
                    else
                    {
                        txtboxOutput.Text += "/";
                        placeholder = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
                        placeholderE = placeholder;
                        OperandE = true;

                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "2";
   
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "6";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "8";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

            txtboxOutput.Text += ".";
  
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text += "9";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtboxOutput.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(txtboxOutput.Text.Length > 0)
            {
                txtboxOutput.Text = txtboxOutput.Text.Substring(0, txtboxOutput.Text.Length - 1);
            }
           
            
        }

        private void equal_Click(object sender, EventArgs e)
        {
                // prevents equal click from happening if its empty or if boolean is false
                if (txtboxOutput.Text.Length != 0 && !OperandE)
                {


                }
                //prevents equal click from happening if there is no Operand 2
                if (txtboxOutput.Text.Length != 0 && OperandE)
                {
                if (txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "+"
                || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "-"
                || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "x"
                || txtboxOutput.Text.Substring(txtboxOutput.Text.Length - 1, 1) == "/")
                { }
                else
                {
                    OperandE = false;
                    Operand1 = Convert.ToDouble(placeholderE);

                    placeholder2 = txtboxOutput.Text.Substring(placeholder.Length + 1, txtboxOutput.Text.Length - placeholder.Length - 1);

                    Operand2 = Convert.ToDouble(placeholder2);

                    placeholder3 = txtboxOutput.Text.Substring(placeholder.Length, 1);

                    //each if and else for each operation 
                    if (placeholder3 == "+")
                    {
                        result = Operand1 + Operand2;
                        result1 = Convert.ToString(result);

                    }

                    else if (placeholder3 == "-")
                    {
                        result = Operand1 - Operand2;
                        result1 = Convert.ToString(result);

                    }
                    else if (placeholder3 == "x")
                    {
                        result = Operand1 * Operand2;
                        result1 = Convert.ToString(result);

                    }
                    else if (placeholder3 == "/")
                    {
                        result = Operand1 / Operand2;
                        result1 = Convert.ToString(result);

                    }
                    txtboxOutput.Text = result1;
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
