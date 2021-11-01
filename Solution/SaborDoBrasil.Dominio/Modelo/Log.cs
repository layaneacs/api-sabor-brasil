using System;
using System.IO;
using DotNetEssentials.Crypto;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Log
    {
        private string Relatorio { get; set; }

        private static string diretorioLogs = @".\..\..\..\Logs\"; // Pasta onde ficarão armazenados todos os logs.

        public Log(Estoque e)
        {
            Relatorio = DateTime.Now.ToString() + "\n";
            Relatorio += $"Ingrediente = {e.Ingrediente.Nome}; Atual = {e.QuantidadeAtual}; Maximo = {e.QuantidadeMaxima}; Desperdicio = {e.QuantidadeAtual - e.QuantidadeMaxima} ::";

            GerarLog();
        }

        private static void CriarDiretorioLogs()
        {
            if (!Directory.Exists(diretorioLogs))
            {
                Directory.CreateDirectory(diretorioLogs);
            }
        }

        private void GerarLog()
        {
            CriarDiretorioLogs();
            
            string logPath = diretorioLogs + $@"\{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}-LOG.txt";
            string textoEncriptado = CodificarLog(Relatorio);

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine(textoEncriptado); // Tanto criação do Log quanto adição de novos relatórios.
            }
        }

        public static void LerLog(DateTime date, Usuarios user)
        {
            if (user.Perfil == Perfil.GERENTE)
            {
                CriarDiretorioLogs();

                string logPath = diretorioLogs + $@"\{date.Day}-{date.Month}-{date.Year}-LOG.txt";

                if (!File.Exists(logPath))
                {
                    return; // Não mostra nada.
                }

                string[] linhas = File.ReadAllLines(logPath);

                foreach(string linha in linhas)
                {
                    Console.WriteLine(DecodificarLog(linha));
                    Console.WriteLine();
                }
            }
            else
            {
                // Permissão negada.
            }
        }

        private static string CodificarLog(string relatorio)
        {
            return StringCipher.Encrypt(relatorio, "0");
        }

        private static string DecodificarLog(string relatorio)
        {
            return StringCipher.Decrypt(relatorio, "0");
        }
    }
}