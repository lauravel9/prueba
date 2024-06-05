using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Models;
using prueba.Services.Quotes;

namespace prueba.Controllers.Quotes
{
    
    public class QuoteRecoverController : ControllerBase
    {
        private readonly IQuoteRepository _quotesRepository;
        public QuoteRecoverController(IQuoteRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }
        [HttpPut("Quote/Recover/{Id}")]
        public IActionResult RecoverQuote (int Id)
        {
            _quotesRepository.RecoverQuote(Id);
            return Ok();
        }
    }
}