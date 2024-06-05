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
    [ApiController]
    [Route("Vet/list")]
    public class VetListController : ControllerBase
    {
        
        private readonly IVetRepository _vetRepository;
        public VetListController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository; 
        
        }
        
        [HttpGet]
        public IEnumerable<Vet> Get()
        {
            return _vetRepository.GetAll();
        }   
    }
}