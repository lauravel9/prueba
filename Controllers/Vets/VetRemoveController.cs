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
    public class VetRemoveController : ControllerBase
    {
        private readonly IVetRepository _vetRepository;
        public VetRemoveController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository;
        }
        [HttpDelete("Vet/remove/{Id}")]
        public IActionResult RemoveVet (int Id)
        {
            _vetRepository.RemoveVet(Id);
            return Ok();
        }
    }
}