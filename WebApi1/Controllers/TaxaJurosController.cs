using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private static decimal _taxaJuros = 0.01M;
        
        [HttpGet]
        public decimal Get()
        {
            return _taxaJuros;
        }
    }
}
