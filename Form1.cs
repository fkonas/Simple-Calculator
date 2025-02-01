namespace Calculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btn_digit_click(object sender, EventArgs e)
        {
            if ((txt_display.Text == "0") || (isOperationPerformed))
                txt_display.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txt_display.Text = txt_display.Text + button.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            result = 0;
        }

        private void btn_operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(txt_display.Text);
            isOperationPerformed = true;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txt_display.Text = (result + Double.Parse(txt_display.Text)).ToString();
                    break;
                case "-":
                    txt_display.Text = (result - Double.Parse(txt_display.Text)).ToString();
                    break;
                case "*":
                    txt_display.Text = (result * Double.Parse(txt_display.Text)).ToString();
                    break;
                case "/":
                    txt_display.Text = (result / Double.Parse(txt_display.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

