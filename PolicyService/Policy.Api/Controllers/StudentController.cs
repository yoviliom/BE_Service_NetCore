using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Response;

namespace Policy.Api.Controllers
{
    [Route("v1/api/[controller]")]
    public class StudentController : BaseController
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Route("update")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<EndpointResult> Insert([FromBody] Student student)
        {
            try
            {
                _studentService.Insert(student);

                return new EndpointResult(student);
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }


        /// <summary>
        /// Get collection sheet by id
        /// </summary>
        /// <param name="studentCode"></param>
        /// <returns></returns>
        [Route("getStudentsByCode/{studentCode}")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<EndpointResult> GetStudentsByCode(string studentCode)
        {
            try
            {
                StudentDTO studen = _studentService.Select(studentCode);

                return new EndpointResult(studen);
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        [Route("delete")]
        [HttpPost]
        public async Task<EndpointResult> DeleteStudentByCode(string studentCode)
        {
            try
            {
                _studentService.Delete(studentCode);

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
