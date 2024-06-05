using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;
using prueba.Services.Owners;


namespace prueba.Services.Owners
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll(); //LIST
        Task<Owner> CreateOwner(Owner owner); //CREATE
        void UpdateOwner(int Id, Owner owner); // UPDATE
        void RemoveOwner(int Id); // REMOVE
    }
}