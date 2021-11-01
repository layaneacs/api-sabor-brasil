using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SaborDoBrasil.Testes.Modelo
{
    public class EstoqueEntidade
    {
        [Fact]
        public void Verifca_se_quantidade_atual_e_maior_que_a_permitida()
        {

            // Arrange
            var ingrediente = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var estoque = new Estoque();
            estoque.Id = "2";
            estoque.QuantidadeAtual = 12;
            estoque.QuantidadeMaxima = 10;
            estoque.QuantidadeMinima = 2;
            estoque.Ingrediente = ingrediente;


            // Act
            var result = estoque.ExisteDespedicio();
            

            // Assert 
            Assert.True(result);

        }

        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        public void Verifca_se_quantidade_atual_e_menor_ou_igual_a_quantidade_minima(int input)
        {

            // Arrange
            var ingrediente = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var estoque = new Estoque();
            estoque.Id = "2";
            estoque.QuantidadeAtual = input;
            estoque.QuantidadeMaxima = 10;
            estoque.QuantidadeMinima = 2;
            estoque.Ingrediente = ingrediente;


            // Act
            var result = estoque.AtingiuQuantidadeMinima();


            // Assert 
            Assert.True(result);

        }
    }
}
