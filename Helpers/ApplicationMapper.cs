using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Team6_Project_.Models;

namespace Team6_Project_.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<EmployeeDb, Employee>().ReverseMap();
        }
    }
}
