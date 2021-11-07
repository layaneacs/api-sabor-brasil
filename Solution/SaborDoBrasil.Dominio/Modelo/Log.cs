using SaborDoBrasil.Repositorio;
using System;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Log
    {
        private readonly LogRepositorio logRepositorio = new LogRepositorio();

        public string Id { get; set; }
        public DateTime Data { get; set; }

        public string IngredienteNome { get; set; }
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

            IngredienteNome = estoque.Ingrediente.Nome;
            QuantidadeAtual = estoque.QuantidadeAtual;
            QuantidadeMaxima = estoque.QuantidadeMaxima;

            Desperdicio = QuantidadeAtual - QuantidadeMaxima;

            logRepositorio.Cadastrar(this);
            return this;
        }

        public bool LerLog(string id, Usuarios user)
        {
            var result = logRepositorio.BuscarPorId(id);

            if (!(user.Perfil == Perfil.GERENTE))
            {
                Console.WriteLine("Perfil não autorizado.");
                return false;
            }
            else if (result is null)
            {
                Console.WriteLine("Log não encontrado.");
                return false;
            }

            Console.WriteLine($"Data: {result.Data.Day}/{result.Data.Month}/{result.Data.Year}");
            Console.WriteLine($"Ingrediente: {result.IngredienteNome}; Quantidade Atual: {result.QuantidadeAtual}; Quantidade Máxima: {result.QuantidadeMaxima}; Desperdício: {result.Desperdicio}");

            return true;
        }
    }
}