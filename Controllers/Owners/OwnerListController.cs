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
    [ApiController]
    [Route("Owner/list")]
    public class OwnerListController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerListController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository; 
        
        }
        
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return _ownerRepository.GetAll();
        }
    }
}