using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Policy.Application.Interfaces;

namespace Policy.Api.Controllers
{
    [Route("v1/teacher")]
    public class TeacherController : BaseController
    {

        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
