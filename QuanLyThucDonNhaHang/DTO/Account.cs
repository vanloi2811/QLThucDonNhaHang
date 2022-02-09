using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    public class Account
    {
        private int id;
        public int Id
        {
            get { return Id; }
            set { this.Id = value; }
        }

        private string userName;
        public string UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private string PassWord;
        public string passWord
        {
            get { return PassWord; }
            set { PassWord = value; }
        }

        private int type;
        public int Type
        {
            get { return Type; }
            set { Type = value; }
        }

        public Account(){}
        public Account(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
        public Account(int id, string userName, string passWord, int type)
        {
            this.id = id;
            this.userName = userName;
            this.passWord = passWord;
            this.type = type;
        }
    }
}
