using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using teamProject.Adapter;

namespace teamProject.UI
{
    partial class OrderUpdate : UserControl
    {
        BaseAdapter adapter;
        MainForm mainForm;

        const string UC_ORDERLIST = "OrderList";


        public OrderUpdate()
        {
            InitializeComponent();
        }

        public OrderUpdate(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }


        //=========================화면 이벤트함수===========================
        /// <summary>
        /// 취소버튼 클릭시 리스트화면으로 돌아감
        /// </summary>
        private void B_cancelUP_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new OrderList(adapter, mainForm), UC_ORDERLIST);
        }

        /// <summary>
        /// 
        /// </summary>
        private void B_orderUP_Click(object sender, EventArgs e)
        {
            OracleMgr ora = adapter.Org;
            String order_code = L_ordercodeUp.Text;
            int order_status = 0;
            String waybill_code = T_wayUp.Text;

            if (C_statusUp.Text.Equals("주문완료"))
            {

                order_status = 0;
            }
            else if (C_statusUp.Text.Equals("출고완료"))
            {

                order_status = 1;
            }

            ora.updateOrder(order_code, order_status, waybill_code);

            MessageBox.Show("발주정보를 수정했습니다.");
            mainForm.controllView(new OrderList(adapter, mainForm), UC_ORDERLIST);
        }

        //=========================프로그램코드===========================
        /// <summary>
        /// 수정화면으로 선택아이템을 불러오는 함수
        /// </summary>
        public void getItem(string order_code,string branch_code, string branch_name, string name,string tel ,string material_name, string material_count, string order_status)
        {
            L_ordercodeUp.Text = order_code;
            L_branchcodeUp.Text = branch_code;
            L_branchnameUp.Text = branch_name;
            L_nameUp.Text = name;
            L_materialnameUp.Text = material_name;
            L_materialcountUp.Text = material_count;
            C_statusUp.Text = order_status;
           
        }

       
    }
}
