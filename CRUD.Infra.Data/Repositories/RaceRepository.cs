using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces;
using CRUD.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Infra.Data.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private AppDbContext context;
        public RaceRepository(AppDbContext _context)
        {
            context = _context;
        }
        public  List<Race> Search()
        {
            return  context.Race.ToList();
        }
    }
}
