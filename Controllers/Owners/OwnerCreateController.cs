using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Services.Owners;
using prueba.Models;


namespace prueba.Controllers.Owners
{
    public class OwnerCreateController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerCreateController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository; 
        }
        
        [HttpPost]
        [Route("Owner/Create")]
        public IActionResult Create([FromBody] Owner owner)
        {
            _ownerRepository.CreateOwner(owner);
            return Ok();
        }
    }
}