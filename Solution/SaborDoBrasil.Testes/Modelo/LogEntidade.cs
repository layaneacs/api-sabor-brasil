using System;
using SaborDoBrasil.Dominio.Modelo;
using SaborDoBrasil.Repositorio;
using Xunit;
namespace SaborDoBrasil.Testes.Modelo
{
    public class LogEntidade
    {
        [Fact]
        public void Verifica_Leitura_Com_Usuario_Igual_Gerente()
        {
            // Arrange

            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = "NomeDoIngrediente";

            Estoque e = new Estoque();

            e.Ingrediente = ingrediente;
            e.QuantidadeMaxima = 150;
            e.QuantidadeAtual = 200;

            Log l = new Log();

            // Act
            l.GerarLog(e);
            var result = l.LerLog(l.Id, new Usuarios { Perfil = Perfil.GERENTE});

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verifica_Leitura_Com_Usuario_Diferente_De_Gerente()
        {
            // Arrange

            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = "NomeDoIngrediente";

            Estoque e = new Estoque();

            e.Ingrediente = ingrediente;
            e.QuantidadeMaxima = 150;
            e.QuantidadeAtual = 200;

            Log l = new Log();

            // Act
            l.GerarLog(e);
            var result = l.LerLog(l.Id, new Usuarios { Perfil = Perfil.ESTOQUISTA });

            // Assert
            Assert.False(result);
        }
    }
}
