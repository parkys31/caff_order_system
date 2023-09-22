using Sunny.UI;
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
using teamProject.Utill;

namespace teamProject.UI
{
    partial class InOutListView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;
        Material_warehousing materialWarehousing = new Material_warehousing();

        const string UC_INOUTCREATEVIEW = "InOutCreateView";

        public InOutListView()
        {
            InitializeComponent();
        }

        public InOutListView(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        private void search()
        {
            List<Material_warehousing> mwList = new List<Material_warehousing>();
            if (inOutRadioButton.Checked == true)
            {
                mwList = adapter.Org.selectMaterialWarehousing();
            }
            else if (inRadioButton.Checked == true)
            {
                mwList = adapter.Org.selectMaterialWarehousingInOut(0);
            }
            else if (outRadioButton.Checked == true)
            {
                mwList = adapter.Org.selectMaterialWarehousingInOut(1);
            }
            warehousingList.Items.Clear();
            for (int i = 0; i < mwList.Count; i++)
            {
                string inOutFlgText = string.Empty;
                if (mwList[i].InOutFlag == 0)
                {
                    inOutFlgText = "입고";
                }
                else
                {
                    inOutFlgText = "출고";
                }
                warehousingList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        mwList[i].InOutNumber.ToString(),
                        mwList[i].MaterialName,
                        mwList[i].MaterialCode,
                        mwList[i].MaterialCount.ToString(),
                        inOutFlgText,
                        mwList[i].InOutData
                    }
                ));
            }
            FormUtil.setRowColor(warehousingList, Color.SkyBlue, Color.LightBlue);
        }

        private void InOutList_Load(object sender, EventArgs e)
        {
            branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            inOutRadioButton.Checked = true;
            search();
        }

        private void inOutCheckedChanged(object sender, EventArgs e)
        {
            if (inRadioButton.Checked == true)
            {
                outRadioButton.Checked = false;
                inOutRadioButton.Checked = false;
            }
            else if (outRadioButton.Checked == true)
            {
                inRadioButton.Checked = false;
                inOutRadioButton.Checked = false;
            }
            else if (inOutRadioButton.Checked == true)
            {
                inRadioButton.Checked = false;
                outRadioButton.Checked = false;
            }
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (warehousingList.SelectedIndices.Count > 0)
            {
                int SelectRow = warehousingList.SelectedItems[0].Index;

                string inOutNumber = warehousingList.Items[SelectRow].SubItems[0].Text;
                string materialName = warehousingList.Items[SelectRow].SubItems[1].Text;
                string materialCode = warehousingList.Items[SelectRow].SubItems[2].Text;
                string materialCount = warehousingList.Items[SelectRow].SubItems[3].Text;
                string inOutFlag = warehousingList.Items[SelectRow].SubItems[4].Text;
                string inOutData = warehousingList.Items[SelectRow].SubItems[5].Text;
                materialWarehousing.InOutNumber = int.Parse(inOutNumber);
                materialWarehousing.MaterialName = materialName;
                materialWarehousing.MaterialCode = materialCode;
                materialWarehousing.MaterialCount = int.Parse(materialCount);
                if (inOutFlag.Equals("입고"))
                {
                    materialWarehousing.InOutFlag = 0;
                }
                else
                {
                    materialWarehousing.InOutFlag = 1;
                }
                
                materialWarehousing.InOutData = inOutData;
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new InOutCreateView(adapter, mainForm), UC_INOUTCREATEVIEW);
        }

        private void modifiedButton_Click(object sender, EventArgs e)
        {
            if (warehousingList.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("수정할 입출력 데이터를 선택해 주세요.");
                return;
            }
            mainForm.controllView(new InOutCreateView(adapter, mainForm, materialWarehousing), UC_INOUTCREATEVIEW);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (warehousingList.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("삭제할 입출력 데이터를 선택해 주세요.");
                return;
            }
            adapter.Org.deleteMaterialWarehousing(materialWarehousing.InOutNumber);
            search();
        }
    }
}
