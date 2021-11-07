using System;
using System.Collections.Generic;
using SaborDoBrasil.Dominio.Modelo;

namespace SaborDoBrasil.Repositorio
{
    public class LogRepositorio
    {
        // Banco de dados com duas colunas,
        // Id --> Primary Key?
        // Data --> Tipo?

        private static List<Log> db;

        public LogRepositorio()
        {
            db = new List<Log>();
        }

        private void AdicionarLog(Log log)
        {
            db.Add(log);
        }
    }
}
