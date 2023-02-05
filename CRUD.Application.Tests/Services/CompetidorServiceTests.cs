using AutoMapper;
using CRUD.Application.Services;
using CRUD.Application.ViewModels;
using CRUD.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CRUD.Application.Tests.Services
{
    public class CompetidorServiceTests
    {
        private CompetidorService competidorService;
        public CompetidorServiceTests()
        {
            competidorService = new CompetidorService(new Mock<ICompetidorRepository>().Object, new Mock<IMapper>().Object);
        }

        [Fact]
        public async Task Post_cadastrar_novo_competidor()
        {
            var exception = await Assert.ThrowsAsync<ValidationException>(() => competidorService.NewAsync(new CompetidorViewModel
            {
                //TODO: 
            }));
            Assert.Equal("Error", exception.Message);
        }
        [Fact]
        public void Post_Update_competidor()
        {
            Assert.True(true);
        }
    }
}
