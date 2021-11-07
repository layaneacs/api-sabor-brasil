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
            Usuarios user = new Usuarios();
            user.Perfil = Perfil.COZINHEIRO;

            repositorio.Cadastrar(estoque, user);
            var getEstoque = repositorio.BuscarPorId("2");
            getEstoque.AlterarQuantidade(4);


            // Act
            repositorio.Update("2", getEstoque);

            // Assert 
            Assert.Equal(5, getEstoque.QuantidadeAtual);
            Assert.Equal(10, getEstoque.QuantidadeMaxima);
        }

        [Fact]
        public void Verifica_se_nao_cadastra_caso_seja_diferente_de_estoquista()
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
            Usuarios user = new Usuarios();
            user.Perfil = Perfil.COZINHEIRO;

            // Act
            var result = repositorio.Cadastrar(estoque, user);

            // Assert 
            Assert.Null(result);
        }
    }
}
