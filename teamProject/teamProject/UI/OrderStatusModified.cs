using Sunny.UI;
using Sunny.UI.Win32;
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
    partial class OrderStatusModified : UserControl
    {
        BaseAdapter adapter;
        MainForm mainForm;
        Order_management om;

        string authority = string.Empty;

        const string UC_ORDERLISTVIEW = "OrderListView";

        public OrderStatusModified()
        {
            InitializeComponent();
        }
        public OrderStatusModified(BaseAdapter adapter, MainForm mainForm, Order_management om, string authority)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.adapter = adapter;
            this.om = om;
            this.authority = authority;
        }

        private void uiRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (shippingRadioButton.Checked == true)
            {
                endRadioButton.Checked = false;
            }
            else if (endRadioButton.Checked == true)
            {
                shippingRadioButton.Checked = false;
            }
        }
        private void OrderStatusModified_Load(object sender, EventArgs e)
        {
            materialNameText.Text = om.MaterialName;
            countText.Text = om.MaterialCount.ToString();
            if (om.OrderStatus == 1)
            {
                shippingRadioButton.Checked = true;
            }
            else if (om.OrderStatus == 2)
            {
                endRadioButton.Checked = true;
            }
            waybillText.Text = om.WaybillCode;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Order_management updateOm = new Order_management();
            if (shippingRadioButton.Checked == false && endRadioButton.Checked == false)
            {
                MessageBox.Show("발주 현황을 선택해 주세요.");
                return;
            }
            if (waybillText.Text.IsNullOrEmpty())
            {
                MessageBox.Show("운송장 번호를 입력해 주세요.");
                return;
            }
            updateOm.OrderCode = om.OrderCode;
            if (shippingRadioButton.Checked == true)
            {
                updateOm.OrderStatus = 1;
            }
            else if (endRadioButton.Checked == true)
            {
                updateOm.OrderStatus = 2;
            }
            updateOm.WaybillCode = waybillText.Text;
            adapter.Org.updateOrderManagementHead(updateOm);
            mainForm.controllView(new OrderListView(adapter, mainForm, authority), UC_ORDERLISTVIEW);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new OrderListView(adapter, mainForm, authority), UC_ORDERLISTVIEW);
        }
    }
}
