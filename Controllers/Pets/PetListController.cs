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
    [ApiController]
    [Route("Pets/list")]
    public class PetListController : ControllerBase
    {
       private readonly IPetRepository _petRepository;
        public PetListController(IPetRepository petRepository)
        {
            _petRepository = petRepository; 
        
        }
        
        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return _petRepository.GetAll();
        }
       
    }
}