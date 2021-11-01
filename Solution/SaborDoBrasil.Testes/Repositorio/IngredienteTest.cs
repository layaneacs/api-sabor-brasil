using System;
using SaborDoBrasil.Dominio.Modelo;
using SaborDoBrasil.Repositorio;
using Xunit;

namespace SaborDoBrasil.Testes.Repositorio
{
    public class IngredienteTest
    {
        [Fact]
        public void Verifica_se_esta_gravando_dados()
        {

            // Arrange
            var repositorio = new IngredienteRepositorio();

            var ingrediente1 = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var ingrediente2 = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            
            // Act
            repositorio.Cadastrar(ingrediente1);
            repositorio.Cadastrar(ingrediente2);

            // Assert 
            Assert.Equal(2, repositorio.BuscarTodos().Count);

        }
        [Fact]
        public void Verifica_se_busca_por_id()
        {
            var repositorio = new IngredienteRepositorio();

            var id = Guid.NewGuid().ToString();
            var ingrediente1 = new Ingrediente
            {
                Id = id,
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var ingrediente2 = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Leite",
                Validade = DateTime.Today.AddDays(2)
            };

            repositorio.Cadastrar(ingrediente2);
            repositorio.Cadastrar(ingrediente1);

            var result = repositorio.BuscarPorId(id);

            Assert.Equal("Farinha", result.Nome);

        }

        [Fact]
        public void Verifica_se_esta_deletando_dados()
        {

            // Arrange
            var repositorio = new IngredienteRepositorio();

            var id = Guid.NewGuid().ToString();
            var ingrediente = new Ingrediente
            {

                Id = id,
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            // Act
            repositorio.Cadastrar(ingrediente);
            repositorio.Delete(id);

            // Assert 
            Assert.Empty(repositorio.BuscarTodos());

        }
    }
}
