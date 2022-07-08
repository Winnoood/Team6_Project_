using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team6_Project_.Models;

namespace Team6_Project_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfoController : ControllerBase
    {
        static List<Employee> lstemp = new List<Employee>()
        {
            new Employee{Id=1,EmpName="Vinod",Salary=1000000},
            new Employee{Id=2,EmpName="Winod ",Salary=2500000},
            new Employee{Id=3,EmpName="Winnie",Salary=275000},
            new Employee{Id=4,EmpName="Winnoodd",Salary=450000}
        };
        [HttpGet("showall")]
        public ActionResult<List<Employee>> GetAllEmp()
        {
            return lstemp;
        }
        [HttpGet("search/{id?}")]
        public ActionResult<Employee> Search(int? id)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            return ar;
        }
        [HttpPost]
        public ActionResult<List<Employee>> Insert(Employee employee)
        {
            lstemp.Add(employee);
            return lstemp;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            if (ar != null)
            {
                lstemp.Remove(ar);
            }

            return 1;
        }
        [HttpPut("{id}")]
        public int Put(int id, Employee employee)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            if (ar != null)
            {
                ar.EmpName = employee.EmpName;
                ar.Salary = employee.Salary;
                
            }

            return 1;
        }
    }
}
