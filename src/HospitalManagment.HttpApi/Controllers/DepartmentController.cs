//using Asp.Versioning;
//using HospitalManagement.Departments;
//using Microsoft.AspNetCore.Mvc;
//using MiNET.Plugins;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Volo.Abp.AspNetCore.Mvc;

//namespace HospitalManagment.Controllers
//{
//    [Area("hospitalmanage")]
//    [ControllerName("HospitalDepartment")]
//    [Route("api/hospitalmanage/departments")]
//    public class DepartmentController :AbpController
//    {
//       private readonly  IDepartmentAppService _appService;
//        public DepartmentController(IDepartmentAppService appService)
//        {
//            _appService = appService;
//        }

//        [HttpPost]
//        public Task<DepartmentDtos> CreateAsync(string Title, string Name)
//        {
//            return _appService.CreateAsync(Title, Name);
//        }

//    }
//}
