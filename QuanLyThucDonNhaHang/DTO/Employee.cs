using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    class Employee
    {
        int employeeId;
        string employeeName;
        int service;
        int accountId;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public int Service { get => service; set => service = value; }
        public int AccountId { get => accountId; set => accountId = value; }

        public Employee()
        {
        }
        public Employee(int employeeId, string employeeName, int service, int accountId)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.service = service;
            this.accountId = accountId;
        }

    }
}
