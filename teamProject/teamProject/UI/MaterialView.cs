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
    partial class MaterialView : UserControl
    {
        String iniPath = Application.StartupPath + @"\config.ini";
        string branchCode = string.Empty;
        BaseAdapter adapter;
        MainForm mainForm;
        Total_material tm = new Total_material();
        const string UC_MATERIALLISTVIEW = "MaterialListView";
        string authority = string.Empty;

        public MaterialView()
        {
            InitializeComponent();
        }
        public MaterialView(BaseAdapter adapter, MainForm mainForm, string authority)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.authority = authority;
        }
        public MaterialView(BaseAdapter adapter, MainForm mainForm, string authority, Total_material tm)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.mainForm = mainForm;
            this.authority = authority;
            this.tm = tm;
        }

        private void getMaterialCodeList()
        {
            List<Material_codeModel> mcList = adapter.Org.selecetMaterialCodeModel();
            List<Total_material> tmList = adapter.Org.selecetTotalMaterialModel(branchCode);
            BindingList<Material_codeModel> list = new BindingList<Material_codeModel>();
            for (int i = 0; i < mcList.Count; i++)
            {
                int checkFlg = 0;
                for(int j=0; j < tmList.Count; j++)
                {
                    if (mcList[i].MaterialCode.Equals(tmList[j].MaterialCode))
                    {
                        checkFlg = 1;
                        break;
                    }
                }
                if (checkFlg == 0)
                {
                    Material_codeModel mc = mcList[i];
                    list.Add(mc);
                }
            }
            materialCodeList.DataSource = list;
            materialCodeList.DisplayMember = "materialName";
            materialCodeList.ValueMember = "materialCode";
            materialCodeList.SelectedIndex = 0;
        }

        private void MaterialView_Load(object sender, EventArgs e)
        {
            branchCode = iniCreate.GetValue(iniPath, "public", "branchCode", "기본값");
            if (tm.MaterialCode.IsNullOrEmpty())
            {
                materialCodeList.Visible = true;
                materialSave.Visible = true;
                getMaterialCodeList();
            }
            else
            {
                matyerialNameView.Visible = true;
                modifyButton.Visible = true;
                matyerialNameView.Text = tm.MaterialName;
                count.Text = tm.MaterialCount.ToString();
            }
        }

        private void materialSave_Click(object sender, EventArgs e)
        {
            string materialCode = materialCodeList.SelectedValue.ToString();
            string materialName = materialCodeList.Text;
            if (count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("개수를 입력해 주세요.");
                return;
            }
            int materialCount = int.Parse(count.Text);
            tm.MaterialName = materialName;
            tm.MaterialCode = materialCode;
            tm.MaterialCount = materialCount;
            tm.BranchCode = branchCode;
            adapter.Org.insertTotalMaterial(tm);
            mainForm.controllView(new MaterialListView(adapter, mainForm, authority), UC_MATERIALLISTVIEW);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("개수를 입력해 주세요.");
                return;
            }
            string materialCount = count.Text;
            adapter.Org.updateTotalMaterial(int.Parse(materialCount), tm.BranchCode, tm.MaterialCode);
            mainForm.controllView(new MaterialListView(adapter, mainForm, authority), UC_MATERIALLISTVIEW);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mainForm.controllView(new MaterialListView(adapter, mainForm, authority), UC_MATERIALLISTVIEW);
        }

        private void matyerialNameView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
