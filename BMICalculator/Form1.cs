using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please enter both height and weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!decimal.TryParse(txtHeight.Text, out decimal height) || !decimal.TryParse(txtWeight.Text, out decimal weight))
            {
                MessageBox.Show("Please enter valid numeric values for height and weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (height <= 0 || weight <= 0)
            {
                MessageBox.Show("Height and weight must be positive numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal BMI = weight / (height * height);
            string status = "";

            if (BMI >= 40.0m)
            {
                status = "Morbidly obese";
            }
            else if (BMI >= 35.0m)
            {
                status = "Severely obese";
            }
            else if (BMI >= 30.0m)
            {
                status = "Obese";
            }
            else if (BMI >= 25.0m)
            {
                status = "Overweight";
            }
            else if (BMI >= 18.5m)
            {
                status = "Healthy weight";
            }
            else
            {
                status = "Underweight";
            }

            Status.Text = status;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = String.Empty;
            txtHeight.Text = String.Empty;
            Status.Text = String.Empty;
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
