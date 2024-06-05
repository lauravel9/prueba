using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Services.Pets;
using prueba.Models;

namespace prueba.Controllers.Pets
{
    public class PetCreateController : ControllerBase
    {   
        private readonly IPetRepository _petRepository;
        public PetCreateController(IPetRepository petRepository)
        {
            _petRepository = petRepository; 
        }
        
        [HttpPost]
        [Route("Pet/create")]
        public IActionResult Create([FromBody] Pet pet)
        {
            _petRepository.CreatePet(pet);
            return Ok();
        }
        
    }
}