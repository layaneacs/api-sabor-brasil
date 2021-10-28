using System;
using System.IO;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Log
    {
        /*
         
        Resumo de tudo até aqui:

        - No método de cadastro, se (Quantidade Atuual > Quantidade Maxima), um novo objeto do tipo Log é criado.
        - Quando o novo objeto é criado, automáticamente um arquivo com toda a descrição do log é criado.
        - Assim, o log é criado!
        - O nome do arquivo é em função da data em que se cria o log.
        - Há um e somente um diretório em que vão todos os logs criados.
        - Caso o diretório não exista, será criado.

        */

        private string Relatorio { get; set; }

        private static string diretorioLogs = @".\..\..\..\Logs\"; // Pasta onde ficarão armazenados todos os logs.

        public Log(Estoque e)
        {
            Relatorio = DateTime.Now.ToString() + "\n";
            Relatorio += $"Ingrediente = {e.Ingrediente.Nome}; Atual = {e.QuantidadeAtual}; Maximo = {e.QuantidadeMaxima}; Desperdicio = {e.QuantidadeAtual - e.QuantidadeMaxima} :: \n";

            GerarLog();
        }

        private static void CriarDiretorioLogs()
        {
            if (!Directory.Exists(diretorioLogs))
                Directory.CreateDirectory(diretorioLogs);
        }

        private void GerarLog()
        {
            string logPath = diretorioLogs + $@"\{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}-LOG.txt";

            CriarDiretorioLogs();

            using (StreamWriter writer = new StreamWriter(logPath, true))
                writer.WriteLine(Relatorio); // Tanto criação do Log quanto adição de novos relatórios.
        }

        public static void LerLog(DateTime date, Usuarios user)
        {
            if (user.Perfil == Perfil.GERENTE)
            {
                CriarDiretorioLogs();

                string logPath = diretorioLogs + $@"\{date.Day}-{date.Month}-{date.Year}-LOG.txt";

                if (!File.Exists(logPath))
                    return; // Não mostra nada.

                using (StreamReader reader = new StreamReader(logPath))
                    Console.Write(reader.ReadToEnd()); // Dando output. Por enquanto, output no Console.
            }
            else
            {
                // Permissão negada.
            }
        }
    }
}
