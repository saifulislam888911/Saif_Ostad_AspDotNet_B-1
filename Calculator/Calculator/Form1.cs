namespace Calculator
{
    public partial class Calculator_page_1 : Form
    {
        public Calculator_page_1()
        {
            InitializeComponent();
        }



        /* ---------- Fields & Properties (start) ---------- */
        private double firstOperand;
        private double secondOperand;
        private string? currentOperation;
        private double result;

        private int flag_OperationBtnCal = 0;
        private int flag_operator2ndtime = 0;
        /* ---------- Fields & Properties (end) ---------- */



        /* ---------- Operand Number Assign (start) ---------- */   
        private void btn_For_Num1_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "1";
        }

        private void btn_For_Num2_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "2";
        }

        private void btn_For_Num3_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "3";
        }

        private void btn_For_Num4_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "4";
        }

        private void btn_For_Num5_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "5";
        }

        private void btn_For_Num6_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "6";
        }

        private void btn_For_Num7_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "7";
        }

        private void btn_For_Num8_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "8";
        }

        private void btn_For_Num9_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "9";
        }

        private void btn_For_Num0_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + "0";
        }

        private void btn_For_Dot_Click(object sender, EventArgs e)
        {
            txt_InputOutput.Text = txt_InputOutput.Text + ".";
        }
        /* ---------- Operand Number Assign (end) ---------- */



        /* ---------- Operator Assign (start) ---------- */
        private void btn_Div_Click(object sender, EventArgs e)
        {
            Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "/";

            operator_Validation();

            /*
            //txt_InputOutput.Text = txt_InputOutput.Text + "/";
            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;

            //firstOperand = Convert.ToInt16(txt_InputOutput.Text);
            firstOperand = double.Parse(txt_InputOutput.Text.Remove(txt_InputOutput.Text.Length-1));
            */
        }     

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "*";

            operator_Validation();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "-";

            operator_Validation();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "+";

            operator_Validation();
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "%";

            operator_Validation();
        }
        /* ---------- Operator Assign (end) ---------- */



        /* ---------- Functional Button Assign (start) ---------- */
        private void btn_Power_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            resetOperandValue();
            flag_operator2ndtime = 0;

            //txt_InputOutput.Text = "";
            txt_InputOutput.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_InputOutput.Text.Length > 0)
            {
                txt_InputOutput.Text = txt_InputOutput.Text.Remove(txt_InputOutput.Text.Length - 1);
            }
        }

        private void btn_For_Result_Click(object sender, EventArgs e)
        {
            try
            {
                Calculation();

                flag_operator2ndtime = 0;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid operand format. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Handle the format exception, which occurs if the operands are not valid doubles

                Console.WriteLine($"Format Exception: {ex.Message}"); // Output exception message to console
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Operand numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Format Exception: {ex.Message}"); // Output exception message to console

            }
        }
        /* ---------- Functional Button Assign (end) ---------- */



        /* ---------- Validation Function (start) ---------- */
        private void Btn_Validation()
        {
            if (flag_OperationBtnCal == 1)
            {
                Calculation();
            }
            else
            {
                flag_OperationBtnCal++;
            }
        }

        private void operator_Validation()
        {
            if ((firstOperand != 0) && (flag_operator2ndtime == 0))
            {
                txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;

                flag_operator2ndtime++;
            }
            else
            {
                flag_operator2ndtime = 0;
            }
        }
        /* ---------- Validation Function (end) ---------- */



        /* ---------- Common Function (start) ---------- */
        private void resetOperandValue()
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperation = null;

            flag_OperationBtnCal = 0;
            //flag_operator2ndtime = 0;
        }

        private void Calculation()
        {
            int charPos = txt_InputOutput.Text.IndexOf(currentOperation);
            //secondOperand = Convert.ToInt16(txt_InputOutput.Text);
            secondOperand = double.Parse(txt_InputOutput.Text.Substring(charPos + 1));

            switch (currentOperation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;

                case "-":
                    result = firstOperand - secondOperand;
                    break;

                case "*":
                    result = firstOperand * secondOperand;
                    break;

                case "/":
                    if (secondOperand != 0)
                    {
                        result = firstOperand / secondOperand;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "%":
                    result = firstOperand % secondOperand;
                    break;
            }

            txt_InputOutput.Text = result.ToString();

            resetOperandValue();
        }
        /* ---------- Common Function (end) ---------- */

    }
}
