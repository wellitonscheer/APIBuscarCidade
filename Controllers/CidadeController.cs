using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIBuscarCidade.Models;
using APIBuscarCidade.Utils;

namespace APIBuscarCidade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : ControllerBase
    {
        private readonly ILogger<CidadeController> _logger;

        public CidadeController(ILogger<CidadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{cep}")]
        public string Get(string cep)
        {
            Cidade cidade = new Cidade();
            cidade.cep = cep;
            ViaCEP viaCEP = new ViaCEP();
            Cidade cidadeRetorno = viaCEP.BuscarCidade(cidade);
            return cidadeRetorno.localidade;
        }

        [HttpPost]
        public string Post(Cidade cidade)
        {
            ViaCEP viaCEP = new ViaCEP();
            Cidade cidadeRetorno = viaCEP.BuscarCidade(cidade);
            return cidadeRetorno.localidade;
        }
    }

}
