using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Services.Vets;
using prueba.Models;

namespace prueba.Controllers.Vets
{
    public class VetCreateController : ControllerBase
    {
        private readonly IVetRepository _vetRepository;
        public VetCreateController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository; 
        }
        
        [HttpPost]
        [Route("Vet/create")]
        public IActionResult Create([FromBody] Vet vet)
        {
            _vetRepository.CreateVet(vet);
            return Ok();
        }
        
    }
}