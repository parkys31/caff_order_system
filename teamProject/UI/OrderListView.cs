using Sunny.UI;
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
    partial class OrderListView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;

        Order_management orderManagement = new Order_management();

        const string UC_ORDERCREATEVIEW = "OrderCreateView";
        const string UC_ORDERSTATUSMODIFIED = "OrderStatusModified";

        string authority = string.Empty;

        public OrderListView()
        {
            InitializeComponent();
        }
        public OrderListView(BaseAdapter adapter, MainForm mainForm, string authority)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.authority = authority;
        }

        private void search()
        {
            string searchRq = searchList.Text;
            string searchT = searchText.Text;
            List<Order_management> omList = new List<Order_management>();
            if (searchT.IsNullOrEmpty() && authority.Equals("0"))
            {
                searchList.SelectedIndex = 0;
                searchList.Enabled = true;
                omList = adapter.Org.selectOrderManagement();
            }
            else if (searchT.IsNullOrEmpty() && authority.Equals("1"))
            {
                searchList.SelectedIndex = 1;
                searchList.Enabled = false;
                omList = adapter.Org.selectOrderManagementBranchCode(branchCode);
            }
            else if (searchRq.Equals("재료") && authority.Equals("1"))
            {
                omList = adapter.Org.selectOrderManagementBranchMaterial(branchCode, searchT);
            }
            else if (searchRq.Equals("재료") && authority.Equals("0"))
            {
                omList = adapter.Org.selectOrderManagementMaterial(searchT);
            }
            else if (searchRq.Equals("지점") && authority.Equals("0"))
            {
                omList = adapter.Org.selectOrderManagementBranchName(searchT);
            }
            orderList.Items.Clear();
            for (int i = 0; i < omList.Count; i++)
            {
                orderList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        omList[i].OrderCode,
                        omList[i].BranchName,
                        omList[i].MaterialName,
                        omList[i].MaterialCount.ToString(),
                        omList[i].OrderStatus.ToString(),
                        omList[i].ApplicationDate,
                        omList[i].WaybillCode
                    }
                ));
            }
            FormUtil.setRowColor(orderList, Color.SkyBlue, Color.LightBlue);
        }

        private void OrderListView_Load(object sender, EventArgs e)
        {
            searchList.Clear();
            searchList.Items.Add("지점");
            searchList.Items.Add("재료");
            branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            search();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void modifiedButton_Click(object sender, EventArgs e)
        {
            if (authority.Equals("1"))
            {
                mainForm.controllView(
                new OrderCreateView(adapter, mainForm, orderManagement.OrderCode,
                orderManagement.MaterialName, orderManagement.MaterialCount.ToString()),
                UC_ORDERCREATEVIEW);
            }
            else
            {
                mainForm.controllView(new OrderStatusModified(adapter, mainForm, orderManagement, authority), UC_ORDERSTATUSMODIFIED);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            adapter.Org.deleteOrderManagement(orderManagement.OrderCode);
            search();
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderList.SelectedIndices.Count > 0)
            {
                int SelectRow = orderList.SelectedItems[0].Index;

                string oderCode = orderList.Items[SelectRow].SubItems[0].Text;
                string branchName = orderList.Items[SelectRow].SubItems[1].Text;
                string materialName = orderList.Items[SelectRow].SubItems[2].Text;
                string materialCount = orderList.Items[SelectRow].SubItems[3].Text;
                string orderStatus = orderList.Items[SelectRow].SubItems[4].Text;
                string applicationDate = orderList.Items[SelectRow].SubItems[5].Text;
                string waybillCode = orderList.Items[SelectRow].SubItems[6].Text;
                orderManagement.OrderCode = oderCode;
                orderManagement.BranchName = branchName;
                orderManagement.MaterialName = materialName;
                orderManagement.MaterialCount = int.Parse(materialCount);
                orderManagement.OrderStatus = int.Parse(orderStatus);
                orderManagement.ApplicationDate = applicationDate;
                orderManagement.WaybillCode = waybillCode;
                return;
            }
        }
    }
}
