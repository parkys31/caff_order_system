using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    /// <summary>
    /// 카페 지점 관리
    /// </summary>
    internal class Cafe_branch
    {
        private string branchCode; // 지점 코드
        private string branchName; // 지점명
        private string name;        // 지점장
        private string tel;         // 지점장 번호
        private string address;     // 지점 주소
        private string openDate;   // 오픈날
        private string closeDate;  // 폐점날

        public Cafe_branch()
        {
        }

        public Cafe_branch(string branchCode, string branchName, string name, string tel, string address, string openDate)
        {
            this.branchCode = branchCode;
            this.branchName = branchName;
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.openDate = openDate;
        }

        public Cafe_branch(string branchCode, string branchName, string name, string tel, string address, string openDate, string closeDate)
        {
            this.branchCode = branchCode;
            this.branchName = branchName;
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.openDate = openDate;
            this.closeDate = closeDate;
        }

        public string BranchCode { get => branchCode; set => branchCode = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string OpenDate { get => openDate; set => openDate = value; }
        public string CloseDate { get => closeDate; set => closeDate = value; }
    }
}
