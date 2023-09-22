using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.Adapter;
using teamProject.Model;
using teamProject.Utill;

namespace teamProject.UI
{
    partial class OrderCreateView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        BaseAdapter adapter;
        MainForm mainForm;
        Order_management om;

        string authority = string.Empty;

        const string UC_ORDERLISTVIEW = "OrderListView";

        string orderCode;
        string materialName;
        string materialCount;

        public OrderCreateView()
        {
            InitializeComponent();
        }

        public OrderCreateView(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        public OrderCreateView(BaseAdapter adapter, MainForm mainForm, string orderCode, string materialName, string materialCount)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.orderCode = orderCode;
            this.materialName = materialName;
            this.materialCount = materialCount;
        }

        // 발주코드,지점코드,자재코드,개수,신청일자,발주현황,운송장코드
        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"{materialList.Text} : {materialList.SelectedValue}");
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            authority = iniCreate.GetValue(iniPath, "public", "authority", "기본값");
            List<Material_codeModel> mcList = adapter.Org.selecetMaterialCodeModel();
            int comboxSelectIndex = 0;
            if (orderCode.IsNullOrEmpty())
            {
                string code = adapter.Org.selectOrderManagementBranchCode();
                if (!code.IsNullOrEmpty())
                {
                    int codeNum = int.Parse(code.Split("order")[1]) + 1;
                    orderCode = $"order{string.Format("{0:D5}", codeNum)}";
                }
                else
                {
                    orderCode = "order00001";
                }
            }
            BindingList<Material_codeModel> list = new BindingList<Material_codeModel>();
            for (int i = 0; i < mcList.Count; i++)
            {
                Material_codeModel mc = mcList[i];
                list.Add(mc);
                if (!materialName.IsNullOrEmpty() && mc.MaterialName.Equals(materialName))
                {
                    comboxSelectIndex = i;
                }
            }
            materialList.DataSource = list;
            materialList.DisplayMember = "materialName";
            materialList.ValueMember = "materialCode";
            materialList.SelectedIndex = comboxSelectIndex;
            if (!materialCount.IsNullOrEmpty())
            {
                count.Text = materialCount;
                modifyButton.Visible = true;
            }
            else
            {
                orderSave.Visible = true;
            }
        }

        private void orderSave_Click(object sender, EventArgs e)
        {
            string materialCode = materialList.SelectedValue.ToString();
            if (count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("발주 재료 개수를 입력해 주세요.");
                return;
            }
            int materialCount = int.Parse(count.Text);
            string branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            if (materialCount <= 0)
            {
                MessageBox.Show("발주 신청 재고 개수를 입력해주세요.");
                return;
            }
            Order_management order = new Order_management();
            order.OrderCode = orderCode;
            order.BranchCode = branchCode;
            order.MaterialCode = materialCode;
            order.MaterialCount = materialCount;
            adapter.Org.insertOrderManagement(order);
            MessageBox.Show("등록 되었습니다.");
            count.Text = string.Empty;
            mainForm.controllView(new OrderListView(adapter, mainForm, authority), UC_ORDERLISTVIEW);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            string materialCode = materialList.SelectedValue.ToString();
            int materialCount = int.Parse(count.Text);
            string branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            if (materialCount <= 0)
            {
                MessageBox.Show("발주 신청 재고 개수를 입력해주세요.");
                return;
            }
            Order_management order = new Order_management();
            order.OrderCode = orderCode;
            order.BranchCode = branchCode;
            order.MaterialCode = materialCode;
            order.MaterialCount = materialCount;
            adapter.Org.updateOrderManagementBranch(order);
            MessageBox.Show("수정 되었습니다.");
            mainForm.controllView(new OrderListView(adapter, mainForm, authority), UC_ORDERLISTVIEW);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new OrderListView(adapter, mainForm, authority), UC_ORDERLISTVIEW);
        }
    }
}
