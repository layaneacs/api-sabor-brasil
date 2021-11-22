using System;
using SaborDoBrasil.Dominio.Modelo;
using Xunit;

namespace SaborDoBrasil.Testes.Modelo
{
    public class FabricanteEntidade
    {
        [Fact]
        public void Nome_Fabricante_Valido()
        {
            // Arrange
            Fabricante fabricante = new Fabricante();
            
            fabricante.Nome = "VendedorX";
            fabricante.Telefone = "5512984724322";

            // Act
            bool result = fabricante.NomeValido();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Nome_Fabricante_Invalido()
        {
            // Arrange
            Fabricante fabricante = new Fabricante();

            fabricante.Nome = "534-543gger";
            fabricante.Telefone = "5512984724322";

            // Act
            bool result = fabricante.NomeValido();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Telefone_Fabricante_Valido()
        {
            // Arrange
            Fabricante fabricante = new Fabricante();

            fabricante.Nome = "VendedorZ";
            fabricante.Telefone = "5512984724322";

            // Act
            bool result = fabricante.TelefoneValido();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Telefone_Fabricante_Invalido()
        {
            // Arrange
            Fabricante fabricante = new Fabricante();

            fabricante.Nome = "VendedorZ";
            fabricante.Telefone = "5345534j2342";

            // Act
            bool result = fabricante.TelefoneValido();

            // Assert
            Assert.False(result);
        }
    }
}
