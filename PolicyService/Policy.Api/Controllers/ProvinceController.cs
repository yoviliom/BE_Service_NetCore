using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy.Api.Controllers
{
    [Route("v1/province")]
    public class ProvinceController: BaseController
    {
        private readonly IProvinceService _provinceService;
        
        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<EndpointResult> Insert([FromBody]Province province)
        {
            try
            {
                _provinceService.Insert(province);

                return new EndpointResult("OK");
            }
            catch(Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }
    }
}
