using CRUD.Domain.DTOs;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Interfaces
{
    public interface ICompetidorRepository
    {
        Task<List<Competidor>> Search(string pesquisa);
        Task<Competidor> SearchById(int id);
        Task<(bool, string)> Delete(int id);
        Task<(bool, string)> Update(Competidor competidor_);
        Task<(bool, string)> New(Competidor competidor_);

    }
}
