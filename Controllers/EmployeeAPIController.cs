using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team6_Project_.DataAccessLayer_EF;
using Team6_Project_.Models;
using AutoMapper;

namespace Team6_Project_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        DataAccessLayer _DataAccessLayer;
        private readonly IMapper mapper;

        public EmployeeAPIController(DataAccessLayer DataAccessLayer,IMapper mapper)
        {
            _DataAccessLayer = DataAccessLayer;
            this.mapper = mapper;
        }
        
        
    }
}
