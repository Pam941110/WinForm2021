using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinForm_01
{
    public partial class FM_Login : Form
    {
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
    }
}
