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
            repositorio.Cadastrar(ingrediente1, Perfil.ESTOQUISTA);
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

            repositorio.Cadastrar(ingrediente2, Perfil.ESTOQUISTA);
            repositorio.Cadastrar(ingrediente1, Perfil.ESTOQUISTA);

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
            var result = repositorio.Cadastrar(ingrediente, Perfil.ESTOQUISTA);
            repositorio.Delete(id);

            // Assert 
            Assert.Empty(repositorio.BuscarTodos());
            Assert.NotNull(result);

        }
        [Fact]
        public void Verifica_se_nao_cadastra_caso_seja_diferente_de_cozinheiro_ou_estoquista()
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
            var result = repositorio.Cadastrar(ingrediente, Perfil.GARCOM);            

            // Assert 
            Assert.Null(result);

        }


    }
}
