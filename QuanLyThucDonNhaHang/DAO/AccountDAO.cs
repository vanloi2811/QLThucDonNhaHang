using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }
        }

        private AccountDAO() { }

        public List<Account> checkAccount(string userName, string passWord)
        {
            List<Account> accounts = new List<Account>();
            string query = string.Format("select * from Account where UserName = '{0}' and PassWord = '{1}'", userName, passWord);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {


                    Account ac = new Account(item["UserName"].ToString(), item["PassWord"].ToString());

                    accounts.Add(ac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra DAO!");
            }
            return accounts;
        }
    }
}
