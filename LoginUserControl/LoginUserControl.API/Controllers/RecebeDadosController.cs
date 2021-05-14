using LoginUserControl.Core.Entities;
using LoginUserControl.Core.Interfaces;
using LoginUserControl.Service.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginUserControl.API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class RecebeDadosController : ControllerBase
    {
        private readonly IBaseService<DadoRecebido> _baseService;
        private readonly ILogger<DadoRecebido> _logger;

        public RecebeDadosController(IBaseService<DadoRecebido> baseService, ILogger<DadoRecebido> logger)
        {
            _baseService = baseService;
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Create([FromBody] DadoRecebido dadorecebido)
        {
            if (dadorecebido == null)
                return NotFound();


            return Execute(() => _baseService.Add<DadoRecebidoValidator>(dadorecebido).Id);
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro de envio da placa");
                return BadRequest(ex);
            }
        }
    }
}
