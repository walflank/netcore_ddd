using CRUD.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD.Application.Interfaces
{
    public interface ICompetidorService
    {
        Task<(bool, string)> NewAsync(CompetidorViewModel competidorViewModel);
        Task<(bool, string)> UpdateAsync(CompetidorViewModel competidorViewModel);
        Task<(bool, string)> DeleteAsync(CompetidorViewModel competidorViewModel);
        Task<List<CompetidorViewModel>> SearchAsync(string pesquisa="");

        Task<CompetidorViewModel> SearchByIdAsync(int id);

    }
}
