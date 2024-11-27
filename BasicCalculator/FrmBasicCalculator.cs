using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, System.EventArgs e)
        {
            float a = float.Parse(txtFirst.Text);
            float b = float.Parse(txtSecond.Text);

            if (cbOperations.SelectedItem.ToString() == "+")
            {
                lblResult.Text = BasicComputation.Addition(a, b).ToString();
            }
            else if (cbOperations.SelectedItem.ToString() == "-")
            {
                lblResult.Text = BasicComputation.Subtraction(a, b).ToString();
            }
            else if (cbOperations.SelectedItem.ToString() == "*")
            {
                lblResult.Text = BasicComputation.Multiplication(a, b).ToString();
            }
            else if (cbOperations.SelectedItem.ToString() == "/")
            {
                lblResult.Text = BasicComputation.Division(a, b).ToString();
            }
            else
            {
                lblResult.Text = "Please choose an operation.";
            }
        }
    }
}