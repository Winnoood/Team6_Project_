using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team6_Project_.Models
{
    public class EmployeeDb
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string city { get; set; }
    }
}
