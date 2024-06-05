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
    public class QuoteUpdateController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;
        public QuoteUpdateController(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        [HttpPut("Quote/update{Id}")]
        public void UpdateQuote(int Id, [FromBody] Quote quote) => _quoteRepository.UpdateQuote(Id, quote);
    }
}