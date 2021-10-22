using System;
using SaborDoBrasil.Repositorio;
using Xunit;

namespace SaborDoBrasil.Testes.Repositorio
{
    public class Ingrediente
    {
        [Fact]
        public void Verifca_se_cadastro_esta_funcionando()
        {

            // Arrange
            var repositorio = new IngredienteRepositorio();

            var ingrediente1 = new Dominio.Modelo.Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var ingrediente2 = new Dominio.Modelo.Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            // Act
            repositorio.Cadastrar(ingrediente1);
            repositorio.Cadastrar(ingrediente2);

            // Assert 
            Assert.Equal(2, repositorio.QuantidadeIngredientes());

        }
    }
}
