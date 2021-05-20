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

namespace ApplicationWinForm_01
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null; // 데이터베이스 접속 정보
        private SqlTransaction Tran; // 데이터베이스 관리 권한
        private SqlCommand cmd = new SqlCommand(); // 데이터베이스 명령 전달
        public FM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 비밀번호 변경 화면 팝업을 호출한다. 
            this.Visible = false; // 로그인 화면을 보이지 않게 한다. 
            FM_Password FmPassWord = new FM_Password();

            FmPassWord.ShowDialog(); // Show와의 차이점 구별! 
            this.Visible = true; // 로그인 화면 보이게 한다. 
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            string sLoginid = string.Empty; // 로그인 ID
            string sPw = string.Empty; // 로그인 비밀번호

            sLoginid = txtUserID.Text;
            sPw = txtPassword.Text;

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_NHJ WHERE USERID='" + sLoginid + "'", Connect);

            // 데이터를 담을 그릇
            DataTable DtTemp = new DataTable();

            // 어댑터 실행 후 그릇에 데이터 담기
            Adapter.Fill(DtTemp);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            if (DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자 입니다.");
                return;
            }
            else if (DtTemp.Rows[0]["PW"].ToString() != sPw)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
            else
            {
                cmd.CommandText = "SELECT * FROM TB_USER_NHJ WHERE USERID= '" + sLoginid + "'WHERE PW = '" + sPw + "'";
                
                MessageBox.Show("안녕하세요. 반갑습니다!");
                this.Close();
            }
            
        }
    }
}
