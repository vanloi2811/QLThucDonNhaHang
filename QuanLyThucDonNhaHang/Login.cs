using QuanLyThucDonNhaHang.BUS;
using QuanLyThucDonNhaHang.DAO;
using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(AccountBUS.Instance.checkAccount(txbUserName.Text, txbPassWord.Text))
            {
                // ban đầu
                //Form1 f = new Form1();
                //this.Hide();
                //f.Show();

                //cách 1
                string user = txbUserName.Text.Trim();
                string password = txbPassWord.Text.Trim();
                string query = string.Format("select * from Account where UserName = '{0}' and PassWord = '{1}'", user, password);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {

                    this.Hide();
                    Form1 f = new Form1((int)data.Rows[0][0], data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), (int)data.Rows[0][3]);
                    f.Show();
                }

                //cách 2
                //List<Account> accounts = new List<Account>();
                //string query = string.Format("select * from Account where UserName = {0}, PassWord = {1}", user, password);
                //try
                //{
                //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                //    foreach (DataRow item in data.Rows)
                //    {
                //        int id = (int)item["Id"];
                //        string userName = item["UserName"].ToString();
                //        string passWord = item["PassWord"].ToString();
                //        int type = (int)item["Type"];
                //        Account ac = new Account(id, userName, passWord, type);

                //        accounts.Add(ac);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi xem bàn DAO!");

                //Form1 f = new Form1(accounts[0], accounts[1], accounts[2], accounts[3]);
                //this.Hide();
                //f.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
