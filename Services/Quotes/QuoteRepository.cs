using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Data;
using Microsoft.EntityFrameworkCore;
using prueba.Services;
using prueba.Controllers;
using prueba.Services.Quotes;

namespace prueba.Services.Quotes
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly PruebaDbContext _context;
        public QuoteRepository(PruebaDbContext pruebaDbContext)
        {
            _context = pruebaDbContext;
        }


        private readonly List<Quote> _Quotes = new List<Quote>();

         public IEnumerable<Quote> GetAll()
        {
            return _context.Quotes.ToList();
        }

        public async Task<Quote> CreateQuote(Quote quote)
        {
            _context.Quotes.Add(quote);
            _context.SaveChanges();
            
            return await Task.FromResult(quote);
        }

        

        //update
        public void UpdateQuote(Quote quote)
        {
            var quoteUpdate = _Quotes.Find(b => b.Id == quote.Id);
            if (quote != null)
            {
                quoteUpdate.Id = quote.Id;
                quoteUpdate.Date = quote.Date;
                quoteUpdate.PetId = quote.PetId;
                quoteUpdate.VetId = quote.VetId;
                quoteUpdate.Descripcion = quote.Descripcion;
                quoteUpdate.Status = quote.Status;

                _context.Quotes.Update(quoteUpdate);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Quote not found");
            }
        }

        //REMOVE
        public void RemoveQuote(int Id)
        {
            var quote = _context.Quotes.Find(Id);
            quote.Status = "Desactive";
            _context.Quotes.Update(quote);
            _context.SaveChanges();
        }
    }
}