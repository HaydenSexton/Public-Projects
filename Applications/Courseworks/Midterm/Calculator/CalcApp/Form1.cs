namespace CalcApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        Calculator calculator = new Calculator();
        MemoryCalculator memCalculator = new MemoryCalculator();

        private void Number_Click(object sender, EventArgs e)
        {
            if (calculator.UserInput == "0")
            {
                calculator.UserInput = "";
            }
            txtResult.Text = "";
            Button btn = (Button)sender;
            string buttonText = btn.Text; // buttontext equals whatever number button is clicked
            txtResult.Text = calculator.AddingNumbertoTXT(buttonText);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            first = "";
            second = "";
            result = 0.0;
            userInput = "";
            calculator.UserInput = "";
            calculator.First = "";
            calculator.Second = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double tempvalue = Convert.ToDouble(txtResult.Text);
            calculator.ConvertNum(tempvalue);
            txtResult.Text = calculator.UserInput;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculator.Function = '/';
            calculator.First = calculator.UserInput;
            calculator.UserInput = "";
            txtResult.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calculator.Function = '*';
            calculator.First = calculator.UserInput;
            calculator.UserInput = "";
            txtResult.Text = "0";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calculator.Function = '-';
            calculator.First = calculator.UserInput;
            calculator.UserInput = "";
            txtResult.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculator.Function = '+';
            calculator.First = calculator.UserInput;
            calculator.UserInput = "";
            txtResult.Text = "0";
        }

        private void btnsquareRoot_Click(object sender, EventArgs e)
        {
            double tempvalue = Convert.ToDouble(txtResult.Text);
            calculator.SquareRoot(tempvalue);
            txtResult.Text = calculator.UserInput;
        }

        private void btnRecipocal_Click(object sender, EventArgs e)
        {
            double tempvalue = Convert.ToDouble(txtResult.Text);
            calculator.Reciprocal(tempvalue);
            txtResult.Text = calculator.UserInput;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculator.EqualsButton();
            txtResult.Text = calculator.Result.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            calculator.UserInput = txtResult.Text;
            txtResult.Text = calculator.BackKey();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            txtMemory.Text = "";
            memCalculator.UserInput = "";
            memCalculator.First = "";
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            calculator.UserInput = memCalculator.UserInput;
            txtResult.Text = calculator.UserInput;
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memCalculator.UserInput = txtResult.Text; 
            calculator.UserInput = "";
            txtResult.Text = "0";
            txtMemory.Text = "M";
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e) // hardest feature to implement right here
        {
            calculator.First = calculator.UserInput;
            memCalculator.First = calculator.First;
            string result = memCalculator.MemoryAdd();

            calculator.UserInput = result;
            txtResult.Text = result;

        }
    }
}
