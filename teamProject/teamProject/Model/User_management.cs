using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.Model
{
    /// <summary>
    /// 유저 관리
    /// </summary>
    internal class User_management
    {
        private string userId;      // 유저 ID
        private string userPw;      // 유저 PW
        private int authority;      // 유저 권한
        private string branchCode;  // 지점 코드
        private string branchName;  // 지점 코드

        public User_management()
        {

        }

        public User_management(string userId, string userPw, int authority, string branchCode)
        {
            this.userId = userId;
            this.userPw = userPw;
            this.authority = authority;
            this.branchCode = branchCode;
        }

        public string UserId { get => userId; set => userId = value; }
        public string UserPw { get => userPw; set => userPw = value; }
        public int Authority { get => authority; set => authority = value; }
        public string BranchCode { get => branchCode; set => branchCode = value; }
        public string BranchName { get => branchName; set => branchName = value; }
    }
}
