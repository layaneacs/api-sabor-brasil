using System;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Log
    {
        public string Id { get; set; }
        public DateTime Data { get; set; }

        public double QuantidadeAtual { get; set; }
        public double QuantidadeMaxima { get; set; }
        public double Desperdicio { get; set; }

        public Log()
        {

        }

        public Log GerarLog(Estoque estoque)
        {
            Id = Guid.NewGuid().ToString();
            Data = DateTime.Today;

            QuantidadeAtual = estoque.QuantidadeAtual;
            QuantidadeMaxima = estoque.QuantidadeMaxima;

            Desperdicio = QuantidadeAtual - QuantidadeMaxima;
            
            // Método de cadastro na db

            return this;
        }
    }
}