using SaborDoBrasil.Dominio.Modelo;
using System;

namespace SaborDoBrasil.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var estoque1 = new Estoque();
            estoque1.Id = 1;
            var usuario = new Usuarios();
            usuario.Perfil = Perfil.GERENTE;
           Console.WriteLine("Hello World!");
        }
    }
}
