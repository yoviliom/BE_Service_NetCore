using Microsoft.AspNetCore.Mvc;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy.Api.Controllers
{
    [Route("v1/contract")]
    public class ContractController: BaseController
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet("insert")]
        public async Task<EndpointResult> Insert([FromBody] ContractDTO contract)
        {
            try
            {
                _contractService.Insert(contract);


                return new EndpointResult("OK");
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        [HttpGet("update")]
        public async Task<EndpointResult> Update([FromBody] ContractDTO contract)
        {
            try
            {
                _contractService.Update(contract);
                return new EndpointResult("OK");
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }

        [HttpGet("delete")]
        public async Task<EndpointResult> Delete([FromBody] ContractDTO contract)
        {
            try
            {
                _contractService.Delete(contract);
                return new EndpointResult("OK");
            }
            catch (Exception ex)
            {
                return ProcessExceptionResult(ex);
            }
        }
    }
}
