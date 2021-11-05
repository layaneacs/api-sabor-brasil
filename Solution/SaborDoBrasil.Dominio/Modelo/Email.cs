using System;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Email
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }

        public Email(Estoque e)
        {
            Destinatario = "devbrofficial@gmail.com";
            Assunto = $"Quantidade de {e.Ingrediente.Nome} abaixo do esperado!";

            Corpo = $"O ingrediente {e.Ingrediente} possui quantidade atual de {e.QuantidadeAtual}, o que" +
                    $"é abaixo ou igual a quantidade miníma, de {e.QuantidadeMinima}.";

            EnviarEmail(e);
        }

        public void EnviarEmail(Estoque e)
        {
            // O destinatário é sempre "devbrofficial@gmail.com"
        }

        public bool DestinatarioValido()
        {
            var primeiroDigito = this.Destinatario[0];
            var ultimoDigito = this.Destinatario[Destinatario.Length - 1];

            if (!Char.IsLetterOrDigit(primeiroDigito) || !Char.IsLetter(ultimoDigito))
                return false;
            else if (!this.Destinatario.Contains("@") || !this.Destinatario.Contains("."))
                return false;
            else
                return true;
        }

        public bool AssuntoValido()
        {
            return !String.IsNullOrEmpty(this.Assunto);
        }

        public bool CorpoValido()
        {
            return !String.IsNullOrEmpty(this.Corpo);
        }
    }
}
