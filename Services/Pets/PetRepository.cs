using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Data;
using Microsoft.EntityFrameworkCore;
using prueba.Services;
using prueba.Controllers;
using prueba.Services.Pets;

namespace prueba.Services.Pets
{
    public class PetRepository : IPetRepository
    {
        private readonly PruebaDbContext _context;
        public PetRepository(PruebaDbContext pruebaDbContext)
        {
            _context = pruebaDbContext;
        }


        private readonly List<Pet> _Pets = new List<Pet>();

         public IEnumerable<Pet> GetAll()
        {
            return _context.Pets.ToList();
        }

        public async Task<Pet> CreatePet(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            
            return await Task.FromResult(pet);
        }

        

        //update
        public void UpdatePet(Pet pet)
        {
            var petUpdate = _Pets.Find(b => b.Id == pet.Id);
            if (pet != null)
            {
                petUpdate.Id = pet.Id;
                petUpdate.Name = pet.Name;
                petUpdate.Specie = pet.Specie;
                petUpdate.Race = pet.Race;
                petUpdate.DateBirth = pet.DateBirth;
                petUpdate.Photo = pet.Photo;
                petUpdate.Status = pet.Status;
                petUpdate.OwnerId = pet.OwnerId;

                _context.Pets.Update(petUpdate);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Pet not found");
            }
        }

        //REMOVE
        public void RemovePet(int Id)
        {
            var pet = _context.Pets.Find(Id);
            pet.Status = "Desactive";
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }
    }
}