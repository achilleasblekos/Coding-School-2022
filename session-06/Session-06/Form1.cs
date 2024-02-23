namespace Session_06
{
    public partial class Form1 : Form
    {
        private SimpleCalculator _calc;
        private double? _result;

        public Form1()
        {
            InitializeComponent();
            _calc = new SimpleCalculator();
            _result = null;
        }

        private void btnSymbol0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            txtInputValue.Text += "0";
        }

        private void btnSymbol1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            txtInputValue.Text += "1";
        }

        private void btnSymbol2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            txtInputValue.Text += "2";
        }

        private void btnSymbol3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            txtInputValue.Text += "3";
        }

        private void btnSymbol4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            txtInputValue.Text += "4";
        }

        private void btnSymbol5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            txtInputValue.Text += "5";
        }

        private void btnSymbol6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            txtInputValue.Text += "6";
        }

        private void btnSymbol7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            txtInputValue.Text += "7";
        }

        private void btnSymbol8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            txtInputValue.Text += "8";
        }

        private void btnSymbol9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            txtInputValue.Text += "9";
        }

        private void btnSymbolDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
            txtInputValue.Text += ".";
        }

        private void btnSymbolPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " + ";
            double number = Convert.ToDouble(txtInputValue.Text);
            _calc.ComputationType = ComputationTypeEnum.Addition;
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            txtInputValue.Clear();
        }

        private void btnSymbolMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " - ";
            double number = Convert.ToDouble(txtInputValue.Text);
            _calc.ComputationType = ComputationTypeEnum.Subtraction;
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            txtInputValue.Clear();
        }
        private void btnSymbolMul_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " * ";
            double number = Convert.ToDouble(txtInputValue.Text);
            _calc.ComputationType = ComputationTypeEnum.Multiplication;
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            txtInputValue.Clear();
        }
        private void btnSymbolDiv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " / ";
            double number = Convert.ToDouble(txtInputValue.Text);
            _calc.ComputationType = ComputationTypeEnum.Division;
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            txtInputValue.Clear();
        }
        private void btnSymbolPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " Power ";
            double number = Convert.ToDouble(txtInputValue.Text);
            _calc.ComputationType = ComputationTypeEnum.Power;
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            txtInputValue.Clear();
        }
        private void btnSymbolSqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " Sqrt";
            _calc.ComputationType = ComputationTypeEnum.SquareRoot;
            _result = Convert.ToDouble(txtInputValue.Text);
            txtInputValue.Clear();
        }

        private void btnSymbolEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " = ";
            double? number;
            if (_calc.ComputationType == ComputationTypeEnum.SquareRoot)
            {
                number = null;
            }
            else
            {
                number = Convert.ToDouble(txtInputValue.Text);
            }

            if (_result != null)
            {
                _result = _calc.Compute(_result, number, _calc.ComputationType);
                txtDisplay.Text += $"{_result}{Environment.NewLine}";
            }
            else
            {
                txtDisplay.Text += $"Result Not a Number!{Environment.NewLine}";
            }

            txtInputValue.Clear();
            _result = null;

        }

        private void btnSymbolCE_Click(object sender, EventArgs e)
        {
            _result = null;
            txtInputValue.Clear();
            txtDisplay.Clear();
        }
    }
}