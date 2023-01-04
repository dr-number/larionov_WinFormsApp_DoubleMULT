namespace larionov_WinFormsApp_COPY_TXT
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
            if (textBox1.Text != "")
            {
                listBox_output.Items.Add(textBox1.Text);
                textBox1.Text = "";
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