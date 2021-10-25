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

            // Arrange - entrada de dados, preparação do testes
            // act - ação de fato 
            // assert - resultado esperado

            // Arrange
            var ingrediente = new Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };

            // Act
            var result = ingrediente.Valido();

            // Assert 
            Assert.True(result);

        }

        [Fact]
        public void Verifca_se_ingrediente_esta_vencido()
        {

            // Arrange
            var ingrediente = new Ingrediente
            {
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(-2)
            };

            // Act
            var result = ingrediente.Valido();

            // Assert 
            Assert.False(result);

        }

    }
}
