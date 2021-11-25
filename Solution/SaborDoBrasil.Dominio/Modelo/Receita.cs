using System.Linq;
using System.Collections.Generic;
using SaborDoBrasil.Repositorio;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Receita : EntidadeBase
    {
        public Dictionary<Ingrediente, int> Ingredientes { get; set; }
        
        // public Ingrediente Ingrediente { get; set; }
        // public int QuantidadeUtilizada { get; set; }
        
        public UnidadeMedida UnidadeMedida { get; set; }
        // public Prato Prato { get; set; }

        public Receita()
        {

        }
    }
}
