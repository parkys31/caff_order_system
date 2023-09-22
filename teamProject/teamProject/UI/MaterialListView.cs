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
using static System.Windows.Forms.ListView;

namespace teamProject.UI
{
    partial class MaterialListView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;
        Total_material listSelTm = new Total_material();

        const string UC_MATERIALVIEW     = "MaterialView";

        string authority = string.Empty;
        Boolean m_Columnclick = true;

        public MaterialListView()
        {
            InitializeComponent();
        }
        public MaterialListView(BaseAdapter adapter, MainForm mainForm, string authority)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.authority = authority;
        }

        private void search()
        {
            string searchT = searchText.Text;
            List<Total_material> tmList = new List<Total_material>();
            if (searchT.IsNullOrEmpty())
            {
                tmList = adapter.Org.selecetTotalMaterialModel(branchCode);
            }
            else if (!searchT.IsNullOrEmpty())
            {
                tmList = adapter.Org.selecetTotalMaterialModelMaterial(branchCode, searchT);
            }
            materialList.Items.Clear();
            for (int i = 0; i < tmList.Count; i++)
            {
                materialList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        tmList[i].MaterialName,
                        tmList[i].MaterialCount.ToString(),
                        tmList[i].MaterialCode
                    }
                ));
            }
            FormUtil.setRowColor(materialList, Color.SkyBlue, Color.LightBlue);
        }

        private void MaterialListView_Load(object sender, EventArgs e)
        {
            branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            search();
            if (authority.Equals("0"))
            {
                materialCode.Visible = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private Boolean MaterialListCountCheck()
        {
            int tmCount = adapter.Org.selectMaterialCount(branchCode);
            int mcCount = adapter.Org.selectMaterialCodeCount();
            if (tmCount == mcCount)
            {
                MessageBox.Show("더이상 등록 할수 없습니다.");
                return true;
            }
            return false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (MaterialListCountCheck())
            {
                return;
            }
            mainForm.controllView(new MaterialView(adapter, mainForm, authority), UC_MATERIALVIEW);
        }

        private void modifiedButton_Click(object sender, EventArgs e)
        {
            if (listSelTm.MaterialCode.IsNullOrEmpty())
            {
                MessageBox.Show("수정할 대상을 선택해 주세요.");
                return;
            }
            mainForm.controllView(new MaterialView(adapter, mainForm, authority, listSelTm), UC_MATERIALVIEW);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listSelTm.MaterialCode.IsNullOrEmpty())
            {
                MessageBox.Show("삭제할 대상을 선택해 주세요.");
                return;
            }
            adapter.Org.deleteTotalMaterial(listSelTm.BranchCode, listSelTm.MaterialCode);
            search();
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialList.SelectedIndices.Count > 0)
            {
                int SelectRow = materialList.SelectedItems[0].Index;

                string materialName = materialList.Items[SelectRow].SubItems[0].Text;
                string materialCount = materialList.Items[SelectRow].SubItems[1].Text;
                string materialCode = materialList.Items[SelectRow].SubItems[2].Text;
                listSelTm.MaterialCode = materialCode;
                listSelTm.MaterialName = materialName;
                listSelTm.MaterialCount = int.Parse(materialCount);
                listSelTm.BranchCode = branchCode;
                return;
            }
        }

        private void materialCode_Click(object sender, EventArgs e)
        {
            MaterialCodeListView mcCodeList = new MaterialCodeListView(adapter);
            mcCodeList.ShowDialog(this);
        }

        private void materialList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (m_Columnclick == true)
                materialList.ListViewItemSorter = new ListViewItemComparerASC(e.Column);
            else
                materialList.ListViewItemSorter = new ListViewItemComparerDESC(e.Column);
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
