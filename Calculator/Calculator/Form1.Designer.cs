namespace Calculator
{
    partial class Calculator_page_1
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
            txt_InputOutput = new TextBox();
            btn_Power = new Button();
            btn_Clear = new Button();
            btn_Delete = new Button();
            btn_Div = new Button();
            btn_Mul = new Button();
            btn_For_Num3 = new Button();
            btn_For_Num2 = new Button();
            btn_For_Num1 = new Button();
            btn_Sub = new Button();
            btn_For_Num6 = new Button();
            btn_For_Num5 = new Button();
            btn_For_Num4 = new Button();
            btn_Add = new Button();
            btn_For_Num9 = new Button();
            btn_For_Num8 = new Button();
            btn_For_Num7 = new Button();
            btn_For_Result = new Button();
            btn_For_Dot = new Button();
            btn_For_Num0 = new Button();
            btn_Percent = new Button();
            SuspendLayout();
            // 
            // txt_InputOutput
            // 
            txt_InputOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_InputOutput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_InputOutput.Location = new Point(12, 12);
            txt_InputOutput.Multiline = true;
            txt_InputOutput.Name = "txt_InputOutput";
            txt_InputOutput.Size = new Size(195, 78);
            txt_InputOutput.TabIndex = 0;
            // 
            // btn_Power
            // 
            btn_Power.BackColor = Color.Green;
            btn_Power.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Power.ForeColor = Color.White;
            btn_Power.Location = new Point(12, 132);
            btn_Power.Name = "btn_Power";
            btn_Power.Size = new Size(45, 49);
            btn_Power.TabIndex = 1;
            btn_Power.Text = "On/Off";
            btn_Power.UseVisualStyleBackColor = false;
            btn_Power.Click += btn_Power_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Red;
            btn_Clear.Font = new Font("Segoe UI Black", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(63, 132);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(45, 49);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Orange;
            btn_Delete.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.ForeColor = Color.Black;
            btn_Delete.Location = new Point(114, 132);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(45, 49);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "DEL";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Div
            // 
            btn_Div.BackColor = SystemColors.InactiveCaption;
            btn_Div.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Div.ForeColor = Color.Black;
            btn_Div.Location = new Point(165, 132);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new Size(45, 49);
            btn_Div.TabIndex = 4;
            btn_Div.Text = "/";
            btn_Div.UseVisualStyleBackColor = false;
            btn_Div.Click += btn_Div_Click;
            // 
            // btn_Mul
            // 
            btn_Mul.BackColor = SystemColors.InactiveCaption;
            btn_Mul.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Mul.ForeColor = Color.Black;
            btn_Mul.Location = new Point(165, 187);
            btn_Mul.Name = "btn_Mul";
            btn_Mul.Size = new Size(45, 49);
            btn_Mul.TabIndex = 9;
            btn_Mul.Text = "*";
            btn_Mul.UseVisualStyleBackColor = false;
            btn_Mul.Click += btn_Mul_Click;
            // 
            // btn_For_Num3
            // 
            btn_For_Num3.BackColor = SystemColors.InactiveCaption;
            btn_For_Num3.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num3.ForeColor = Color.Black;
            btn_For_Num3.Location = new Point(114, 187);
            btn_For_Num3.Name = "btn_For_Num3";
            btn_For_Num3.Size = new Size(45, 49);
            btn_For_Num3.TabIndex = 8;
            btn_For_Num3.Text = "3";
            btn_For_Num3.UseVisualStyleBackColor = false;
            btn_For_Num3.Click += btn_For_Num3_Click;
            // 
            // btn_For_Num2
            // 
            btn_For_Num2.BackColor = SystemColors.InactiveCaption;
            btn_For_Num2.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num2.ForeColor = Color.Black;
            btn_For_Num2.Location = new Point(63, 187);
            btn_For_Num2.Name = "btn_For_Num2";
            btn_For_Num2.Size = new Size(45, 49);
            btn_For_Num2.TabIndex = 7;
            btn_For_Num2.Text = "2";
            btn_For_Num2.UseVisualStyleBackColor = false;
            btn_For_Num2.Click += btn_For_Num2_Click;
            // 
            // btn_For_Num1
            // 
            btn_For_Num1.BackColor = SystemColors.InactiveCaption;
            btn_For_Num1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num1.ForeColor = Color.Black;
            btn_For_Num1.Location = new Point(12, 187);
            btn_For_Num1.Name = "btn_For_Num1";
            btn_For_Num1.Size = new Size(45, 49);
            btn_For_Num1.TabIndex = 6;
            btn_For_Num1.Text = "1";
            btn_For_Num1.UseVisualStyleBackColor = false;
            btn_For_Num1.Click += btn_For_Num1_Click;
            // 
            // btn_Sub
            // 
            btn_Sub.BackColor = SystemColors.InactiveCaption;
            btn_Sub.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sub.ForeColor = Color.Black;
            btn_Sub.Location = new Point(165, 242);
            btn_Sub.Name = "btn_Sub";
            btn_Sub.Size = new Size(45, 49);
            btn_Sub.TabIndex = 14;
            btn_Sub.Text = "-";
            btn_Sub.UseVisualStyleBackColor = false;
            btn_Sub.Click += btn_Sub_Click;
            // 
            // btn_For_Num6
            // 
            btn_For_Num6.BackColor = SystemColors.InactiveCaption;
            btn_For_Num6.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num6.ForeColor = Color.Black;
            btn_For_Num6.Location = new Point(114, 242);
            btn_For_Num6.Name = "btn_For_Num6";
            btn_For_Num6.Size = new Size(45, 49);
            btn_For_Num6.TabIndex = 13;
            btn_For_Num6.Text = "6";
            btn_For_Num6.UseVisualStyleBackColor = false;
            btn_For_Num6.Click += btn_For_Num6_Click;
            // 
            // btn_For_Num5
            // 
            btn_For_Num5.BackColor = SystemColors.InactiveCaption;
            btn_For_Num5.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num5.ForeColor = Color.Black;
            btn_For_Num5.Location = new Point(63, 242);
            btn_For_Num5.Name = "btn_For_Num5";
            btn_For_Num5.Size = new Size(45, 49);
            btn_For_Num5.TabIndex = 12;
            btn_For_Num5.Text = "5";
            btn_For_Num5.UseVisualStyleBackColor = false;
            btn_For_Num5.Click += btn_For_Num5_Click;
            // 
            // btn_For_Num4
            // 
            btn_For_Num4.BackColor = SystemColors.InactiveCaption;
            btn_For_Num4.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num4.ForeColor = Color.Black;
            btn_For_Num4.Location = new Point(12, 242);
            btn_For_Num4.Name = "btn_For_Num4";
            btn_For_Num4.Size = new Size(45, 49);
            btn_For_Num4.TabIndex = 11;
            btn_For_Num4.Text = "4";
            btn_For_Num4.UseVisualStyleBackColor = false;
            btn_For_Num4.Click += btn_For_Num4_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.InactiveCaption;
            btn_Add.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(165, 297);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(45, 49);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_For_Num9
            // 
            btn_For_Num9.BackColor = SystemColors.InactiveCaption;
            btn_For_Num9.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num9.ForeColor = Color.Black;
            btn_For_Num9.Location = new Point(114, 297);
            btn_For_Num9.Name = "btn_For_Num9";
            btn_For_Num9.Size = new Size(45, 49);
            btn_For_Num9.TabIndex = 18;
            btn_For_Num9.Text = "9";
            btn_For_Num9.UseVisualStyleBackColor = false;
            btn_For_Num9.Click += btn_For_Num9_Click;
            // 
            // btn_For_Num8
            // 
            btn_For_Num8.BackColor = SystemColors.InactiveCaption;
            btn_For_Num8.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num8.ForeColor = Color.Black;
            btn_For_Num8.Location = new Point(63, 297);
            btn_For_Num8.Name = "btn_For_Num8";
            btn_For_Num8.Size = new Size(45, 49);
            btn_For_Num8.TabIndex = 17;
            btn_For_Num8.Text = "8";
            btn_For_Num8.UseVisualStyleBackColor = false;
            btn_For_Num8.Click += btn_For_Num8_Click;
            // 
            // btn_For_Num7
            // 
            btn_For_Num7.BackColor = SystemColors.InactiveCaption;
            btn_For_Num7.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num7.ForeColor = Color.Black;
            btn_For_Num7.Location = new Point(12, 297);
            btn_For_Num7.Name = "btn_For_Num7";
            btn_For_Num7.Size = new Size(45, 49);
            btn_For_Num7.TabIndex = 16;
            btn_For_Num7.Text = "7";
            btn_For_Num7.UseVisualStyleBackColor = false;
            btn_For_Num7.Click += btn_For_Num7_Click;
            // 
            // btn_For_Result
            // 
            btn_For_Result.BackColor = SystemColors.InactiveCaption;
            btn_For_Result.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Result.ForeColor = Color.Black;
            btn_For_Result.Location = new Point(165, 352);
            btn_For_Result.Name = "btn_For_Result";
            btn_For_Result.Size = new Size(45, 49);
            btn_For_Result.TabIndex = 23;
            btn_For_Result.Text = "=";
            btn_For_Result.UseVisualStyleBackColor = false;
            btn_For_Result.Click += btn_For_Result_Click;
            // 
            // btn_For_Dot
            // 
            btn_For_Dot.BackColor = SystemColors.InactiveCaption;
            btn_For_Dot.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Dot.ForeColor = Color.Black;
            btn_For_Dot.Location = new Point(114, 352);
            btn_For_Dot.Name = "btn_For_Dot";
            btn_For_Dot.Size = new Size(45, 49);
            btn_For_Dot.TabIndex = 22;
            btn_For_Dot.Text = ".";
            btn_For_Dot.UseVisualStyleBackColor = false;
            btn_For_Dot.Click += btn_For_Dot_Click;
            // 
            // btn_For_Num0
            // 
            btn_For_Num0.BackColor = SystemColors.InactiveCaption;
            btn_For_Num0.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_For_Num0.ForeColor = Color.Black;
            btn_For_Num0.Location = new Point(63, 352);
            btn_For_Num0.Name = "btn_For_Num0";
            btn_For_Num0.Size = new Size(45, 49);
            btn_For_Num0.TabIndex = 21;
            btn_For_Num0.Text = "0";
            btn_For_Num0.UseVisualStyleBackColor = false;
            btn_For_Num0.Click += btn_For_Num0_Click;
            // 
            // btn_Percent
            // 
            btn_Percent.BackColor = SystemColors.InactiveCaption;
            btn_Percent.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Percent.ForeColor = Color.Black;
            btn_Percent.Location = new Point(12, 352);
            btn_Percent.Name = "btn_Percent";
            btn_Percent.Size = new Size(45, 49);
            btn_Percent.TabIndex = 20;
            btn_Percent.Text = "%";
            btn_Percent.UseVisualStyleBackColor = false;
            btn_Percent.Click += btn_Percent_Click;
            // 
            // Calculator_page_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 410);
            Controls.Add(btn_For_Result);
            Controls.Add(btn_For_Dot);
            Controls.Add(btn_For_Num0);
            Controls.Add(btn_Percent);
            Controls.Add(btn_Add);
            Controls.Add(btn_For_Num9);
            Controls.Add(btn_For_Num8);
            Controls.Add(btn_For_Num7);
            Controls.Add(btn_Sub);
            Controls.Add(btn_For_Num6);
            Controls.Add(btn_For_Num5);
            Controls.Add(btn_For_Num4);
            Controls.Add(btn_Mul);
            Controls.Add(btn_For_Num3);
            Controls.Add(btn_For_Num2);
            Controls.Add(btn_For_Num1);
            Controls.Add(btn_Div);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Power);
            Controls.Add(txt_InputOutput);
            Name = "Calculator_page_1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_InputOutput;
        private Button btn_Power;
        private Button btn_Clear;
        private Button btn_Delete;
        private Button btn_Div;
        private Button btn_Mul;
        private Button btn_For_Num3;
        private Button btn_For_Num2;
        private Button btn_For_Num1;
        private Button btn_Sub;
        private Button btn_For_Num6;
        private Button btn_For_Num5;
        private Button btn_For_Num4;
        private Button btn_Add;
        private Button btn_For_Num9;
        private Button btn_For_Num8;
        private Button btn_For_Num7;
        private Button btn_For_Result;
        private Button btn_For_Dot;
        private Button btn_For_Num0;
        private Button btn_Percent;
    }
}
