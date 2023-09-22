using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.UI;
using teamProject.Adapter;
using Sunny.UI;
using teamProject.Utill;

namespace teamProject.UI
{
    partial class MainForm : Form
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        // C#에서 드래그 기능을 사용하기 위해 win32api (C언어)를
        // 사용함.
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

#pragma warning restore CS0108

        const string UC_ORDERCREATEVIEW = "OrderCreateView";
        const string UC_ORDERLISTVIEW = "OrderListView";
        const string UC_ORDERLIST = "OrderList";
        const string UC_MATERIALLISTVIEW = "MaterialListView";
        const string UC_USERLISTVIEW = "UserListView";
        const string UC_INOUTLISTVIEW = "InOutListView";
        const string UC_MANAGERBRANCH = "ManagerBranch";

        BaseAdapter adapter;

        string authority = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        public void controllView(UserControl uc, string ucName)
        {
            panel1.Controls.Clear();
            if (!panel1.Controls.ContainsKey(ucName))
            {
                uc.Dock = DockStyle.Fill;
                panel1.Controls.Add(uc);
            }
        }

        private void view()
        {
            //controllView(new Login(adapter, this), UC_LOGIN);
        }

        private void orderView()
        {
            controllView(new OrderCreateView(adapter, this), UC_ORDERCREATEVIEW);
        }

        private void orderListView()
        {
            controllView(new OrderListView(adapter, this, authority), UC_ORDERLISTVIEW);
        }

        private void orderListManagerView()
        {
            controllView(new OrderList(adapter, this), UC_ORDERLIST);
        }

        private void materialListView()
        {
            controllView(new MaterialListView(adapter, this, authority), UC_MATERIALLISTVIEW);
        }

        private void userListView()
        {
            controllView(new UserListView(adapter, this), UC_USERLISTVIEW);
        }

        private void inOutListView()
        {
            controllView(new InOutListView(adapter, this), UC_INOUTLISTVIEW);
        }

        private void managerBranchView()
        {
            controllView(new ManagerBranch(adapter, this), UC_MANAGERBRANCH);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            authority = iniCreate.GetValue(iniPath, "public", "authority", "기본값");
            if (authority.Equals("0"))
            {
                branch.Visible = true;
                orderList.Visible = true;
                materialList.Visible = true;
                inOut.Visible = true;
                user.Visible = true;
            }
            else if (authority.Equals("1"))
            {
                order.Visible = true;
                orderList.Visible = true;
                materialList.Visible = true;
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            orderView();
        }

        private void orderList_Click(object sender, EventArgs e)
        {
            if (authority.Equals("0"))
            {
                orderListManagerView();
            }
            else
            {
                orderListView();
            }
        }

        private void materialList_Click(object sender, EventArgs e)
        {
            materialListView();
        }

        private void branch_Click(object sender, EventArgs e)
        {
            managerBranchView();
        }

        private void inOut_Click(object sender, EventArgs e)
        {
            inOutListView();
        }

        private void user_Click(object sender, EventArgs e)
        {
            userListView();
        }
    }
}
