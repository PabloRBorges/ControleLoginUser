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
        private readonly IBaseService<DadoRecebido> _baseDadoService;
        private readonly IBaseService<Placa> _basePlacaService;
        private readonly IBaseService<Contrato> _baseContratoService;
        private readonly ILogger<DadoRecebido> _logger;
        private List<Placa> placasAtivas = new List<Placa>();


        public RecebeDadosController(ILogger<DadoRecebido> logger,
                                     IBaseService<DadoRecebido> baseService,
                                     IBaseService<Placa> basePlacaService,
                                     IBaseService<Contrato> baseContratoService)
        {
            _baseDadoService = baseService;
            _logger = logger;
            _basePlacaService = basePlacaService;
            _baseContratoService = baseContratoService;
        }


        [HttpPost]
        public IActionResult Create([FromBody] DadoRecebido dadorecebido)
        {
            if (dadorecebido == null)
                return NotFound();

            var placas = _basePlacaService.Get();

            if (placas.Where(x => x.Id == dadorecebido.IdPlaca ).Any())
            {
                return Execute(() => _baseDadoService.Add<DadoRecebidoValidator>(dadorecebido).Id);
            }

            return BadRequest("Placa sem autorização");
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
