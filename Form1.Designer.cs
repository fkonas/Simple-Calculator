namespace Calculator
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
            txt_display = new TextBox();
            btn_seven = new Button();
            btn_eight = new Button();
            btn_nine = new Button();
            btn_six = new Button();
            btn_five = new Button();
            btn_four = new Button();
            btn_tree = new Button();
            btn_two = new Button();
            btn_one = new Button();
            btn_equals = new Button();
            btn_point = new Button();
            btn_zero = new Button();
            btn_multiply = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // txt_display
            // 
            txt_display.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_display.ForeColor = Color.SlateGray;
            txt_display.Location = new Point(31, 59);
            txt_display.Name = "txt_display";
            txt_display.Size = new Size(475, 71);
            txt_display.TabIndex = 0;
            txt_display.TextAlign = HorizontalAlignment.Right;
            txt_display.TextChanged += textBox1_TextChanged;
            // 
            // btn_seven
            // 
            btn_seven.BackColor = Color.AliceBlue;
            btn_seven.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_seven.FlatAppearance.BorderSize = 5;
            btn_seven.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_seven.ForeColor = Color.SlateGray;
            btn_seven.Location = new Point(44, 170);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(80, 90);
            btn_seven.TabIndex = 1;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = false;
            btn_seven.Click += btn_digit_click;
            // 
            // btn_eight
            // 
            btn_eight.BackColor = Color.AliceBlue;
            btn_eight.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_eight.FlatAppearance.BorderSize = 5;
            btn_eight.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_eight.ForeColor = Color.SlateGray;
            btn_eight.Location = new Point(147, 170);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(80, 90);
            btn_eight.TabIndex = 2;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = false;
            btn_eight.Click += btn_digit_click;
            // 
            // btn_nine
            // 
            btn_nine.BackColor = Color.AliceBlue;
            btn_nine.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_nine.FlatAppearance.BorderSize = 5;
            btn_nine.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_nine.ForeColor = Color.SlateGray;
            btn_nine.Location = new Point(250, 170);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(80, 90);
            btn_nine.TabIndex = 3;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = false;
            btn_nine.Click += btn_digit_click;
            // 
            // btn_six
            // 
            btn_six.BackColor = Color.AliceBlue;
            btn_six.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_six.FlatAppearance.BorderSize = 5;
            btn_six.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_six.ForeColor = Color.SlateGray;
            btn_six.Location = new Point(250, 278);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(80, 90);
            btn_six.TabIndex = 6;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = false;
            btn_six.Click += btn_digit_click;
            // 
            // btn_five
            // 
            btn_five.BackColor = Color.AliceBlue;
            btn_five.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_five.FlatAppearance.BorderSize = 5;
            btn_five.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_five.ForeColor = Color.SlateGray;
            btn_five.Location = new Point(147, 278);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(80, 90);
            btn_five.TabIndex = 5;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = false;
            btn_five.Click += btn_digit_click;
            // 
            // btn_four
            // 
            btn_four.BackColor = Color.AliceBlue;
            btn_four.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_four.FlatAppearance.BorderSize = 5;
            btn_four.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_four.ForeColor = Color.SlateGray;
            btn_four.Location = new Point(44, 278);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(80, 90);
            btn_four.TabIndex = 4;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = false;
            btn_four.Click += btn_digit_click;
            // 
            // btn_tree
            // 
            btn_tree.BackColor = Color.AliceBlue;
            btn_tree.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_tree.FlatAppearance.BorderSize = 5;
            btn_tree.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_tree.ForeColor = Color.SlateGray;
            btn_tree.Location = new Point(250, 386);
            btn_tree.Name = "btn_tree";
            btn_tree.Size = new Size(80, 90);
            btn_tree.TabIndex = 9;
            btn_tree.Text = "3";
            btn_tree.UseVisualStyleBackColor = false;
            btn_tree.Click += btn_digit_click;
            // 
            // btn_two
            // 
            btn_two.BackColor = Color.AliceBlue;
            btn_two.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_two.FlatAppearance.BorderSize = 5;
            btn_two.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_two.ForeColor = Color.SlateGray;
            btn_two.Location = new Point(147, 386);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(80, 90);
            btn_two.TabIndex = 8;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = false;
            btn_two.Click += btn_digit_click;
            // 
            // btn_one
            // 
            btn_one.BackColor = Color.AliceBlue;
            btn_one.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_one.FlatAppearance.BorderSize = 5;
            btn_one.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_one.ForeColor = Color.SlateGray;
            btn_one.Location = new Point(44, 386);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(80, 90);
            btn_one.TabIndex = 7;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = false;
            btn_one.Click += btn_digit_click;
            // 
            // btn_equals
            // 
            btn_equals.BackColor = Color.AliceBlue;
            btn_equals.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_equals.FlatAppearance.BorderSize = 5;
            btn_equals.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_equals.ForeColor = Color.SlateGray;
            btn_equals.Location = new Point(353, 494);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(135, 90);
            btn_equals.TabIndex = 12;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = false;
            btn_equals.Click += btn_equals_Click;
            // 
            // btn_point
            // 
            btn_point.BackColor = Color.AliceBlue;
            btn_point.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_point.FlatAppearance.BorderSize = 5;
            btn_point.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_point.ForeColor = Color.SlateGray;
            btn_point.Location = new Point(147, 494);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(80, 90);
            btn_point.TabIndex = 11;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = false;
            btn_point.Click += btn_digit_click;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = Color.AliceBlue;
            btn_zero.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_zero.FlatAppearance.BorderSize = 5;
            btn_zero.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_zero.ForeColor = Color.SlateGray;
            btn_zero.Location = new Point(44, 494);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(80, 90);
            btn_zero.TabIndex = 10;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = false;
            btn_zero.Click += btn_digit_click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.AliceBlue;
            btn_multiply.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_multiply.FlatAppearance.BorderSize = 5;
            btn_multiply.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold);
            btn_multiply.ForeColor = Color.SlateGray;
            btn_multiply.Location = new Point(353, 330);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(136, 66);
            btn_multiply.TabIndex = 15;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_operator_click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.AliceBlue;
            btn_minus.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_minus.FlatAppearance.BorderSize = 5;
            btn_minus.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold);
            btn_minus.ForeColor = Color.SlateGray;
            btn_minus.Location = new Point(353, 250);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(136, 66);
            btn_minus.TabIndex = 14;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_operator_click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.AliceBlue;
            btn_plus.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_plus.FlatAppearance.BorderSize = 5;
            btn_plus.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold);
            btn_plus.ForeColor = Color.SlateGray;
            btn_plus.Location = new Point(353, 170);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(136, 66);
            btn_plus.TabIndex = 13;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_operator_click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.AliceBlue;
            btn_divide.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_divide.FlatAppearance.BorderSize = 5;
            btn_divide.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold);
            btn_divide.ForeColor = Color.SlateGray;
            btn_divide.Location = new Point(353, 410);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(136, 66);
            btn_divide.TabIndex = 16;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_operator_click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.AliceBlue;
            btn_clear.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_clear.FlatAppearance.BorderSize = 5;
            btn_clear.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_clear.ForeColor = Color.SlateGray;
            btn_clear.Location = new Point(250, 494);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(80, 90);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(540, 650);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_minus);
            Controls.Add(btn_plus);
            Controls.Add(btn_equals);
            Controls.Add(btn_point);
            Controls.Add(btn_zero);
            Controls.Add(btn_tree);
            Controls.Add(btn_two);
            Controls.Add(btn_one);
            Controls.Add(btn_six);
            Controls.Add(btn_five);
            Controls.Add(btn_four);
            Controls.Add(btn_nine);
            Controls.Add(btn_eight);
            Controls.Add(btn_seven);
            Controls.Add(txt_display);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Crayz Calculate";
            Click += btn_digit_click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_display;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_nine;
        private Button btn_six;
        private Button btn_five;
        private Button btn_four;
        private Button btn_tree;
        private Button btn_two;
        private Button btn_one;
        private Button btn_equals;
        private Button btn_point;
        private Button btn_zero;
        private Button btn_multiply;
        private Button btn_minus;
        private Button btn_plus;
        private Button btn_divide;
        private Button btn_clear;
    }
}
