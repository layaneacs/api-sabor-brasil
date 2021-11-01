using SaborDoBrasil.Dominio.Modelo;
using Xunit;
using System;
using System.IO;

namespace SaborDoBrasil.Testes.Modelo
{
    public class LogEntidade
    {
        [Fact]
        public void Verifica_Diretorio_Logs()
        {
            Directory.CreateDirectory(@".\..\..\..\Logs\");

            var diretorioExiste = Directory.Exists(@".\..\..\..\Logs\");
            Assert.True(diretorioExiste);
        }

        [Fact]
        public void Verifica_Se_Log_Existe()
        {
            Ingrediente ingrediente = new Ingrediente();
            
            ingrediente.Nome = "NomeDoIngrediente";
            // Outras propriedades...

            Estoque estoque = new Estoque();

            estoque.Ingrediente = ingrediente;
            estoque.QuantidadeAtual = 200;
            estoque.QuantidadeMaxima = 150;
            // Outras propriedades...

            if (estoque.ExisteDespedicio())
            {
                Log novoLog = new Log(estoque);
            }

            var dia = DateTime.Today.Day;
            var mes = DateTime.Today.Month;
            var ano = DateTime.Today.Year;
            string logName = $"{dia}-{mes}-{ano}-LOG";

            var logExiste = File.Exists(@".\..\..\..\Logs\" + logName + ".txt");
            Assert.True(logExiste);
        }
    }
}
