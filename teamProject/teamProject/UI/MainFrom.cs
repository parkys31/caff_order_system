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
    partial class MainFrom : Form
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

        const string UC_LOGIN = "Login"; // 클래스 이름
        const string UC_ORDERVIEW = "OrderView";

        BaseAdapter adapter;

        public MainFrom()
        {
            InitializeComponent();
        }

        public MainFrom(BaseAdapter adapter)
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
            controllView(new OrderView(adapter), UC_ORDERVIEW);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String authority = iniCreate.GetValue(iniPath, "public", "authority", "기본값");
            if (authority.Equals("0"))
            {
                branch.Visible = true;
                orderList.Visible = true;
                materialList.Visible = true;
                inOut.Visible = true;
                user.Visible = true;
            }
            else
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

        }

        private void materialList_Click(object sender, EventArgs e)
        {

        }

        private void branch_Click(object sender, EventArgs e)
        {

        }

        private void inOut_Click(object sender, EventArgs e)
        {

        }
    }
}
