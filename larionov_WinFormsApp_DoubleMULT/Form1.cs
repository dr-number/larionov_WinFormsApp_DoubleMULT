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
            if (maskedTextBox1.Text == "")
            {
                label_info.Text = "Вы забыли ввести операнд!";
                return;
            }

            int size = listBox_output.Items.Count;
            int numberOperand = size % 2 == 0 ? 1 : 2;

            string newString = $"Операнд №{numberOperand}: {Convert.ToDouble(maskedTextBox1.Text)}";
            listBox_output.Items.Add(newString);
            label_info.Text = newString;

            bool isFirstCalculate = size + 1 == 2;

            if (isFirstCalculate || size + 1 % 3 == 0)
            {
                int index1;
                int index2;

                if (isFirstCalculate)
                {
                    index1 = 0;
                    index2 = 1;
                }
                else
                {
                    index1 = size - 2;
                    index2 = size - 1;
                }

                Regex reg = new Regex(@"?<=#");
                MatchCollection operandReg1 = reg.Matches(Convert.ToString(listBox_output.Items[index1]));
                MatchCollection operandReg2 = reg.Matches(Convert.ToString(listBox_output.Items[index2]));

                double operand1 = Convert.ToDouble(operandReg1[0]);
                double operand2 = Convert.ToDouble(operandReg2[0]);

                string result = $"Результат: {operand1} * {operand2} = {operand1 * operand2}";
                listBox_output.Items.Add(result);
                label_info.Text = result;
            }

            maskedTextBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                buttonSendText.PerformClick();
        }
    }
}