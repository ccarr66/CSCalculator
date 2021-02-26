namespace CS_Calculator
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnAdd.Location = new System.Drawing.Point(496, 64);
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
            this.txtNumberOne.Location = new System.Drawing.Point(151, 316);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(109, 20);
            this.txtNumberOne.TabIndex = 24;
            this.txtNumberOne.TabStop = false;
            this.txtNumberOne.Visible = false;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(268, 316);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(109, 20);
            this.txtNumberTwo.TabIndex = 23;
            this.txtNumberTwo.TabStop = false;
            this.txtNumberTwo.Visible = false;
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(148, 300);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(67, 13);
            this.lblNumberOne.TabIndex = 3;
            this.lblNumberOne.Text = "Number One";
            this.lblNumberOne.Visible = false;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(265, 300);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(68, 13);
            this.lblNumberTwo.TabIndex = 4;
            this.lblNumberTwo.Text = "Number Two";
            this.lblNumberTwo.Visible = false;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(15, 105);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(233, 26);
            this.txtResult.TabIndex = 26;
            this.txtResult.TabStop = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(438, 176);
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
            this.btnDivide.Location = new System.Drawing.Point(438, 120);
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
            this.btnMod.Location = new System.Drawing.Point(496, 120);
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
            this.btnPow.Location = new System.Drawing.Point(496, 176);
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
            this.btnMultiply.Location = new System.Drawing.Point(438, 64);
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
            this.lblResult.Location = new System.Drawing.Point(12, 89);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Result";
            // 
            // txtTest
            // 
            this.txtTest.Enabled = false;
            this.txtTest.Location = new System.Drawing.Point(438, 316);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(110, 20);
            this.txtTest.TabIndex = 22;
            this.txtTest.TabStop = false;
            this.txtTest.Text = " ";
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btnEquals.Location = new System.Drawing.Point(496, 232);
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
            this.txtExpression.Location = new System.Drawing.Point(12, 25);
            this.txtExpression.Multiline = true;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(236, 61);
            this.txtExpression.TabIndex = 25;
            this.txtExpression.Leave += new System.EventHandler(this.txtExpression_Leave);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(9, 9);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(58, 13);
            this.lblExpression.TabIndex = 20;
            this.lblExpression.Text = "Expression";
            // 
            // ckbxDumbMode
            // 
            this.ckbxDumbMode.AutoSize = true;
            this.ckbxDumbMode.Location = new System.Drawing.Point(12, 316);
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
            this.btnSeven.Location = new System.Drawing.Point(264, 64);
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
            this.btnEight.Location = new System.Drawing.Point(322, 64);
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
            this.btnNine.Location = new System.Drawing.Point(380, 64);
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
            this.btnFour.Location = new System.Drawing.Point(264, 120);
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
            this.btnFive.Location = new System.Drawing.Point(322, 120);
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
            this.btnSix.Location = new System.Drawing.Point(380, 120);
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
            this.btnOne.Location = new System.Drawing.Point(264, 176);
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
            this.btnTwo.Location = new System.Drawing.Point(322, 176);
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
            this.btnThree.Location = new System.Drawing.Point(380, 176);
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
            this.btnRightParen.Location = new System.Drawing.Point(322, 8);
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
            this.btnLeftParen.Location = new System.Drawing.Point(264, 8);
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
            this.btnZero.Location = new System.Drawing.Point(264, 232);
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
            this.btnDecimal.Location = new System.Drawing.Point(380, 232);
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
            this.btnBkspce.Location = new System.Drawing.Point(496, 8);
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
            this.btnAns.Location = new System.Drawing.Point(438, 232);
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
            this.btnClear.Location = new System.Drawing.Point(438, 8);
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
            this.btnNegate.Location = new System.Drawing.Point(380, 8);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(52, 50);
            this.btnNegate.TabIndex = 30;
            this.btnNegate.TabStop = false;
            this.btnNegate.Text = "±";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 340);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnBkspce);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnLeftParen);
            this.Controls.Add(this.btnRightParen);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.ckbxDumbMode);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

