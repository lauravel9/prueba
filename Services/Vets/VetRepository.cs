using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Data;
using Microsoft.EntityFrameworkCore;
using prueba.Services;
using prueba.Controllers;
using prueba.Services.Vets;

namespace prueba.Services.Vets
{
    public class VetRepository : IVetRepository
    {
        private readonly PruebaDbContext _context;
        public VetRepository(PruebaDbContext pruebaDbContext)
        {
            _context = pruebaDbContext;
        }


        private readonly List<Vet> _Vets = new List<Vet>();

         public IEnumerable<Vet> GetAll()
        {
            return _context.Vets.ToList();
        }

        public async Task<Vet> CreateVet(Vet vet)
        {
            _context.Vets.Add(vet);
            _context.SaveChanges();
            
            return await Task.FromResult(vet);
        }

        

        //update
        // public void UpdateVet(Vet vet)
        // {
        //     var vetUpdate = _Vets.Find(b => b.Id == vet.Id);
        //     if (vet != null)
        //     {
        //         vetUpdate.Id = vet.Id;
        //         vetUpdate.Name = vet.Name;
        //         vetUpdate.Phone = vet.Phone;
        //         vetUpdate.Address = vet.Address;
        //         vetUpdate.Email = vet.Email;
        //         vetUpdate.Status = vet.Status;

                
        //         _context.Vets.Update(vetUpdate);
        //         _context.SaveChanges();
        //     }
        //     else
        //     {
        //         throw new KeyNotFoundException("Vet not found");
        //     }
        // }
        public void UpdateVet (int Id, Vet vet)
        {
            vet.Id = Id;
            _context.Vets.Update(vet);
            _context.SaveChanges();
        }

        //REMOVE
        public void RemoveVet(int Id)
        {
            var vet = _context.Vets.Find(Id);
            vet.Status = "Desactive";
            _context.Vets.Update(vet);
            _context.SaveChanges();
        }
    }
}