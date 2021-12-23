using System.Collections.Generic;

using System.Linq;
using System.Collections.Generic;
using SaborDoBrasil.Repositorio;

namespace SaborDoBrasil.Dominio.Modelo
{
    public class Receita : EntidadeBase
    {
        
        // public Ingrediente Ingrediente { get; set; }
        // public int QuantidadeUtilizada { get; set; }
        
        // public Ingrediente Ingrediente { get; set; }
        // public int QuantidadeUtilizada { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }
        public List<int> QuantidadesIngrediente { get; set; }

        public UnidadeMedida UnidadeMedida { get; set; }
        // public Prato Prato { get; set; }

        public Receita()
        {

        }
    }
}
