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
using teamProject.Adapter;
using teamProject.Model;

namespace teamProject.UI
{
    partial class InsertBranch : UserControl
    {
        BaseAdapter adapter;
        MainForm mainForm;

        public InsertBranch()
        {
            InitializeComponent();
        }
        public InsertBranch(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        public InsertBranch(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        const string UC_MANAGERBRANCH = "ManagerBranch";

        /// <summary>
        /// 지점등록
        /// </summary>
        private void B_branchInsertOK_Click(object sender, EventArgs e)
        {
            OracleMgr ora = adapter.Org;
            string code = ora.selectCode();

            string branchname = T_branchname.Text;
            if (branchname.Equals(""))
            {
                MessageBox.Show("지점명을 입력하세요");
                T_branchname.Focus();
                return;
            }

            string name = T_name.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("점주명을 입력하세요");
                T_name.Focus(); 
                return; 
            }

            string tel = T_tel.Text;
            if (tel.Equals(""))
            {
                MessageBox.Show("전화번호를 입력하세요");
                T_tel.Focus();
                return;
            }

            string addr = T_addr.Text;
            if (addr.Equals(""))
            {
                MessageBox.Show("매장주소를 입력하세요");
                T_addr.Focus();
                return;
            }
            string openDate = DateTime.Now.ToString("yyyy년MM월dd일");

            ora.insertBranch(new Cafe_branch(code,branchname,name,tel,addr, openDate));
            MessageBox.Show("매장 정보를 저장했습니다.");

            mainForm.controllView(new ManagerBranch(adapter, mainForm), UC_MANAGERBRANCH);
        }

        /// <summary>
        /// 등록취소
        /// </summary>
        private void B_branchinsertcancel_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new ManagerBranch(adapter, mainForm), UC_MANAGERBRANCH);
        }
    }
}
