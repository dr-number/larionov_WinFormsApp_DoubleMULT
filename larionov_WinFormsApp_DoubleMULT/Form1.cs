using System.Text.RegularExpressions;

namespace larionov_WinFormsApp_DoubleMULT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() == ",")
            {
                label_info.Text = "Вы забыли ввести операнд!";
                return;
            }

            int size = listBox_output.Items.Count;
            bool isFirstCalculate = size == 1;
            int countCalculate = size % 3;
            bool isNotFirstCalculate = size != 0 && !isFirstCalculate && (size - (countCalculate * 3)) + 1 == 2;

            int numberOperand = size % 2 == 0 ? 1 : 2;
            string newString = $"Операнд №{numberOperand}: {Convert.ToDouble(maskedTextBox1.Text)}";

            listBox_output.Items.Add(newString);
            label_info.Text = newString;

            if (isNotFirstCalculate || isFirstCalculate)
            {
                string operandStr1 = Convert.ToString(listBox_output.Items[size - 1]);
                string operandStr2 = Convert.ToString(listBox_output.Items[size]);

                double operand1 = Convert.ToDouble(operandStr1.Substring(operandStr1.IndexOf(": ") + 1));
                double operand2 = Convert.ToDouble(operandStr2.Substring(operandStr2.IndexOf(": ") + 1));

                string result = $"Результат: {operand1} * {operand2} = {operand1 * operand2}";
                listBox_output.Items.Add(result);
                label_info.Text = result;
            }

            maskedTextBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSendText.PerformClick();
        }
    }
}