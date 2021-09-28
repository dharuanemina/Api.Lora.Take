using Api.Lora.Take.Interface;
using Api.Lora.Take.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Lora.Take.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RepositoriesController : ControllerBase
    {
        private readonly IRepositoryFacade _repositoryFacade;

        public RepositoriesController(IRepositoryFacade repositoryFacade)
        {
            _repositoryFacade = repositoryFacade;
        }


        [HttpGet]
        public async Task<IActionResult> GetLastAsync([FromBody] RepositoryRequest repositoryRequest)
        {
            return Ok(await _repositoryFacade.GetLastsAsync(repositoryRequest));
        }
    }
}
