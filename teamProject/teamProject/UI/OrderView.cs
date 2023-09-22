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
    partial class OrderView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        BaseAdapter adapter;
        MainForm mainForm;
        string orderCode;
        public OrderView()
        {
            InitializeComponent();
        }

        public OrderView(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        // 발주코드,지점코드,자재코드,개수,신청일자,발주현황,운송장코드
        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"{materialList.Text} : {materialList.SelectedValue}");
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            List<Material_codeModel> mcList = adapter.Org.selecetMaterialCodeModel();
            string code = adapter.Org.selectOrderManagementBranchCode();
            if (!code.IsNullOrEmpty())
            {
                int codeNum = int.Parse(code.Split("order")[1]) + 1;
                orderCode = $"order{string.Format("{0:D5}", codeNum)}";
            }
            BindingList<Material_codeModel> list = new BindingList<Material_codeModel>();
            for (int i = 0; i < mcList.Count; i++)
            {
                Material_codeModel mc = mcList[i];
                list.Add(mc);
            }
            materialList.DataSource = list;
            materialList.DisplayMember = "materialName";
            materialList.ValueMember = "materialCode";
            //for (int i = 0; i < mcList.Count; i++)
            //{
            //    //materialList.Items.Add(mcList[i].MaterialName);
            //}
        }

        private void orderSave_Click(object sender, EventArgs e)
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
            adapter.Org.insertOrderManagement(order);
            MessageBox.Show("등록 되었습니다.");
            count.Text = string.Empty;
        }
    }
}
