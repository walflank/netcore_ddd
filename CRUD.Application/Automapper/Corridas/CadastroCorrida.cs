using AutoMapper;
using CRUD.Application.ViewModels;
using CRUD.Domain.DTOs;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Automapper.Corridas
{
    public class CadastroCorrida: Corrida
    {
        public CadastroCorrida()
        {
            CreateMap<Competidor, CompetidorViewModel>();
            CreateMap<CompetidorViewModel, Competidor>();

            CreateMap<Race, RaceViewModel>();
            CreateMap<RaceViewModel, Race>();

            CreateMap<Competidor, CompetidorViewModel>();
        }
    }
}
