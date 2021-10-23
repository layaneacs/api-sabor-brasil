using System;
using System.Collections.Generic;
using System.Text;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Email
    {
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }

        public bool DestinatarioValido()
        {
            // Um email tem o seguinte formato: Nome@Dominio.algo
            // Email não deve começar com nenhum símbolo.
            // Deve terminar com letra (ex: .coM).
            // Deve conter tanto '@' quanto '.'

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
            return !String.IsNullOrEmpty(this.Assunto); // Se for null ou em branco, retornará "false".
        }

        public bool CorpoValido()
        {
            return !String.IsNullOrEmpty(this.Corpo); // Se for null ou em branco, retornará "false".
        }

        // Eu deveria criar um método só para a verificação do "assunto" e do "corpo"?
        // Se sim, eu conseguiria verificar qual dos dois é nulo ou em branco?

        /*public bool AssuntoOuCorpoValidos()
        {
            return !String.IsNullOrEmpty(Assunto) && !String.IsNullOrEmpty(Corpo);
        }*/
    }
}
