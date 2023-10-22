namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumber1.Text);
            double n2 = Convert.ToDouble(txtNumber2.Text);
            double result = n1 + n2;
            MessageBox.Show(n1 + "+" + n2 + " = " + result);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumber1.Text);
            double n2 = Convert.ToDouble(txtNumber2.Text);
            double result = n1 - n2;
            MessageBox.Show(n1 + "-" + n2 + " = " + result);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumber1.Text);
            double n2 = Convert.ToDouble(txtNumber2.Text);
            double result = n1 * n2;
            MessageBox.Show(n1 + "*" + n2 + " = " + result);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNumber1.Text);
            double n2 = Convert.ToDouble(txtNumber2.Text);
            double result = n1 / n2;
            MessageBox.Show(n1 + "/" + n2 + " = " + result);
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}