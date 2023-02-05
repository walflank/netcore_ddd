using AutoMapper;
using CRUD.Application.Interfaces;
using CRUD.Application.ViewModels;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Services
{
    public class RaceServices : IRaceService
    {

        public IRaceRepository raceRepository;
        private readonly IMapper mapper;
        public RaceServices(IRaceRepository _raceRepository, IMapper _mapper)
        {
            raceRepository = _raceRepository;
            mapper = _mapper;
        }
        public List<RaceViewModel> Search()
        {
            return mapper.Map<List<RaceViewModel>>( raceRepository.Search());
        }
    }
}
