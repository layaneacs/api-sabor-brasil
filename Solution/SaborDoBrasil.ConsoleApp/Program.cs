using SaborDoBrasil.Dominio.Modelo;


using System;

namespace SaborDoBrasil.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente i = new Ingrediente();
            i.Nome = "Farinha";

            Estoque e = new Estoque();
            e.Ingrediente = i;
            e.QuantidadeAtual = 200;
            e.QuantidadeMaxima = 150;

            if (e.ExisteDespedicio())
            {
                Log l = new Log(e);
            }

            Usuarios u = new Usuarios();
            u.Perfil = Perfil.GERENTE;

            Log.LerLog(DateTime.Today, u);

            Console.ReadKey();

        }
    }
}
