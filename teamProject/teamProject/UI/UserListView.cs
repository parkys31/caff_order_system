using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections;
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
using teamProject.Utill;

namespace teamProject.UI
{
    partial class UserListView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;
        List<User_management> userManagemnt = new List<User_management>();
        List<Cafe_branch> cbList = new List<Cafe_branch>();
        User_management user = new User_management();

        Boolean m_Columnclick = true;

        public UserListView()
        {
            InitializeComponent();
        }
        public UserListView(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        private void userList()
        {
            userManagemnt = adapter.Org.selectUser();
            userManagementList.Items.Clear();
            for (int i = 0; i < userManagemnt.Count; i++)
            {
                if (userManagemnt[i].UserId.Equals("root"))
                {
                    continue;
                }
                userManagementList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        userManagemnt[i].UserId,
                        userManagemnt[i].UserPw,
                        userManagemnt[i].BranchName,
                        userManagemnt[i].BranchCode
                    }
                ));
            }
            FormUtil.setRowColor(userManagementList, Color.SkyBlue, Color.LightBlue);
        }

        private void branchCodeList()
        {
            branchList.Clear();
            cbList = adapter.Org.selectCafeBranch();
            BindingList<Cafe_branch> list = new BindingList<Cafe_branch>();
            for (int i = 0; i < cbList.Count; i++)
            {
                int checkFlg = 0;
                for (int j = 0; j < userManagemnt.Count; j++)
                {
                    if (cbList[i].BranchCode.Equals(userManagemnt[j].BranchCode))
                    {
                        checkFlg = 1;
                        break;
                    }
                }
                if (checkFlg == 0)
                {
                    Cafe_branch cb = cbList[i];
                    list.Add(cb);
                }
            }
            if (list.Count > 0)
            {
                branchList.DataSource = list;
                branchList.DisplayMember = "branchName";
                branchList.ValueMember = "branchCode";
                branchList.SelectedIndex = 0;
            }
        }

        private void UserListView_Load(object sender, EventArgs e)
        {
            userList();
            branchCodeList();
        }

        private void userManagementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userManagementList.SelectedIndices.Count > 0)
            {
                int SelectRow = userManagementList.SelectedItems[0].Index;

                string userId = userManagementList.Items[SelectRow].SubItems[0].Text;
                string userPw = userManagementList.Items[SelectRow].SubItems[1].Text;
                string branchName = userManagementList.Items[SelectRow].SubItems[2].Text;
                string branchCode = userManagementList.Items[SelectRow].SubItems[3].Text;
                userIdTextBox.Text = userId;
                userPwTextBox.Text = userPw;
                branchList.Text = branchName;
                user.UserId = userId;
                user.UserPw = userPw;
                user.BranchCode = branchCode;
                return;
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;
            string userPw = userPwTextBox.Text;
            string branchCode = branchList.SelectedValue.ToString();
            if (userId.IsNullOrEmpty())
            {
                MessageBox.Show("아이디를 입력해 주세요.");
                return;
            }
            if (userPw.IsNullOrEmpty())
            {
                MessageBox.Show("비밀번호를 입력해 주세요.");
                return;
            }
            user.UserId = userId;
            user.UserPw = userPw;
            int insertFlg = 0;
            for (int i = 0; i < userManagemnt.Count; i++)
            {
                if (userManagemnt[i].UserId.Equals(userIdTextBox.Text))
                {
                    insertFlg = 1;
                }
            }
            if (insertFlg == 0)
            {
                user.BranchCode = branchCode;
                if (MessageBox.Show("등록하시겠습니까?", "등록", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    adapter.Org.insertUser(user);
                    userList();
                    branchCodeList();
                }
            }
            else
            {
                if (!user.BranchCode.IsNullOrEmpty() && !user.BranchCode.Equals(branchCode))
                {
                    user.BranchCode = branchCode;
                }
                if (MessageBox.Show("유저 정보를 수정하시겠습니까?", "수정", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    adapter.Org.updateUser(user);
                    userList();
                }
            }
            userIdTextBox.Clear();
            userPwTextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("유저 정보를 삭제하시겠습니까?", "삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                adapter.Org.deleteUserManagement(userIdTextBox.Text);
                userList();
                branchCodeList();
            }
        }

        private void userList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (m_Columnclick == true)
                userManagementList.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
            else
                userManagementList.ListViewItemSorter = new ListViewItemComparerDESC(e.Column);
            m_Columnclick = !m_Columnclick;
        }

        class ListViewItemComparer : IComparer
        {
            private int col;

            public ListViewItemComparer()
            {
                col = 0;
            }

            public ListViewItemComparer(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }

        }

        class ListViewItemComparerASC : IComparer
        {
            private int col;
            public ListViewItemComparerASC()
            {
                col = 0;
            }

            public ListViewItemComparerASC(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                try
                {
                    // 숫자 비교
                    if (Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text) > Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text))
                    {
                        return 1;
                    }
                    else
                        return -1;
                }

                catch (Exception)
                {
                    // 텍스트 비교
                    return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
            }
        }

        class ListViewItemComparerDESC : IComparer
        {
            private int col;
            public ListViewItemComparerDESC()
            {
                col = 0;
            }

            public ListViewItemComparerDESC(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                try
                {
                    if (Convert.ToDecimal(((ListViewItem)x).SubItems[col].Text) < Convert.ToDecimal(((ListViewItem)y).SubItems[col].Text))
                    {
                        return 1;
                    }
                    else
                        return -1;
                }

                catch (Exception)
                {
                    if (String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text) == 1)
                    {
                        return -1;
                    }
                    else
                        return 1;
                }
            }
        }
    }
}
