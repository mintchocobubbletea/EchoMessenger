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
            ListBox = new ListBox();
            SendButton = new Button();
            myTextBox = new TextBox();
            label1 = new Label();
            txtCount = new Label();
            btnDelete = new Button();
            Deletebtn = new Button();
            SuspendLayout();
            // 
            // ListBox
            // 
            ListBox.Font = new Font("맑은 고딕", 15F);
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(70, 107);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(726, 228);
            ListBox.TabIndex = 0;
            // 
            // SendButton
            // 
            SendButton.Font = new Font("맑은 고딕", 10F);
            SendButton.Location = new Point(588, 368);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(66, 38);
            SendButton.TabIndex = 1;
            SendButton.Text = "전송";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // myTextBox
            // 
            myTextBox.Font = new Font("맑은 고딕", 15F);
            myTextBox.Location = new Point(70, 372);
            myTextBox.Name = "myTextBox";
            myTextBox.Size = new Size(506, 34);
            myTextBox.TabIndex = 2;
            myTextBox.KeyDown += myTextBox_KeyDown;
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
            // txtCount
            // 
            txtCount.AutoSize = true;
            txtCount.Location = new Point(70, 338);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(85, 15);
            txtCount.TabIndex = 4;
            txtCount.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("맑은 고딕", 9F);
            btnDelete.Location = new Point(732, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 38);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "전체 대화 삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("맑은 고딕", 10F);
            Deletebtn.Location = new Point(660, 368);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(66, 38);
            Deletebtn.TabIndex = 6;
            Deletebtn.Text = "삭제";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(881, 450);
            Controls.Add(Deletebtn);
            Controls.Add(btnDelete);
            Controls.Add(txtCount);
            Controls.Add(label1);
            Controls.Add(myTextBox);
            Controls.Add(SendButton);
            Controls.Add(ListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox;
        private Button SendButton;
        private TextBox myTextBox;
        private Label label1;
        private Label txtCount;
        private Button btnDelete;
        private Button Deletebtn;
    }
}
