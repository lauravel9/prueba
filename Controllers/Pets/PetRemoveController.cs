using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Models;
using prueba.Services.Pets;

namespace prueba.Controllers.Pets
{
    [Route("[controller]")]
    public class PetRemoveController : ControllerBase
    {
        private readonly IPetRepository _petRepository;
        public PetRemoveController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        [HttpDelete("Pet/remove/{Id}")]
        public IActionResult RemovePet (int Id)
        {
            _petRepository.RemovePet(Id);
            return Ok();
        }
    }
}