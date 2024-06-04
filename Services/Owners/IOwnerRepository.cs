using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prueba.Models;

namespace prueba.Services.Owner
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll(); //LIST
        Task<Owner> CreateOwner(Owner owner); //CREATE
        void updatedOwner(Owner owner); // UPDATE
        void RemoveOwner (int Id); // REMOVE
    }
}