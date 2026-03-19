namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // ListBox에 메시지 추가
            ListBox.Items.Add(myTextBox.Text);

            // 입력창 비우기
            myTextBox.Clear();
        }
    }
}
