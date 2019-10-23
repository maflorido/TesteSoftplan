using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi2.Services;

namespace WebApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }
        
        [HttpGet]        
        public async Task<double> Get(double? valorinicial, double? tempo)
        {
            double taxaJuros = await _taxaJurosService.ObterValorFinal(valorinicial, tempo);
            return taxaJuros;
        }
    }
}
