using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dev_Form; // Dev 파일 참조 

namespace ApplicationWinForm_01
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            // 로그인 화면 먼저 띄우고, 다음에 메인 화면 띄운다. 
            FM_Login login = new FM_Login();
            login.ShowDialog();
            tss_UserName.Text = login.Tag.ToString(); // 참고)tag는 배열에는 사용 x
            // 로그인창에서 X표시 누르면 메인창으로 넘어가지 않고 창 종료 
            if (login.Tag.ToString()== "FAIL")
            {
                System.Environment.Exit(0); 
                /*
                Application.ExitThread(); // 동작중인 Thread를 모두 중단시켜라 
                //Application.Exit(); // 어플리케이션 종료  (닷넷 버전 달라 실행이 안댔음...)
                */
            }

            // MenuStrip에서 '테스트화면' 클릭 시 Dev_Form 프로젝트 띄우기 
            // 버튼에 이벤트 추가  
            M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_SYSTEM_DropDownItemClicked);
        }
        // 종료 버튼 
        private void stb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 닫기 버튼 
        private void stb_Close_Click(object sender, EventArgs e)
        {
            // 열려있는 화면이 있는지 확인 
            if (myTabControl1.TabPages.Count == 0) return;
            // 선택된 탭페이지를 닫는다.
            myTabControl1.SelectedTab.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tss_NowDate.Text = DateTime.Now.ToString();
        }

        // MenuStrip에서 '테스트화면' 클릭 시 Dev_Form 프로젝트 띄우기 
        // 클릭 
        private void M_SYSTEM_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // 1. 단순히 폼을 호출하는 경우 
            // 다른 프로젝트에도 Form1이 있을 수 있으니, 모호성을 피하기 위해 'Dev_Form'이라고 프로젝트 정확히 지칭하는 것이 좋음.
            //Dev_Form.MDI_Test form = new MDI_Test();
            //form.MdiParent = this;
            //form.Show();
            // 주석 처리 팁 (ctrl+K+C) : 주석 설정 & (Ctrl+K+U) : 주석 해제

            // 2. 프로그램을 호출 
            // 내가 메뉴를 클릭했을때 .dll 에서 똑같은 이름을 가진 폼을 열어라 (메뉴가 많을 경우 사용.. 고오급...)
            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "Dev_Form.dll");
            Type typeForm = assemb.GetType("Dev_Form." + e.ClickedItem.Name.ToString(), true);
            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            // 해당되는 폼이 이미 오픈되어 있는지 확인 후 활성화 또는 신규 오픈한다. 
            for (int i = 0; i < myTabControl1.TabPages.Count; i++)
            {
                if (myTabControl1.TabPages[i].Name == e.ClickedItem.Name.ToString()) return;
            }

            //ShowForm.MdiParent = this;
            //ShowForm.Show();

            myTabControl1.AddForm(ShowForm); // 텝페이지에 폼을 추가하여 오픈한다. 
            // myTabControl1은? 내가 만든 사용자 정의 컨트롤의 이름임 (디자인탭 속성에서 확인해봐~)

        }
    }
    // TabPage를 상속받아 MDIForm 클래스를 만듬
    public partial class MDIForm : TabPage
    { }
    // TabControl에 대해 파생클래스로 MyTabControl 사용자 정의 컨트롤을 만들겠다.
    public partial class MyTabControl : TabControl
    {
        // AddForm 함수 (NewForm이라는 이름의 Form 형식을 던져주는 함수 ex. int MaxValue 등) 
        public void AddForm(Form NewForm)
        {
            if (NewForm == null) return;  // 인자로 받은 폼이 없을경우 실행 중지 
            NewForm.TopLevel = false;     // 인자로 받은 폼이 최상위 개체가 아님을 선언 
            MDIForm page = new MDIForm(); // 탭 페이지 객체 생성  
            // page란? TabControl 안에 있는 하나하나의 창들 
            page.Controls.Clear();        // 페이지 초기화
            page.Controls.Add(NewForm);   // 페이지에 폼 추가
            page.Text = NewForm.Text;     // 폼에서 지정한 명칭으로 탭 페이지 설정 
            page.Name = NewForm.Name;     // 폼에서 설정한 이름으로 탭 페이지 설정 
            base.TabPages.Add(page);      // 탭 컨트롤에 페이지를 추가한다. 
            // base란? 파생클래스 안에서 부모클래스의 함수를 불러올 때 사용한다. 
            NewForm.Show();               // 인자로 받은 폼을 보여준다. 
            base.SelectedTab = page;      // 현재 선택된 페이지를 호출한 폼의 페이지로 설정한다. 
        }
    }
}
