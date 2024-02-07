namespace Calculator
{
    public partial class Calculator_page_1 : Form
    {
        private double firstOperand;
        private double secondOperand;
        private string currentOperation;
        private double result;

        private int flag_OperationBtn = 0;

        public Calculator_page_1()
        {
            InitializeComponent();
        }
              
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

        private void btn_Power_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
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

        private void btn_Div_Click(object sender, EventArgs e)
        {
            currentOperation = "/";

            //txt_InputOutput.Text = txt_InputOutput.Text + "/";
            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;

            //firstOperand = Convert.ToInt16(txt_InputOutput.Text);
            firstOperand = double.Parse(txt_InputOutput.Text.Remove(txt_InputOutput.Text.Length-1));
        }     

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "*";

            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;    
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txt_InputOutput.Text);
            
            currentOperation = "-";

            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Btn_Validation();

            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "+";

            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;

            //if (string.IsNullOrEmpty(Convert.ToString(secondOperand))){}          
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(txt_InputOutput.Text);

            currentOperation = "%";

            txt_InputOutput.Text = txt_InputOutput.Text + currentOperation;
        }

        private void Btn_Validation()
        {          
            if(flag_OperationBtn == 1)
            {
                Calculation();

                flag_OperationBtn = 0;
            }

            flag_OperationBtn++;
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
        }

        private void btn_For_Result_Click(object sender, EventArgs e)
        {
           Calculation();  
        }
    }
}
