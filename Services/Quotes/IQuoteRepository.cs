using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Services.Quotes;


namespace prueba.Services.Quotes
{
    public interface IQuoteRepository
    {
        IEnumerable<Quote> GetAll(); //LIST
        Task<Quote> CreateQuote(Quote quote); //CREATE
        void UpdateQuote(int Id, Quote quote); // UPDATE
        void RemoveQuote(int Id); // REMOVE
        void RecoverQuote (int Id);// STATUS
    }
}