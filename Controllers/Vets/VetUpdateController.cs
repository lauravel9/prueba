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
    public class VetUpdateController : ControllerBase
    {
        private readonly IVetRepository _vetRepository;
        public VetUpdateController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository;
        }

        [HttpPut("Vet/update{Id}")]
        public void UpdateVet(int Id, [FromBody] Vet vet) => _vetRepository.UpdateVet(Id, vet);    
    }
}