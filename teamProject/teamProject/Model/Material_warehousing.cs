using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    /// <summary>
    /// 입출고 관리
    /// </summary>
    internal class Material_warehousing
    {
        private int inOutNumber;        //등록번호
        private string materialCode;    // 자재코드
        private string materialName;    // 자재명
        private int materialCount;      // 개수
        private int inOutFlag;          // 입출고 플래그 0: 입고 1: 출고
        private string inOutData;       // 입출고 날짜

        public Material_warehousing()
        {
        }

        public Material_warehousing(int inOutNumber, string materialCode, int materialCount, int inOutFlag)
        {
            this.inOutNumber = inOutNumber;
            this.materialCode = materialCode;
            this.materialCount = materialCount;
            this.inOutFlag = inOutFlag;
        }

        public int InOutNumber { get => inOutNumber; set => inOutNumber = value; }
        public string MaterialCode { get => materialCode; set => materialCode = value; }
        public int MaterialCount { get => materialCount; set => materialCount = value; }
        public int InOutFlag { get => inOutFlag; set => inOutFlag = value; }
        public string MaterialName { get => materialName; set => materialName = value; }
        public string InOutData { get => inOutData; set => inOutData = value; }
    }
}
