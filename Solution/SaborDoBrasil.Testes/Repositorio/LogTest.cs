using System;
using System.Collections.Generic;
using System.Text;
using SaborDoBrasil.Repositorio;
using SaborDoBrasil.Dominio.Modelo;
using Xunit;

namespace SaborDoBrasil.Testes.Repositorio
{
    public class LogTest
    {
        [Fact]
        public void Verifica_Se_Log_Foi_Registrado()
        {
            // Arrange
            LogRepositorio repositorio = new LogRepositorio();

            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = "NomeDoIngrediente";

            Estoque e = new Estoque();
            
            e.Ingrediente = ingrediente;
            e.QuantidadeMaxima = 150;
            e.QuantidadeAtual = 200;

            Log l = new Log();

            // Act
            l.GerarLog(e);
            var result = repositorio.BuscarPorId(l.Id);

            // Assert
            Assert.Equal(50, result.Desperdicio);
        }
    }
}
