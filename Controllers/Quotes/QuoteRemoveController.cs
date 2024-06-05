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
    public class QuoteRemoveController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;
        public QuoteRemoveController(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }
        [HttpDelete("Quote/remove/{Id}")]
        public IActionResult RemoveQuote (int Id)
        {
            _quoteRepository.RemoveQuote(Id);
            return Ok();
        }
    }
}