using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CS_Calculator
{
    public partial class Form1 : Form
    {
        int lastSelect = 0;

        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnEquals;
            Select();
            txtExpression.Focus();
            txtExpression.SelectionStart = txtExpression.Text.Length;
        }

        private void btnLeftParen_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "(");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnRightParen_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, ")");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2))
                        txtResult.Text = Convert.ToString(num1 - num2);
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "-");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2))
                        txtResult.Text = Convert.ToString(num1 + num2);
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "+");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }


        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2))
                        txtResult.Text = Convert.ToString(num1 * num2);
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "*");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2) && num2 != 0)
                        txtResult.Text = Convert.ToString(num1 / num2);
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "/");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2))
                        txtResult.Text = Convert.ToString(num1 % num2);
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "%");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                double num1 = 0, num2 = 0;
                if (double.TryParse(txtNumberOne.Text, out num1))
                    if (double.TryParse(txtNumberTwo.Text, out num2))
                    {
                        txtResult.Text = Convert.ToString(Math.Pow(num1, num2));
                    }
                    else
                    {
                        txtNumberTwo.Text = "";
                        txtResult.Text = "";
                    }
                else
                {
                    txtNumberOne.Text = "";
                    txtResult.Text = "";
                }
            }
            else
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "^");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        public double getNumberFromString(string str, int i, out int retI)
        {
            char c = str[i];
            double number = 0;
            int index = i;

            if (c != '.')
            {
                number += Char.GetNumericValue(c);
                index++;
                if (index < str.Length)
                    c = str[index];
                while ((index < str.Length) && (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9'))
                {
                    number = number * 10 + Char.GetNumericValue(c);
                    index++;
                    if (index < str.Length)
                        c = str[index];
                }
            }

            if (c == '.')
            {
                index++;
                if (index < str.Length)
                    c = str[index];
                int decimalCount = 0;
                while ((index < str.Length) && (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9'))
                {
                    number += Char.GetNumericValue(c) / Math.Pow(10, ++decimalCount);
                    index++;
                    if (index < str.Length)
                        c = str[index];
                }
            }

            index--;
            if (index < str.Length)
                i = index;

            retI = i;
            return number;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            Hashtable   operatorPrecedence      =   new Hashtable();
            Hashtable   operatorAssociativity   =   new Hashtable();
            Stack       operators               =   new Stack();
            Queue       output                  =   new Queue();


            operatorPrecedence.Add('+', 2);
            operatorPrecedence.Add('-', 2);
            operatorPrecedence.Add('*', 3);
            operatorPrecedence.Add('/', 3);
            operatorPrecedence.Add('%', 3);
            operatorPrecedence.Add('^', 4);

            operatorAssociativity.Add('+', true);
            operatorAssociativity.Add('-', true);
            operatorAssociativity.Add('*', true);
            operatorAssociativity.Add('/', true);
            operatorAssociativity.Add('%', true);
            operatorAssociativity.Add('^', false);

            string exp = txtExpression.Text.ToLower();
            txtTest.Text = exp;
            int isNextNumberNegative = 1;

            for (int i = 0; i < exp.Length; i++)
            {
                char c = exp[i];
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '.':
                        int retI;
                        double number = isNextNumberNegative * getNumberFromString(exp, i, out retI);
                        i = retI;
                        output.Enqueue(number);
                        break;
                    case '-':
                    case '*':
                    case '+':
                    case '/':
                    case '%':
                    case '^':
                        {
                           if (c == '-')
                            {
                                if ((i - 1 >= 0) && (exp[i - 1] == '-' || exp[i - 1] == '*' || exp[i - 1] == '+' || exp[i - 1] == '/' || exp[i - 1] == '%' || exp[i - 1] == '^' || exp[i - 1] == '('))
                                {
                                    isNextNumberNegative = -1;
                                    exp = exp.Remove(i, 1);
                                    i--;
                                    break;
                                }
                                else if (i == 0)
                                {
                                    isNextNumberNegative = -1;
                                    exp = exp.Remove(i, 1);
                                    i--;
                                    break;
                                }
                                else
                                    isNextNumberNegative = 1;
                            }
                            else
                                isNextNumberNegative = 1;

                            if (c == '+')
                            {
                                if ((i - 1 >= 0) && (exp[i - 1] == '-' || exp[i - 1] == '*' || exp[i - 1] == '+' || exp[i - 1] == '/' || exp[i - 1] == '%' || exp[i - 1] == '^' || exp[i - 1] == '('))
                                {
                                    //isNextNumberNegative = -1;
                                    exp = exp.Remove(i, 1);
                                    i--;
                                    break;
                                }
                                else if (i == 0)
                                {
                                    exp = exp.Remove(i, 1);
                                    i--;
                                    break;
                                }
                                else
                                    isNextNumberNegative = 1;
                            }
                            else
                                isNextNumberNegative = 1;


                            if (operators.Count != 0)
                            {
                                while (operators.Count != 0 &&  (
                                                                ((Convert.ToInt32(operatorPrecedence[operators.Peek()]) > Convert.ToInt32(operatorPrecedence[c])) || ((Convert.ToInt32(operatorPrecedence[operators.Peek()]) == Convert.ToInt32(operatorPrecedence[c])) && (Convert.ToBoolean(operatorAssociativity[operators.Peek()]))))
                                                                && 
                                                                (Convert.ToChar(operators.Peek()) != '(')
                                                                )
                                      )
                                {
                                    output.Enqueue(operators.Pop());
                                }
                            }
                            operators.Push(c);
                        }
                        break;
                    case '(':
                        operators.Push(c);
                        break;
                    case ')':
                        while (c != '(' && Convert.ToBoolean(operators.Count))
                        {
                            output.Enqueue(operators.Pop());
                            if (Convert.ToBoolean(operators.Count))
                                char.TryParse(Convert.ToString(operators.Peek()), out c);
                        }
                        if (Convert.ToBoolean(operators.Count))
                            operators.Pop();
                        break;
                }


            }

            while (Convert.ToBoolean(operators.Count))
                output.Enqueue(operators.Pop());


            txtTest.Text = "";
            foreach (object c in output)
            {
                txtTest.Text += '>' + c.ToString() + '<';
            }


            Stack result = new Stack();
            double operandTwo, operandOne;
            bool parenMismatch = false;

            foreach (object c in output)
            {
                if (!parenMismatch)
                {
                    if(c is double)
                            result.Push(c);
                    else if (c is char)
                    {
                        char a = Convert.ToChar(c.ToString());
                        switch (a)
                        {
                            case '+':
                            case '-':
                            case '*':
                            case '/':
                            case '%':
                            case '^':
                                if (result.Count >= 2)
                                {
                                    operandTwo = Convert.ToDouble(result.Pop());
                                    operandOne = Convert.ToDouble(result.Pop());

                                    switch (a)
                                    {
                                        case '+':
                                            result.Push(operandTwo + operandOne);
                                            break;
                                        case '-':
                                            result.Push(operandOne - operandTwo);
                                            break;
                                        case '*':
                                            result.Push(operandTwo * operandOne);
                                            break;
                                        case '/':
                                            result.Push(operandOne / operandTwo);
                                            break;
                                        case '%':
                                            result.Push(operandOne % operandTwo);
                                            break;
                                        case '^':
                                            result.Push(Math.Pow(operandOne, operandTwo));
                                            break;
                                    }
                                }
                                else
                                    parenMismatch = true;

                                break;

                            case '(':
                                operandOne = Convert.ToDouble(result.Pop());
                                result.Push(operandOne);
                                break;
                            case ')':
                            default:
                                parenMismatch = true;
                                break;



                        }
                    }
                }
                
            }
            if (!parenMismatch && result.Count > 0)
                txtResult.Text = Convert.ToString(result.Pop());
            else if (result.Count == 0)
                txtResult.Text = "";
            else
                txtResult.Text = "Expression Error";

            
        }

        private void ckbxDumbMode_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxDumbMode.Checked)
            {
                lblNumberOne.Visible = true;
                lblNumberTwo.Visible = true;
                txtNumberOne.Visible = true;
                txtNumberTwo.Visible = true;
            }
            else
            {
                lblNumberOne.Visible = false;
                lblNumberTwo.Visible = false;
                txtNumberOne.Visible = false;
                txtNumberTwo.Visible = false;
                txtExpression.Focus();
                txtExpression.SelectionStart = txtExpression.Text.Length;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                //  txtExpression.SelectionStart
                //txtExpression.Focus();
                txtTest.Text = lastSelect.ToString();
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "7");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                //    txtExpression.Text += '8';
                //    txtExpression.Focus();
                //    txtExpression.SelectionStart = txtExpression.Text.Length;
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "8");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "9");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "4");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "5");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "6");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "1");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "2");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "3");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, "0");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                txtExpression.Text = txtExpression.Text.Insert(lastSelect, ".");
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect + 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void btnBkspce_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                //    int index = txtExpression.Text.Length - 1;
                //   if (index >= 0)
                //       txtExpression.Text = txtExpression.Text.Remove(txtExpression.Text.Length - 1, 1);
                //  txtExpression.Focus();
                // txtExpression.SelectionStart = txtExpression.Text.Length;
                txtExpression.Text = txtExpression.Text.Remove(lastSelect-1, 1);
                txtExpression.Focus();
                txtExpression.SelectionStart = lastSelect - 1;
                txtExpression.SelectionLength = 0;
                lastSelect = txtExpression.SelectionStart;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if (Convert.ToInt32(e.KeyChar) != 8)
                txtExpression.Text += e.KeyChar;
            txtExpression.Focus();
            txtExpression.SelectionStart = txtExpression.Text.Length;*/

        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                if (txtExpression.Text != "Expression Error")
                {
                    txtExpression.Text = txtResult.Text;
                    txtResult.Text = "";
                }
                txtExpression.Focus();
                txtExpression.SelectionStart = txtExpression.Text.Length;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (!ckbxDumbMode.Checked)
            {
                //txtExpression.Focus();
                int start = lastSelect;
                //txtTest.Text = start.ToString();
                char c = ' ';

                if (start > 0)
                    c = txtExpression.Text[start-1];


                if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '7' || c == '8' || c == '9' || c == '.')
                {
                    while(start>0 && (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '7' || c == '8' || c == '9' || c == '.'))
                    {
                        c = txtExpression.Text[--start];
                    }
                }
                else
                { 
                    for (int i = start; i < txtExpression.Text.Length; i++)
                    {
                        c = txtExpression.Text[i];
                        if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '7' || c == '8' || c == '9' || c == '.')
                        {
                            txtExpression.Text = txtExpression.Text.Insert(i, "-");
                            break;
                        }
                        else if (c == '-')
                        {
                            txtExpression.Text = txtExpression.Text.Remove(i, 1);
                            txtExpression.Text = txtExpression.Text.Insert(i, "+");
                            break;
                        }
                        else if (c == '+')
                        {
                            txtExpression.Text = txtExpression.Text.Remove(i, 1);
                            txtExpression.Text = txtExpression.Text.Insert(i, "-");
                            break;
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
        }

        private void txtExpression_Leave(object sender, EventArgs e)
        {
            lastSelect = txtExpression.SelectionStart;
        }
    }
}
