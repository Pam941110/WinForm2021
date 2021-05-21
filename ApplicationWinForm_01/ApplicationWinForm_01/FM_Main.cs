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

        private void stb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

            ShowForm.MdiParent = this;
            ShowForm.Show();

        }
         
    }
}
