using AutoMapper;
using CRUD.Application.Interfaces;
using CRUD.Application.ViewModels;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace CRUD.Application.Services
{
    public class CompetidorService : ICompetidorService
    {
        public ICompetidorRepository competidorRepository;
        private readonly IMapper mapper;
        public CompetidorService(ICompetidorRepository _competidorRepository, IMapper _mapper)
        {
            competidorRepository = _competidorRepository;
            mapper = _mapper;
        }
        public async Task<List<CompetidorViewModel>> SearchAsync(string pesquisa = "")
        {
            List<CompetidorViewModel> Competidor = mapper.Map<List<CompetidorViewModel>>(await competidorRepository.Search(pesquisa));
            return Competidor;
        }

        public async Task<(bool, string)> NewAsync(CompetidorViewModel competidorViewModel)
        {
            Validator.ValidateObject(competidorViewModel, new ValidationContext(competidorViewModel), true);
            Competidor competidor_ = mapper.Map<Competidor>(competidorViewModel);
            return await competidorRepository.New(competidor_);
        }

        public async Task<(bool, string)> UpdateAsync(CompetidorViewModel competidorViewModel)
        {
           
            Competidor competidor_ = mapper.Map<Competidor>(competidorViewModel);
            return await competidorRepository.Update(competidor_);
        }

        public async Task<(bool,string)> DeleteAsync(CompetidorViewModel competidorViewModel)
        {
            return await competidorRepository.Delete(competidorViewModel.con_id);
        }

        public async Task<CompetidorViewModel> SearchByIdAsync(int id)
        {
            return mapper.Map<CompetidorViewModel>(await competidorRepository.SearchById(id));
        }
    }
}
