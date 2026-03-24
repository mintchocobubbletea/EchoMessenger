# (C# 코딩) 에코 메신저
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자 키보드 입력을 받아서 처리하는 프로그램
- 핵심기능: 메시지 전송, 삭제 및 전체 초기화
- 화면구성: Label(프로그램 제목, 현재 대화 개수), ListBox, Textbox, button(전송, 삭제, 전체 대화 삭제)
- 사용한 플랫폼: 
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인
	- string 클래스를 이용한 사용자 입력 데이터 처리
	- DateTime 클래스를 이용한 현재시간 정보 구하기

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
<img width="804" height="477" alt="과제1" src="https://github.com/user-attachments/assets/f349ad23-1478-4c7e-adf8-148e09048704" />

- 과제 내용
	- Label(표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치합니다.
	- 전송 버튼 클릭 시 TextBox의 텍스트를 ListBox의 항목(Items)으로 추가합니다.
	- 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비합니다.
- 구현 내용과 기능 설명
	- 입력창에 메시지 입력하고 전송 버튼을 누르면 메시지가 리스트 박스에 표시된다.
	- 계속 반복하면 메시지가 리스트 박스에 한 줄씩 계속 추가된다.
	- 추가 내용이 많아지면 리스트 박스에 스크롤바가 자동으로 생기고 스크롤된다.
- 사용한 기술과 구현한 기능:
	- button과 label, listbox 등의 툴들을 이용하여 UI 디자인
	- ADD() 함수 등을 이용하여 listbox에 전송 기능 및 내용 추가
	- Clear() 함수 등을 이용하여 입력창 내용을 지우고 다음 입력 준비

## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
<img width="796" height="482" alt="과제2" src="https://github.com/user-attachments/assets/1aa8f9f8-24e5-4ab3-bc43-192cee28d580" />
<img width="860" height="480" alt="과제 2 추가" src="https://github.com/user-attachments/assets/7579a5e0-3e53-46d1-96cd-8f00421bc2aa" />

- 과제 내용
	- Focus() 메소드를 사용합니다.
	- if (e.KeyCode == Keys.Enter) 작성하여 엔터키를 사용 가능하게 합니다.
	- IsNullOrWhiteSpace() 메소드를 사용합니다.
- 구현 내용과 기능 설명
	- 전송이 끝나면 입력창에 남겨진 기존 메시지를 삭제합니다.
	- 전송 후에 마우스로 입력창을 다시 클릭하지 않아도 되도록 커서를 자동으로 입력창에 둡니다.
	- 마우스 클릭 대신 키보드의 Enter 키를 눌러도 메시지가 전송되도록 합니다.
	- 내용이 없는 빈 문자열이나 공백(Space)만 있을 때는 메시지가 전송되지 않도록 방지하고 메시지를 입력하라는 알림창이 뜹니다.
- 사용한 기술과 구현한 기능:
	- Focus() 메소드를 이용하여 입력창에 초점 맞추기
	- 입력창에 key down 함수를 추가하여 엔터키 눌러 전송하기 기능 구현
	- IsNullOrWhiteSpace()함수를 이용하여 공백 입력 방어 기능 구현

## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
<img width="798" height="479" alt="과제 3" src="https://github.com/user-attachments/assets/e314fd11-5fd0-48da-b9bd-1af6ad093d20" />

- 과제 내용
	- DateTime.Now로 타임 스탬프를 생성합니다.
	- ListBox의 하단에 Label을 추가합니다.
	- textBox1.Text에 Trim() 함수 메소드를 사용합니다.
- 구현 내용과 기능 설명
	- 타임 스탬프를 이용해 메시지 앞에 현재 시간을 자동으로 결합하여 리스트에 출력합니다.
	- 현재 리스트에 쌓인 총 메시지 개수를 계산하여 하단 Label에 실시간으로 업데이트합니다. 
	- 사용자가 입력한 메시지의 앞뒤 불필요한 공백을 Trim() 함수로 제거하여 저장합니다.
- 사용한 기술과 구현한 기능:
	- trim() 함수를 이용해 문자열 공백 제거
	- Listbox 하단에 label을 추가하여 현재 list 박스 내의 메시지 개수 카운트 기능 구현
	- DateTime 클래스를 이용하여 타임 스탬프 기능 구현

## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
<img width="884" height="479" alt="스크린샷 2026-03-19 130310" src="https://github.com/user-attachments/assets/ab9b13d3-d74f-4c33-9898-051ad0349e6f" />
<img width="992" height="529" alt="스크린샷 2026-03-19 130442" src="https://github.com/user-attachments/assets/42369490-4edd-4124-872d-51b008859bf0" />
<img width="882" height="482" alt="스크린샷 2026-03-19 130548" src="https://github.com/user-attachments/assets/bfb12630-b81b-42be-b784-12164f7bf0ff" />

- 과제 내용
	- 삭제 버튼을 하단에 추가합니다.
	- 전체 초기화 버튼인 대화 기록 삭제 버튼을 추가합니다.
	- 글자 수를 message.Length > 50 코드를 추가하여 50자 이하로 제한합니다.

- 구현 내용과 기능 설명
	- ListBox에서 특정 메시지를 마우스로 클릭하고 '삭제' 버튼을 누르면 해당 항목만 목록에서 제거합니다.
	- '대화 기록 삭제' 버튼을 클릭하면 리스트의 모든 내용을 한 번에 지웁니다.
	- 입력창에 글자 수를 50자로 제한하고, 초과시 사용자에게 경고 메시지를 띄우거나 전송을 차단합니다.

- 사용한 기술과 구현한 기능:
	- removeat() 함수를 사용하여 선택 삭제 기능 구현 및 try catch 문으로 예외 처리 구현
	- Clear() 함수로 리스트 내용 초기화 기능 구현
	- 입력창 문자열 길이 50자로 제한하기
## 배운 내용
- 컨트롤과 어떤 함수를 연결해줘야 할지 헷갈렸지만 검색하여 알아냈습니다.
- 전체 초기화 버튼을 만들어야 했는데 전체 초기화하는 함수가 무엇인지 몰랐으나 Copilot의 도움으로 해결했습니다.
- 예외처리를 어떻게 해야 할지 감이 잡히지 않았으나 Copilot의 도움으로 해결했습니다.
