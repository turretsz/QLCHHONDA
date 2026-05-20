using honda.DAL;

namespace honda.BUS
{
    public class AccountBUS
    {
        private static AccountBUS? instance;
        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set { instance = value; }
        }

        private AccountBUS() { }

        public bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

        public string GetRole(string username)
        {
            return AccountDAL.Instance.GetRole(username);
        }
    }
}
