﻿namespace SaborDoBrasil.Dominio.Modelo
{
    public class Receita : EntidadeBase
    {
        public Ingrediente Ingrediente { get; set; }
        public int QuantidadeUtilizada { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Prato Prato { get; set; }


        public Receita()
        {

        }



    }
}
