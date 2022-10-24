namespace SimpleCalculatorv2
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
            this.button_equals = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_equals
            // 
            this.button_equals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_equals.Location = new System.Drawing.Point(258, 403);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(74, 74);
            this.button_equals.TabIndex = 39;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(16, 106);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(232, 58);
            this.button_clear.TabIndex = 38;
            this.button_clear.Text = "C/CE";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_decimal
            // 
            this.button_decimal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_decimal.Location = new System.Drawing.Point(173, 403);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(75, 73);
            this.button_decimal.TabIndex = 37;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = true;
            this.button_decimal.Click += new System.EventHandler(this.button_decimal_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(16, 403);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(151, 73);
            this.button_0.TabIndex = 36;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_divide.Location = new System.Drawing.Point(254, 325);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(74, 73);
            this.button_divide.TabIndex = 35;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiply.Location = new System.Drawing.Point(258, 246);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(74, 72);
            this.button_multiply.TabIndex = 34;
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_subtract.Location = new System.Drawing.Point(258, 170);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(74, 69);
            this.button_subtract.TabIndex = 33;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(258, 111);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(74, 53);
            this.button_add.TabIndex = 32;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(174, 325);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(74, 73);
            this.button_9.TabIndex = 31;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(93, 325);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(75, 73);
            this.button_8.TabIndex = 30;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(16, 324);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(71, 73);
            this.button_7.TabIndex = 29;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(174, 246);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(74, 73);
            this.button_6.TabIndex = 28;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(93, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 73);
            this.button5.TabIndex = 27;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(16, 245);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(71, 73);
            this.button_4.TabIndex = 26;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(174, 167);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(74, 73);
            this.button_3.TabIndex = 25;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(93, 167);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 73);
            this.button_2.TabIndex = 24;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatorDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 9);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(320, 94);
            this.calculatorDisplay.TabIndex = 23;
            this.calculatorDisplay.Text = "0";
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(16, 166);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(71, 73);
            this.button_1.TabIndex = 22;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 486);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_decimal);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.button_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_equals;
        private Button button_clear;
        private Button button_decimal;
        private Button button_0;
        private Button button_divide;
        private Button button_multiply;
        private Button button_subtract;
        private Button button_add;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private Button button_6;
        private Button button5;
        private Button button_4;
        private Button button_3;
        private Button button_2;
        private Label calculatorDisplay;
        private Button button_1;
    }
}