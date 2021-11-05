using System;
using SaborDoBrasil.Dominio.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace SaborDoBrasil.Repositorio
{
    public class LogRepositorio
    {
        private static List<Log> db;

        public LogRepositorio()
        {
            db = new List<Log>();
        }

        public void LerLog(string id, Usuarios user)
        {
            var result = BuscarPorId(id);

            if (!(user.Perfil == Perfil.GERENTE))
            {
                Console.WriteLine("Perfil não autorizado.");
                return;
            }
            else if (result is null)
            {
                Console.WriteLine("Log não encontrado.");
                return;
            }

            Console.WriteLine($"Data: {result.Data.Date}.");
            Console.WriteLine($"Relatório: ");
            Console.WriteLine($"Quantidade Atual: {result.QuantidadeAtual}; Quantidade Máxima: {result.QuantidadeMaxima}; Desperdício: {result.Desperdicio}");
        }

        // Encapsulado na hora da geração do log
        public Log Cadastrar(Log log)
        {
            db.Add(log);

            return log;
        }

        public List<Log> BuscarTodos()
        {
            return db;
        }

        // Encapsulado na hora de ler um log
        private Log BuscarPorId(string id)
        {
            return db.FirstOrDefault<Log>(x => x.Id == id);
        }
    }
}
