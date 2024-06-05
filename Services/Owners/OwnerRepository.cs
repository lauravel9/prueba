using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Data;
using Microsoft.EntityFrameworkCore;
using prueba.Services;
using prueba.Controllers;
using prueba.Services.Owners;

namespace prueba.Services.Owners
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly PruebaDbContext _context;
        public OwnerRepository(PruebaDbContext pruebaDbContext)
        {
            _context = pruebaDbContext;
        }


        private readonly List<Owner> _Owners = new List<Owner>();

         public IEnumerable<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }

        public async Task<Owner> CreateOwner(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
            
            return await Task.FromResult(owner);
        }

        

        //update
        // public void UpdateOwner(Owner owner)
        // {
        //     var ownerUpdate = _Owners.Find(b => b.Id == owner.Id);
        //     if (owner != null)
        //     {
        //         ownerUpdate.Id = owner.Id;
        //         ownerUpdate.Names = owner.Names;
        //         ownerUpdate.LastNames = owner.LastNames;
        //         ownerUpdate.Email = owner.Email;
        //         ownerUpdate.Address = owner.Address;
        //         ownerUpdate.Phone = owner.Phone;
        //         ownerUpdate.Status = owner.Status;

        //         _context.Owners.Update(ownerUpdate);
        //         _context.SaveChanges();
        //     }
        //     else
        //     {
        //         throw new KeyNotFoundException("Owner not found");
        //     }
        // }


        public void UpdateOwner (int Id, Owner owner)
        {
            owner.Id = Id;
            _context.Owners.Update(owner);
            _context.SaveChanges();
        }

        //REMOVE
        public void RemoveOwner(int Id)
        {
            var owner = _context.Owners.Find(Id);
            owner.Status = "Desactive";
            _context.Owners.Update(owner);
            _context.SaveChanges();
        }
    }
}