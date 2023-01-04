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
            if (maskedTextBox1.Text != "")
            {
                listBox_output.Items.Add(maskedTextBox1.Text);
                maskedTextBox1.Text = "";
                label_info.Text = "";
            }
            else
                label_info.Text = "Вы забыли ввести текст";
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