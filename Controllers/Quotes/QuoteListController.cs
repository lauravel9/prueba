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
    [ApiController]
    [Route("Quotes/list")]
    public class QuoteListController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;
        public QuoteListController(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository; 
        
        }
        
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quoteRepository.GetAll();
        }
        
    }
}