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
    partial class InOutCreateView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;
        Material_warehousing materialWarehousing = new Material_warehousing();

        const string UC_INOUTLISTVIEW = "InOutListView";
        public InOutCreateView()
        {
            InitializeComponent();
        }

        public InOutCreateView(BaseAdapter adapter, MainForm mainForm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
        }

        public InOutCreateView(BaseAdapter adapter, MainForm mainForm, Material_warehousing materialWarehousing)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.materialWarehousing = materialWarehousing;
        }

        private void setMaterialList()
        {
            List<Material_codeModel> mcList = adapter.Org.selecetMaterialCodeModel();
            int comboxSelectIndex = 0;
            BindingList<Material_codeModel> list = new BindingList<Material_codeModel>();
            for (int i = 0; i < mcList.Count; i++)
            {
                Material_codeModel mc = mcList[i];
                list.Add(mc);
                if (!materialWarehousing.MaterialCode.IsNullOrEmpty() && materialWarehousing.MaterialCode.Equals(mcList[i].MaterialCode))
                {
                    comboxSelectIndex = i;
                }
            }
            materialList.DataSource = list;
            materialList.DisplayMember = "materialName";
            materialList.ValueMember = "materialCode";
            materialList.SelectedIndex = comboxSelectIndex;
        }

        private void InOutCreateView_Load(object sender, EventArgs e)
        {
            setMaterialList();
            branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            if (!materialWarehousing.MaterialCode.IsNullOrEmpty())
            {
                count.Text = materialWarehousing.MaterialCount.ToString();
                if (materialWarehousing.InOutFlag == 0)
                {
                    inRadio.Checked = true;
                }
                else
                {
                    outRadio.Checked = true;
                }
                modifyButton.Visible = true;
            }
            else
            {
                createButton.Visible = true;
            }
        }

        private void inOutCheckedChanged(object sender, EventArgs e)
        {
            if (inRadio.Checked == true)
            {
                outRadio.Checked = false;
            }
            else if (outRadio.Checked == true)
            {
                inRadio.Checked = false;
            }
        }

        private void updateTotalMaterialList()
        {
            if (inRadio.Checked == true)
            {
                int materialCount = adapter.Org.selecetTotalMaterialCount(branchCode, materialWarehousing.MaterialCode);
                materialCount = materialCount + materialWarehousing.MaterialCount;
                adapter.Org.updateTotalMaterial(materialCount, branchCode, materialWarehousing.MaterialCode);
            }
            else if (outRadio.Checked == true)
            {
                int materialCount = adapter.Org.selecetTotalMaterialCount(branchCode, materialWarehousing.MaterialCode);
                materialCount = materialCount - materialWarehousing.MaterialCount;
                adapter.Org.updateTotalMaterial(materialCount, branchCode, materialWarehousing.MaterialCode);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new InOutListView(adapter, mainForm), UC_INOUTLISTVIEW);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            string materialCode = materialList.SelectedValue.ToString();
            if (count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("입고 혹은 출고 개수를 입력해주세요.");
                return;
            }
            if (inRadio.Checked == false && outRadio.Checked == false)
            {
                MessageBox.Show("입고 혹은 출고 라디오 버튼을 선택해주세요.");
                return;
            }

            int inOutCount = int.Parse(count.Text);
            int materialCount = adapter.Org.selecetTotalMaterialCount(branchCode, materialCode);
            if (materialCount < inOutCount && outRadio.Checked == true)
            {
                MessageBox.Show("현재 재고 이상의 물품을 출고하실수 없습니다.");
                return;
            }

            materialWarehousing.MaterialCode = materialCode;
            materialWarehousing.MaterialName = materialList.Text;
            materialWarehousing.MaterialCount = inOutCount;

            if (inRadio.Checked == true)
            {
                materialWarehousing.InOutFlag = 0;
            }
            else
            {
                materialWarehousing.InOutFlag = 1;
            }

            Sunny.UI.UISymbolButton btn = (Sunny.UI.UISymbolButton)sender;
            if (btn.Name.Equals("modifyButton"))
            {
                adapter.Org.updateMaterialWarehousing(materialWarehousing);
            }
            else if (btn.Name.Equals("createButton"))
            {
                Boolean existenceCheck = adapter.Org.selecetTotalMaterialExistenceCheck(branchCode, materialWarehousing.MaterialCode);
                if (!existenceCheck && outRadio.Checked == true)
                {
                    MessageBox.Show("출고가능한 재고가 존재하지 않습니다.");
                    return;
                }
                adapter.Org.insertMaterialWarehousing(materialWarehousing);

                if (!existenceCheck)
                {
                    Total_material tm = new Total_material();
                    tm.MaterialCode = materialWarehousing.MaterialCode;
                    tm.MaterialName = materialWarehousing.MaterialName;
                    tm.MaterialCount = materialWarehousing.MaterialCount;
                    tm.BranchCode = branchCode;
                    adapter.Org.insertTotalMaterial(tm);
                    mainForm.controllView(new InOutListView(adapter, mainForm), UC_INOUTLISTVIEW);
                    return;
                }
            }

            updateTotalMaterialList();
            mainForm.controllView(new InOutListView(adapter, mainForm), UC_INOUTLISTVIEW);
        }
    }
}
