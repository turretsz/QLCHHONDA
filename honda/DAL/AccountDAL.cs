using System.Data;

namespace honda.DAL
{
    public class AccountDAL
    {
        private static AccountDAL? instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @username AND Password = @password";
            object? result = DataProvider.Instance.ExecuteScalar(query, new object[] { username, password });
            return result != null && Convert.ToInt32(result) > 0;
        }

        public string GetRole(string username)
        {
            string query = "SELECT Role FROM TaiKhoan WHERE Username = @username";
            object? result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });
            return result?.ToString() ?? "Staff";
        }
    }
}
