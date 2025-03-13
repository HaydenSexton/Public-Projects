namespace CalcApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            txtMemory = new TextBox();
            btnBack = new Button();
            btnClear = new Button();
            btnMemoryClear = new Button();
            btnMemoryRecall = new Button();
            btnMemorySave = new Button();
            btnMemoryAdd = new Button();
            btnsquareRoot = new Button();
            btnRecipocal = new Button();
            btnEquals = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btn2 = new Button();
            btnDecimal = new Button();
            btn3 = new Button();
            btnSubtract = new Button();
            btnConvert = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 12);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.RightToLeft = RightToLeft.No;
            txtResult.Size = new Size(241, 23);
            txtResult.TabIndex = 25;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(12, 42);
            txtMemory.Name = "txtMemory";
            txtMemory.ReadOnly = true;
            txtMemory.Size = new Size(37, 23);
            txtMemory.TabIndex = 26;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(67, 41);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(152, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.ForeColor = Color.Red;
            btnMemoryClear.Location = new Point(12, 70);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(37, 23);
            btnMemoryClear.TabIndex = 21;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.ForeColor = Color.Red;
            btnMemoryRecall.Location = new Point(12, 99);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(37, 23);
            btnMemoryRecall.TabIndex = 22;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = true;
            btnMemoryRecall.Click += btnMemoryRecall_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.ForeColor = Color.Red;
            btnMemorySave.Location = new Point(12, 128);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(37, 23);
            btnMemorySave.TabIndex = 23;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.ForeColor = Color.Red;
            btnMemoryAdd.Location = new Point(12, 157);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(37, 23);
            btnMemoryAdd.TabIndex = 24;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = true;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // btnsquareRoot
            // 
            btnsquareRoot.ForeColor = Color.FromArgb(0, 192, 192);
            btnsquareRoot.Location = new Point(217, 70);
            btnsquareRoot.Name = "btnsquareRoot";
            btnsquareRoot.Size = new Size(36, 23);
            btnsquareRoot.TabIndex = 18;
            btnsquareRoot.Text = "sqrt";
            btnsquareRoot.UseVisualStyleBackColor = true;
            btnsquareRoot.Click += btnsquareRoot_Click;
            // 
            // btnRecipocal
            // 
            btnRecipocal.ForeColor = Color.FromArgb(0, 192, 192);
            btnRecipocal.Location = new Point(217, 99);
            btnRecipocal.Name = "btnRecipocal";
            btnRecipocal.Size = new Size(36, 23);
            btnRecipocal.TabIndex = 19;
            btnRecipocal.Text = "1/X";
            btnRecipocal.UseVisualStyleBackColor = true;
            btnRecipocal.Click += btnRecipocal_Click;
            // 
            // btnEquals
            // 
            btnEquals.ForeColor = Color.Red;
            btnEquals.Location = new Point(217, 128);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(36, 55);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn7
            // 
            btn7.ForeColor = Color.FromArgb(0, 192, 192);
            btn7.Location = new Point(67, 70);
            btn7.Name = "btn7";
            btn7.Size = new Size(27, 23);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.ForeColor = Color.FromArgb(0, 192, 192);
            btn4.Location = new Point(67, 99);
            btn4.Name = "btn4";
            btn4.Size = new Size(27, 23);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.ForeColor = Color.FromArgb(0, 192, 192);
            btn1.Location = new Point(67, 128);
            btn1.Name = "btn1";
            btn1.Size = new Size(27, 23);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn0
            // 
            btn0.ForeColor = Color.FromArgb(0, 192, 192);
            btn0.Location = new Point(67, 157);
            btn0.Name = "btn0";
            btn0.Size = new Size(27, 23);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.ForeColor = Color.FromArgb(0, 192, 192);
            btn8.Location = new Point(100, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(27, 23);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.ForeColor = Color.FromArgb(0, 192, 192);
            btn9.Location = new Point(133, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(27, 23);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btnDivide
            // 
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(175, 70);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(27, 23);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn5
            // 
            btn5.ForeColor = Color.FromArgb(0, 192, 192);
            btn5.Location = new Point(100, 99);
            btn5.Name = "btn5";
            btn5.Size = new Size(27, 23);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.ForeColor = Color.FromArgb(0, 192, 192);
            btn6.Location = new Point(133, 99);
            btn6.Name = "btn6";
            btn6.Size = new Size(27, 23);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(175, 99);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(27, 23);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn2
            // 
            btn2.ForeColor = Color.FromArgb(0, 192, 192);
            btn2.Location = new Point(100, 128);
            btn2.Name = "btn2";
            btn2.Size = new Size(27, 23);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.ForeColor = Color.FromArgb(0, 192, 192);
            btnDecimal.Location = new Point(142, 157);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(27, 23);
            btnDecimal.TabIndex = 16;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += Number_Click;
            // 
            // btn3
            // 
            btn3.ForeColor = Color.FromArgb(0, 192, 192);
            btn3.Location = new Point(133, 128);
            btn3.Name = "btn3";
            btn3.Size = new Size(27, 23);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(175, 128);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(27, 23);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnConvert
            // 
            btnConvert.ForeColor = Color.FromArgb(0, 192, 192);
            btnConvert.Location = new Point(100, 157);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(36, 23);
            btnConvert.TabIndex = 15;
            btnConvert.Text = "+/-";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(175, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(27, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 195);
            Controls.Add(btnAdd);
            Controls.Add(btnConvert);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btnDecimal);
            Controls.Add(btn2);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnEquals);
            Controls.Add(btnRecipocal);
            Controls.Add(btnsquareRoot);
            Controls.Add(btnMemoryAdd);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(txtMemory);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private TextBox txtMemory;
        private Button btnBack;
        private Button btnClear;
        private Button btnMemoryClear;
        private Button btnMemoryRecall;
        private Button btnMemorySave;
        private Button btnMemoryAdd;
        private Button btnsquareRoot;
        private Button btnRecipocal;
        private Button btnEquals;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btn2;
        private Button btnDecimal;
        private Button btn3;
        private Button btnSubtract;
        private Button btnConvert;
        private Button btnAdd;
    }
}
