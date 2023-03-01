using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class mainForm : Form
    {
        //properties
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string operation = "";
        double storedNum;

        public mainForm()
        {
            InitializeComponent();
        }

       

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {

            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
            storedNum = 0;
            textBoxResults.Text = "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 8);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 8);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 9);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 9);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operation = "*";
            //storedNum = Double.Parse(textBoxResults.Text);
            textBoxResults.Text = "0";
        }

        private void buttonSubt_Click(object sender, EventArgs e)
        {
            operation = "-";
            //storedNum = Double.Parse(textBoxResults.Text);
            textBoxResults.Text = "0";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 6);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 6);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 5);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 5);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 4);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 4);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = (firstNumber * -1);
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * -1);
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 0);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 0);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }

        private void btnDeci_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text.Contains("."))
            {
                if (operation.Equals(""))
                {
                    firstNumber = Double.Parse(textBoxResults.Text);
                    textBoxResults.Text = firstNumber.ToString();
                }
                else
                {
                    secondNumber = Double.Parse(textBoxResults.Text);
                    textBoxResults.Text = secondNumber.ToString();
                }

            }
            else
            {
                textBoxResults.Text = textBoxResults.Text + ".";

            }
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!operation.Equals(""))
            {
                //do nothing
            }
            if (operation.Equals("+"))
            {
                result = firstNumber + secondNumber;
                textBoxResults.Text = result.ToString();
                operation = "";
                firstNumber = Double.Parse(textBoxResults.Text);
                secondNumber = 0;
            }
            if (operation.Equals("-"))
            {
                result = firstNumber - secondNumber;
                textBoxResults.Text = result.ToString();
                operation = "";
                firstNumber = Double.Parse(textBoxResults.Text);
                secondNumber = 0;
            }
            if (operation.Equals("/"))
            {
                result = firstNumber / secondNumber;
                textBoxResults.Text = result.ToString();
                operation = "";
                firstNumber = Double.Parse(textBoxResults.Text);
                secondNumber = 0;
            }
            if (operation.Equals("*"))
            {
                result = firstNumber * secondNumber;
                textBoxResults.Text = result.ToString();
                operation = "";
                firstNumber = Double.Parse(textBoxResults.Text);
                secondNumber = 0;
            }
            else
            {
                //do nothing
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text.Equals(""))
            {

            }
            else
            {
                textBoxResults.Text = textBoxResults.Text.Remove(textBoxResults.Text.Length - 1);
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 1);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 1);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 2);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 2);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            storedNum = Double.Parse(textBoxResults.Text);
            textBoxResults.Text = "0";

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 3);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 3);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = Double.Parse(textBoxResults.Text + 7);
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = Double.Parse(textBoxResults.Text + 7);
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            storedNum = Double.Parse(textBoxResults.Text);
            textBoxResults.Text = "0";

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (operation.Equals(""))
            {
                firstNumber = 0;
                //firstNumber = (firstNumber*10) + 8;
                textBoxResults.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = 0;
                //secondNumber = (secondNumber*10) + 8;
                textBoxResults.Text = secondNumber.ToString();
            }
        }
    }
}
