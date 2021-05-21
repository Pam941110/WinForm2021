using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Linq.Expressions;

namespace ApplicationWinForm_01
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null; // 데이터베이스 접속 정보
        public FM_Login()
        {
            InitializeComponent();
            // Tag가 빌 상황이 없게, FAIL 값 넣어줌
            // 이 로직은 유저 이름이 FAIL이 아닌 이상 무조건 돌아감
            this.Tag = "FAIL"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 비밀번호 변경 화면 팝업을 호출한다. 
            this.Visible = false; // 로그인 화면을 보이지 않게 한다. 
            FM_Password FmPassWord = new FM_Password();

            FmPassWord.ShowDialog(); // Show와의 차이점 구별! 
            this.Visible = true; // 로그인 화면 보이게 한다. 
        }
        private int PwFailCount = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = "Data Source = 61.105.9.203; Initial Catalog=AppDev; User ID = kfqs;Password = 1234";

                Connect = new SqlConnection(strCon);

                Connect.Open(); // 데이터베이스에 접속한다.
                                // DB 접속이 되지 않았을 경우 메세지 리턴 후 이벤트 종료
                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                    return;
                }
                string sLoginid = txtUserID.Text; // 로그인 ID
                string sPw = txtPassword.Text; ; // 로그인 비밀번호

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW,USERNAME FROM TB_USER_NHJ WHERE USERID='" + sLoginid + "'", Connect);

                // 데이터를 담을 그릇
                DataTable DtTemp = new DataTable();

                // 어댑터 실행 후 그릇에 데이터 담기
                Adapter.Fill(DtTemp);

                // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("등록되지 않은 사용자 입니다.");
                    txtUserID.Text = "";
                    txtPassword.Focus();
                    return;
                }
                else if (DtTemp.Rows[0]["PW"].ToString() != sPw)
                {
                    txtPassword.Text = "";
                    txtPassword.Focus();  // 커서이동
                    PwFailCount += 1;
                    if (PwFailCount == 3)
                    {
                        MessageBox.Show("로그인 3회 오류로 종료합니다.");
                        this.Close();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("안녕하세요. 반갑습니다!");
                    this.Tag = DtTemp.Rows[0]["USERNAME"].ToString();  // 유저 명을 메인화면으로 보냄
                    this.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("로그인 작업 중 오류가 발생하였습니다."+ex.ToString()); }
            finally
            {Connect.Close();}
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin_Click(null, null); // 간단히 이벤트 호출하면 댐 
            }
        }
    }
}
