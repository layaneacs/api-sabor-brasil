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
            repositorio.Cadastrar(ingrediente1, Perfil.COZINHEIRO);
            repositorio.Cadastrar(ingrediente2, Perfil.ESTOQUISTA);

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

            repositorio.Cadastrar(ingrediente1, Perfil.COZINHEIRO);
            repositorio.Cadastrar(ingrediente2, Perfil.ESTOQUISTA);

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
            repositorio.Cadastrar(ingrediente, Perfil.COZINHEIRO);
            repositorio.Delete(id);

            // Assert 
            Assert.Empty(repositorio.BuscarTodos());
        }

        [Fact]
        public void Verifica_se_nao_grava_dados_se_perfil_diferente_estoquista_ou_cozinheiro()
        {

            // Arrange
            var repositorio = new IngredienteRepositorio();

            var ingrediente = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            // Act
            repositorio.Cadastrar(ingrediente, Perfil.GARCOM);

            // Assert 
            Assert.Empty(repositorio.BuscarTodos());

        }
    }
}
