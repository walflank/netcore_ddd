using CRUD.Application.Interfaces;
using CRUD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Services
{
    public class PistaServices : IPistaService
    {
        public List<PistaViewModel> AllPistas()
        {
            return new List<PistaViewModel>()
            {
                new PistaViewModel(){ id = 1, name="A", description="AAAAAA"},
                new PistaViewModel(){ id = 1, name="B", description="BBBBBB"},
                new PistaViewModel(){ id = 1, name="C", description="CCCCCC"},
              
            };
        }
    }
}
