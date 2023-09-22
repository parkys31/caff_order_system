using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    internal class Material_codeModel
    {
        private string materialCode;    // 자재코드
        private string materialName;    // 자재명

        public Material_codeModel()
        {
        }

        public Material_codeModel(string materialCode, string materialName)
        {
            this.materialCode = materialCode;
            this.materialName = materialName;
        }

        public string MaterialCode { get => materialCode; set => materialCode = value; }
        public string MaterialName { get => materialName; set => materialName = value; }
    }
}
