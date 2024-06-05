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
    public class OwnerUpdateController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerUpdateController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpPut("Owner/update{Id}")]
        public void UpdateOwner(int Id, [FromBody] Owner owner) => _ownerRepository.UpdateOwner(Id, owner);
    }
}