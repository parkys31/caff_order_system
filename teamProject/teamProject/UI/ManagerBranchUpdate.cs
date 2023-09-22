using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using teamProject.Adapter;
using teamProject.Model;

namespace teamProject.UI
{
   partial class ManagerBranchUpdate :UserControl

    {

        public ManagerBranchUpdate()
        {
            InitializeComponent();
        }
        BaseAdapter adapter;
        MainForm mainForm;

        const string UC_MANAGERBRANCH = "ManagerBranch";

        public ManagerBranchUpdate(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        public ManagerBranchUpdate(BaseAdapter adapter,MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            
        }

        //=========================화면 이벤트함수===========================
        private void B_updateUP_Click(object sender, EventArgs e)
        {
            OracleMgr ora = adapter.Org;
            string branchname = T_branchNameUP.Text;
            if (branchname.Equals(""))
            {
                MessageBox.Show("지점명을 입력하세요");
                T_branchNameUP.Focus();
                return;
            }

            string name = T_nameUP.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("점주명을 입력하세요");
                T_nameUP.Focus();
                return;
            }

            string tel = T_telUP.Text;
            if (tel.Equals(""))
            {
                MessageBox.Show("전화번호를 입력하세요");
                T_telUP.Focus();
                return;
            }

            string addr = T_addrUP.Text;
            if (addr.Equals(""))
            {
                MessageBox.Show("매장주소를 입력하세요");
                T_addrUP.Focus();
                return;
            }
            string openUP = T_openUP.Text;
            if (addr.Equals(""))
            {
                MessageBox.Show("오픈날짜를 입력하세요");
                T_openUP.Focus();
                return;
            }
            string code =L_codeUP.Text;
            string closeUP = T_closeUP.Text;
            if (closeUP.Equals(""))
            {
                ora.updateBranch(new Cafe_branch(code, branchname, name, tel, addr, openUP));
            }
            else
            {
                ora.updateBranch(new Cafe_branch(code, branchname, name, tel, addr, openUP,closeUP));
            }
            
            MessageBox.Show("지점 정보를 수정했습니다.");

            mainForm.controllView(new ManagerBranch(adapter, mainForm), UC_MANAGERBRANCH);
        }

        private void B_cancelUP_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new ManagerBranch(adapter, mainForm), UC_MANAGERBRANCH);
        }

        //=========================프로그램코드===========================
        public void getItem(string branch_code,string branch_name,string name,string tel,string addr,string open_date)
        {
            L_codeUP.Text = branch_code;
            T_branchNameUP.Text = branch_name;
            T_nameUP.Text = name;
            T_telUP.Text=tel;
            T_addrUP.Text = addr;
            T_openUP.Text = open_date;
        }

    }
}
