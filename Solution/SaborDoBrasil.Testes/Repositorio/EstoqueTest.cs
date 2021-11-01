using SaborDoBrasil.Dominio.Modelo;
using SaborDoBrasil.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SaborDoBrasil.Testes.Repositorio
{
    public class EstoqueTest
    {
        [Fact]
        public void Verifica_se_esta_fazendo_update_do_estoque()
        {

            // Arrange
            var repositorio = new EstoqueRepositorio();
            var ingrediente1 = new Ingrediente
            {
                Id = Guid.NewGuid().ToString(),
                Nome = "Farinha",
                Validade = DateTime.Today.AddDays(2)
            };
            var estoque = new Estoque();
            estoque.Id = "2";
            estoque.QuantidadeAtual = 1;
            estoque.QuantidadeMaxima = 10;
            estoque.QuantidadeMinima = 2;
            estoque.Ingrediente = ingrediente1;


            // Act
            repositorio.Cadastrar(estoque);
            repositorio.Update("2", 2);

            // Assert 
            Assert.Equal(3, repositorio.BuscarPorId("2").QuantidadeAtual);

        }
    }
}
