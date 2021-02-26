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
    partial class Form1 : Form
    {
        public Size textBoxSize = new Size(30, 30);
        public int standardMargin = 6;

        public class RowM
        {
            public List<TextBox> row = new List<TextBox>();

            public List<TextBox> Row
            {
                get
                {
                    return row;
                }
                set
                {
                    row = value;
                }
            }

            public TextBox this[int key]
            {
                get
                {
                    return row[key];
                }
                set
                {
                    row[key] = value;
                }
            }
        }

        public class Array
        {

            public int rowsM = 0;
            public int colsN = 0;
            public List<RowM> array = new List<RowM>();

            public RowM this[int key]
            {
                get
                {
                    return array[key];
                }
                set
                {
                    array[key] = value;
                }
            }
        }

        public Array matrixDisplayOne = new Array();
        public Array matrixDisplayTwo = new Array();
        public Array matrixDisplayThree = new Array();
        public List<Array> matDisplays = new List<Array>();
        public List<bool> activeDisplays = new List<bool>();

        public Array matrixDisplayOutputOne = new Array();
        public Array matrixDisplayOutputTwo = new Array();
        public Array matrixDisplayOutputThree = new Array();
        public List<Array> matDisplayOutputs = new List<Array>();


        public class matrix
        {
            public string name;
            public Size matrixDimMN;
            public double[,] array;
            public string[] ToStringArray()
            {
                string[] output = new string[matrixDimMN.Height];
                //output[0] = name;
                for (int j = 0; j < matrixDimMN.Height; j++)
                {

                    for (int i = 0; i < matrixDimMN.Width; i++)
                    {
                        output[j] = output[j] + array[j, i] + " ";
                    }
                    output[j] = output[j] + "\n";
                }
                return output;
            }

            public matrix()
            {
                ;
            }

            public matrix(string id, int RowsM, int colsN)
            {
                name = id;
                matrixDimMN = new Size(colsN, RowsM);
                array = new double[RowsM, colsN];
            }

            public double this[int keyR, int keyC]
            {
                get
                {
                    return array[keyR, keyC];
                }
                set
                {
                    array[keyR, keyC] = value;
                }
            }
        }

        public static List<matrix> matrixStorage = new List<matrix>();

        static matrix zero;



        public void initializeMatDisplays()
        {
            matDisplays.Add(matrixDisplayOne);
            matDisplays.Add(matrixDisplayTwo);
            matDisplays.Add(matrixDisplayThree);

            matDisplayOutputs.Add(matrixDisplayOutputOne);
            matDisplayOutputs.Add(matrixDisplayOutputTwo);
            matDisplayOutputs.Add(matrixDisplayOutputThree);

            activeDisplays.Add(chkbx_MatrixOne.Checked);
            activeDisplays.Add(chkbx_MatrixTwo.Checked);
            activeDisplays.Add(chkbx_MatrixThree.Checked);
        }

        public void updateActiveDisplays()
        {
            activeDisplays[0] = chkbx_MatrixOne.Checked;
            activeDisplays[1] = chkbx_MatrixTwo.Checked;
            activeDisplays[2] = chkbx_MatrixThree.Checked;
        }

        public void updateMatrixDimensions(int m, int newRowsM, int newColsN)
        {
            updateActiveDisplays();

            if (matDisplays[m].rowsM == 0 && matDisplays[m].colsN == 0 && !(newRowsM < 0) && !(newColsN < 0))
            {
                matDisplays[m].array.Clear();
                matDisplays[m].array.Add(new RowM());
                matDisplays[m].array[0].Row.Add(new TextBox());

                matDisplays[m].array[0][0].Name = 0.ToString() + 0.ToString();
                matDisplays[m].array[0][0].Text = "0";
                matDisplays[m].array[0][0].Location = new Point(20 + 394 * m, 90);
                matDisplays[m].array[0][0].Size = textBoxSize;
                tb_LinAlg.Controls.Add(matDisplays[m].array[0].Row[0]);
                //txt_TestLinAl.Text = "sucess?";
                matDisplays[m].rowsM++;
                matDisplays[m].colsN++;
                txt_TestLinAl.Text = matDisplays[m].rowsM.ToString() + "  " + matDisplays[m].colsN.ToString();

            }
            else if (newRowsM > matDisplays[m].rowsM && newRowsM > 0 && newRowsM <= 6)
            {
                Point lastRowLocation = matDisplays[m].array[matDisplays[m].rowsM - 1][0].Location;
                Point newRowLocation = new Point(lastRowLocation.X, lastRowLocation.Y + textBoxSize.Height + standardMargin);
                matDisplays[m].array.Add(new RowM());

                for (int i = 0; i < matDisplays[m].colsN; i++)
                {
                    int highestRow = matDisplays[m].array.Count;
                    matDisplays[m].array[highestRow - 1].Row.Add(new TextBox());
                    matDisplays[m].array[highestRow - 1][i].Name = (newRowsM - 1).ToString() + i.ToString();
                    matDisplays[m].array[highestRow - 1][i].Text = "0";
                    matDisplays[m].array[highestRow - 1][i].Location = new Point(newRowLocation.X + i * (textBoxSize.Width + standardMargin), newRowLocation.Y);
                    matDisplays[m].array[highestRow - 1][i].Size = textBoxSize;
                    tb_LinAlg.Controls.Add(matDisplays[m].array[highestRow - 1][i]);

                }
                matDisplays[m].rowsM++;
                txt_TestLinAl.Text = matDisplays[m].rowsM.ToString() + "  " + matDisplays[m].colsN.ToString();

            }
            else if (newColsN > matDisplays[m].colsN && newColsN > 0 && newColsN <= 10)
            {
                Point lastColLocation = matDisplays[m].array[0][matDisplays[m].colsN - 1].Location;
                Point newColLocation = new Point(lastColLocation.X + textBoxSize.Width + standardMargin, lastColLocation.Y);
                //txt_TestLinAl.Text = colsN.ToString() + "  " + newColsN.ToString();

                for (int i = 0; i < matDisplays[m].rowsM; i++)
                {
                    matDisplays[m].array[i].Row.Add(new TextBox());
                    int highestCol = matDisplays[m].array[i].Row.Count;
                    matDisplays[m].array[i][highestCol - 1].Name = i.ToString() + (newColsN - 1).ToString();
                    matDisplays[m].array[i][highestCol - 1].Text = "0";
                    matDisplays[m].array[i][highestCol - 1].Location = new Point(newColLocation.X, matDisplays[m].array[i][0].Location.Y);
                    matDisplays[m].array[i][highestCol - 1].Size = textBoxSize;
                    tb_LinAlg.Controls.Add(matDisplays[m].array[i].Row[highestCol - 1]);

                }
                matDisplays[m].colsN++;
                txt_TestLinAl.Text = matDisplays[m].rowsM.ToString() + "  " + matDisplays[m].colsN.ToString();

            }
            else if (newRowsM < matDisplays[m].rowsM && newRowsM >= 0)
            {
                for (int i = 0; i < matDisplays[m].colsN; i++)
                {
                    tb_LinAlg.Controls.Remove(matDisplays[m].array[matDisplays[m].array.Count - 1][i]);
                }
                matDisplays[m].array.RemoveAt(matDisplays[m].array.Count - 1);
                matDisplays[m].rowsM--;
                if (matDisplays[m].rowsM == 0)
                    matDisplays[m].colsN = 0;
                txt_TestLinAl.Text = matDisplays[m].rowsM.ToString() + "  " + matDisplays[m].colsN.ToString();

            }
            else if (newColsN < matDisplays[m].colsN && newColsN >= 0)
            {
                for (int i = 0; i < matDisplays[m].rowsM; i++)
                {
                    tb_LinAlg.Controls.Remove(matDisplays[m].array[i][matDisplays[m].array[i].Row.Count - 1]);
                    matDisplays[m].array[i].Row.RemoveAt(matDisplays[m].array[i].Row.Count - 1);
                }
                matDisplays[m].colsN--;
                if (matDisplays[m].colsN == 0)
                    matDisplays[m].rowsM = 0;

                txt_TestLinAl.Text = matDisplays[m].rowsM.ToString() + "  " + matDisplays[m].colsN.ToString();

            }

            //txt_TestLinAl.Text = matDisplays[m].array[0][matDisplays[m].colsN -1].Location.X + "  " + matDisplays[m].array[0][matDisplays[m].colsN - 1].Location.Y;
            for (int i = 0; i < matDisplayOutputs[m].rowsM; i++)
            {
                for (int j = 0; j < matDisplayOutputs[m].colsN; j++)
                {
                    tb_LinAlg.Controls.Remove(matDisplayOutputs[m].array[i][j]);
                }
            }

            updateTabIndexes();
        }

        public void updateTabIndexes()
        {
            int nextTabIndex = 17 + 1;
            for (int mat = 0; mat < 3; mat++)
            {
                for (int i = 0; i < matDisplays[mat].rowsM; i++)
                {
                    for (int j = 0; j < matDisplays[mat].colsN; j++)
                    {
                        matDisplays[mat].array[i][j].TabIndex = nextTabIndex++;
                    }
                }
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int i = 0; i < 3; i++)
            {
                if (activeDisplays[i])
                {
                    int newRowsM = matDisplays[i].rowsM + 1;
                    updateMatrixDimensions(i, newRowsM, matDisplays[i].colsN);
                }
            }
        }

        private void addCol_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();

            for (int i = 0; i < 3; i++)
            {
                if (activeDisplays[i])
                {
                    int newColsN = matDisplays[i].colsN + 1;
                    updateMatrixDimensions(i, matDisplays[i].rowsM, newColsN);
                }
            }
        }

        private void delRow_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();

            for (int i = 0; i < 3; i++)
            {
                if (activeDisplays[i])
                {
                    int newRowsM = matDisplays[i].rowsM - 1;
                    updateMatrixDimensions(i, newRowsM, matDisplays[i].colsN);
                }
            }
        }

        private void delCol_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();

            for (int i = 0; i < 3; i++)
            {
                if (activeDisplays[i])
                {
                    int newColsN = matDisplays[i].colsN - 1;
                    updateMatrixDimensions(i, matDisplays[i].rowsM, newColsN);
                }
            }
        }


        private void btn_SaveMatrix_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();

            if (cmb_SaveMatrix.SelectedIndex >= 0 && cmb_SaveMatrix.SelectedIndex < cmb_SaveMatrix.Items.Count)
            {
                Array currMatrix;
                if (cmb_SaveMatrix.SelectedIndex == 0)
                    currMatrix = matrixDisplayOne;
                else if (cmb_SaveMatrix.SelectedIndex == 1)
                    currMatrix = matrixDisplayOutputOne;
                else if (cmb_SaveMatrix.SelectedIndex == 2)
                    currMatrix = matrixDisplayTwo;
                else if (cmb_SaveMatrix.SelectedIndex == 3)
                    currMatrix = matrixDisplayOutputTwo;
                else if (cmb_SaveMatrix.SelectedIndex == 4)
                    currMatrix = matrixDisplayThree;
                else if (cmb_SaveMatrix.SelectedIndex == 4)
                    currMatrix = matrixDisplayOutputThree;
                else
                    return;

                if (txt_MatrixName.Text.Length <= 4 && txt_MatrixName.Text.Length > 0 && !cmb_MatrixStorage.Items.Contains(txt_MatrixName.Text))
                {
                    txt_MatrixName.BackColor = Color.White;
                    cmb_MatrixStorage.Items.Add(txt_MatrixName.Text);
                    txt_MatrixName.Text = txt_MatrixName.Text;
                    matrixStorage.Add(new matrix());
                    matrixStorage[matrixStorage.Count - 1].name = txt_MatrixName.Text;
                    matrixStorage[matrixStorage.Count - 1].matrixDimMN = new Size(currMatrix.colsN, currMatrix.rowsM);
                    matrixStorage[matrixStorage.Count - 1].array = new double[currMatrix.rowsM, currMatrix.colsN];
                    for (int k = 0; k < currMatrix.rowsM; k++)
                        for (int j = 0; j < currMatrix.colsN; j++)
                        {
                            if (!double.TryParse(currMatrix.array[k][j].Text, out matrixStorage[matrixStorage.Count - 1].array[k, j]))
                                matrixStorage[matrixStorage.Count - 1].array[k, j] = 0;
                        }
                }
                else
                {
                    txt_MatrixName.BackColor = Color.Red;
                }
            }
        }

        private void btn_LoadMatrix_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();

            for (int i = 0; i < 3; i++)
            {
                if (activeDisplays[i])
                {
                    if (cmb_MatrixStorage.SelectedIndex >= 0 && cmb_MatrixStorage.SelectedIndex < cmb_MatrixStorage.Items.Count)
                    {
                        matrix currentMatrix = matrixStorage[cmb_MatrixStorage.SelectedIndex];
                        while (matDisplays[i].rowsM != currentMatrix.matrixDimMN.Height || matDisplays[i].colsN != currentMatrix.matrixDimMN.Width)
                            updateMatrixDimensions(i, currentMatrix.matrixDimMN.Height, currentMatrix.matrixDimMN.Width);

                        for (int k = 0; k < matDisplays[i].rowsM; k++)
                            for (int j = 0; j < matDisplays[i].colsN; j++)
                            {
                                matDisplays[i].array[k][j].Text = currentMatrix.array[k, j].ToString();
                            }
                        txt_MatrixName.Text = currentMatrix.name;
                    }
                }
            }

        }

        private void btn_DelMatrix_Click(object sender, EventArgs e)
        {
            if (cmb_MatrixStorage.SelectedIndex >= 0 && cmb_MatrixStorage.SelectedIndex < cmb_MatrixStorage.Items.Count)
            {
                matrixStorage.RemoveAt(cmb_MatrixStorage.SelectedIndex);
                cmb_MatrixStorage.Items.RemoveAt(cmb_MatrixStorage.SelectedIndex);
            }
            if (cmb_MatrixStorage.Items.Count == 0)
            {
                cmb_MatrixStorage.Text = "";
            }
        }



        public void rowOpSwap(ref matrix toSwap, int rowM, int rowN)
        {
            double[,] newArray = new double[toSwap.matrixDimMN.Height, toSwap.matrixDimMN.Width];

            for (int i = 0; i < toSwap.matrixDimMN.Height; i++)
            {

                for (int j = 0; j < toSwap.matrixDimMN.Width; j++)
                {
                    if (i == rowM)
                    {
                        newArray[rowN, j] = toSwap.array[rowM, j];
                    }
                    else if (i == rowN)
                    {
                        newArray[rowM, j] = toSwap.array[rowN, j];
                    }
                    else
                    {
                        newArray[i, j] = toSwap.array[i, j];
                    }
                }
            }
            toSwap.array = newArray;
        }

        public void rowOpMult(ref matrix toSwap, double k, int rowM)
        {
            for (int j = 0; j < toSwap.matrixDimMN.Width; j++)
            {
                toSwap.array[rowM, j] *= k;
            }
        }

        public void rowOpMultPlus(ref matrix toSwap, double k, int rowM, int rowN)
        {
            for (int j = 0; j < toSwap.matrixDimMN.Width; j++)
            {
                toSwap.array[rowN, j] += k * toSwap.array[rowM, j];
            }
        }

        public void createOutputMatrix(int outMatDest, matrix output)
        {
            for (int i = 0; i < matDisplayOutputs[outMatDest].rowsM; i++)
            {
                for (int j = 0; j < matDisplayOutputs[outMatDest].colsN; j++)
                {
                    tb_LinAlg.Controls.Remove(matDisplayOutputs[outMatDest].array[i][j]);
                }
            }

            Point locMatOne = new Point(20 + 0 * 394, 332);
            Point locMatTwo = new Point(20 + 1 * 394, 332);
            Point locMatThree = new Point(20 + 2 * 394, 332);
            List<Point> locList = new List<Point>();
            locList.Add(locMatOne);
            locList.Add(locMatTwo);
            locList.Add(locMatThree);


            matDisplayOutputs[outMatDest].array.Clear();
            //txt_TestLinAl.Text = "sucess?";
            matDisplayOutputs[outMatDest].rowsM = output.matrixDimMN.Height;
            matDisplayOutputs[outMatDest].colsN = output.matrixDimMN.Width;
            //txt_TestLinAl.Text = output.matrixDimMN.Height + "  " + output.matrixDimMN.Width;

            for (int i = 0; i < output.matrixDimMN.Height; i++)
            {

                matDisplayOutputs[outMatDest].array.Add(new RowM());

                for (int j = 0; j < output.matrixDimMN.Width; j++)
                {
                    matDisplayOutputs[outMatDest].array[i].Row.Add(new TextBox());
                    matDisplayOutputs[outMatDest].array[i][j].ReadOnly = true;
                    matDisplayOutputs[outMatDest].array[i][j].TabStop = false;
                    matDisplayOutputs[outMatDest].array[i][j].Name = i.ToString() + j.ToString();
                    matDisplayOutputs[outMatDest].array[i][j].Text = output.array[i, j].ToString();
                    matDisplayOutputs[outMatDest].array[i][j].Location = new Point(locList[outMatDest].X + j * (textBoxSize.Width + standardMargin), locList[outMatDest].Y + i * (textBoxSize.Height + standardMargin));
                    matDisplayOutputs[outMatDest].array[i][j].Size = textBoxSize;
                    tb_LinAlg.Controls.Add(matDisplayOutputs[outMatDest].array[i][j]);
                }
            }

        }

        public void eraseOutputMatrices()
        {
            for (int mat = 0; mat < 3; mat++)
            {
                for (int i = 0; i < matDisplayOutputs[mat].rowsM; i++)
                {
                    for (int j = 0; j < matDisplayOutputs[mat].colsN; j++)
                    {
                        tb_LinAlg.Controls.Remove(matDisplayOutputs[mat].array[i][j]);
                    }
                }
            }
        }


        private void btn_RREF_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat])
                {
                    matrix RREFmat = new matrix();

                    RREFmat.name = "RREF" + mat;
                    RREFmat.matrixDimMN = new Size(matDisplays[mat].colsN, matDisplays[mat].rowsM);
                    RREFmat.array = new double[matDisplays[mat].rowsM, matDisplays[mat].colsN];
                    for (int i = 0; i < matDisplays[mat].rowsM; i++)
                    {
                        for (int j = 0; j < matDisplays[mat].colsN; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out RREFmat.array[i, j]))
                                RREFmat.array[i, j] = 0;
                        }
                    }

                    RREFmat = RREF(RREFmat);

                    createOutputMatrix(mat, RREFmat);

                }
            }


        }

        public matrix RREF(matrix RREF)
        {

            for (int i = 0; i < RREF.matrixDimMN.Height; i++)
            {
                int workingCol = -1;
                for (int j = 0; j < RREF.matrixDimMN.Width; j++)
                {
                    if (RREF.array[i, j] != 0)
                    {
                        workingCol = j;
                        break;
                    }
                }
                if (workingCol == -1)
                    continue;

                double rowDivider = 1 / RREF.array[i, workingCol];
                rowOpMult(ref RREF, rowDivider, i);

                if (RREF.array[i, workingCol] != 1)
                    RREF.array[i, workingCol] = 1;

                for (int k = 0; k < RREF.matrixDimMN.Height; k++)
                {
                    if (k != i)
                    {
                        double rowIMult = -RREF.array[k, workingCol];
                        rowOpMultPlus(ref RREF, rowIMult, i, k);
                        if (RREF.array[k, workingCol] != 0)
                            RREF.array[k, workingCol] = 0;
                    }
                }
            }

            locateDiagonals(ref RREF);

            return RREF;
        }

        public void locateDiagonals(ref matrix toSwap)
        {
            int diagonals = 0;
            for (int i = 0; i < toSwap.matrixDimMN.Width; i++)
            {

                for (int j = 0; j < toSwap.matrixDimMN.Height; j++)
                {
                    if (toSwap.array[j, i] != 0 && diagonals < toSwap.matrixDimMN.Height)
                    {
                        rowOpSwap(ref toSwap, j, diagonals++);
                    }
                }
            }
        }

        private void btn_RandValues_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat])
                {
                    Random matrixValue = new Random();
                    int maximum = 15;
                    int minimum = -15;

                    for (int i = 0; i < matDisplays[mat].rowsM; i++)
                    {
                        for (int j = 0; j < matDisplays[mat].colsN; j++)
                        {
                            matDisplays[mat].array[i][j].Text = (Math.Round(matrixValue.NextDouble() * (maximum - minimum) + minimum, 0)).ToString();
                        }
                    }
                }
            }
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            List<matrix> matricesToMultiply = new List<matrix>();
            int count = 0;
            int prevCols = 0;

            int lastMat = 0;
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat])
                {
                    if (mat > lastMat)
                        lastMat = mat;

                    if (count == 0)
                        prevCols = matDisplays[mat].colsN;
                    else
                    {
                        if (!(matDisplays[mat].rowsM == prevCols))
                            return;
                        count++;
                    }

                }
            }

            for (int mat = 0; mat < 3; mat++) 
            {
                if (activeDisplays[mat])
                {
                    matricesToMultiply.Add(new matrix());

                    matricesToMultiply[matricesToMultiply.Count - 1].name = "mult" + mat;
                    matricesToMultiply[matricesToMultiply.Count - 1].matrixDimMN = new Size(matDisplays[mat].colsN, matDisplays[mat].rowsM);
                    matricesToMultiply[matricesToMultiply.Count - 1].array = new double[matDisplays[mat].rowsM, matDisplays[mat].colsN];
                    for (int i = 0; i < matDisplays[mat].rowsM; i++)
                    {
                        for (int j = 0; j < matDisplays[mat].colsN; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out matricesToMultiply[matricesToMultiply.Count - 1].array[i, j]))
                                matricesToMultiply[matricesToMultiply.Count - 1].array[i, j] = 0;
                        }
                    }
                }
            }

            if (matricesToMultiply.Count == 2)
            {
                eraseOutputMatrices();
                matrix result = matrixMultiplication(matricesToMultiply[0], matricesToMultiply[1]);
                createOutputMatrix(lastMat, result);

            }
            else if (matricesToMultiply.Count == 3)
            {
                eraseOutputMatrices();
                matrix result = matrixMultiplication(matricesToMultiply[0], matricesToMultiply[1]);
                result = matrixMultiplication(result, matricesToMultiply[2]);
                createOutputMatrix(lastMat, result);
            }
            else
            {
                eraseOutputMatrices();
            }


        }

        public matrix matrixMultiplication(matrix multiOne, matrix multiTwo)
        {
            if (multiOne.matrixDimMN.Width == multiTwo.matrixDimMN.Height)
            {
                int commonSideN = multiOne.matrixDimMN.Width;
                matrix product= new matrix();
                product.name = "product";
                product.matrixDimMN = new Size(multiTwo.matrixDimMN.Width, multiOne.matrixDimMN.Height);
                product.array = new double[multiOne.matrixDimMN.Height, multiTwo.matrixDimMN.Width];
                string[] expressionRows = new string[multiOne.matrixDimMN.Height];


                for (int i = 0; i < product.matrixDimMN.Height; i++)
                {
                    string expr = "";

                    for (int j = 0; j < product.matrixDimMN.Width; j++)
                    {
                        double newVal = 0;
                        for (int k = 0; k < commonSideN; k++)
                        {
                            newVal += multiOne.array[i, k] * multiTwo.array[k, j];
                            expr += "(" + multiOne.array[i, k] + '*' + multiTwo.array[k, j] + ") +";
                        }
                        expr.Remove(expr.Length - 1);
                        expr += " || ";
                        product.array[i,j] = newVal;
                    }
                    expressionRows[i] += expr;
                }


                txt_MultiTest.Lines = expressionRows;

                return product;
            }
            else
                return zero;
        }

        private void btn_Transpose_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat])
                {
                    matrix transpose = new matrix();

                    transpose.name = "transpose" + mat;
                    transpose.matrixDimMN = new Size(matDisplays[mat].rowsM, matDisplays[mat].colsN);
                    transpose.array = new double[matDisplays[mat].colsN, matDisplays[mat].rowsM];
                    for (int i = 0; i < transpose.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < transpose.matrixDimMN.Width; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[j][i].Text, out transpose.array[i, j]))
                                transpose.array[i, j] = 0;
                        }
                    }


                    

                    createOutputMatrix(mat, transpose);
                    //  txt_MultiTest.Clear();
                    //  txt_MultiTest.Lines = RREF.ToStringArray();

                }
            }
        }

        private void btn_Determinant_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat] && matDisplays[mat].colsN == matDisplays[mat].rowsM)
                {
                    matrix determinant = new matrix();

                    determinant.name = "determinant" + mat;
                    determinant.matrixDimMN = new Size(matDisplays[mat].colsN, matDisplays[mat].rowsM);
                    determinant.array = new double[matDisplays[mat].rowsM, matDisplays[mat].colsN];

                    for (int i = 0; i < determinant.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < determinant.matrixDimMN.Width; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out determinant.array[i, j]))
                                determinant.array[i, j] = 0;
                        }
                    }

                    double det = calcDeterminant(determinant);


                    matrix result = zero;
                    result.array[0, 0] = det;
                    createOutputMatrix(mat, result);
                    //  txt_MultiTest.Clear();
                    //  txt_MultiTest.Lines = RREF.ToStringArray();

                }
            }
        }

        public double calcDeterminant(matrix det)
        {

            if (det.matrixDimMN.Height == 2 && det.matrixDimMN.Width == 2)
            {
                return det.array[0, 0] * det.array[1, 1] - det.array[0, 1] * det.array[1, 0];
            }
            else
            {
                List<matrix> minors = new List<matrix>();
                for (int i = 0; i < det.matrixDimMN.Width; i++)
                {
                    matrix minor = new matrix();
                    minor.name = "determinant" + i;
                    minor.matrixDimMN = new Size(det.matrixDimMN.Height - 1, det.matrixDimMN.Height - 1);
                    minor.array = new double[det.matrixDimMN.Height - 1, det.matrixDimMN.Height - 1];

                    int currRow = 0;
                    int currCol = 0;

                    for (int k = 1; k < det.matrixDimMN.Height; k++)
                    {
                        currCol = 0;
                        for (int j = 0; j < det.matrixDimMN.Width; j++)
                        {
                            if(j!=i)
                            {
                                minor.array[currRow, currCol] = det.array[k,j];
                                currCol++;
                            }
                        }
                        currRow++;
                    }
                    minors.Add(minor);

                }

                int sign = 1;
                double determinant = 0;
                for (int i = 0; i < minors.Count; i++)
                {
                    determinant += det.array[0, i]*sign*calcDeterminant(minors[i]);
                    sign *= -1;
                }
                return determinant;
            }

        }

        private void btn_Adjoint_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat] && matDisplays[mat].colsN == matDisplays[mat].rowsM)
                {
                    matrix adjoint = new matrix();

                    adjoint.name = "adjoint" + mat;
                    adjoint.matrixDimMN = new Size(matDisplays[mat].colsN, matDisplays[mat].rowsM);
                    adjoint.array = new double[matDisplays[mat].rowsM, matDisplays[mat].colsN];

                    for (int i = 0; i < adjoint.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < adjoint.matrixDimMN.Width; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out adjoint.array[i, j]))
                                adjoint.array[i, j] = 0;
                        }
                    }

                    int sign = 1;
                    double[,] cofactors = new double[adjoint.matrixDimMN.Height, adjoint.matrixDimMN.Width];

                    for (int i = 0; i < adjoint.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < adjoint.matrixDimMN.Width; j++)
                        {
                            matrix minor = new matrix();
                            minor.name = "minor" + i + j;
                            minor.matrixDimMN = new Size(adjoint.matrixDimMN.Width - 1, adjoint.matrixDimMN.Height - 1);
                            minor.array = new double[adjoint.matrixDimMN.Height - 1, adjoint.matrixDimMN.Width - 1];

                            int currRow = 0;
                            int currCol = 0;

                            for (int k = 0; k < adjoint.matrixDimMN.Height; k++)
                            {
                                currCol = 0;
                                if (k != i)
                                {
                                    for (int l = 0; l < adjoint.matrixDimMN.Width; l++)
                                    {
                                        if (l != j)
                                        {
                                            minor.array[currRow, currCol] = adjoint.array[k, l];
                                            currCol++;
                                        }
                                    }
                                    currRow++;
                                }
                            }

                            cofactors[i, j] = sign * calcDeterminant(minor);
                            sign *= -1;

                        }
                    }

                    for (int i = 0; i < adjoint.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < adjoint.matrixDimMN.Width; j++)
                        {
                            adjoint.array[i, j] = cofactors[j, i];
                        }
                    }


                    createOutputMatrix(mat, adjoint);

                }
            }
        }

        public matrix calcAdjoint(matrix adjoint)
        {

            int sign = 1;
            double[,] cofactors = new double[adjoint.matrixDimMN.Height, adjoint.matrixDimMN.Width];

            for (int i = 0; i < adjoint.matrixDimMN.Height; i++)
            {
                for (int j = 0; j < adjoint.matrixDimMN.Width; j++)
                {
                    matrix minor = new matrix();
                    minor.name = "minor" + i + j;
                    minor.matrixDimMN = new Size(adjoint.matrixDimMN.Width - 1, adjoint.matrixDimMN.Height - 1);
                    minor.array = new double[adjoint.matrixDimMN.Height - 1, adjoint.matrixDimMN.Width - 1];

                    int currRow = 0;
                    int currCol = 0;

                    for (int k = 0; k < adjoint.matrixDimMN.Height; k++)
                    {
                        currCol = 0;
                        if (k != i)
                        {
                            for (int l = 0; l < adjoint.matrixDimMN.Width; l++)
                            {
                                if (l != j)
                                {
                                    minor.array[currRow, currCol] = adjoint.array[k, l];
                                    currCol++;
                                }
                            }
                            currRow++;
                        }
                    }

                    cofactors[i, j] = sign * calcDeterminant(minor);
                    sign *= -1;

                }
            }

            for (int i = 0; i < adjoint.matrixDimMN.Height; i++)
            {
                for (int j = 0; j < adjoint.matrixDimMN.Width; j++)
                {
                    adjoint.array[i, j] = cofactors[j, i];
                }
            }

            return adjoint;
        }

        private void btn_Inverse_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat] && matDisplays[mat].colsN == matDisplays[mat].rowsM)
                {
                    matrix determinant = new matrix();

                    determinant.name = "determinant" + mat;
                    determinant.matrixDimMN = new Size(matDisplays[mat].colsN, matDisplays[mat].rowsM);
                    determinant.array = new double[matDisplays[mat].rowsM, matDisplays[mat].colsN];

                    for (int i = 0; i < determinant.matrixDimMN.Height; i++)
                    {
                        for (int j = 0; j < determinant.matrixDimMN.Width; j++)
                        {
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out determinant.array[i, j]))
                                determinant.array[i, j] = 0;
                        }
                    }

                    double det = calcDeterminant(determinant);

                    if (det != 0)
                    {

                        double detReciprocal = 1 / calcDeterminant(determinant);

                        matrix inverse = calcAdjoint(determinant);

                        for (int i = 0; i < inverse.matrixDimMN.Height; i++)
                        {
                            rowOpMult(ref inverse, detReciprocal, i);
                        }

                        createOutputMatrix(mat, inverse);
                    }
                    else
                    {
                        matrix result = zero;
                        result.array[0, 0] = det;
                        createOutputMatrix(mat, result);
                    }
                }
            }

        }

        static public List<cmplxNumber> DurandKernerMethod(polynomial F, ref int loopCounter)
        {

            double largestCoeff = 0;
            for (int i = 0; i < F.coefficients.Count; i++)
            {
                if (Math.Abs(F[i]) > largestCoeff)
                    largestCoeff = Math.Abs(F[i]);
            }

            /* List<cmplxNumber> roots = new List<cmplxNumber>(F.degree);
             double degreesApart = 360 / (F.degree + 2);
             if (degreesApart < 6)
                 degreesApart = 6;

             double degree = 0;
             for (int i = 0; i < F.degree; i++)
             {
                 degree += degreesApart;
                 if (degree % 180 == 0)
                     degree += degreesApart;
                 roots.Add(new cmplxNumber(largestCoeff, degree * cmplxNumber.PI / 180, true));
                 roots[i] = roots[i] ^ (((int)(degree / 360)) + 1);
                 roots[i].toCartes();
             }*/

            List<cmplxNumber> roots = new List<cmplxNumber>(F.degree);
            cmplxNumber basis = new cmplxNumber(.4, .9);

            for (int i = 0; i < F.degree; i++)
            {
                roots.Add(basis ^ i);
            }

            bool keepLooping = true;
            while (keepLooping)
            {
                loopCounter++;
                for (int i = 0; i < F.degree; i++)
                {
                    if (roots[i].A < .000000001 && roots[i].A > -.000000001)
                        roots[i].A = 0;
                    if (roots[i].B < .000000001 && roots[i].B > -.000000001)
                        roots[i].B = 0;

                    roots[i].A = Math.Round(roots[i].A, 10);
                    roots[i].B = Math.Round(roots[i].B, 10);
                }

                List<cmplxNumber> oldRoots = new List<cmplxNumber>();
                for (int i = 0; i < F.degree; i++)
                {
                    oldRoots.Add(roots[i]);
                }

                for (int i = 0; i < F.degree; i++)
                {
                    if (!(roots[i].A == 0 && roots[i].B == 0))
                    {
                        //Console.WriteLine("\nRoot " + i + ": " + roots[i].ToString());

                        //int multiplicand = 0;
                        List<cmplxNumber> multiplicands = new List<cmplxNumber>(F.degree - 1);
                        for (int j = 0; j < F.degree; j++)
                        {
                            if (j != i)
                            {
                                multiplicands.Add(roots[i] - roots[j]);
                                //Console.WriteLine("\tMultiplicand " + multiplicand + ": (" + i + "-" + j + "): " + multiplicands[multiplicand++].ToString());
                            }
                        }

                        cmplxNumber denominator = multiplicands[0];
                        for (int j = 1; j < F.degree - 1; j++)
                        {
                            denominator = denominator * multiplicands[j];
                        }

                        //Console.WriteLine("\tDenominator: " + denominator.ToString());
                        //Console.WriteLine("\tF( " + roots[i] + " ): " + F.evaulate(roots[i]).ToString());

                        //Console.WriteLine("\tSecond term: " + (-F.evaulate(roots[i]) / denominator).ToString());
                        if (!(denominator.A == 0 && denominator.B == 0))
                            roots[i] = roots[i] - F.evaulate(roots[i]) / denominator;
                        //Console.WriteLine("\tModified root " + i + ": " + roots[i].ToString());
                    }

                }

                for (int i = 0; i < F.degree; i++)
                {
                    if (roots[i].A < .000000001 && roots[i].A > -.000000001)
                        roots[i].A = 0;
                    if (roots[i].B < .000000001 && roots[i].B > -.000000001)
                        roots[i].B = 0;

                    roots[i].A = Math.Round(roots[i].A, 10);
                    roots[i].B = Math.Round(roots[i].B, 10);
                }

                keepLooping = false;
                for (int i = 0; i < F.degree; i++)
                {
                    //Console.WriteLine(cmplxNumber.getLargestDifference(roots[i], oldRoots[i]));
                    if (cmplxNumber.getLargestDifference(roots[i], oldRoots[i]) > .00000000000001)
                    {
                        keepLooping = true;
                        i = F.degree;
                    }
                }

            }

            for (int i = 0; i < F.degree; i++)
            {
                if (roots[i].A < .000000001 && roots[i].A > -.000000001)
                    roots[i].A = 0;
                if (roots[i].B < .000000001 && roots[i].B > -.000000001)
                    roots[i].B = 0;

                roots[i].A = Math.Round(roots[i].A, 8);
                roots[i].B = Math.Round(roots[i].B, 8);
            }

            return roots;

        }

        public class cmplxNumber
        {
            public double A;
            public double B;
            public bool polarForm;
            public static double PI = 3.14159265;

            public cmplxNumber(double real, double imag, bool polar = false)
            {
                A = real;
                B = imag;
                polarForm = polar;
            }

            public static cmplxNumber operator !(cmplxNumber num)
            {
                if (num.polarForm)
                {
                    return new cmplxNumber(num.A, -num.B);
                }
                else
                    return new cmplxNumber(num.A, -num.B);
            }

            public static bool operator ==(cmplxNumber first, cmplxNumber second)
            {
                    return (first.A == second.A && first.B == second.B);
            }

            public static bool operator !=(cmplxNumber first, cmplxNumber second)
            {
                return !(first.A == second.A && first.B == second.B);
            }

            public static cmplxNumber operator +(cmplxNumber first, cmplxNumber second)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;

                    cmplxNumber convertSecond = new cmplxNumber(second.A * Math.Cos(second.B), second.A * Math.Sin(second.B));
                    second = convertSecond;

                    cmplxNumber result = new cmplxNumber(first.A + second.A, first.B + second.B);
                    result.toPolar();
                    return result;

                }
                else
                {
                    cmplxNumber result = new cmplxNumber(first.A + second.A, first.B + second.B);
                    return result;
                }
            }

            public static cmplxNumber operator -(cmplxNumber first, cmplxNumber second)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;

                    cmplxNumber convertSecond = new cmplxNumber(second.A * Math.Cos(second.B), second.A * Math.Sin(second.B));
                    second = convertSecond;

                    cmplxNumber result = new cmplxNumber(first.A - second.A, first.B - second.B);
                    result.toPolar();
                    return result;

                }
                else
                {
                    cmplxNumber result = new cmplxNumber(first.A - second.A, first.B - second.B);
                    return result;
                }
            }

            public static cmplxNumber operator -(cmplxNumber first)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;
                }

                return new cmplxNumber(-first.A, -first.B);
            }

            public static cmplxNumber operator *(cmplxNumber first, cmplxNumber second)
            {
                /*if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;

                    cmplxNumber convertSecond = new cmplxNumber(second.A * Math.Cos(second.B), second.A * Math.Sin(second.B));
                    second = convertSecond;

                    cmplxNumber result = new cmplxNumber(first.A * second.A - first.B * second.B, first.B * second.A - first.A * second.B);
                    result.toPolar();
                    return result;

                }
                else
                {*/
                cmplxNumber result = new cmplxNumber(first.A * second.A - first.B * second.B, first.B * second.A + first.A * second.B);
                return result;
                // }
            }

            public static cmplxNumber operator /(cmplxNumber first, cmplxNumber second)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;

                    cmplxNumber convertSecond = new cmplxNumber(second.A * Math.Cos(second.B), second.A * Math.Sin(second.B));
                    second = convertSecond;

                    cmplxNumber numerator = first * !second;
                    cmplxNumber denominator = second * !second;
                    cmplxNumber result = new cmplxNumber(numerator.A / denominator.A, numerator.B / denominator.A);
                    result.toPolar();
                    return result;

                }
                else
                {
                    cmplxNumber numerator = first * !second;
                    cmplxNumber denominator = second * !second;
                    cmplxNumber result = new cmplxNumber(numerator.A / denominator.A, numerator.B / denominator.A);
                    /*cmplxNumber reciprocal = new cmplxNumber((second.A / (second.A * second.A + second.B * second.B)), -(second.B / (second.A * second.A + second.B * second.B)));
                    second = reciprocal;
                    cmplxNumber result = new cmplxNumber(first.A * second.A - first.B * second.B, first.B * second.A - first.A * second.B);
                    */
                    return result;
                }
            }

            public static cmplxNumber operator ^(cmplxNumber first, int pow)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;

                    cmplxNumber second = first;

                    if (pow == 0)
                    {
                        return new cmplxNumber(1, 0, true);
                    }
                    else if (pow > 0)
                    {
                        for (int i = 1; i < pow; i++)
                        {
                            first = first * second;
                        }
                        first.toPolar();
                        return first;
                    }
                    else
                    {
                        first.toPolar();
                        return first;
                    }

                }
                else
                {

                    cmplxNumber second = first;

                    if (pow == 0)
                    {
                        return new cmplxNumber(1, 0);
                    }
                    else if (pow > 0)
                    {
                        for (int i = 1; i < pow; i++)
                        {
                            first = first * second;
                        }
                        return first;
                    }
                    else
                        return first;
                }
            }

            public static double operator ~(cmplxNumber first)
            {
                if (first.polarForm)
                {
                    cmplxNumber convertFirst = new cmplxNumber(first.A * Math.Cos(first.B), first.A * Math.Sin(first.B));
                    first = convertFirst;
                }

                return Math.Sqrt(first.A * first.A + first.B * first.B);
            }

            public static explicit operator cmplxNumber(double d)
            {

                return new cmplxNumber(d, 0);
            }

            public bool toPolar()
            {
                if (this.polarForm == true)
                    return false;

                double X = this.A;
                double Y = this.B;
                if (X < .0000001 && X > -.0000001)
                    X = 0;
                if (Y < .0000001 && Y > -.0000001)
                    Y = 0;
                double angle;
                double length = ~this;



                if (X < 0 && Y >= 0)
                {
                    angle = Math.Atan2(Y, X);
                    angle += PI;
                }
                else if (X < 0 && Y < 0)
                {
                    angle = Math.Atan2(Y, X);
                    angle -= PI;
                }
                else if (X == 0 && Y > 0)
                {
                    angle = PI / 2;
                }
                else if (X == 0 && Y < 0)
                {
                    angle = -PI / 2;
                }
                else if (X == 0 && Y == 0)
                {
                    this.polarForm = false;
                    return false;
                }
                else
                {
                    angle = Math.Atan2(Y, X);
                }

                this.A = length;
                this.B = angle;
                this.polarForm = true;
                return true;
            }

            public bool toCartes()
            {
                if (this.polarForm == false)
                    return false;

                double Y = this.A * Math.Sin(this.B);
                double X = this.A * Math.Cos(this.B);

                this.A = X;
                this.B = Y;
                this.polarForm = false;
                return true;
            }

            public override string ToString()
            {
                if (polarForm)
                {
                    return A.ToString() + "* ( Cos(" + B.ToString() + ") + i*Sin(" + B.ToString() + ") )";
                }
                else
                {
                    if (B < 0)
                        return A.ToString() + " - " + (-1 * B).ToString() + 'i';
                    else
                        return A.ToString() + " + " + B.ToString() + 'i';
                }

            }

            public static double getLargestDifference(cmplxNumber C1, cmplxNumber C2)
            {
                double differenceOne = Math.Abs(C1.A - C2.A);
                double differenceTwo = Math.Abs(C1.B - C2.B);

                if (differenceOne > differenceTwo)
                    return differenceOne;
                else
                    return differenceTwo;
            }

        }

        public class polynomial
        {
            public List<double> coefficients;

            public polynomial(params double[] listOfCoeff)
            {
                coefficients = new List<double>();
                for (int i = listOfCoeff.Length - 1; i >= 0; i--)
                {
                    coefficients.Add(listOfCoeff[i]);
                }
            }

            public int degree
            {
                get
                {
                    return coefficients.Count - 1;
                }
            }

            public double this[int key]
            {
                get
                {
                    return coefficients[key];
                }
                set
                {
                    coefficients[key] = value;
                }
            }

            public cmplxNumber evaulate(cmplxNumber x)
            {
                cmplxNumber output = new cmplxNumber(0, 0);
                for (int i = 0; i < coefficients.Count; i++)
                {
                    output = output + ((cmplxNumber)coefficients[i]) * (x ^ i);
                }
                return output;
            }

            public override string ToString()
            {
                string output = "";
                for (int i = coefficients.Count - 1; i >= 0; i--)
                {
                    output += coefficients[i] + "x^" + i;
                    if (i != 0)
                        output += " + ";
                }
                return output;
            }

            public static polynomial operator *(polynomial first, polynomial second)
            {
                double[] coefficients = new double[first.degree + second.degree + 1];


                //double[,] coefficientArray = new double[first.coefficients.Count, second.coefficients.Count];

                for (int i = 0; i <= first.degree; i++)
                {
                    for (int j = 0; j <= second.degree; j++)
                    {
                        coefficients[first.degree + second.degree - i - j] += first[i] * second[j];
                    }

                }
                polynomial result = new polynomial(coefficients);
                return result;
            }

            public static polynomial operator *(polynomial first, int second)
            {
                for (int i = 0; i <= first.degree; i++)
                {
                    first[i] = first[i] * second;
                }
                return first;
            }

            public static polynomial operator +(polynomial first, polynomial second)
            {
                while (second.degree > first.degree)
                {
                    first.coefficients.Add(0);
                }
                for (int i = 0; i < second.coefficients.Count; i++)
                {
                    first.coefficients[i] += second.coefficients[i];
                }
                return first;
            }

            public static polynomial operator -(polynomial first, polynomial second)
            {
                polynomial firstCopy = first;
                polynomial secondCopy = second;
                while (secondCopy.degree > firstCopy.degree)
                {
                    firstCopy.coefficients.Add(0D);
                }
                for (int i = 0; i < secondCopy.coefficients.Count; i++)
                {
                    firstCopy.coefficients[i] -= secondCopy.coefficients[i];
                }
                return firstCopy;
            }

            public static polynomial calcDeterminant(polynomial[,] polyMat)
            {

                if (polyMat.GetLength(0) == 2 && polyMat.GetLength(1) == 2)
                {
                    return polyMat[0, 0] * polyMat[1, 1] - polyMat[0, 1] * polyMat[1, 0];
                }
                else
                {
                    List<polynomial[,]> minors = new List<polynomial[,]>();
                    for (int i = 0; i < polyMat.GetLength(1); i++)
                    {
                        polynomial[,] minor = new polynomial[polyMat.GetLength(0) - 1, polyMat.GetLength(1) - 1];

                        int currRow = 0;
                        int currCol = 0;

                        for (int k = 1; k < polyMat.GetLength(0); k++)
                        {
                            currCol = 0;
                            for (int j = 0; j < polyMat.GetLength(1); j++)
                            {
                                if (j != i)
                                {
                                    minor[currRow, currCol] = polyMat[k, j];
                                    currCol++;
                                }
                            }
                            currRow++;
                        }
                        minors.Add(minor);

                        /*Console.Write("\n\n\n\n");

                        for (int k = 0; k < minor.GetLength(0); k++)
                        {
                            Console.Write("\n\n");
                            for (int j = 0; j < minor.GetLength(1); j++)
                            {
                                Console.Write("\t\t" + minor[k, j].ToString());
                            }
                        }*/
                    }

                    polynomial determinant = new polynomial();
                    int sign = 1;
                    for (int i = 0; i < minors.Count; i++)
                    {

                        // Console.WriteLine("\nDeterminant = (" + determinant.ToString() + ") + (" + polyMat[0, i].ToString() + ") * (" + calcDeterminant(minors[i]).ToString() + ") * " + sign);
                        determinant = determinant + polyMat[0, i] * calcDeterminant(minors[i]) * sign;
                        // Console.WriteLine(determinant.ToString());

                        sign *= -1;
                    }
                    return determinant;
                }

            }

        }



        private void btn_EigenVectorValue_Click(object sender, EventArgs e)
        {
            updateActiveDisplays();
            for (int mat = 0; mat < 3; mat++)
            {
                if (activeDisplays[mat] && matDisplays[mat].colsN == matDisplays[mat].rowsM)
                {

                    polynomial[,] polynomialArray = new polynomial[matDisplays[mat].rowsM, matDisplays[mat].colsN];

                    for (int i = 0; i < matDisplays[mat].rowsM; i++)
                    {
                        for (int j = 0; j < matDisplays[mat].colsN; j++)
                        {
                            double coefficient;
                            if (!double.TryParse(matDisplays[mat].array[i][j].Text, out coefficient))
                                polynomialArray[i,j].coefficients.Add(0);
                            if(i==j)
                                polynomialArray[i, j].coefficients.Add(-1);
                        }
                    }

                    polynomial det = polynomial.calcDeterminant(polynomialArray);

                    if (det[det.degree] != 1)
                    {
                        double divideOut = det[det.degree];
                        for (int i = 0; i < det.coefficients.Count; i++)
                        {
                            det[i] = det[i] / divideOut;
                        }
                        if (det[det.degree] != 1)
                            det[det.degree] = 1;
                    }
                    Console.WriteLine("\n\n\n\n" + det.ToString());

                    int loopCnt = 0;
                    List<cmplxNumber> roots = DurandKernerMethod(det, ref loopCnt);
                    
                    for(int r = 0; r < roots.Count; r++)
                    {
                        matrix eigenValSub = new matrix("EVS", matDisplays[mat].rowsM, matDisplays[mat].colsN);

                        for (int i = 0; i < matDisplays[mat].rowsM; i++)
                        {
                            for (int j = 0; j < matDisplays[mat].colsN; j++)
                            {
                                eigenValSub[i, j] = polynomialArray[i, j].evaulate(roots[r]);
                            }
                        }

                    }




                }
            }
        }

    }

}
