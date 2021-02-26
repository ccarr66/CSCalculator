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
using System.Globalization;
using System.Numerics;

namespace CS_Calculator
{
    public partial class MainWindow : Form
    {
        int lastSelect = 0;

        public MainWindow()
        {
            InitializeComponent();
            AcceptButton = btnEquals;
            Select();
            txtExpression.Focus();
            txtExpression.SelectionStart = txtExpression.Text.Length;
            cmb_bx_Complement.SelectedIndex = 1;
            txt_BitLen.Text = "16";

            cmb_Groups.SelectedIndex = 2;
            chbx_Groups.Checked = true;
            txt_Decimal.MaxLength = 15;
            txt_Hex.MaxLength = 12;
            txt_Octal.MaxLength = 16;
            txt_Binary.MaxLength = 48;
            initializeMatDisplays();

            zero = new matrix();
            zero.name = "zero";
            zero.matrixDimMN = new Size(1, 1);
            zero.array = new cmplxNumber[1, 1];
            zero.array[0, 0] = 0;
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

        private void MainWindow_Load(object sender, EventArgs e)
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

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MainWindow_Load_1(object sender, EventArgs e)
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



        public string decimalToHex(double decimalNum, bool isNegative)
        {
            BigInteger entireNum = new BigInteger(decimalNum);
            BigInteger integerPart = new BigInteger( Math.Round(decimalNum, 0));

            List<int> digits = new List<int>();

            BigInteger dividend = integerPart;
            do
            {
                BigInteger quotient = new BigInteger(Math.Round((double)(dividend / 16), 0));
                int remainder = (int)(dividend % 16);
                digits.Add(remainder);
                dividend = quotient;
            } while (dividend != 0);

            string hexNum = "";

            foreach(int digit in digits)
            {
                char c;
                if (digit == 10)
                    c = 'A';
                else if (digit == 11)
                    c = 'B';
                else if (digit == 12)
                    c = 'C';
                else if (digit == 13)
                    c = 'D';
                else if (digit == 14)
                    c = 'E';
                else if (digit == 15)
                    c = 'F';
                else
                    char.TryParse(digit.ToString(), out c);
                hexNum = c + hexNum;
            }

       

            BigInteger decimalPart = entireNum - integerPart;

            if (decimalPart > 0)
            {
                hexNum = hexNum + '.';

                BigInteger result = decimalPart;

                for (int i = 0; i < 50; i++)
                {
                    result = 16 * result;
                    int resultIntegerPart = (int)result;
                    BigInteger resultDecimalPart = result - resultIntegerPart;
                    result = resultDecimalPart;

                    char c;
                    if (resultIntegerPart == 10)
                        c = 'A';
                    else if (resultIntegerPart == 11)
                        c = 'B';
                    else if (resultIntegerPart == 12)
                        c = 'C';
                    else if (resultIntegerPart == 13)
                        c = 'D';
                    else if (resultIntegerPart == 14)
                        c = 'E';
                    else if (resultIntegerPart == 15)
                        c = 'F';
                    else
                        char.TryParse(resultIntegerPart.ToString(), out c);

                    hexNum = hexNum + c;
                }

                while (hexNum.Length > 0 && hexNum[hexNum.Length - 1] == '0')
                {
                    hexNum = hexNum.Remove(hexNum.Length - 1, 1);
                }
            }

            if (isNegative)
                hexNum = '-' + hexNum;

            return hexNum;
        }

        public string decimalToOct(double decimalNum, bool isNegative)
        {
            BigInteger entireNum = new BigInteger(decimalNum);
            BigInteger integerPart = new BigInteger(Math.Round(decimalNum, 0));

            List<int> digits = new List<int>();

            BigInteger dividend = integerPart;
            do
            {
                BigInteger quotient = new BigInteger(Math.Round((double)(dividend / 8), 0));
                int remainder = (int)(dividend % 8);
                digits.Add(remainder);
                dividend = quotient;
            } while (dividend != 0);

            string octNum = "";

            foreach (int digit in digits)
            {
                char c;
                char.TryParse(digit.ToString(), out c);
                octNum = c + octNum;
            }



            BigInteger decimalPart = entireNum - integerPart;

            if (decimalPart > 0)
            {
                octNum = octNum + '.';

                BigInteger result = decimalPart;

                for (int i = 0; i < 50; i++)
                {
                    result = 8 * result;
                    int resultIntegerPart = (int)result;
                    BigInteger resultDecimalPart = result - resultIntegerPart;
                    result = resultDecimalPart;

                    char c;
                    char.TryParse(resultIntegerPart.ToString(), out c);

                    octNum = octNum + c;
                }

                while (octNum.Length > 0 && octNum[octNum.Length - 1] == '0')
                {
                    octNum = octNum.Remove(octNum.Length - 1, 1);
                }
            }

            if (isNegative)
                octNum = '-' + octNum;

            return octNum;
        }

        public string decimalToBin(double decimalNum, int comp, bool isNegative)
        {
            BigInteger entireNum = new BigInteger(decimalNum);
            BigInteger integerPart = new BigInteger(Math.Round(decimalNum, 0));

            List<int> digits = new List<int>();

            BigInteger dividend = integerPart;
            do
            {
                BigInteger quotient = new BigInteger(Math.Round((double)(dividend / 2), 0));
                int remainder = (int)(dividend % 2);
                digits.Add(remainder);
                dividend = quotient;
            } while (dividend != 0);

            string binNum = "";

            foreach (int digit in digits)
            {
                char c;
                char.TryParse(digit.ToString(), out c);
                binNum = c + binNum;
            }



            BigInteger decimalPart = entireNum - integerPart;

            if (decimalPart > 0)
            {
                binNum = binNum + '.';

                BigInteger result = decimalPart;

                for (int i = 0; i < 50; i++)
                {
                    result = 2 * result;
                    int resultIntegerPart = (int)result;
                    BigInteger resultDecimalPart = result - resultIntegerPart;
                    result = resultDecimalPart;

                    char c;
                    char.TryParse(resultIntegerPart.ToString(), out c);

                    binNum = binNum + c;
                }

                while (binNum.Length > 0 && binNum[binNum.Length - 1] == '0')
                {
                    binNum = binNum.Remove(binNum.Length - 1, 1);
                }
            }

            int bitLen;
            bool hadToAdd = false;
            if(txt_BitLen.Text != "" && int.TryParse(txt_BitLen.Text, out bitLen) && binNum.Length < bitLen)
            {
                while (binNum.Length < bitLen)
                    binNum = '0' + binNum;
                hadToAdd = true;
            }


            if (comp == 0 && isNegative)
            {
                binNum = '-' + binNum;
            }

            if (comp == 1)
            {
                //if(binNum[0] == '1')
                if (!hadToAdd)
                    binNum = '0' + binNum;

                if (isNegative)
                {
                    //binNum = binNum + '0';
                    int lastOneIndex = binNum.LastIndexOf('1');
                    string newBinNum = "";



                    for (int index = 0; index < lastOneIndex; index++)
                    {
                        if (binNum[index] == '0')
                            newBinNum = newBinNum + '1';
                        else if (binNum[index] == '1')
                            newBinNum = newBinNum + '0';
                        else if (binNum[index] == '.')
                            newBinNum = newBinNum + '.';
                    }

                    for (int index = lastOneIndex; index < binNum.Length && index >= 0; index++)
                    {
                        newBinNum += binNum[index];
                    }

                    binNum = newBinNum;
                }
            }

            if (comp == 2)
            {
                //if (binNum[0] == '1')
                if (!hadToAdd)
                    binNum = '0' + binNum;

                if (isNegative)
                {

                    string newBinNum = "";



                    for (int index = 0; index < binNum.Length; index++)
                    {
                        if (binNum[index] == '0')
                            newBinNum = newBinNum + '1';
                        else if (binNum[index] == '1')
                            newBinNum = newBinNum + '0';
                        else if (binNum[index] == '.')
                            newBinNum = newBinNum + '.';
                    }

                    binNum = newBinNum;
                }
            }

            /*if (chbx_Groups.Checked && int.TryParse(txt_BitLen.Text, out bitLen) && bitLen > txt_Binary.Text.Length) 
            {
                int group;
                if(int.TryParse(cmb_Groups.SelectedItem.ToString(), out group))
                {
                    int remainder = bitLen % group;
                    txt_BitLen.Text = (txt_Binary.Text.Length + remainder).ToString();
                }
            }*/

            

            return binNum;
        }

        private void txt_Decimal_TextChanged(object sender, EventArgs e)
        {
            if (txt_Decimal.Focused)
            {
                string decimalText = txt_Decimal.Text;

                for (int index = 0; index < decimalText.Length; index++)
                {
                    if (!(
                           decimalText[index] == '-'
                        || decimalText[index] == '.'
                        || (decimalText[index] >= '0' && decimalText[index] <= '9')
                       ))
                    {
                        txt_Decimal.Text = "";
                        return;
                    }
                }

                if (txt_Decimal.Text == "" || txt_Decimal.Text == "-")
                {
                    txt_Hex.Text = "";
                    txt_Octal.Text = "";
                    txt_Binary.Text = "";
                    return;
                }

                bool isNegative = false;

                if (decimalText != "" && decimalText[0] == '-')
                {
                    isNegative = true;
                    decimalText = decimalText.Remove(0, 1);
                }

                double decimalNum = 0;

                if (decimalText != "" && double.TryParse(decimalText, out decimalNum))
                {
                    txt_Binary.Text = decimalToBin(decimalNum, cmb_bx_Complement.SelectedIndex, isNegative);
                    if (chbx_Groups.Checked)
                    {
                        cmb_Groups.Visible = true;
                        int grouping;
                        if (int.TryParse(cmb_Groups.SelectedItem.ToString(), out grouping))
                        {
                            updateBinary(grouping);
                        }
                    }
                    txt_Hex.Text = decimalToHex(decimalNum, isNegative);
                    txt_Octal.Text = decimalToOct(decimalNum, isNegative);
                }
                txt_Decimal.SelectionStart = txt_Decimal.Text.Length;
                txt_Decimal.SelectionLength = 0;
            }
        }



        private double hexToDecimal(string hexText)
        {
            int highestPower = -1;
            while (highestPower + 1 < hexText.Length && hexText[highestPower + 1] != '.') 
                highestPower++;

            double decimalFromHex = 0;

            for (int i = 0; i < hexText.Length; i++)
            {
                if(hexText[i] != '.')
                {
                    int digit;
                    if (hexText[i] == 'A' || hexText[i] == 'a')
                        digit = 10;
                    else if (hexText[i] == 'B' || hexText[i] == 'b')
                        digit = 11;
                    else if (hexText[i] == 'C' || hexText[i] == 'c')
                        digit = 12;
                    else if (hexText[i] == 'D' || hexText[i] == 'd')
                        digit = 13;
                    else if (hexText[i] == 'E' || hexText[i] == 'e')
                        digit = 14;
                    else if (hexText[i] == 'F' || hexText[i] == 'f')
                        digit = 15;
                    else
                        int.TryParse(hexText[i].ToString(), out digit);

                    decimalFromHex += digit * Math.Pow(16, highestPower--);
                }
            }

            return decimalFromHex;
        }

        private void txt_Hex_TextChanged(object sender, EventArgs e)
        {
            if (txt_Hex.Focused)
            {
                string hexText = txt_Hex.Text;

                for (int index = 0; index < hexText.Length; index++)
                {
                    if (!(
                           hexText[index] == '-'
                        || hexText[index] == '.'
                        || hexText[index] == 'A'
                        || hexText[index] == 'a'
                        || hexText[index] == 'B'
                        || hexText[index] == 'b'
                        || hexText[index] == 'C'
                        || hexText[index] == 'c'
                        || hexText[index] == 'D'
                        || hexText[index] == 'd'
                        || hexText[index] == 'E'
                        || hexText[index] == 'e'
                        || hexText[index] == 'F'
                        || hexText[index] == 'f'
                        || (hexText[index] >= '0' && hexText[index] <= '9')
                       ))
                    {
                        txt_Hex.Text = "";
                        return;
                    }
                }

                if (txt_Hex.Text == "" || txt_Hex.Text == "-")
                {
                    txt_Decimal.Text = "";
                    txt_Octal.Text = "";
                    txt_Binary.Text = "";
                    return;
                }

                bool isNegative = false;

                if (hexText != "" && hexText[0] == '-')
                {
                    isNegative = true;
                    hexText = hexText.Remove(0, 1);
                }


                if (hexText != "")
                {
                    double decimalConvert = hexToDecimal(hexText);
                    txt_Binary.Text       = decimalToBin(decimalConvert, cmb_bx_Complement.SelectedIndex, isNegative);
                    if (chbx_Groups.Checked)
                    {
                        cmb_Groups.Visible = true;
                        int grouping;
                        if (int.TryParse(cmb_Groups.SelectedItem.ToString(), out grouping))
                        {
                            updateBinary(grouping);
                        }
                    }
                    txt_Octal.Text        = decimalToOct(decimalConvert, isNegative);
                    if (isNegative)
                        txt_Decimal.Text = (-1 * decimalConvert).ToString();
                    else
                        txt_Decimal.Text = (decimalConvert).ToString();
                }
                txt_Hex.SelectionStart = txt_Hex.Text.Length;
                txt_Hex.SelectionLength = 0;
            }
        }





        private double octToDecimal(string octText)
        {
            int highestPower = -1;
            while (highestPower + 1 < octText.Length && octText[highestPower + 1] != '.')
                highestPower++;

            double decimalFromHex = 0;

            for (int i = 0; i < octText.Length; i++)
            {
                if (octText[i] != '.')
                {
                    int digit;

                    int.TryParse(octText[i].ToString(), out digit);

                    decimalFromHex += digit * Math.Pow(8, highestPower--);
                }
            }

            return decimalFromHex;
        }

        private void txt_Octal_TextChanged(object sender, EventArgs e)
        {
            if (txt_Octal.Focused)
            {
                string octText = txt_Octal.Text;

                for (int index = 0; index < octText.Length; index++)
                {
                    if (!(
                           octText[index] == '-'
                        || octText[index] == '.'
                        || (octText[index] >= '0' && octText[index] <= '7')
                       ))
                    {
                        txt_Octal.Text = "";
                        return;
                    }
                }

                if (txt_Octal.Text == "" || txt_Octal.Text == "-")
                {
                    txt_Decimal.Text = "";
                    txt_Hex.Text = "";
                    txt_Binary.Text = "";
                    return;
                }

                bool isNegative = false;

                if (octText != "" && octText[0] == '-')
                {
                    isNegative = true;
                    octText = octText.Remove(0, 1);
                }


                if (octText != "")
                {
                    double decimalConvert = octToDecimal(octText);
                    txt_Binary.Text = decimalToBin(decimalConvert, cmb_bx_Complement.SelectedIndex, isNegative);
                    if (chbx_Groups.Checked)
                    {
                        cmb_Groups.Visible = true;
                        int grouping;
                        if (int.TryParse(cmb_Groups.SelectedItem.ToString(), out grouping))
                        {
                            updateBinary(grouping);
                        }
                    }
                    txt_Hex.Text = decimalToHex(decimalConvert, isNegative);
                    if (isNegative)
                        txt_Decimal.Text = (-1 * decimalConvert).ToString();
                    else
                        txt_Decimal.Text = (decimalConvert).ToString();
                }
                txt_Octal.SelectionStart = txt_Octal.Text.Length;
                txt_Octal.SelectionLength = 0;
            }
        }





        private double binToDecimal(string binText)
        {
            int highestPower = -1;
            while (highestPower + 1 < binText.Length && binText[highestPower + 1] != '.')
                highestPower++;

            double decimalFromBin = 0;

            for (int i = 0; i < binText.Length; i++)
            {
                if (binText[i] != '.')
                {
                    int digit;

                    int.TryParse(binText[i].ToString(), out digit);

                    decimalFromBin += digit * Math.Pow(2, highestPower--);
                }
            }

            return decimalFromBin;
        }

        private void txt_Binary_TextChanged(object sender, EventArgs e)
        {
            if (txt_Binary.Focused || sender == cmb_bx_Complement)
            {
                chbx_Groups.Checked = false;
                string binText = txt_Binary.Text;

                for (int index = 0; index < binText.Length; index++)
                {
                    if (!(
                           binText[index] == '-'
                        || binText[index] == '.'
                        || (binText[index] >= '0' && binText[index] <= '1')
                       ))
                    {
                        txt_Binary.Text = "";
                        return;
                    }
                }

                if (txt_Binary.Text == "" || txt_Binary.Text == "-")
                {
                    txt_Decimal.Text = "";
                    txt_Hex.Text = "";
                    txt_Octal.Text = "";
                    return;
                }

                bool isNegative = false;

                if (binText != "" && binText[0] == '-')
                {
                    isNegative = true;
                    binText = binText.Remove(0, 1);
                }
                else if (binText != "" && cmb_bx_Complement.SelectedIndex == 1 && binText[0] == '1')
                {
                    string newBinText = "";
                    int lastOne = binText.LastIndexOf("1");
                    for (int i = 0; i < binText.Length; i++) 
                    {
                        if (i < lastOne)
                        {
                            if (binText[i] == '1')
                                newBinText = '0' + newBinText;
                            else if (binText[i] == '0')
                                newBinText = '1' + newBinText;
                            else
                                newBinText = binText[i] + newBinText;
                        }
                        else
                            newBinText = binText[i] + newBinText;
                    }
                    binText = newBinText;
                    isNegative = true;
                }
                else if (binText != "" && cmb_bx_Complement.SelectedIndex == 1 && binText[0] == '2')
                {
                    string newBinText = "";

                    for (int i = 0; i < binText.Length; i++)
                    {
                        if (binText[i] == '1')
                            newBinText = '0' + newBinText;
                        else if (binText[i] == '0')
                            newBinText = '1' + newBinText;
                        else
                            newBinText = binText[i] + newBinText;
                    }
                    binText = newBinText;
                    isNegative = true;
                }


                if (binText != "")
                {
                    double decimalConvert = binToDecimal(binText);
                    txt_Octal.Text = decimalToOct(decimalConvert, isNegative);
                    txt_Hex.Text = decimalToHex(decimalConvert, isNegative);
                    if (isNegative)
                        txt_Decimal.Text = (-1 * decimalConvert).ToString();
                    else
                        txt_Decimal.Text = (decimalConvert).ToString();
                }
                txt_Octal.SelectionStart = txt_Octal.Text.Length;
                txt_Octal.SelectionLength = 0;
            }
        }




        private void txt_BitLen_TextChanged(object sender, EventArgs e)
        {
            bool check = chbx_Groups.Checked;
            chbx_Groups.Checked = false;

            int bitLen;
            if (txt_BitLen.Text != "" && int.TryParse(txt_BitLen.Text, out bitLen))
            {
                if (bitLen > 48)
                {
                    bitLen = 48;
                    txt_BitLen.Text = "48";
                }

                int comp = cmb_bx_Complement.SelectedIndex;
                if (bitLen > txt_Binary.Text.Length)
                {
                    if (comp == 0 && txt_Binary.Text != "")
                    {
                        if (txt_Binary.Text[0] == '-')
                        {
                            while (txt_Binary.Text.Length - 1 < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(1, "0");
                        }
                        else
                        {
                            while (txt_Binary.Text.Length < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(0, "0");
                        }
                    }
                    else if (comp == 1 && txt_Binary.Text != "")
                    {
                        if (txt_Binary.Text[0] == '1')
                        {
                            while (txt_Binary.Text.Length < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(0, "1");
                        }
                        else
                        {
                            while (txt_Binary.Text.Length < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(0, "0");
                        }
                    }
                    else if (comp == 2 && txt_Binary.Text != "")
                    {
                        if (txt_Binary.Text[0] == '1')
                        {
                            while (txt_Binary.Text.Length < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(0, "1");
                        }
                        else
                        {
                            while (txt_Binary.Text.Length < bitLen)
                                txt_Binary.Text = txt_Binary.Text.Insert(0, "0");
                        }
                    }
                }
                else
                {
                    string decimalText = txt_Decimal.Text;

                    for (int index = 0; index < decimalText.Length; index++)
                    {
                        if (!(
                               decimalText[index] == '-'
                            || decimalText[index] == '.'
                            || (decimalText[index] >= '0' && decimalText[index] <= '9')
                           ))
                        {
                            txt_Decimal.Text = "";
                            return;
                        }
                    }

                    if (txt_Decimal.Text == "" || txt_Decimal.Text == "-")
                    {
                        txt_Hex.Text = "";
                        txt_Octal.Text = "";
                        txt_Binary.Text = "";
                        return;
                    }

                    bool isNegative = false;

                    if (decimalText != "" && decimalText[0] == '-')
                    {
                        isNegative = true;
                        decimalText = decimalText.Remove(0, 1);
                    }
                    else if (decimalText != "" && decimalText[0] == '1')
                    {
                        isNegative = true;
                    }

                    double decimalNum = 0;

                    if (decimalText != "" && double.TryParse(decimalText, out decimalNum))
                    {
                        txt_Binary.Text = decimalToBin(decimalNum, cmb_bx_Complement.SelectedIndex, isNegative);
                        //txt_Binary_TextChanged(sender, e);
                    }
                }
            }

            if (check)
            {
                chbx_Groups.Checked = true;
            }
        }

        private void cmb_bx_Complement_SelectedIndexChanged(object sender, EventArgs e)
        {

            //chbx_Groups.Checked = false;

            string decimalText = txt_Decimal.Text;

            for (int index = 0; index < decimalText.Length; index++)
            {
                if (!(
                       decimalText[index] == '-'
                    || decimalText[index] == '.'
                    || (decimalText[index] >= '0' && decimalText[index] <= '9')
                   ))
                {
                    txt_Decimal.Text = "";
                    return;
                }
            }

            if (txt_Decimal.Text == "" || txt_Decimal.Text == "-")
            {
                txt_Hex.Text = "";
                txt_Octal.Text = "";
                txt_Binary.Text = "";
                return;
            }

            bool isNegative = false;

            if (decimalText != "" && decimalText[0] == '-')
            {
                isNegative = true;
                decimalText = decimalText.Remove(0, 1);
            }

            double decimalNum = 0;

            if (decimalText != "" && double.TryParse(decimalText, out decimalNum))
            {
                txt_Binary.Text = decimalToBin(decimalNum, cmb_bx_Complement.SelectedIndex, isNegative);
                if (chbx_Groups.Checked)
                {
                    cmb_Groups.Visible = true;
                    int grouping;
                    if (int.TryParse(cmb_Groups.SelectedItem.ToString(), out grouping))
                    {
                        updateBinary(grouping);
                    }
                }
                //txt_Binary_TextChanged(sender, e);
            }
        }

        private void chbx_Groups_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_Groups.Checked)
            {
                //cmb_Groups.Visible = true;
                int grouping;
                if (int.TryParse(cmb_Groups.SelectedItem.ToString(), out grouping))
                {
                    updateBinary(grouping);
                }
            }
            else
            {
                //cmb_Groups.Visible = false;
                updateBinary(txt_Binary.Text.Length * 2);
            }


        }

        private void updateBinary(int grouping)
        {
            string newBinStr = "";
            string oldBinStr = txt_Binary.Text;
            for (int i = oldBinStr.Length - 1; i >= 0; i--) 
            {
                if(oldBinStr[i] == ' ')
                {
                    oldBinStr = oldBinStr.Remove(i, 1);
                }
            }

                int count = 0;
            for (int i = oldBinStr.Length - 1; i >= 0; i--) 
            {
                count++;
                newBinStr = oldBinStr[i] + newBinStr;
                if (count % grouping == 0 && i != 0)
                    newBinStr = "  " + newBinStr;

            }
            txt_Binary.Text = newBinStr;
        }

        private void cmb_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {

            chbx_Groups_CheckedChanged(sender, e);

        }

        private void txt_MultiTest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
