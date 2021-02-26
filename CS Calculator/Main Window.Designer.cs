namespace CS_Calculator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.ckbxDumbMode = new System.Windows.Forms.CheckBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnRightParen = new System.Windows.Forms.Button();
            this.btnLeftParen = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnBkspce = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.tb_Calculator = new System.Windows.Forms.TabPage();
            this.tb_Logic = new System.Windows.Forms.TabPage();
            this.cmb_Groups = new System.Windows.Forms.ComboBox();
            this.lbl_Groups = new System.Windows.Forms.Label();
            this.chbx_Groups = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BitLen = new System.Windows.Forms.TextBox();
            this.lbl_Comp = new System.Windows.Forms.Label();
            this.cmb_bx_Complement = new System.Windows.Forms.ComboBox();
            this.lbl_Bin = new System.Windows.Forms.Label();
            this.txt_Binary = new System.Windows.Forms.TextBox();
            this.lbl_Oct = new System.Windows.Forms.Label();
            this.txt_Octal = new System.Windows.Forms.TextBox();
            this.lbl_Hex = new System.Windows.Forms.Label();
            this.txt_Hex = new System.Windows.Forms.TextBox();
            this.lbl_Dec = new System.Windows.Forms.Label();
            this.txt_Decimal = new System.Windows.Forms.TextBox();
            this.Lbl_Conversion = new System.Windows.Forms.Label();
            this.tb_LinAlg = new System.Windows.Forms.TabPage();
            this.btn_EigenVectorValue = new System.Windows.Forms.Button();
            this.btn_Inverse = new System.Windows.Forms.Button();
            this.btn_Adjoint = new System.Windows.Forms.Button();
            this.btn_Determinant = new System.Windows.Forms.Button();
            this.btn_Transpose = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_RandValues = new System.Windows.Forms.Button();
            this.cmb_SaveMatrix = new System.Windows.Forms.ComboBox();
            this.txt_MultiTest = new System.Windows.Forms.TextBox();
            this.btn_RREF = new System.Windows.Forms.Button();
            this.chkbx_MatrixThree = new System.Windows.Forms.CheckBox();
            this.chkbx_MatrixTwo = new System.Windows.Forms.CheckBox();
            this.chkbx_MatrixOne = new System.Windows.Forms.CheckBox();
            this.btn_LoadMatrix = new System.Windows.Forms.Button();
            this.cmb_MatrixStorage = new System.Windows.Forms.ComboBox();
            this.btn_DelMatrix = new System.Windows.Forms.Button();
            this.txt_MatrixName = new System.Windows.Forms.TextBox();
            this.btn_SaveMatrix = new System.Windows.Forms.Button();
            this.txt_TestLinAl = new System.Windows.Forms.TextBox();
            this.delCol = new System.Windows.Forms.Button();
            this.delRow = new System.Windows.Forms.Button();
            this.addCol = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.TabCtrl.SuspendLayout();
            this.tb_Calculator.SuspendLayout();
            this.tb_Logic.SuspendLayout();
            this.tb_LinAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnAdd.Location = new System.Drawing.Point(493, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(148, 312);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(109, 20);
            this.txtNumberOne.TabIndex = 24;
            this.txtNumberOne.TabStop = false;
            this.txtNumberOne.Visible = false;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(265, 312);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(109, 20);
            this.txtNumberTwo.TabIndex = 23;
            this.txtNumberTwo.TabStop = false;
            this.txtNumberTwo.Visible = false;
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(145, 296);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(67, 13);
            this.lblNumberOne.TabIndex = 3;
            this.lblNumberOne.Text = "Number One";
            this.lblNumberOne.Visible = false;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(262, 296);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(68, 13);
            this.lblNumberTwo.TabIndex = 4;
            this.lblNumberTwo.Text = "Number Two";
            this.lblNumberTwo.Visible = false;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(9, 99);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(233, 26);
            this.txtResult.TabIndex = 26;
            this.txtResult.TabStop = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(435, 170);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(52, 50);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnDivide.Location = new System.Drawing.Point(435, 114);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 50);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnMod.Location = new System.Drawing.Point(493, 114);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(52, 50);
            this.btnMod.TabIndex = 14;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnPow.Location = new System.Drawing.Point(493, 170);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(52, 50);
            this.btnPow.TabIndex = 18;
            this.btnPow.TabStop = false;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnMultiply.Location = new System.Drawing.Point(435, 58);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(52, 50);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Result";
            // 
            // txtTest
            // 
            this.txtTest.Enabled = false;
            this.txtTest.Location = new System.Drawing.Point(435, 312);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(110, 20);
            this.txtTest.TabIndex = 22;
            this.txtTest.TabStop = false;
            this.txtTest.Text = " ";
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnEquals.Location = new System.Drawing.Point(493, 226);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(52, 50);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpression.Location = new System.Drawing.Point(9, 19);
            this.txtExpression.Multiline = true;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(236, 61);
            this.txtExpression.TabIndex = 25;
            this.txtExpression.Leave += new System.EventHandler(this.txtExpression_Leave);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(6, 3);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(58, 13);
            this.lblExpression.TabIndex = 20;
            this.lblExpression.Text = "Expression";
            // 
            // ckbxDumbMode
            // 
            this.ckbxDumbMode.AutoSize = true;
            this.ckbxDumbMode.Location = new System.Drawing.Point(9, 312);
            this.ckbxDumbMode.Name = "ckbxDumbMode";
            this.ckbxDumbMode.Size = new System.Drawing.Size(109, 17);
            this.ckbxDumbMode.TabIndex = 27;
            this.ckbxDumbMode.TabStop = false;
            this.ckbxDumbMode.Text = "Use dumb mode?";
            this.ckbxDumbMode.UseVisualStyleBackColor = true;
            this.ckbxDumbMode.CheckedChanged += new System.EventHandler(this.ckbxDumbMode_CheckedChanged);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnSeven.Location = new System.Drawing.Point(261, 58);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(52, 50);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnEight.Location = new System.Drawing.Point(319, 58);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(52, 50);
            this.btnEight.TabIndex = 8;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnNine.Location = new System.Drawing.Point(377, 58);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(52, 50);
            this.btnNine.TabIndex = 9;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnFour.Location = new System.Drawing.Point(261, 114);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(52, 50);
            this.btnFour.TabIndex = 11;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnFive.Location = new System.Drawing.Point(319, 114);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(52, 50);
            this.btnFive.TabIndex = 12;
            this.btnFive.TabStop = false;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnSix.Location = new System.Drawing.Point(377, 114);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(52, 50);
            this.btnSix.TabIndex = 13;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnOne.Location = new System.Drawing.Point(261, 170);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(52, 50);
            this.btnOne.TabIndex = 15;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnTwo.Location = new System.Drawing.Point(319, 170);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(52, 50);
            this.btnTwo.TabIndex = 16;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnThree.Location = new System.Drawing.Point(377, 170);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(52, 50);
            this.btnThree.TabIndex = 17;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnRightParen
            // 
            this.btnRightParen.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnRightParen.Location = new System.Drawing.Point(319, 2);
            this.btnRightParen.Name = "btnRightParen";
            this.btnRightParen.Size = new System.Drawing.Size(52, 50);
            this.btnRightParen.TabIndex = 2;
            this.btnRightParen.TabStop = false;
            this.btnRightParen.Text = ")";
            this.btnRightParen.UseVisualStyleBackColor = true;
            this.btnRightParen.Click += new System.EventHandler(this.btnRightParen_Click);
            // 
            // btnLeftParen
            // 
            this.btnLeftParen.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnLeftParen.Location = new System.Drawing.Point(261, 2);
            this.btnLeftParen.Name = "btnLeftParen";
            this.btnLeftParen.Size = new System.Drawing.Size(52, 50);
            this.btnLeftParen.TabIndex = 1;
            this.btnLeftParen.TabStop = false;
            this.btnLeftParen.Text = "(";
            this.btnLeftParen.UseVisualStyleBackColor = true;
            this.btnLeftParen.Click += new System.EventHandler(this.btnLeftParen_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnZero.Location = new System.Drawing.Point(261, 226);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(110, 50);
            this.btnZero.TabIndex = 19;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.btnDecimal.Location = new System.Drawing.Point(377, 226);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(52, 50);
            this.btnDecimal.TabIndex = 20;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnBkspce
            // 
            this.btnBkspce.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnBkspce.Location = new System.Drawing.Point(493, 2);
            this.btnBkspce.Name = "btnBkspce";
            this.btnBkspce.Size = new System.Drawing.Size(52, 50);
            this.btnBkspce.TabIndex = 6;
            this.btnBkspce.TabStop = false;
            this.btnBkspce.Text = "←";
            this.btnBkspce.UseVisualStyleBackColor = true;
            this.btnBkspce.Click += new System.EventHandler(this.btnBkspce_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnAns.Location = new System.Drawing.Point(435, 226);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(52, 50);
            this.btnAns.TabIndex = 28;
            this.btnAns.TabStop = false;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnClear.Location = new System.Drawing.Point(435, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 50);
            this.btnClear.TabIndex = 31;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnNegate.Location = new System.Drawing.Point(377, 2);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(52, 50);
            this.btnNegate.TabIndex = 30;
            this.btnNegate.TabStop = false;
            this.btnNegate.Text = "±";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // TabCtrl
            // 
            this.TabCtrl.Controls.Add(this.tb_Calculator);
            this.TabCtrl.Controls.Add(this.tb_Logic);
            this.TabCtrl.Controls.Add(this.tb_LinAlg);
            this.TabCtrl.Location = new System.Drawing.Point(12, 12);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(1269, 779);
            this.TabCtrl.TabIndex = 32;
            // 
            // tb_Calculator
            // 
            this.tb_Calculator.BackColor = System.Drawing.Color.Gray;
            this.tb_Calculator.Controls.Add(this.lblExpression);
            this.tb_Calculator.Controls.Add(this.ckbxDumbMode);
            this.tb_Calculator.Controls.Add(this.txtTest);
            this.tb_Calculator.Controls.Add(this.btnClear);
            this.tb_Calculator.Controls.Add(this.lblNumberTwo);
            this.tb_Calculator.Controls.Add(this.btnAdd);
            this.tb_Calculator.Controls.Add(this.lblNumberOne);
            this.tb_Calculator.Controls.Add(this.btnNegate);
            this.tb_Calculator.Controls.Add(this.txtNumberTwo);
            this.tb_Calculator.Controls.Add(this.txtResult);
            this.tb_Calculator.Controls.Add(this.txtNumberOne);
            this.tb_Calculator.Controls.Add(this.btnAns);
            this.tb_Calculator.Controls.Add(this.btnSubtract);
            this.tb_Calculator.Controls.Add(this.btnBkspce);
            this.tb_Calculator.Controls.Add(this.btnDivide);
            this.tb_Calculator.Controls.Add(this.btnDecimal);
            this.tb_Calculator.Controls.Add(this.btnMod);
            this.tb_Calculator.Controls.Add(this.btnZero);
            this.tb_Calculator.Controls.Add(this.btnPow);
            this.tb_Calculator.Controls.Add(this.btnLeftParen);
            this.tb_Calculator.Controls.Add(this.btnMultiply);
            this.tb_Calculator.Controls.Add(this.btnRightParen);
            this.tb_Calculator.Controls.Add(this.lblResult);
            this.tb_Calculator.Controls.Add(this.btnThree);
            this.tb_Calculator.Controls.Add(this.btnEquals);
            this.tb_Calculator.Controls.Add(this.btnTwo);
            this.tb_Calculator.Controls.Add(this.txtExpression);
            this.tb_Calculator.Controls.Add(this.btnOne);
            this.tb_Calculator.Controls.Add(this.btnSeven);
            this.tb_Calculator.Controls.Add(this.btnSix);
            this.tb_Calculator.Controls.Add(this.btnEight);
            this.tb_Calculator.Controls.Add(this.btnFive);
            this.tb_Calculator.Controls.Add(this.btnNine);
            this.tb_Calculator.Controls.Add(this.btnFour);
            this.tb_Calculator.Location = new System.Drawing.Point(4, 22);
            this.tb_Calculator.Name = "tb_Calculator";
            this.tb_Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Calculator.Size = new System.Drawing.Size(1261, 753);
            this.tb_Calculator.TabIndex = 0;
            this.tb_Calculator.Text = "Calculator";
            // 
            // tb_Logic
            // 
            this.tb_Logic.BackColor = System.Drawing.Color.Gray;
            this.tb_Logic.Controls.Add(this.cmb_Groups);
            this.tb_Logic.Controls.Add(this.lbl_Groups);
            this.tb_Logic.Controls.Add(this.chbx_Groups);
            this.tb_Logic.Controls.Add(this.label1);
            this.tb_Logic.Controls.Add(this.txt_BitLen);
            this.tb_Logic.Controls.Add(this.lbl_Comp);
            this.tb_Logic.Controls.Add(this.cmb_bx_Complement);
            this.tb_Logic.Controls.Add(this.lbl_Bin);
            this.tb_Logic.Controls.Add(this.txt_Binary);
            this.tb_Logic.Controls.Add(this.lbl_Oct);
            this.tb_Logic.Controls.Add(this.txt_Octal);
            this.tb_Logic.Controls.Add(this.lbl_Hex);
            this.tb_Logic.Controls.Add(this.txt_Hex);
            this.tb_Logic.Controls.Add(this.lbl_Dec);
            this.tb_Logic.Controls.Add(this.txt_Decimal);
            this.tb_Logic.Controls.Add(this.Lbl_Conversion);
            this.tb_Logic.Location = new System.Drawing.Point(4, 22);
            this.tb_Logic.Name = "tb_Logic";
            this.tb_Logic.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Logic.Size = new System.Drawing.Size(1261, 753);
            this.tb_Logic.TabIndex = 1;
            this.tb_Logic.Text = "Logic";
            // 
            // cmb_Groups
            // 
            this.cmb_Groups.DisplayMember = "1";
            this.cmb_Groups.FormattingEnabled = true;
            this.cmb_Groups.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "8"});
            this.cmb_Groups.Location = new System.Drawing.Point(135, 189);
            this.cmb_Groups.Name = "cmb_Groups";
            this.cmb_Groups.Size = new System.Drawing.Size(34, 21);
            this.cmb_Groups.TabIndex = 16;
            this.cmb_Groups.SelectedIndexChanged += new System.EventHandler(this.cmb_Groups_SelectedIndexChanged);
            // 
            // lbl_Groups
            // 
            this.lbl_Groups.AutoSize = true;
            this.lbl_Groups.Location = new System.Drawing.Point(52, 192);
            this.lbl_Groups.Name = "lbl_Groups";
            this.lbl_Groups.Size = new System.Drawing.Size(41, 13);
            this.lbl_Groups.TabIndex = 15;
            this.lbl_Groups.Text = "Groups";
            // 
            // chbx_Groups
            // 
            this.chbx_Groups.AutoSize = true;
            this.chbx_Groups.Location = new System.Drawing.Point(99, 192);
            this.chbx_Groups.Name = "chbx_Groups";
            this.chbx_Groups.Size = new System.Drawing.Size(15, 14);
            this.chbx_Groups.TabIndex = 14;
            this.chbx_Groups.UseVisualStyleBackColor = true;
            this.chbx_Groups.CheckedChanged += new System.EventHandler(this.chbx_Groups_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Length";
            // 
            // txt_BitLen
            // 
            this.txt_BitLen.Location = new System.Drawing.Point(135, 163);
            this.txt_BitLen.Name = "txt_BitLen";
            this.txt_BitLen.Size = new System.Drawing.Size(34, 20);
            this.txt_BitLen.TabIndex = 12;
            this.txt_BitLen.TextChanged += new System.EventHandler(this.txt_BitLen_TextChanged);
            // 
            // lbl_Comp
            // 
            this.lbl_Comp.AutoSize = true;
            this.lbl_Comp.Location = new System.Drawing.Point(54, 139);
            this.lbl_Comp.Name = "lbl_Comp";
            this.lbl_Comp.Size = new System.Drawing.Size(65, 13);
            this.lbl_Comp.TabIndex = 11;
            this.lbl_Comp.Text = "Complement";
            // 
            // cmb_bx_Complement
            // 
            this.cmb_bx_Complement.DisplayMember = "1";
            this.cmb_bx_Complement.FormattingEnabled = true;
            this.cmb_bx_Complement.Items.AddRange(new object[] {
            "Negative",
            "Two\'s Complement",
            "One\'s Complement"});
            this.cmb_bx_Complement.Location = new System.Drawing.Point(135, 136);
            this.cmb_bx_Complement.Name = "cmb_bx_Complement";
            this.cmb_bx_Complement.Size = new System.Drawing.Size(121, 21);
            this.cmb_bx_Complement.TabIndex = 10;
            this.cmb_bx_Complement.SelectedIndexChanged += new System.EventHandler(this.cmb_bx_Complement_SelectedIndexChanged);
            // 
            // lbl_Bin
            // 
            this.lbl_Bin.AutoSize = true;
            this.lbl_Bin.Location = new System.Drawing.Point(6, 113);
            this.lbl_Bin.Name = "lbl_Bin";
            this.lbl_Bin.Size = new System.Drawing.Size(36, 13);
            this.lbl_Bin.TabIndex = 8;
            this.lbl_Bin.Text = "Binary";
            // 
            // txt_Binary
            // 
            this.txt_Binary.Location = new System.Drawing.Point(57, 110);
            this.txt_Binary.Name = "txt_Binary";
            this.txt_Binary.Size = new System.Drawing.Size(378, 20);
            this.txt_Binary.TabIndex = 7;
            this.txt_Binary.TextChanged += new System.EventHandler(this.txt_Binary_TextChanged);
            // 
            // lbl_Oct
            // 
            this.lbl_Oct.AutoSize = true;
            this.lbl_Oct.Location = new System.Drawing.Point(6, 87);
            this.lbl_Oct.Name = "lbl_Oct";
            this.lbl_Oct.Size = new System.Drawing.Size(32, 13);
            this.lbl_Oct.TabIndex = 6;
            this.lbl_Oct.Text = "Octal";
            // 
            // txt_Octal
            // 
            this.txt_Octal.Location = new System.Drawing.Point(57, 84);
            this.txt_Octal.Name = "txt_Octal";
            this.txt_Octal.Size = new System.Drawing.Size(112, 20);
            this.txt_Octal.TabIndex = 5;
            this.txt_Octal.TextChanged += new System.EventHandler(this.txt_Octal_TextChanged);
            // 
            // lbl_Hex
            // 
            this.lbl_Hex.AutoSize = true;
            this.lbl_Hex.Location = new System.Drawing.Point(6, 61);
            this.lbl_Hex.Name = "lbl_Hex";
            this.lbl_Hex.Size = new System.Drawing.Size(26, 13);
            this.lbl_Hex.TabIndex = 4;
            this.lbl_Hex.Text = "Hex";
            // 
            // txt_Hex
            // 
            this.txt_Hex.Location = new System.Drawing.Point(57, 58);
            this.txt_Hex.Name = "txt_Hex";
            this.txt_Hex.Size = new System.Drawing.Size(112, 20);
            this.txt_Hex.TabIndex = 3;
            this.txt_Hex.TextChanged += new System.EventHandler(this.txt_Hex_TextChanged);
            // 
            // lbl_Dec
            // 
            this.lbl_Dec.AutoSize = true;
            this.lbl_Dec.Location = new System.Drawing.Point(6, 35);
            this.lbl_Dec.Name = "lbl_Dec";
            this.lbl_Dec.Size = new System.Drawing.Size(45, 13);
            this.lbl_Dec.TabIndex = 2;
            this.lbl_Dec.Text = "Decimal";
            // 
            // txt_Decimal
            // 
            this.txt_Decimal.Location = new System.Drawing.Point(57, 32);
            this.txt_Decimal.Name = "txt_Decimal";
            this.txt_Decimal.Size = new System.Drawing.Size(112, 20);
            this.txt_Decimal.TabIndex = 1;
            this.txt_Decimal.TextChanged += new System.EventHandler(this.txt_Decimal_TextChanged);
            // 
            // Lbl_Conversion
            // 
            this.Lbl_Conversion.AutoSize = true;
            this.Lbl_Conversion.Location = new System.Drawing.Point(6, 3);
            this.Lbl_Conversion.Name = "Lbl_Conversion";
            this.Lbl_Conversion.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Conversion.TabIndex = 0;
            this.Lbl_Conversion.Text = "Conversion";
            // 
            // tb_LinAlg
            // 
            this.tb_LinAlg.BackColor = System.Drawing.Color.Gray;
            this.tb_LinAlg.Controls.Add(this.btn_EigenVectorValue);
            this.tb_LinAlg.Controls.Add(this.btn_Inverse);
            this.tb_LinAlg.Controls.Add(this.btn_Adjoint);
            this.tb_LinAlg.Controls.Add(this.btn_Determinant);
            this.tb_LinAlg.Controls.Add(this.btn_Transpose);
            this.tb_LinAlg.Controls.Add(this.btn_Multiply);
            this.tb_LinAlg.Controls.Add(this.btn_RandValues);
            this.tb_LinAlg.Controls.Add(this.cmb_SaveMatrix);
            this.tb_LinAlg.Controls.Add(this.txt_MultiTest);
            this.tb_LinAlg.Controls.Add(this.btn_RREF);
            this.tb_LinAlg.Controls.Add(this.chkbx_MatrixThree);
            this.tb_LinAlg.Controls.Add(this.chkbx_MatrixTwo);
            this.tb_LinAlg.Controls.Add(this.chkbx_MatrixOne);
            this.tb_LinAlg.Controls.Add(this.btn_LoadMatrix);
            this.tb_LinAlg.Controls.Add(this.cmb_MatrixStorage);
            this.tb_LinAlg.Controls.Add(this.btn_DelMatrix);
            this.tb_LinAlg.Controls.Add(this.txt_MatrixName);
            this.tb_LinAlg.Controls.Add(this.btn_SaveMatrix);
            this.tb_LinAlg.Controls.Add(this.txt_TestLinAl);
            this.tb_LinAlg.Controls.Add(this.delCol);
            this.tb_LinAlg.Controls.Add(this.delRow);
            this.tb_LinAlg.Controls.Add(this.addCol);
            this.tb_LinAlg.Controls.Add(this.addRow);
            this.tb_LinAlg.Location = new System.Drawing.Point(4, 22);
            this.tb_LinAlg.Name = "tb_LinAlg";
            this.tb_LinAlg.Padding = new System.Windows.Forms.Padding(3);
            this.tb_LinAlg.Size = new System.Drawing.Size(1261, 753);
            this.tb_LinAlg.TabIndex = 2;
            this.tb_LinAlg.Text = "Linear Algebra";
            // 
            // btn_EigenVectorValue
            // 
            this.btn_EigenVectorValue.Location = new System.Drawing.Point(573, 297);
            this.btn_EigenVectorValue.Name = "btn_EigenVectorValue";
            this.btn_EigenVectorValue.Size = new System.Drawing.Size(75, 23);
            this.btn_EigenVectorValue.TabIndex = 21;
            this.btn_EigenVectorValue.Text = "Eigen";
            this.btn_EigenVectorValue.UseVisualStyleBackColor = true;
            this.btn_EigenVectorValue.Click += new System.EventHandler(this.btn_EigenVectorValue_Click);
            // 
            // btn_Inverse
            // 
            this.btn_Inverse.Location = new System.Drawing.Point(492, 297);
            this.btn_Inverse.Name = "btn_Inverse";
            this.btn_Inverse.Size = new System.Drawing.Size(75, 23);
            this.btn_Inverse.TabIndex = 20;
            this.btn_Inverse.Text = "Inverse";
            this.btn_Inverse.UseVisualStyleBackColor = true;
            this.btn_Inverse.Click += new System.EventHandler(this.btn_Inverse_Click);
            // 
            // btn_Adjoint
            // 
            this.btn_Adjoint.Location = new System.Drawing.Point(411, 297);
            this.btn_Adjoint.Name = "btn_Adjoint";
            this.btn_Adjoint.Size = new System.Drawing.Size(75, 23);
            this.btn_Adjoint.TabIndex = 19;
            this.btn_Adjoint.Text = "Adjoint";
            this.btn_Adjoint.UseVisualStyleBackColor = true;
            this.btn_Adjoint.Click += new System.EventHandler(this.btn_Adjoint_Click);
            // 
            // btn_Determinant
            // 
            this.btn_Determinant.Location = new System.Drawing.Point(330, 297);
            this.btn_Determinant.Name = "btn_Determinant";
            this.btn_Determinant.Size = new System.Drawing.Size(75, 23);
            this.btn_Determinant.TabIndex = 18;
            this.btn_Determinant.Text = "Determinant";
            this.btn_Determinant.UseVisualStyleBackColor = true;
            this.btn_Determinant.Click += new System.EventHandler(this.btn_Determinant_Click);
            // 
            // btn_Transpose
            // 
            this.btn_Transpose.Location = new System.Drawing.Point(249, 297);
            this.btn_Transpose.Name = "btn_Transpose";
            this.btn_Transpose.Size = new System.Drawing.Size(75, 23);
            this.btn_Transpose.TabIndex = 17;
            this.btn_Transpose.Text = "Transpose";
            this.btn_Transpose.UseVisualStyleBackColor = true;
            this.btn_Transpose.Click += new System.EventHandler(this.btn_Transpose_Click);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Location = new System.Drawing.Point(168, 297);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiply.TabIndex = 16;
            this.btn_Multiply.Text = "Multiply";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.btn_Multiply_Click);
            // 
            // btn_RandValues
            // 
            this.btn_RandValues.Location = new System.Drawing.Point(87, 297);
            this.btn_RandValues.Name = "btn_RandValues";
            this.btn_RandValues.Size = new System.Drawing.Size(75, 23);
            this.btn_RandValues.TabIndex = 15;
            this.btn_RandValues.Text = "Rand Matrix";
            this.btn_RandValues.UseVisualStyleBackColor = true;
            this.btn_RandValues.Click += new System.EventHandler(this.btn_RandValues_Click);
            // 
            // cmb_SaveMatrix
            // 
            this.cmb_SaveMatrix.FormattingEnabled = true;
            this.cmb_SaveMatrix.Items.AddRange(new object[] {
            "Matrix 1",
            "Output Matrix 1",
            "Matrix 2",
            "Output Matrix 2",
            "Matrix 3",
            "Output Matrix 3"});
            this.cmb_SaveMatrix.Location = new System.Drawing.Point(358, 9);
            this.cmb_SaveMatrix.Name = "cmb_SaveMatrix";
            this.cmb_SaveMatrix.Size = new System.Drawing.Size(121, 21);
            this.cmb_SaveMatrix.TabIndex = 6;
            // 
            // txt_MultiTest
            // 
            this.txt_MultiTest.Location = new System.Drawing.Point(1047, 727);
            this.txt_MultiTest.Multiline = true;
            this.txt_MultiTest.Name = "txt_MultiTest";
            this.txt_MultiTest.Size = new System.Drawing.Size(101, 20);
            this.txt_MultiTest.TabIndex = 1000000;
            this.txt_MultiTest.TabStop = false;
            this.txt_MultiTest.TextChanged += new System.EventHandler(this.txt_MultiTest_TextChanged);
            // 
            // btn_RREF
            // 
            this.btn_RREF.Location = new System.Drawing.Point(6, 297);
            this.btn_RREF.Name = "btn_RREF";
            this.btn_RREF.Size = new System.Drawing.Size(75, 23);
            this.btn_RREF.TabIndex = 14;
            this.btn_RREF.Text = "RREF";
            this.btn_RREF.UseVisualStyleBackColor = true;
            this.btn_RREF.Click += new System.EventHandler(this.btn_RREF_Click);
            // 
            // chkbx_MatrixThree
            // 
            this.chkbx_MatrixThree.AutoSize = true;
            this.chkbx_MatrixThree.Location = new System.Drawing.Point(794, 55);
            this.chkbx_MatrixThree.Name = "chkbx_MatrixThree";
            this.chkbx_MatrixThree.Size = new System.Drawing.Size(63, 17);
            this.chkbx_MatrixThree.TabIndex = 13;
            this.chkbx_MatrixThree.Text = "Matrix 3";
            this.chkbx_MatrixThree.UseVisualStyleBackColor = true;
            // 
            // chkbx_MatrixTwo
            // 
            this.chkbx_MatrixTwo.AutoSize = true;
            this.chkbx_MatrixTwo.Location = new System.Drawing.Point(400, 55);
            this.chkbx_MatrixTwo.Name = "chkbx_MatrixTwo";
            this.chkbx_MatrixTwo.Size = new System.Drawing.Size(63, 17);
            this.chkbx_MatrixTwo.TabIndex = 12;
            this.chkbx_MatrixTwo.Text = "Matrix 2";
            this.chkbx_MatrixTwo.UseVisualStyleBackColor = true;
            // 
            // chkbx_MatrixOne
            // 
            this.chkbx_MatrixOne.AutoSize = true;
            this.chkbx_MatrixOne.Location = new System.Drawing.Point(6, 55);
            this.chkbx_MatrixOne.Name = "chkbx_MatrixOne";
            this.chkbx_MatrixOne.Size = new System.Drawing.Size(63, 17);
            this.chkbx_MatrixOne.TabIndex = 11;
            this.chkbx_MatrixOne.Text = "Matrix 1";
            this.chkbx_MatrixOne.UseVisualStyleBackColor = true;
            // 
            // btn_LoadMatrix
            // 
            this.btn_LoadMatrix.Location = new System.Drawing.Point(1077, 5);
            this.btn_LoadMatrix.Name = "btn_LoadMatrix";
            this.btn_LoadMatrix.Size = new System.Drawing.Size(86, 23);
            this.btn_LoadMatrix.TabIndex = 9;
            this.btn_LoadMatrix.Text = "Load Matrix:";
            this.btn_LoadMatrix.UseVisualStyleBackColor = true;
            this.btn_LoadMatrix.Click += new System.EventHandler(this.btn_LoadMatrix_Click);
            // 
            // cmb_MatrixStorage
            // 
            this.cmb_MatrixStorage.FormattingEnabled = true;
            this.cmb_MatrixStorage.Location = new System.Drawing.Point(950, 7);
            this.cmb_MatrixStorage.Name = "cmb_MatrixStorage";
            this.cmb_MatrixStorage.Size = new System.Drawing.Size(121, 21);
            this.cmb_MatrixStorage.TabIndex = 8;
            // 
            // btn_DelMatrix
            // 
            this.btn_DelMatrix.Location = new System.Drawing.Point(1169, 5);
            this.btn_DelMatrix.Name = "btn_DelMatrix";
            this.btn_DelMatrix.Size = new System.Drawing.Size(86, 23);
            this.btn_DelMatrix.TabIndex = 10;
            this.btn_DelMatrix.Text = "Del Matrix:";
            this.btn_DelMatrix.UseVisualStyleBackColor = true;
            this.btn_DelMatrix.Click += new System.EventHandler(this.btn_DelMatrix_Click);
            // 
            // txt_MatrixName
            // 
            this.txt_MatrixName.Location = new System.Drawing.Point(485, 9);
            this.txt_MatrixName.Name = "txt_MatrixName";
            this.txt_MatrixName.Size = new System.Drawing.Size(100, 20);
            this.txt_MatrixName.TabIndex = 7;
            // 
            // btn_SaveMatrix
            // 
            this.btn_SaveMatrix.Location = new System.Drawing.Point(266, 7);
            this.btn_SaveMatrix.Name = "btn_SaveMatrix";
            this.btn_SaveMatrix.Size = new System.Drawing.Size(86, 23);
            this.btn_SaveMatrix.TabIndex = 5;
            this.btn_SaveMatrix.Text = "Save Matrix:";
            this.btn_SaveMatrix.UseVisualStyleBackColor = true;
            this.btn_SaveMatrix.Click += new System.EventHandler(this.btn_SaveMatrix_Click);
            // 
            // txt_TestLinAl
            // 
            this.txt_TestLinAl.Location = new System.Drawing.Point(1154, 727);
            this.txt_TestLinAl.Name = "txt_TestLinAl";
            this.txt_TestLinAl.Size = new System.Drawing.Size(101, 20);
            this.txt_TestLinAl.TabIndex = 1000000;
            this.txt_TestLinAl.TabStop = false;
            // 
            // delCol
            // 
            this.delCol.Location = new System.Drawing.Point(201, 7);
            this.delCol.Name = "delCol";
            this.delCol.Size = new System.Drawing.Size(59, 23);
            this.delCol.TabIndex = 3;
            this.delCol.Text = "Del Col";
            this.delCol.UseVisualStyleBackColor = true;
            this.delCol.Click += new System.EventHandler(this.delCol_Click);
            // 
            // delRow
            // 
            this.delRow.Location = new System.Drawing.Point(136, 7);
            this.delRow.Name = "delRow";
            this.delRow.Size = new System.Drawing.Size(59, 23);
            this.delRow.TabIndex = 2;
            this.delRow.Text = "Del Row";
            this.delRow.UseVisualStyleBackColor = true;
            this.delRow.Click += new System.EventHandler(this.delRow_Click);
            // 
            // addCol
            // 
            this.addCol.Location = new System.Drawing.Point(71, 7);
            this.addCol.Name = "addCol";
            this.addCol.Size = new System.Drawing.Size(59, 23);
            this.addCol.TabIndex = 1;
            this.addCol.Text = "Add Col";
            this.addCol.UseVisualStyleBackColor = true;
            this.addCol.Click += new System.EventHandler(this.addCol_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(6, 7);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(59, 23);
            this.addRow.TabIndex = 0;
            this.addRow.Text = "Add Row";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 803);
            this.Controls.Add(this.TabCtrl);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            this.TabCtrl.ResumeLayout(false);
            this.tb_Calculator.ResumeLayout(false);
            this.tb_Calculator.PerformLayout();
            this.tb_Logic.ResumeLayout(false);
            this.tb_Logic.PerformLayout();
            this.tb_LinAlg.ResumeLayout(false);
            this.tb_LinAlg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.CheckBox ckbxDumbMode;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnRightParen;
        private System.Windows.Forms.Button btnLeftParen;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnBkspce;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage tb_Calculator;
        private System.Windows.Forms.TabPage tb_Logic;
        private System.Windows.Forms.Label lbl_Bin;
        private System.Windows.Forms.TextBox txt_Binary;
        private System.Windows.Forms.Label lbl_Oct;
        private System.Windows.Forms.TextBox txt_Octal;
        private System.Windows.Forms.Label lbl_Hex;
        private System.Windows.Forms.TextBox txt_Hex;
        private System.Windows.Forms.Label lbl_Dec;
        private System.Windows.Forms.TextBox txt_Decimal;
        private System.Windows.Forms.Label Lbl_Conversion;
        private System.Windows.Forms.ComboBox cmb_bx_Complement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BitLen;
        private System.Windows.Forms.Label lbl_Comp;
        private System.Windows.Forms.Label lbl_Groups;
        private System.Windows.Forms.CheckBox chbx_Groups;
        private System.Windows.Forms.ComboBox cmb_Groups;
        private System.Windows.Forms.TabPage tb_LinAlg;
        private System.Windows.Forms.Button delCol;
        private System.Windows.Forms.Button delRow;
        private System.Windows.Forms.Button addCol;
        private System.Windows.Forms.Button addRow;
        private System.Windows.Forms.TextBox txt_TestLinAl;
        private System.Windows.Forms.Button btn_LoadMatrix;
        private System.Windows.Forms.ComboBox cmb_MatrixStorage;
        private System.Windows.Forms.Button btn_DelMatrix;
        private System.Windows.Forms.TextBox txt_MatrixName;
        private System.Windows.Forms.Button btn_SaveMatrix;
        private System.Windows.Forms.CheckBox chkbx_MatrixOne;
        private System.Windows.Forms.CheckBox chkbx_MatrixTwo;
        private System.Windows.Forms.CheckBox chkbx_MatrixThree;
        private System.Windows.Forms.Button btn_RREF;
        private System.Windows.Forms.TextBox txt_MultiTest;
        private System.Windows.Forms.ComboBox cmb_SaveMatrix;
        private System.Windows.Forms.Button btn_RandValues;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Transpose;
        private System.Windows.Forms.Button btn_Determinant;
        private System.Windows.Forms.Button btn_Adjoint;
        private System.Windows.Forms.Button btn_Inverse;
        private System.Windows.Forms.Button btn_EigenVectorValue;
    }
}

