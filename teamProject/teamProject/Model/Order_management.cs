using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    /// <summary>
    /// 발주 관리
    /// </summary>
    internal class Order_management
    {
        private string orderCode;       // 발주코드
        private string branchCode;      // 지점코드
        private string branchName;      // 지점명
        private string materialCode;    // 자재코드
        private string materialName;    // 자재명
        private int materialCount;      // 자재개수
        private int orderStatus;        // 발주 상태 0: 확인중 1: 배송중 2: 배달완료
        private string applicationDate; // 발주 신청일
        private string waybillCode;     // 발송번호 ※배송중일때 운송장 코드 입력
        private String name;
        private String tel;

        public Order_management()
        {
        }

        public Order_management(string orderCode, string branchCode, string materialCode, int materialCount)
        {
            this.orderCode = orderCode;
            this.branchCode = branchCode;
            this.materialCode = materialCode;
            this.materialCount = materialCount;
        }

        public Order_management(string orderCode, string branchCode, string materialCode, int materialCount, int orderStatus)
        {
            this.orderCode = orderCode;
            this.branchCode = branchCode;
            this.materialCode = materialCode;
            this.materialCount = materialCount;
            this.orderStatus = orderStatus;
        }

        public Order_management(string orderCode, string branchCode, string materialCode, int materialCount, int orderStatus, string waybillCode)
        {
            this.orderCode = orderCode;
            this.branchCode = branchCode;
            this.materialCode = materialCode;
            this.materialCount = materialCount;
            this.orderStatus = orderStatus;
            this.waybillCode = waybillCode;
        }

        public Order_management(string orderCode, string branchCode, string branchName, string materialCode, string materialName, int materialCount, int orderStatus, string applicationDate, string waybillCode, string name, string tel)
        {
            this.orderCode = orderCode;
            this.branchCode = branchCode;
            this.branchName = branchName;
            this.materialCode = materialCode;
            this.materialName = materialName;
            this.materialCount = materialCount;
            this.orderStatus = orderStatus;
            this.applicationDate = applicationDate;
            this.waybillCode = waybillCode;
            this.name = name;
            this.tel = tel;
        }

        public string OrderCode { get => orderCode; set => orderCode = value; }
        public string BranchCode { get => branchCode; set => branchCode = value; }
        public string MaterialCode { get => materialCode; set => materialCode = value; }
        public int MaterialCount { get => materialCount; set => materialCount = value; }
        public int OrderStatus { get => orderStatus; set => orderStatus = value; }
        public string WaybillCode { get => waybillCode; set => waybillCode = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        public string MaterialName { get => materialName; set => materialName = value; }
        public string ApplicationDate { get => applicationDate; set => applicationDate = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
