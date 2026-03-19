using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e) //전송 버튼
        {
            //공백 입력 방지
            if (string.IsNullOrWhiteSpace(myTextBox.Text))
            {
                return;
            }
            // ListBox에 메시지 추가
            ListBox.Items.Add(myTextBox.Text);

            // 입력창 비우기
            myTextBox.Clear();

            // 입력창에 커서 다시 위치
            myTextBox.Focus();
        }

        private void myTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender, e); //전송 버튼 클릭 이벤트 호출
                e.Handled = true; // Enter 키 이벤트 처리 완료
            }
        }
    }
}
