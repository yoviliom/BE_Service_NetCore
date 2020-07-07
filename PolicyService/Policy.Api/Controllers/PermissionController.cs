using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Infrastructure.Response;

namespace Policy.Api.Controllers
{
    [Route("v1/api/[controller]")]
    public class PermissionController : BaseController
    {

        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }


        /// <summary>
        /// Get collection sheet by id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [Route("getPermissionsByCode/{code}")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<EndpointResult> GetPermissionUser(string code)
        {
            try
            {
                _permissionService.Select(code);

                return new EndpointResult(code);
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        [Route("update")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<EndpointResult> UpdatePermission([FromBody] PermissionDTO permission)
        {
            try
            {
                _permissionService.Update(permission);

                return new EndpointResult(permission);
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
