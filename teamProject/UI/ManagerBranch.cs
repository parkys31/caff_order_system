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
    partial class ManagerBranch : UserControl
    {
        BaseAdapter adapter;
        MainForm mainForm;
        public ManagerBranch()
        {
            InitializeComponent();
        }
        public ManagerBranch(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        public ManagerBranch(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        const string UC_INSERTBRNCH = "insertBranch";
        const string UC_MANAGERBRANCHUPDATE = "ManagerBranchUpdate";



        //=========================화면 이벤트함수===========================

        /// <summary>
        /// 전체 버튼클릭시 리스트 전체보기
        /// </summary>
        private void B_branchAll_Click(object sender, EventArgs e)
        {
            showBranchAll();
        }
        /// <summary>
        /// 화면이 로드될때 리스트전체가 보이게하는 함수
        /// </summary>
        private void Branch_Load(object sender, EventArgs e)
        {
            showBranchAll();
        }
        /// <summary>
        /// 검색 버튼클릭 함수
        /// </summary>
        private void B_branchSearch_Click(object sender, EventArgs e)
        {
            OracleMgr ora = adapter.Org;
            string item = C_branch.Text;

            if (item.Equals("") || item.Equals("항목선택"))
            {
                MessageBox.Show("검색 항목을 선택하세요");
                return;
            }
            item = C_branch.SelectedItem.ToString();

            string value = T_branch.Text;
            if (value.Equals(""))
            {
                MessageBox.Show("검색어를 입력하세요");
                T_branch.Focus();
                return;
            }

            List<Cafe_branch> branchList = ora.searchBranch(item, value);

            showBranch(branchList);
        }
        /// <summary>
        /// 등록 버튼 클릭시 등록화면으로 이동
        /// </summary>
        private void B_branchInsert_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new InsertBranch(adapter, mainForm), UC_INSERTBRNCH);
        }
        /// <summary>
        /// 수정 버튼 클릭시 수정 화면으로 이동
        /// </summary>
        private void B_branchUp_Click(object sender, EventArgs e)
        {
            ManagerBranchUpdate mbu = new ManagerBranchUpdate(adapter, mainForm);


            if (L_branchList.SelectedItems.Count > 0)
            {
                mainForm.controllView(mbu, UC_MANAGERBRANCHUPDATE);


                int n = L_branchList.SelectedItems[0].Index;

                string branch_code = L_branchList.Items[n].SubItems[0].Text;
                string branch_name = L_branchList.Items[n].SubItems[1].Text;
                string name = L_branchList.Items[n].SubItems[2].Text;
                string tel = L_branchList.Items[n].SubItems[3].Text;
                string addr = L_branchList.Items[n].SubItems[4].Text;
                string open_date = L_branchList.Items[n].SubItems[5].Text;

                mbu.getItem(branch_code, branch_name, name, tel, addr, open_date);
            }
            else { MessageBox.Show("수정항목을 선택하세요."); return; }
        }


        //=========================프로그램코드===========================
        /// <summary>
        /// 리스트 전체보기
        /// </summary>
        void showBranchAll()
        {
            OracleMgr ora = adapter.Org;
            L_branchList.Items.Clear();
            List<Cafe_branch> branchList = ora.allBranch();

            for (int i = 0; i < branchList.Count; i++)
            {

                L_branchList.Items.Add(new ListViewItem(
                new string[]
                {
                        branchList[i].BranchCode,
                        branchList[i].BranchName,
                        branchList[i].Name,
                        branchList[i].Tel,
                        branchList[i].Address,
                        branchList[i].OpenDate.ToString()
                }));
            }
        }
        /// <summary>
        /// 검색시 해당 리스트 출력
        /// </summary>
        void showBranch(List<Cafe_branch> list)
        {
            L_branchList.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {

                L_branchList.Items.Add(new ListViewItem(
                new string[]
                {
                        list[i].BranchCode,
                        list[i].BranchName,
                        list[i].Name,
                        list[i].Tel,
                        list[i].Address,
                        list[i].OpenDate.ToString().Substring(0, 10),
            }));
            }
        }



    }
}
