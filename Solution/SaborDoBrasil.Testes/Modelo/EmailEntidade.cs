using SaborDoBrasil.Dominio.Modelo;
using Xunit;

namespace SaborDoBrasil.Testes.Modelo
{
    public class EmailEntidade
    {
        [Fact]

        public void Verifica_Se_O_Endereco_De_Email_Esta_Correto()
        {
            // Arrange
            var email = new Email();

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
            var email = new Email();

            email.Destinatario = "devbrofficialgmail.com";
            email.Assunto = "Quantidade de ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            // Act
            var resultado = email.DestinatarioValido();

            // Assert
            Assert.False(resultado); // O resultado esperado é que o email seja inválido (false).
        }

        [Fact]
        public void Verifica_Se_Corpo_Ou_Assunto_Validos()
        {
            // Arrange
            var email = new Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "Quantidade de ingredientes abaixo do esperado.";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            //Act
            var resultado = email.AssuntoOuCorpoValidos();

            // Assert
            Assert.True(resultado); // O resultado é que o corpo e o assunto sejam válidos (true).
        }

        [Fact]
        public void Verifica_Se_Corpo_Ou_Assunto_Invalidos()
        {
            // Arrange
            var email = new Email();

            email.Destinatario = "devbrofficial@gmail.com";
            email.Assunto = "";
            email.Corpo = "A quantidade atual do ingrediente (Estoque.Ingrediente.Nome) está abaixo do minímo, que é de (Estoque.QuantidadeMinima).";

            //Act
            var resultado = email.AssuntoOuCorpoValidos();

            // Assert
            Assert.False(resultado); // O resultado é que o corpo ou o assunto sejam inválidos (false).
        }
    }
}
