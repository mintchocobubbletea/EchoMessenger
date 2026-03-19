namespace EchoMessenger
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
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(70, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(630, 229);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(600, 368);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 1;
            button1.Text = "전송";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 13F);
            textBox1.Location = new Point(70, 376);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 31);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼편지체", 25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(70, 38);
            label1.Name = "label1";
            label1.Size = new Size(244, 39);
            label1.TabIndex = 3;
            label1.Text = "Echo Messenger";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}
