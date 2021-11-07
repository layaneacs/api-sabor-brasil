using System;
using System.Collections.Generic;
using System.Linq;
using SaborDoBrasil.Dominio.Modelo;

namespace SaborDoBrasil.Repositorio
{
    public class LogRepositorio
    {
        private static List<Log> db;

        public LogRepositorio()
        {
            db = new List<Log>();
        }

        public Log Cadastrar(Log log)
        {
            db.Add(log);

            return log;
        }

        public List<Log> BuscarTodos()
        {
            return db;
        }

        public Log BuscarPorId(string id)
        {
            return db.FirstOrDefault<Log>(x => x.Id == id);
        }
    }
}
