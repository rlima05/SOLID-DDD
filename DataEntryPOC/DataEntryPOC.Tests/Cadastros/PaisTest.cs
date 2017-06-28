using DataEntryPOC.Application.Interfaces;
using DataEntryPOC.Domain.Entities;
using DataEntryPOC.Domain.Interfaces.Repositories;
using DataEntryPOC.Domain.Interfaces.Services;
using DataEntryPOC.Domain.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;


namespace DataEntryPOC.Tests
{
    [TestClass]
    public class PaisTest
    {
        Mock<IPaisRepository> mockPaisRepostiroy = new Mock<IPaisRepository>();
        Mock<IPaisAppService> mockPaisAppService = new Mock<IPaisAppService>();
        Mock<IPaisService> mockPaisService = new Mock<IPaisService>();

        [TestMethod]
        public void Inserir_Novo_Pais_Repository()
        {
            var list = new List<Pais>();
            mockPaisRepostiroy.Setup(c => c.Add(It.IsAny<Pais>())).Callback((Pais paisCallback) => list.Add(paisCallback));

        }


        [TestMethod]
        public void Inserir_Novo_Pais_AppService()
        {
            var list = new List<Pais>();
            mockPaisAppService.Setup(c => c.Add(It.IsAny<Pais>())).Callback((Pais paisCallback) => list.Add(paisCallback));
        }

        [TestMethod]
        public void Inserir_Novo_Pais_Service()
        {
            var list = new List<Pais>();
            mockPaisService.Setup(c => c.Add(It.IsAny<Pais>())).Callback((Pais paisCallback) => list.Add(paisCallback));

        }

        [TestMethod]
        public void Selecionar_Todos_Os_Paises_Repository()
        {
            //var mockPais = new Moq.Mock<IPaisRepository>();

            mockPaisRepostiroy.Setup(c => c.GetAll()).Returns(new List<Pais>());
        }

        [TestMethod]
        public void Selecionar_Todos_Os_Paises_AppService()
        {
            mockPaisAppService.Setup(c => c.GetAll()).Returns(new List<Pais>());
        }

        [TestMethod]
        public void Selecionar_Todos_Os_Paises_Service()
        {            
            mockPaisService.Setup(c => c.GetAll()).Returns(new List<Pais>());
        }

        [TestMethod]
        public void Selecionar_Pais_Por_ID_Repository()
        {            
            mockPaisRepostiroy.Setup(c => c.GetById(It.IsAny<int>())).Returns(new Pais());
        }

        [TestMethod]
        public void Selecionar_Pais_Por_ID_AppService()
        {            
            mockPaisAppService.Setup(c => c.GetById(It.IsAny<int>())).Returns(new Pais());
        }

        [TestMethod]
        public void Selecionar_Pais_Por_ID_Service()
        {            
            mockPaisService.Setup(c => c.GetById(It.IsAny<int>())).Returns(new Pais());
        }


        [TestMethod]
        public void Atualizar_Um_Pais_Repository()
        {
            mockPaisRepostiroy.Setup(c => c.Update(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais)); 
        }

        [TestMethod]
        public void Atualizar_Um_Pais_AppService()
        {
            mockPaisAppService.Setup(c => c.Update(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais));
        }


        [TestMethod]
        public void Atualizar_Um_Pais_Service()
        {
            mockPaisService.Setup(c => c.Update(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais));
        }

        [TestMethod]
        public void Deletar_Um_Pais_Repository()
        {
            mockPaisRepostiroy.Setup(c => c.Remove(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais)); 
        }

        [TestMethod]
        public void Deletar_Um_Pais_AppService()
        {
            mockPaisAppService.Setup(c => c.Remove(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais));
        }

        [TestMethod]
        public void Deletar_Um_Pais_Service()
        {
            mockPaisService.Setup(c => c.Remove(It.IsAny<Pais>())).Callback((Pais pais) => new List<Pais>().Add(pais));
        }

 

      
    }
}
