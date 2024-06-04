using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Services.Owner;
using prueba.Models;

namespace prueba.Controllers.Owners
{
    [ApiController]
    [Route("Prueba/list")]
    public class OwnerListController : ControllerBase
    {
       private readonly IOwnerRepository _ownerRepository;
        public OwnerListController(IOwnerRepository citaRepository)
        {
            _ownerRepository = OwnerRepository; 
        
        }
        
        [HttpGet]
        public IEnumerable<Owner> Get()
            {
                return _ownerRepository.GetAll();
            }
    }
}