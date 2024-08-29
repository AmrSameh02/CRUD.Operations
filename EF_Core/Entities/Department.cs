using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }



        public override string ToString()
        {
            return $"ID = {Id}, DepartmentName = {DeptName}, ManagerId = {ManagerId}";
        }
    }
}
