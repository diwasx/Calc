namespace WindowsFormsApplication1
{
    partial class Calc
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.Screen1 = new System.Windows.Forms.TextBox();
            this.HardClear = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.MemPlus = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.MemMinus = new System.Windows.Forms.Button();
            this.MemC = new System.Windows.Forms.Button();
            this.MemR = new System.Windows.Forms.Button();
            this.Expo = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.DivideByOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(154, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(42, 219);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 37);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(98, 219);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 37);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(154, 219);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 37);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen.Enabled = false;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(42, 55);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(274, 50);
            this.Screen.TabIndex = 9;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(42, 348);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 37);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(210, 262);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(50, 37);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(210, 305);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 37);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(210, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(154, 348);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 37);
            this.btnDot.TabIndex = 14;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(210, 219);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 37);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(42, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(266, 305);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 80);
            this.button16.TabIndex = 17;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Screen1
            // 
            this.Screen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen1.Enabled = false;
            this.Screen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen1.Location = new System.Drawing.Point(42, 29);
            this.Screen1.Multiline = true;
            this.Screen1.Name = "Screen1";
            this.Screen1.Size = new System.Drawing.Size(274, 29);
            this.Screen1.TabIndex = 18;
            this.Screen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HardClear
            // 
            this.HardClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardClear.Location = new System.Drawing.Point(98, 175);
            this.HardClear.Name = "HardClear";
            this.HardClear.Size = new System.Drawing.Size(50, 37);
            this.HardClear.TabIndex = 19;
            this.HardClear.Text = "C";
            this.HardClear.UseVisualStyleBackColor = true;
            this.HardClear.Click += new System.EventHandler(this.HardClear_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(154, 176);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(50, 37);
            this.Del.TabIndex = 20;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // MemPlus
            // 
            this.MemPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemPlus.Location = new System.Drawing.Point(154, 132);
            this.MemPlus.Name = "MemPlus";
            this.MemPlus.Size = new System.Drawing.Size(50, 37);
            this.MemPlus.TabIndex = 21;
            this.MemPlus.Text = "M⁺";
            this.MemPlus.UseVisualStyleBackColor = true;
            this.MemPlus.Click += new System.EventHandler(this.MemPlus_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Location = new System.Drawing.Point(266, 262);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(50, 37);
            this.SquareRoot.TabIndex = 22;
            this.SquareRoot.Text = "√";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(266, 219);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 37);
            this.button12.TabIndex = 23;
            this.button12.Text = "x²";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // MemMinus
            // 
            this.MemMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemMinus.Location = new System.Drawing.Point(210, 132);
            this.MemMinus.Name = "MemMinus";
            this.MemMinus.Size = new System.Drawing.Size(50, 37);
            this.MemMinus.TabIndex = 24;
            this.MemMinus.Text = "M⁻";
            this.MemMinus.UseVisualStyleBackColor = true;
            this.MemMinus.Click += new System.EventHandler(this.MemMinus_Click);
            // 
            // MemC
            // 
            this.MemC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemC.Location = new System.Drawing.Point(98, 132);
            this.MemC.Name = "MemC";
            this.MemC.Size = new System.Drawing.Size(50, 37);
            this.MemC.TabIndex = 25;
            this.MemC.Text = "MC";
            this.MemC.UseVisualStyleBackColor = true;
            this.MemC.Click += new System.EventHandler(this.MemC_Click);
            // 
            // MemR
            // 
            this.MemR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemR.Location = new System.Drawing.Point(42, 132);
            this.MemR.Name = "MemR";
            this.MemR.Size = new System.Drawing.Size(50, 37);
            this.MemR.TabIndex = 26;
            this.MemR.Text = "MR";
            this.MemR.UseVisualStyleBackColor = true;
            this.MemR.Click += new System.EventHandler(this.MemR_Click);
            // 
            // Expo
            // 
            this.Expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expo.Location = new System.Drawing.Point(210, 176);
            this.Expo.Name = "Expo";
            this.Expo.Size = new System.Drawing.Size(50, 37);
            this.Expo.TabIndex = 27;
            this.Expo.Text = "10ˣ";
            this.Expo.UseVisualStyleBackColor = true;
            this.Expo.Click += new System.EventHandler(this.Expo_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinus.Location = new System.Drawing.Point(266, 175);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(50, 37);
            this.PlusMinus.TabIndex = 28;
            this.PlusMinus.Text = "±";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // DivideByOne
            // 
            this.DivideByOne.Location = new System.Drawing.Point(266, 132);
            this.DivideByOne.Name = "DivideByOne";
            this.DivideByOne.Size = new System.Drawing.Size(50, 37);
            this.DivideByOne.TabIndex = 29;
            this.DivideByOne.Text = "1/x";
            this.DivideByOne.UseVisualStyleBackColor = true;
            this.DivideByOne.Click += new System.EventHandler(this.DivideByOne_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 402);
            this.Controls.Add(this.DivideByOne);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.Expo);
            this.Controls.Add(this.MemR);
            this.Controls.Add(this.MemC);
            this.Controls.Add(this.MemMinus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.MemPlus);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.HardClear);
            this.Controls.Add(this.Screen1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calc";
            this.Opacity = 0.95D;
            this.Text = "Calc";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox Screen1;
        private System.Windows.Forms.Button HardClear;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button MemPlus;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button MemMinus;
        private System.Windows.Forms.Button MemC;
        private System.Windows.Forms.Button MemR;
        private System.Windows.Forms.Button Expo;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button DivideByOne;
    }
}

