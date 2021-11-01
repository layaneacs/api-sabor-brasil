using SaborDoBrasil.Dominio.Modelo;
using System;
using Xunit;

namespace SaborDoBrasil.Testes
{
    public class IngredienteEntidade
    {
        [Fact]
        public void Verifca_se_ingrediente_esta_valido()
        {
            // Arrange
            var ingrediente = new Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            // Act
            var result = ingrediente.EstaValido();

            // Assert 
            Assert.True(result);

        }

        [Fact]
        public void Verifca_se_ingrediente_nao_esta_valido()
        {

            // Arrange
            var ingrediente = new Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(-2)
            };

            // Act
            var result = ingrediente.EstaValido();

            // Assert 
            Assert.False(result);

        }

    }
}
