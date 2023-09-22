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
    partial class MaterialCodeListView : Form
    {
        BaseAdapter adapter;
        List<Material_codeModel> mcList = new List<Material_codeModel>();

        Boolean m_Columnclick = true;

        public MaterialCodeListView()
        {
            InitializeComponent();
        }
        public MaterialCodeListView(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void materialCodeListGet()
        {
            mcList = adapter.Org.selecetMaterialCodeModel();
            materialCodeList.Items.Clear();
            for (int i = 0; i < mcList.Count; i++)
            {
                materialCodeList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        mcList[i].MaterialName,
                        mcList[i].MaterialCode
                    }
                ));
            }
            FormUtil.setRowColor(materialCodeList, Color.SkyBlue, Color.LightBlue);
        }

        private void MaterialCodeListView_Load(object sender, EventArgs e)
        {
            materialCodeListGet();
        }

        private void userManagementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialCodeList.SelectedIndices.Count > 0)
            {
                int SelectRow = materialCodeList.SelectedItems[0].Index;

                string materialName = materialCodeList.Items[SelectRow].SubItems[0].Text;
                string materialCode = materialCodeList.Items[SelectRow].SubItems[1].Text;
                materialNameText.Text = materialName;
                materialCodeText.Text = materialCode;
                return;
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (materialNameText.Text.IsNullOrEmpty())
            {
                MessageBox.Show("자재명을 입력해주세요.");
                return;
            }
            if (materialCodeText.Text.IsNullOrEmpty())
            {
                MessageBox.Show("자재코드를 입력해주세요.");
                return;
            }
            string materialName = materialNameText.Text;
            string materialCode = materialCodeText.Text;

            int insertFlg = 0;
            for (int i = 0; i < mcList.Count; i++)
            {
                if (mcList[i].MaterialCode.Equals(materialCode))
                {
                    insertFlg = 1;
                }
            }
            Material_codeModel mc = new Material_codeModel();
            mc.MaterialName = materialName;
            mc.MaterialCode = materialCode;
            if (insertFlg == 0)
            {
                if (MessageBox.Show("자재 코드를 등록하시겠습니까?", "등록", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    adapter.Org.insertMaterialCodeModel(mc);
                    materialCodeListGet();
                }
            }
            else
            {
                if (MessageBox.Show("자재 코드를 수정하시겠습니까?", "수정", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    adapter.Org.updateMaterialCodeModel(mc);
                    materialCodeListGet();
                }
            }
            materialNameText.Clear();
            materialCodeText.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (materialCodeText.Text.IsNullOrEmpty())
            {
                MessageBox.Show("삭제할 자재코드를 선택해주세요.");
                return;
            }
            string materialCode = materialCodeText.Text;
            if (MessageBox.Show("자재 코드를 삭제하시겠습니까?", "삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                adapter.Org.deleteMaterialCode(materialCode);
                materialCodeListGet();
            }
            materialNameText.Clear();
            materialCodeText.Clear();
        }

        private void materialCodeList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (m_Columnclick == true)
                materialCodeList.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
            else
                materialCodeList.ListViewItemSorter = new ListViewItemComparerDESC(e.Column);
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
