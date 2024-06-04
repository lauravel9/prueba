using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Data;
using Microsoft.EntityFrameworkCore;
using prueba.Services;
using prueba.Controllers;
using prueba.Services.Owner;

namespace prueba.Services.Owner
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly PruebaDbContext _context;
        public OwnerRepository(PruebaDbContext pruebaDbContext)
        {
            _context = pruebaDbContext;
        }
        private readonly List<Owner> _Owners = new List<Owner>();

        //LIST
        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }

        
        //CREATE
        public async Task<Owner> CreateOwner(Owner owner);
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
            
            return await Task.FromResult(owner);
        }


        //UPDATE
        public void updatedOwner(Owner owner);
        {
            var ownerUpdate = _Owners.Find(b => b.Id == owner.Id);
            if (owner != null)
            {
                ownerUpdate.Id = Owner.Id;
                ownerUpdate.Names = Owner.Names;
                ownerUpdate.LastNames= Owner.LastNames;
                ownerUpdate.Email = Owner.Email;
                ownerUpdate.Address = Owner.Address;
                ownerUpdate.Phone = Owner.Phone;
                ownerUpdate.Status = Owner.Status;

                _context.Owners.Update(ownerUpdate);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("owner not found");
            }
        }

        //REMOVE
        public void RemoveOwner (int Id);
        {
            var owner = _context.Owners.Find(Id);
            owner.Status = "Desactive;
            _context.Owners.Update(owner);
            _context.SaveChanges();
        }
    }
}