using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Services.Pets;

namespace prueba.Services.Pets
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll(); //LIST
        Task<Pet> CreatePet(Pet pet); //CREATE
        void UpdatePet(Pet pet); // UPDATE
        void RemovePet(int Id); // REMOVE
    }
}