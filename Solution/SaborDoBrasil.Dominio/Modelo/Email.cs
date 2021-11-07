using System;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Email
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }

        public Email()
        {

        }

        public void EnviarEmailAutomaticamente(Estoque e)
        {
            Destinatario = "devbrofficial@gmail.com";
            Assunto = $"Quantidade de {e.Ingrediente.Nome} abaixo do esperado!";

            Corpo = $"O ingrediente {e.Ingrediente} possui quantidade atual de {e.QuantidadeAtual}, o que" +
                    $"é abaixo ou igual a quantidade miníma, de {e.QuantidadeMinima}.";

            // Enviar Email
        }

        public void EnviarEmailPersonalizado(Estoque e, string assunto, string corpo)
        {
            if (!AssuntoOuCorpoValidos())
            {
                return;
            }

            Destinatario = "devbrofficial@gmail.com";
            Assunto = assunto;
            Corpo = corpo;
            
            // Enviar Email
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

        public bool AssuntoOuCorpoValidos()
        {
            return !String.IsNullOrEmpty(this.Assunto) && !String.IsNullOrEmpty(this.Corpo);
        }

        /*
        public bool AssuntoValido()
        {
            return !String.IsNullOrEmpty(this.Assunto);
        }

        public bool CorpoValido()
        {
            return !String.IsNullOrEmpty(this.Corpo);
        }
        */
    }
}
