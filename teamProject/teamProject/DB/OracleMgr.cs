using Oracle.ManagedDataAccess.Client;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.Model;
using static System.Net.Mime.MediaTypeNames;

namespace teamProject
{
    // DAO: DB 연동하는 클래스를 지칭.
    internal class OracleMgr
    {
        // 오라클DB 연동을 위해서는 드라이버 설치를 해야됨.
        string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=team2;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        public OracleMgr()
        {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
        }

        // 소멸자: 객체가 파괴될때 호출
        ~OracleMgr()
        {
            disconnectDB();
        }

        /// <summary>
        /// DB 접속
        /// </summary>
        public void connectDB()
        {
            // 객체지향언어에서 사용하는 예외 처리 (if와 같이 사용)
            // 절차적 프로그래밍(C언어)에서는 if문을 주로 사용
            // 반드시 사용: 파일, DB, 네트웍
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        /// <summary>
        /// DB 접속 해제
        /// </summary>
        public void disconnectDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제!");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("종료 에러: " + e.Message);
            }
        }

        /// <summary>
        /// 새로운 유저 등록
        /// </summary>
        /// <param name="user"></param>
        public void insertUser(User_management user)
        {
            try
            {
                string sql = $"insert into user_management values ('{user.UserId}'," +
                    $"'{user.UserPw}', 1, '{user.BranchCode}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 유저 업데이트
        /// </summary>
        /// <param name="userPw"></param>
        /// <param name="branchCode"></param>
        public void updateUser(User_management user)
        {
            try
            {
                string sql = $"update user_management set user_pw = '{user.UserPw}', branch_code = '{user.BranchCode}'" +
                    $" where user_id = '{user.UserId}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 유저 로그인
        /// </summary>
        /// <returns></returns>
        public User_management selectUserLogin(string userId, string userPw, int authority)
        {
            string sql = $"select * from user_management where user_id = '{userId}' and user_pw = '{userPw}' and authority = {authority}";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            User_management user = new User_management();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    user.UserId = dr["user_id"].ToString();
                    user.UserPw = dr["user_pw"].ToString();
                    user.Authority = int.Parse(dr["authority"].ToString());
                    user.BranchCode = dr["branch_code"].ToString();
                }
            }
            else
            {
                Console.WriteLine("등록된 유저정보가 존재하지 않습니다.");
            }
            dr.Close();
            return user;
        }

        /// <summary>
        /// 유저 리스트 정보 획득
        /// </summary>
        /// <returns></returns>
        public List<User_management> selectUser()
        {
            string sql = "select um.user_id, um.user_pw, um.authority, um.branch_code, " +
                "cb.branch_name from user_management um, cafe_branch cb where um.branch_code = cb.branch_code";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<User_management> list = new List<User_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    User_management user = new User_management();
                    user.UserId = dr["user_id"].ToString();
                    user.UserPw = dr["user_pw"].ToString();
                    user.Authority = int.Parse(dr["authority"].ToString());
                    user.BranchCode = dr["branch_code"].ToString();
                    user.BranchName = dr["branch_name"].ToString();
                    list.Add(user);
                }
            }
            else
            {
                Console.WriteLine("등록된 유저정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 유저 삭제
        /// </summary>
        /// <param name="userId"></param>
        public void deleteUserManagement(string userId)
        {
            try
            {
                string sql = $"delete user_management where user_id = '{userId}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삭제 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 새로운 카페 지점 등록
        /// </summary>
        /// <param name="cafe"></param>
        public void insertCafeBranch(Cafe_branch cafe)
        {
            try
            {
                string sql = $"insert into cafe_branch (branch_code, branch_name, name, tel, address, open_date)" +
                    $" values ('{cafe.BranchCode}', '{cafe.BranchName}', '{cafe.Name}', '{cafe.Tel}', '{cafe.Address}'," +
                    $"'{cafe.OpenDate}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 지점장 교체의 경우 사용
        /// 지점장, 전화번호 수정
        /// </summary>
        /// <param name="cafe"></param>
        public void updateCafeBranch(Cafe_branch cafe)
        {
            try
            {
                string sql = $"update cafe_branch set name = '{cafe.Name}', tel = '{cafe.Tel}'" +
                    $"where branch_code = '{cafe.BranchCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 카페 지점 폐점시 폐점 일자 등록
        /// </summary>
        /// <param name="cafe"></param>
        public void updateCafeBranchCloseDate(Cafe_branch cafe)
        {
            try
            {
                string sql = $"update cafe_branch set close_date = '{cafe.CloseDate}' where branch_code = '{cafe.BranchCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 전체 카페 지점 리스트 획득
        /// </summary>
        /// <returns></returns>
        public List<Cafe_branch> selectCafeBranch()
        {
            string sql = "select * from cafe_branch";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Cafe_branch> list = new List<Cafe_branch>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cafe_branch cafe = new Cafe_branch();
                    cafe.BranchCode = dr["branch_code"].ToString();
                    cafe.BranchName = dr["branch_name"].ToString();
                    cafe.Name = dr["name"].ToString();
                    cafe.Tel = dr["tel"].ToString();
                    cafe.Address = dr["address"].ToString();
                    cafe.OpenDate = dr["open_date"].ToString();
                    cafe.CloseDate = dr["close_date"].ToString();
                    list.Add(cafe);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 특정 카페 지점 데이터 획득
        /// </summary>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public Cafe_branch selectCafeBranch(string branchCode)
        {
            string sql = $"select * from cafe_branch where branch_code = '{branchCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            Cafe_branch cafe = new Cafe_branch();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cafe.BranchCode = dr["branch_code"].ToString();
                    cafe.BranchName = dr["branch_name"].ToString();
                    cafe.Name = dr["name"].ToString();
                    cafe.Tel = dr["tel"].ToString();
                    cafe.Address = dr["address"].ToString();
                    cafe.OpenDate = dr["open_date"].ToString();
                    cafe.CloseDate = dr["close_date"].ToString();
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return cafe;
        }

        /// <summary>
        /// 입출고 정보 입력
        /// </summary>
        /// <param name="ma"></param>
        public void insertMaterialWarehousing(Material_warehousing ma)
        {
            try
            {
                string sql = $"insert into material_warehousing (material_code, material_count, in_out_flag, in_out_date) values (" +
                    $"'{ma.MaterialCode}', {ma.MaterialCount}, {ma.InOutFlag}, sysdate)";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 입출고 데이터 수정
        /// </summary>
        /// <param name="ma"></param>
        public void updateMaterialWarehousing(Material_warehousing ma)
        {
            try
            {
                string sql = $"update material_warehousing set material_code = '{ma.MaterialCode}'," +
                    $"material_count = {ma.MaterialCount}, in_out_flag = {ma.InOutFlag}" +
                    $"where in_out_number = {ma.InOutNumber}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 입출고 이력 전체 출력
        /// </summary>
        /// <returns></returns>
        public List<Material_warehousing> selectMaterialWarehousing()
        {
            string sql = "select mw.in_out_number, mw.material_code, mc.material_name, " +
                "mw.material_count, mw.in_out_flag, mw.in_out_date  " +
                "from material_warehousing mw, material_code mc where mw.material_code = mc.material_code" +
                " order by in_out_number";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Material_warehousing> list = new List<Material_warehousing>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Material_warehousing ma = new Material_warehousing();
                    ma.InOutNumber = int.Parse(dr["in_out_number"].ToString());
                    ma.MaterialName = dr["material_name"].ToString();
                    ma.MaterialCode = dr["material_code"].ToString();
                    ma.MaterialCount = int.Parse(dr["material_count"].ToString());
                    ma.InOutFlag = int.Parse(dr["in_out_flag"].ToString());
                    ma.InOutData = dr["in_out_date"].ToString();
                    list.Add(ma);
                }
            }
            else
            {
                Console.WriteLine("등록된 입출고정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 입출고 이력 입고 혹은 출고 리스트 출력
        /// </summary>
        /// <returns></returns>
        public List<Material_warehousing> selectMaterialWarehousingInOut(int inOutFlag)
        {
            string sql = $"select mw.in_out_number, mw.material_code, mc.material_name, " +
                $"mw.material_count, mw.in_out_flag, mw.in_out_date  " +
                $"from material_warehousing mw, material_code mc where mw.material_code = mc.material_code and in_out_flag = {inOutFlag}" +
                $" order by in_out_number";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Material_warehousing> list = new List<Material_warehousing>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Material_warehousing ma = new Material_warehousing();
                    ma.InOutNumber = int.Parse(dr["in_out_number"].ToString());
                    ma.MaterialName = dr["material_name"].ToString();
                    ma.MaterialCode = dr["material_code"].ToString();
                    ma.MaterialCount = int.Parse(dr["material_count"].ToString());
                    ma.InOutFlag = int.Parse(dr["in_out_flag"].ToString());
                    ma.InOutData = dr["in_out_date"].ToString();
                    list.Add(ma);
                }
            }
            else
            {
                Console.WriteLine("등록된 입출고정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 입출고 데이터 삭제
        /// </summary>
        /// <param name="inOutNumber"></param>
        public void deleteMaterialWarehousing(int inOutNumber)
        {
            try
            {
                string sql = $"delete material_warehousing where in_out_number = {inOutNumber}";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삭제 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 발주 신청
        /// </summary>
        /// <param name="om"></param>
        public void insertOrderManagement(Order_management om)
        {
            try
            {
                string sql = $"insert into order_management (order_code, branch_code, material_code, material_count, application_date, order_status)" +
                    $" values ('{om.OrderCode}', '{om.BranchCode}', '{om.MaterialCode}', {om.MaterialCount}, sysdate, 0)";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 발주코드 습득
        /// </summary>
        /// <returns></returns>
        public string selectOrderManagementBranchCode()
        {
            string sql = "select max(order_code) from order_management";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            string orderCode = string.Empty;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    orderCode = dr["max(order_code)"].ToString();
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return orderCode;
        }

        /// <summary>
        /// 발주 이력 리스트 검색
        /// </summary>
        /// <returns></returns>
        public List<Order_management> selectOrderManagement()
        {
            string sql = "select om.order_code, om.branch_code, cb.branch_name, " +
                "om.material_code, mc.material_name, om.material_count, om.order_status, om.waybill_code " +
                "from order_management om, cafe_branch cb, material_code mc where om.branch_code = cb.branch_code and " +
                "om.material_code = mc.material_code";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Order_management> list = new List<Order_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order_management om = new Order_management();
                    om.OrderCode = dr["order_code"].ToString();
                    om.BranchCode = dr["branch_code"].ToString();
                    om.BranchName = dr["branch_name"].ToString();
                    om.MaterialCode = dr["material_code"].ToString();
                    om.MaterialName = dr["material_name"].ToString();
                    om.MaterialCount = int.Parse(dr["material_count"].ToString());
                    om.OrderStatus = int.Parse(dr["order_status"].ToString());
                    om.WaybillCode = dr["waybill_code"].ToString();
                    list.Add(om);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 지점 발주 이력 리스트 검색 - 지점코드
        /// </summary>
        /// <returns></returns>
        public List<Order_management> selectOrderManagementBranchCode(string branchCode)
        {
            string sql = $"select om.order_code, om.branch_code, cb.branch_name, " +
                $"om.material_code, mc.material_name, om.material_count, om.order_status, om.application_date, om.waybill_code " +
                $"from order_management om, cafe_branch cb, material_code mc where om.branch_code = cb.branch_code and " +
                $"om.material_code = mc.material_code and om.branch_code = '{branchCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Order_management> list = new List<Order_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order_management om = new Order_management();
                    om.OrderCode = dr["order_code"].ToString();
                    om.BranchCode = dr["branch_code"].ToString();
                    om.BranchName = dr["branch_name"].ToString();
                    om.MaterialCode = dr["material_code"].ToString();
                    om.MaterialName = dr["material_name"].ToString();
                    om.MaterialCount = int.Parse(dr["material_count"].ToString());
                    om.OrderStatus = int.Parse(dr["order_status"].ToString());
                    om.ApplicationDate = dr["application_date"].ToString();
                    om.WaybillCode = dr["waybill_code"].ToString();
                    list.Add(om);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 지점 발주 이력 리스트 검색 - 지점명
        /// </summary>
        /// <returns></returns>
        public List<Order_management> selectOrderManagementBranchName(string branchName)
        {
            string sql = $"select om.order_code, om.branch_code, cb.branch_name, " +
                $"om.material_code, mc.material_name, om.material_count, om.order_status, om.application_date, om.waybill_code " +
                $"from order_management om, cafe_branch cb, material_code mc where om.branch_code = cb.branch_code and " +
                $"om.material_code = mc.material_code and cb.branch_name = '{branchName}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Order_management> list = new List<Order_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order_management om = new Order_management();
                    om.OrderCode = dr["order_code"].ToString();
                    om.BranchCode = dr["branch_code"].ToString();
                    om.BranchName = dr["branch_name"].ToString();
                    om.MaterialCode = dr["material_code"].ToString();
                    om.MaterialName = dr["material_name"].ToString();
                    om.MaterialCount = int.Parse(dr["material_count"].ToString());
                    om.OrderStatus = int.Parse(dr["order_status"].ToString());
                    om.ApplicationDate = dr["application_date"].ToString();
                    om.WaybillCode = dr["waybill_code"].ToString();
                    list.Add(om);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 지점 발주 재료 검색 리스트
        /// </summary>
        /// <returns></returns>
        public List<Order_management> selectOrderManagementBranchMaterial(string branchCode, string materialName)
        {
            string sql = $"select om.order_code, om.branch_code, cb.branch_name, " +
                $"om.material_code, mc.material_name, om.material_count, om.order_status, om.application_date, om.waybill_code " +
                $"from order_management om, cafe_branch cb, material_code mc where om.branch_code = cb.branch_code and " +
                $"om.material_code = mc.material_code and om.branch_code = '{branchCode}' and mc.material_name = '{materialName}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Order_management> list = new List<Order_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order_management om = new Order_management();
                    om.OrderCode = dr["order_code"].ToString();
                    om.BranchCode = dr["branch_code"].ToString();
                    om.BranchName = dr["branch_name"].ToString();
                    om.MaterialCode = dr["material_code"].ToString();
                    om.MaterialName = dr["material_name"].ToString();
                    om.MaterialCount = int.Parse(dr["material_count"].ToString());
                    om.OrderStatus = int.Parse(dr["order_status"].ToString());
                    om.ApplicationDate = dr["application_date"].ToString();
                    om.WaybillCode = dr["waybill_code"].ToString();
                    list.Add(om);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 발주 재료 검색 리스트
        /// </summary>
        /// <returns></returns>
        public List<Order_management> selectOrderManagementMaterial(string materialName)
        {
            string sql = $"select om.order_code, om.branch_code, cb.branch_name, " +
                $"om.material_code, mc.material_name, om.material_count, om.order_status, om.application_date, om.waybill_code " +
                $"from order_management om, cafe_branch cb, material_code mc where om.branch_code = cb.branch_code and " +
                $"om.material_code = mc.material_code and mc.material_name = '{materialName}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Order_management> list = new List<Order_management>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order_management om = new Order_management();
                    om.OrderCode = dr["order_code"].ToString();
                    om.BranchCode = dr["branch_code"].ToString();
                    om.BranchName = dr["branch_name"].ToString();
                    om.MaterialCode = dr["material_code"].ToString();
                    om.MaterialName = dr["material_name"].ToString();
                    om.MaterialCount = int.Parse(dr["material_count"].ToString());
                    om.OrderStatus = int.Parse(dr["order_status"].ToString());
                    om.ApplicationDate = dr["application_date"].ToString();
                    om.WaybillCode = dr["waybill_code"].ToString();
                    list.Add(om);
                }
            }
            else
            {
                Console.WriteLine("등록된 지점정보가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 지점에서의 발주 정보 수정
        /// </summary>
        /// <param name="om"></param>
        public void updateOrderManagementBranch(Order_management om)
        {
            try
            {
                string sql = $"update order_management set material_code = '{om.MaterialCode}'," +
                    $"material_count = {om.MaterialCount} where order_code = '{om.OrderCode}' and branch_code = '{om.BranchCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 본점에서의 발주 정보 수정
        /// </summary>
        /// <param name="om"></param>
        public void updateOrderManagementHead(Order_management om)
        {
            try
            {
                string sql = $"update order_management set order_status = '{om.OrderStatus}'," +
                    $"waybill_code = '{om.WaybillCode}' where order_code = '{om.OrderCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 발주 취소
        /// </summary>
        /// <param name="orderCode"></param>
        public void deleteOrderManagement(string orderCode)
        {
            try
            {
                string sql = $"delete order_management where order_code = '{orderCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삭제 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 신규 재고 코드 등록
        /// </summary>
        /// <param name="mc"></param>
        public void insertMaterialCodeModel(Material_codeModel mc)
        {
            try
            {
                string sql = $"insert into material_code values ('{mc.MaterialCode}', " +
                    $"'{mc.MaterialName}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 재고 코드 갱신
        /// </summary>
        /// <param name="mc"></param>
        public void updateMaterialCodeModel(Material_codeModel mc)
        {
            try
            {
                string sql = $"update material_code set material_name = '{mc.MaterialName}'" +
                    $" where material_code = '{mc.MaterialCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 전체 재고코드 불러오기
        /// </summary>
        /// <param name="mc"></param>
        public List<Material_codeModel> selecetMaterialCodeModel()
        {
            string sql = $"select * from material_code order by material_code";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Material_codeModel> list = new List<Material_codeModel>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Material_codeModel mc = new Material_codeModel();
                    mc.MaterialCode = dr["material_code"].ToString();
                    mc.MaterialName = dr["material_name"].ToString();
                    list.Add(mc);
                }
            }
            else
            {
                Console.WriteLine("재고코드가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 재고 코드 삭제
        /// </summary>
        /// <param name="materialCode"></param>
        public void deleteMaterialCode(string materialCode)
        {
            try
            {
                string sql = $"delete material_code where material_code = '{materialCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삭제 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 재고코드 체크
        /// </summary>
        /// <param name="mc"></param>
        public Boolean selecetMaterialCodeModel(string materialCode)
        {
            string sql = $"select * from material_code where material_code = '{materialCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("재고코드가 존재하지 않습니다.");
            }
            dr.Close();
            return false;
        }

        /// <summary>
        /// 각 지점 재고 현황 불러오기
        /// </summary>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public List<Total_material> selecetTotalMaterialModel(string branchCode)
        {
            string sql = $"select * from total_material where branch_code = '{branchCode}'  order by material_count";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Total_material> list = new List<Total_material>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Total_material tm = new Total_material();
                    tm.MaterialCode = dr["material_code"].ToString();
                    tm.MaterialName = dr["material_name"].ToString();
                    tm.MaterialCount = int.Parse(dr["material_count"].ToString());
                    tm.BranchCode = dr["branch_code"].ToString();

                    list.Add(tm);
                }
            }
            else
            {
                Console.WriteLine("재고코드가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 각 지점 재고 현황 검색
        /// </summary>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public List<Total_material> selecetTotalMaterialModelMaterial(string branchCode, string materialName)
        {
            string sql = $"select * from total_material where " +
                $"branch_code = '{branchCode}' and material_name = '{materialName}' order by material_count";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Total_material> list = new List<Total_material>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Total_material tm = new Total_material();
                    tm.MaterialCode = dr["material_code"].ToString();
                    tm.MaterialName = dr["material_name"].ToString();
                    tm.MaterialCount = int.Parse(dr["material_count"].ToString());
                    tm.BranchCode = dr["branch_code"].ToString();

                    list.Add(tm);
                }
            }
            else
            {
                Console.WriteLine("재고코드가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 데이터 존재 유무 체크
        /// </summary>
        /// <param name="branchCode"></param>
        /// <param name="materialCode"></param>
        /// <returns></returns>
        public Boolean selecetTotalMaterialExistenceCheck(string branchCode, string materialCode)
        {
            string sql = $"select material_count from total_material where " +
                $"branch_code = '{branchCode}' and material_code = '{materialCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            int materialCount = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            dr.Close();
            return false;
        }

        /// <summary>
        /// 특정 재고 현재 개수 검색
        /// </summary>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public int selecetTotalMaterialCount(string branchCode, string materialCode)
        {
            string sql = $"select material_count from total_material where " +
                $"branch_code = '{branchCode}' and material_code = '{materialCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            int materialCount = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    materialCount = int.Parse(dr["material_count"].ToString());
                }
            }
            else
            {
                Console.WriteLine("재고코드가 존재하지 않습니다.");
            }
            dr.Close();
            return materialCount;
        }

        /// <summary>
        /// 신규 재고 등록
        /// </summary>
        /// <param name="tm"></param>
        public void insertTotalMaterial(Total_material tm)
        {
            try
            {
                string sql = $"insert into total_material values ('{tm.MaterialCode}', " +
                    $"'{tm.MaterialName}', '{tm.BranchCode}', '{tm.MaterialCount}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 재고 개수 수정
        /// </summary>
        /// <param name="tm"></param>
        public void updateTotalMaterial(int materialCount, string branchCode, string materialCode)
        {
            try
            {
                string sql = $"update total_material set material_count = {materialCount}" +
                    $" where branch_code = '{branchCode}' and material_code = '{materialCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("등록 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 총 재고 현황에서 불필요 자산 작세
        /// </summary>
        /// <param name="branchCode"></param>
        /// <param name="materialCode"></param>
        public void deleteTotalMaterial(string branchCode, string materialCode)
        {
            try
            {
                string sql = $"delete total_material where branch_code = '{branchCode}' and material_code = '{materialCode}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삭제 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 카페지점 검색
        /// </summary>
        public List<Cafe_branch> searchBranch(string item, string value)
        {
            string query = string.Empty;
            if (item.Equals("지점명"))
            {
                query = $"select * from cafe_branch where branch_name='{value}'";
            }
            else if (item.Equals("지점코드"))
            {
                query = $"select * from cafe_branch where branch_code='{value}'";
            }
            else if (item.Equals("점주명"))
            {
                query = $"select * from cafe_branch where name='{value}'";
            }
            else if (item.Equals("주소"))
            {
                query = $"select * from cafe_branch where  address like '%{value}%'";
            }
            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataReader dr = cmd.ExecuteReader();

            List<Cafe_branch> list = new List<Cafe_branch>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string date = (dr["open_date"].ToString()).Substring(0, 10);
                    if (String.IsNullOrEmpty(dr["close_date"].ToString()) == true)
                    {
                        list.Add(new Cafe_branch(
                            dr["branch_code"].ToString(),
                            dr["branch_name"].ToString(),
                            dr["name"].ToString(),
                            dr["tel"].ToString(),
                            dr["address"].ToString(),
                            date
                        ));
                    };
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 카페리스트 전체보기
        /// </summary>
        public List<Cafe_branch> allBranch()
        {
            string query = "select * from cafe_branch";
            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Cafe_branch> list = new List<Cafe_branch>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (String.IsNullOrEmpty(dr["close_date"].ToString()) == true)
                    {
                        list.Add(new Cafe_branch(
                            dr["branch_code"].ToString(),
                            dr["branch_name"].ToString(),
                            dr["name"].ToString(),
                            dr["tel"].ToString(),
                            dr["address"].ToString(),
                            dr["open_date"].ToString()
                        ));
                    }
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 지점 코드입력
        /// </summary>
        /// <returns></returns>
        public string selectCode()
        {
            string code = "";
            string query = "select substr(max(branch_code),3,4)+1 from cafe_branch where branch_code like 'B%'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string resurt = (cmd.ExecuteScalar().ToString());

            if (resurt.Equals(""))
            {
                code = "B0001";
            }
            else
            {
                code = "B000" + cmd.ExecuteScalar();
            }
            return code;
        }

        /// <summary>
        /// 지점 수정
        /// </summary>
        public void updateBranch(Cafe_branch cafe)
        {
            try
            {
                string sql = "";
                if (String.IsNullOrEmpty(cafe.CloseDate) == true)
                {
                    sql = $"update cafe_branch set branch_code = '{cafe.BranchCode}'," +
                        $"branch_name = '{cafe.BranchName}',name = '{cafe.Name}', tel = '{cafe.Tel}'," +
                        $"address = '{cafe.Address}',open_date='{cafe.OpenDate}',close_date = null where branch_code ='{cafe.BranchCode}'";

                }
                else
                {
                    sql = $"update cafe_branch set branch_code = '{cafe.BranchCode}'," +
                     $"branch_name = '{cafe.BranchName}',name = '{cafe.Name}', tel = '{cafe.Tel}'," +
                     $"address = '{cafe.Address}',open_date='{cafe.OpenDate}',close_date='{cafe.CloseDate}' where branch_code ='{cafe.BranchCode}'";

                }
                cmd.CommandText = sql;
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삽입 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 지점 등록
        /// </summary>
        public void insertBranch(Cafe_branch cafe)
        {
            try
            {
                string sql = $"insert into cafe_branch values ('{cafe.BranchCode}'," +
                    $"'{cafe.BranchName}', '{cafe.Name}', '{cafe.Tel}'," +
                    $"'{cafe.Address}','{cafe.OpenDate}',null)";

                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삽입 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 발주 상태수정 및 송장등록
        /// </summary>
        public void updateOrder(string order_code, int order_status, string waybill_code)
        {
            try
            {
                string sql = $"update order_management set order_status = {order_status} ,waybill_code ='{waybill_code}'" +
                             $"where order_code ='{order_code}'";


                cmd.CommandText = sql;
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("삽입 에러: " + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        /// <summary>
        /// 검색 주문 리스트
        /// </summary>
        public List<Order_management> searchOrder(string item, string value)
        {
            string query = string.Empty;
            query = $"select o.order_code,o.branch_code,b.branch_name,b.name,b.tel,o.material_code,t.material_name,o.material_count,o.application_date,o.order_status,o.waybill_code " +
                        $"from cafe_branch b join order_management o on b.branch_code = o.branch_code  join total_material t on t.material_code = o.material_code ";
            if (item.Equals("지점명"))
            {
                query += $"where branch_name='{value}'";
            }
            else if (item.Equals("자재명"))
            {
                query += $"where material_name='{value}'";
            }

            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataReader dr = cmd.ExecuteReader();

            List<Order_management> list = new List<Order_management>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    list.Add(new Order_management(
                                   dr["order_code"].ToString(),
                                   dr["branch_code"].ToString(),
                                   dr["branch_name"].ToString(),
                                   dr["material_code"].ToString(),
                                   dr["material_name"].ToString(),
                                   Convert.ToInt32(dr["material_count"]),
                                   Convert.ToInt32(dr["order_status"]),
                                   dr["application_date"].ToString(),
                                   dr["waybill_code"].ToString(),
                                   dr["name"].ToString(),
                                   dr["tel"].ToString()
                                   ));

                }

            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 전체 주문리스트
        /// </summary>
        public List<Order_management> allOrder()
        {
            string query = "select o.order_code,o.branch_code,b.branch_name,b.name,b.tel,o.material_code,m.material_name,o.material_count,o.application_date,o.order_status,o.waybill_code from cafe_branch b join order_management o on b.branch_code = o.branch_code  join material_code m on m.material_code = o.material_code";
            cmd.Connection = conn;
            cmd.CommandText = query;
            OracleDataReader dr = cmd.ExecuteReader();

            List<Order_management> list = new List<Order_management>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Console.WriteLine(dr["order_code"].ToString());
                    Console.WriteLine(Convert.ToInt32(dr["material_count"]));
                    Console.WriteLine((DateTime)dr["application_date"]);
                    Console.WriteLine(Convert.ToInt32(dr["order_status"]));
                    Console.WriteLine(dr["waybill_code"].ToString());

                    list.Add(new Order_management(
                                   dr["order_code"].ToString(),
                                   dr["branch_code"].ToString(),
                                   dr["branch_name"].ToString(),
                                   dr["material_code"].ToString(),
                                   dr["material_name"].ToString(),
                                   Convert.ToInt32(dr["material_count"]),
                                   Convert.ToInt32(dr["order_status"]),
                                   dr["application_date"].ToString(),
                                   dr["waybill_code"].ToString(),
                                   dr["name"].ToString(),
                                   dr["tel"].ToString()
                                   ));

                }

            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 재고 등록 개수 확인
        /// </summary>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public int selectMaterialCount(string branchCode)
        {
            string sql = $"select count(*) from total_material where branch_code = '{branchCode}'";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count = int.Parse(dr["count(*)"].ToString());
                }
            }
            else
            {
                Console.WriteLine("등록된 입출고정보가 존재하지 않습니다.");
            }
            dr.Close();
            return count;
        }

        /// <summary>
        /// 등록 자재코드 개수
        /// </summary>
        /// <returns></returns>
        public int selectMaterialCodeCount()
        {
            string sql = $"select count(*) from material_code";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count = int.Parse(dr["count(*)"].ToString());
                }
            }
            else
            {
                Console.WriteLine("등록된 입출고정보가 존재하지 않습니다.");
            }
            dr.Close();
            return count;
        }
    }
}
