using CRUD.Domain.DTOs;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Interfaces
{
    public interface IPistaRepository
    {
        Task<List<Pista>> Search(string filter);
        Task<Pista> SearchById(int id);
        Task<(bool, string)> Delete(int id);
        Task<(bool, string)> Update(Pista pista);
        Task<(bool, string)> New(Pista pista);

    }
}
