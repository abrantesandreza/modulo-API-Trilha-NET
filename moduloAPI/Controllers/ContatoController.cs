using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using moduloAPI.Repositories;
using moduloAPI.Models;

namespace moduloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaRepository _dbContext;

        public ContatoController(AgendaRepository dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("CriarContato")]
        public IActionResult Create(Contato contato)
        {
            _dbContext.Add(contato);
            _dbContext.SaveChanges();
            
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _dbContext.Contatos.Find(id);
            
            if (contato == null)
                return NotFound();
                
            return Ok(contato);
        }
    }
}
