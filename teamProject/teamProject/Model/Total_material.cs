using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    /// <summary>
    /// 재고 관리
    /// </summary>
    internal class Total_material
    {
        private string materialCode;    // 자재코드
        private string materialName;    // 자재명
        private string branchCode;      // 지점코드
        private int materialCount;      // 자재 개수

        public Total_material()
        {
        }

        public Total_material(string materialCode, string materialName, string branchCode, int materialCount)
        {
            this.materialCode = materialCode;
            this.materialName = materialName;
            this.branchCode = branchCode;
            this.materialCount = materialCount;
        }

        public string MaterialCode { get => materialCode; set => materialCode = value; }
        public string MaterialName { get => materialName; set => materialName = value; }
        public string BranchCode { get => branchCode; set => branchCode = value; }
        public int MaterialCount { get => materialCount; set => materialCount = value; }
    }
}
