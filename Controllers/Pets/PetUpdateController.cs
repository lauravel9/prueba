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
    public class PetUpdateController : ControllerBase
    {
        private readonly IPetRepository _petRepository;
        public PetUpdateController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPut("Pet/update{Id}")]
        public void UpdatePet(int Id, [FromBody] Pet pet) => _petRepository.UpdatePet(Id, pet);  
    }
}