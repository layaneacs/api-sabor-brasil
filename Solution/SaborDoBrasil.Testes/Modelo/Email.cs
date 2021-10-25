using SaborDoBrasil.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SaborDoBrasil.Testes.Modelo
{
    public class Email
    {
        [Fact]

        public void Verifica_Se_O_Endereco_De_Email_Esta_Correto()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "Quantidade de Ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.DestinatarioValido();

            // Assert
            Assert.True(resultado); // O resultado esperado é que o email seja válido (true).
        }

        [Fact]
        public void Verifica_Se_Endereco_De_Email_Esta_Incorreto()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficialgmail.com";
            email.Assunto = "Quantidade de Ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.DestinatarioValido();

            // Assert
            Assert.False(resultado); // O resultado esperado é que o email seja inválido (false).
        }

        [Fact]
        public void Verifica_Se_Assunto_Esta_Preenchido()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "Quantidade de Ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.AssuntoValido();

            // Assert
            Assert.True(resultado); // O resultado esperado é que o assunto esteja preenchido (true).
        }

        [Fact]
        public void Verifica_Se_Assunto_Esta_Em_Branco()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = null;
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.AssuntoValido();

            // Assert
            Assert.False(resultado); // O resultado esperado é que o assunto esteja em branco (true).

            // Também funciona com Assunto sendo null.
        }

        [Fact]
        public void Verifica_Se_Corpo_Esta_Preenchido()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "Quantidade de Ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.CorpoValido();

            // Assert
            Assert.True(resultado); // O resultado esperado é que o corpo do email esteja preenchido (true).
        }

        [Fact]
        public void Verifica_Se_Corpo_Esta_Em_Branco()
        {
            // Arrange
            var email = new SaborDoBrasil.Dominio.Modelo.Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "Quantidade de Ingredientes abaixo do esperado.";
            email.Corpo = "";

            // Act
            var resultado = email.CorpoValido();

            // Assert
            Assert.False(resultado); // O resultado esperado é que o corpo do email esteja em branco (false).

            // Também funciona com Corpo sendo null.
        }
    }
}
