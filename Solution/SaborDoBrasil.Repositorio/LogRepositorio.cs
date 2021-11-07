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
