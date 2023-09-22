using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject;
using teamProject.Adapter;
using teamProject.Model;
using teamProject.Utill;
using teamProject.UI;

namespace teamProject.UI
{
    public partial class Login : Form
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        BaseAdapter adapter = new BaseAdapter();
        public Login()
        {
            InitializeComponent();
            adapter.Org.connectDB();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            id.Text = string.Empty;
            id.ForeColor = Color.Black;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.Text = string.Empty;
            password.UseSystemPasswordChar = true;
            password.ForeColor = Color.Black;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string uid = id.Text;
            string pwd = password.Text;
            int authority;
            if (user.Checked == false && admin.Checked == false)
            {
                MessageBox.Show("관리자 혹은 유저를 선택해 주세요.");
                return;
            }
            else
            {
                if (user.Checked == true)
                {
                    authority = 1; // 유저
                }
                else
                {
                    authority = 0; // 관리자
                }
            }
            if (uid.IsNullOrEmpty())
            {
                MessageBox.Show("아이디를 입력해 주세요.");
                return;
            }
            if (pwd.IsNullOrEmpty())
            {
                MessageBox.Show("비밀번호를 입력해 주세요.");
                return;
            }
            if (Login_Save.Checked == true)
            {
                iniCreate.SetValue(iniPath, "public", "user_id", id.Text);
            }
            else
            {
                iniCreate.SetValue(iniPath, "public", "user_id", string.Empty);
            }
            User_management userCheck = adapter.Org.selectUserLogin(uid, pwd, authority);
            if (userCheck.UserId.IsNullOrEmpty())
            {
                MessageBox.Show("아이디 혹은 비밀번호를 다시 확인해 주세요.");
                return;
            }
            else
            {
                iniCreate.SetValue(iniPath, "public", "authority", userCheck.Authority.ToString());
                iniCreate.SetValue(iniPath, "public", "branchCode", userCheck.BranchCode);
                MainForm mainForm = new MainForm(adapter);
                mainForm.Show();
                this.Close();
            }
        }

        private void radioChangeCheck(object sender, EventArgs e)
        {
            if (user.Checked == true)
            {
                admin.Checked = false;
            }
            else if (admin.Checked == true)
            {
                user.Checked = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string uid = iniCreate.GetValue(iniPath, "public", "user_id", "");
            if (!uid.IsNullOrEmpty())
            {
                id.Text = uid;
                Login_Save.Checked = true;
            }
        }
    }
}
