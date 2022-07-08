using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team6_Project_.Models;


namespace Team6_Project_.DataAccessLayer_EF
{
    public class DataAccessLayer:DbContext
    {
        public DataAccessLayer(DbContextOptions<DataAccessLayer> options) : base(options)
        {

        }
        public DbSet<EmployeeDb> Employee { get; set; }
    }
}
