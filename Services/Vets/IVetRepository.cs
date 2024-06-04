using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Services.Vets;

namespace prueba.Services.Vets
{
    public interface IVetRepository
    {
        IEnumerable<Vet> GetAll(); //LIST
        Task<Vet> CreateVet(Vet vet); //CREATE
        void UpdateVet(Vet vet); // UPDATE
        void RemoveVet(int Id); // REMOVE
    }
}