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
            //문자열 공백 제거
            string msg = myTextBox.Text.Trim();

            //공백 입력 방지
            if (string.IsNullOrWhiteSpace(myTextBox.Text))
            {
                MessageBox.Show("메시지를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 글자수 50자 제한
            if (msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이하로 입력하세요!");
                return;
            }

            //타임 스탬프
            string timeStamp = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";

            // 메시지 결합
            string finalMessage = "[" + timeStamp + "] " + msg;

            // ListBox에 메시지 추가
            ListBox.Items.Add(finalMessage);

            // 메시지 개수 업데이트
            txtCount.Text = "현재 대화: " + ListBox.Items.Count + "개";

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

        private void btnDelete_Click(object sender, EventArgs e) //전체 삭제 버튼
        {
            ListBox.Items.Clear();

            // 메시지 개수 초기화
            txtCount.Text = "현재 대화: 0개";
        }

        private void Deletebtn_Click(object sender, EventArgs e) //삭제 버튼
        {
            try
            {
                ListBox.Items.RemoveAt(ListBox.SelectedIndex);

                // 메시지 개수 업데이트
                txtCount.Text = "현재 대화: " + ListBox.Items.Count + "개";
            }
            catch
            {
                MessageBox.Show("삭제할 메시지를 먼저 선택하세요!");
            }

        }
    }
}
