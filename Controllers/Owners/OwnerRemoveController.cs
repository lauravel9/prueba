using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Models;
using prueba.Services.Owners;

namespace prueba.Controllers.Owners
{
    public class OwnerRemoveController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerRemoveController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        [HttpDelete("Owner/remove/{Id}")]
        public IActionResult RemoveOwner (int Id)
        {
            _ownerRepository.RemoveOwner(Id);
            return Ok();
        }
    }
}