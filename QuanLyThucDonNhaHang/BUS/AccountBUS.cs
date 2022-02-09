using QuanLyThucDonNhaHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang.BUS
{
    class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() { }
        public bool checkAccount(string userName, string passWord)
        {
            try
            {
                if (AccountDAO.Instance.checkAccount(userName, passWord).Count > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra BUS!");
            }
            return false;
        }
    }
}
