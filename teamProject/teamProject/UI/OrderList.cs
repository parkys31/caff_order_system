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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace teamProject.UI
{
    partial class OrderList : UserControl
    {
        BaseAdapter adapter;
        MainForm mainForm;
        Boolean m_Columnclick = true;
        public OrderList()
        {
            InitializeComponent();
        }
        public OrderList(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
        public OrderList(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        const string UC_ORDERUPDATE = "OrderUpdate";

        //=========================화면 이벤트함수===========================

        /// <summary>
        /// 전체 버튼클릭시 리스트 전체보기
        /// </summary>
        private void B_orderAll_Click(object sender, EventArgs e)
        {
            showOrderAll();
        }

        /// <summary>
        /// 화면이 로드될때 리스트전체가 보이게하는 함수
        /// </summary>
        private void OrderList_Load(object sender, EventArgs e)
        {
            showOrderAll();
        }
        /// <summary>
        /// 검색버튼 클릭시 해당 리스트 보기
        /// </summary>
        private void B_orderSearch_Click(object sender, EventArgs e)
        {
            OracleMgr ora = adapter.Org;
            string item = C_order.Text;

            if (item.Equals("") || item.Equals("항목선택"))
            {
                MessageBox.Show("검색 항목을 선택하세요");
                return;
            }
            item = C_order.SelectedItem.ToString();

            string value = T_order.Text;
            if (value.Equals(""))
            {
                MessageBox.Show("검색어를 입력하세요");
                T_order.Focus();
                return;
            }

            List<Order_management> orderList = ora.searchOrder(item, value);

            showOrderSearch(orderList);
        }
        /// <summary>
        /// 수정 버튼을 누르면 주문수정 페이지로 이동
        /// </summary>
        private void B_orderUp_Click(object sender, EventArgs e)
        {
            OrderUpdate order = new OrderUpdate(adapter, mainForm);

            if (L_orderList.SelectedItems.Count > 0)
            {
                mainForm.controllView(order, UC_ORDERUPDATE);

                // listview에서 선택한 항목의 인덱스를 구함
                int n = L_orderList.SelectedItems[0].Index;
                // 선택한 항목의 컬럼 인덱스

                string order_code = L_orderList.Items[n].SubItems[0].Text;
                string branch_code = L_orderList.Items[n].SubItems[1].Text;
                string branch_name = L_orderList.Items[n].SubItems[2].Text;
                string name = L_orderList.Items[n].SubItems[3].Text;
                string tel = L_orderList.Items[n].SubItems[4].Text;
                string material_name = L_orderList.Items[n].SubItems[5].Text;
                string material_count = L_orderList.Items[n].SubItems[6].Text;
                string application_date = L_orderList.Items[n].SubItems[7].Text;
                string order_status = L_orderList.Items[n].SubItems[8].Text;
                string waybill_code = L_orderList.Items[n].SubItems[9].Text;

                order.getItem(order_code, branch_code, branch_name, name, tel, material_name, material_count, order_status);
            }
            else { MessageBox.Show("수정할 항목을 선택하세요."); return; }



        }


        //=========================프로그램코드===========================

        /// <summary>
        /// 리스트 전체보기
        /// </summary>
        void showOrderAll()
        {
            OracleMgr ora = adapter.Org;
            L_orderList.Items.Clear();
            List<Order_management> orderList = ora.allOrder();

            for (int i = 0; i < orderList.Count; i++)
            {
                String status = "";
                if (orderList[i].OrderStatus==0)
                {
                    status = "주문완료";
                }
                else { status = "출고완료"; }

                L_orderList.Items.Add(new ListViewItem(
                new string[]
                {

                        orderList[i].OrderCode,
                        orderList[i].BranchCode,
                        orderList[i].BranchName,
                        orderList[i].Name,
                        orderList[i].Tel,
                        orderList[i].MaterialName,
                        orderList[i].MaterialCount.ToString(),
                        orderList[i].ApplicationDate.ToString().Substring(0, 10),
                        status,
                        orderList[i].WaybillCode.ToString()
                }));
            }
        }

        /// <summary>
        /// 주문 검색 리스트
        /// </summary>
        void showOrderSearch(List<Order_management> orderList)
        {
            OracleMgr ora = adapter.Org;
            L_orderList.Items.Clear();

            for (int i = 0; i < orderList.Count; i++)
            {
                String status = "";
                if (orderList[i].OrderStatus==0)
                {
                    status = "주문완료";
                }
                else { status = "출고완료"; }

                L_orderList.Items.Add(new ListViewItem(
                new string[]
                {

                        orderList[i].OrderCode,
                        orderList[i].BranchCode,
                        orderList[i].BranchName,
                        orderList[i].Name,
                        orderList[i].Tel,
                        orderList[i].MaterialName,
                        orderList[i].MaterialCount.ToString(),
                        orderList[i].ApplicationDate.ToString().Substring(0, 10),
                        status,
                        orderList[i].WaybillCode.ToString()
                }));
            }
        }

        private void orderList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (m_Columnclick == true)
                L_orderList.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
            else
                L_orderList.ListViewItemSorter = new ListViewItemComparerDESC(e.Column);
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
