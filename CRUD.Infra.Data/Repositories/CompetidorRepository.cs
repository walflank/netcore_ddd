using CRUD.Domain.DTOs;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces;
using CRUD.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Infra.Data.Repositories
{
    public class CompetidorRepository : ICompetidorRepository
    {
        public AppDbContext context;
        public CompetidorRepository(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<(bool, string)> Update(Competidor competidor_)
        {
            try
            {
                context.Competidor.Update(competidor_);
                await context.SaveChangesAsync();
                return (true, "Competidor Atualizado com sucesso."); // TODO: Criar um mensagem service
            }
            catch (Exception ex)
            {
                return (false, $"Ocorreu um erro interno\n{ex.Message}"); 
            }
        }

        public async Task<List<Competidor>> Search(string pesquisa = "")
        {
            try
            {
                List<Competidor> colecao = await context.Competidor
                     .Where(x => x.name.Contains(pesquisa))
                    .Select(x => new Competidor
                    {
                        //TODO: 
                       
                    })
                    .ToListAsync();
                return colecao;
            }
            catch (Exception ex)
            {
                throw;
                
            }
        }

        public async Task<(bool, string)> Delete(int id)
        {
            try
            {
                Competidor competidor_ = await context.Competidor.FindAsync(id);
                context.Competidor.Remove(competidor_);
                await context.SaveChangesAsync();
                return (true, "Competidor Excluido com sucesso");  // TODO: Criar um mensagem service
            }
            catch (Exception ex)
            {
                return (false, $"Ocorreu um erro interno\n{ex.Message}");  // TODO: Criar um mensagem service
            }
        }

        public async Task<Competidor> SearchById(int id)
        {
            return await context.Competidor.FindAsync(id);
        }

        public async Task<(bool, string)> New(Competidor competidor_)
        {
            try
            {
                context.Competidor.Add(competidor_);
                await context.SaveChangesAsync();
                return (true, "Competidor cadastrado com sucesso");  // TODO: Criar um mensagem service
            }
            catch (Exception ex)
            {
                return (false, $"Ocorreu um erro interno\n{ex.Message}");  // TODO: Criar um mensagem service
            }
        }
    }
}
