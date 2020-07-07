using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Response;

namespace Policy.Api.Controllers
{
    [Route("v1/api/[controller]")]
    public class TeacherController : BaseController
    {

        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [Route("update")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<EndpointResult> Insert([FromBody] Teacher teacher)
        {
            try
            {
                _teacherService.Insert(teacher);

                return new EndpointResult(teacher);
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }


        /// <summary>
        /// Get collection sheet by id
        /// </summary>
        /// <param name="teacherCode"></param>
        /// <returns></returns>
        [Route("getTeachersByCode/{teacherCode}")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<EndpointResult> GetTeacherByCode(string teacherCode)
        {
            try
            {
                _teacherService.Select(teacherCode);

                return new EndpointResult(teacherCode);
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        [Route("delete")]
        [HttpPost]
        public async Task<EndpointResult> DeleteTeacherByCode(string teacherCode)
        {
            try
            {
                _teacherService.Delete(teacherCode);

                return new EndpointResult("OK");
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
