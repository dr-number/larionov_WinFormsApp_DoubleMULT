namespace larionov_WinFormsApp_COPY_TXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Введите текст...";
            this.textBox1.Size = new System.Drawing.Size(493, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(520, 415);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(118, 23);
            this.buttonSendText.TabIndex = 1;
            this.buttonSendText.Text = "Отправить текст";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(644, 415);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_output.Location = new System.Drawing.Point(12, 9);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(0, 15);
            this.label_output.TabIndex = 3;
            this.label_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_info.Location = new System.Drawing.Point(14, 388);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 15);
            this.label_info.TabIndex = 6;
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.ItemHeight = 15;
            this.listBox_output.Location = new System.Drawing.Point(12, 12);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(705, 364);
            this.listBox_output.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSendText);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "COPY.TXT Ларионов гр. 210з";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button buttonSendText;
        private Button buttonExit;
        private Label label_output;
        private Label label_info;
        private ListBox listBox_output;
    }
}