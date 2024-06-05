using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prueba.Services.Quotes;
using prueba.Models;

namespace prueba.Controllers.Quotes
{
    public class QuoteCreateController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;
        public QuoteCreateController(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository; 
        }
        
        [HttpPost]
        [Route("Quote/create")]
        public IActionResult Create([FromBody] Quote quote)
        {
            _quoteRepository.CreateQuote(quote);
            return Ok();
        }
        
    }
}