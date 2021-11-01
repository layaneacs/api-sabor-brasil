namespace SaborDoBrasil.Dominio.Modelo
{
    public class Estoque: EntidadeBase
    {
        public Ingrediente Ingrediente { get; set; }
        public double QuantidadeAtual { get; set; }
        public double QuantidadeMaxima { get; set; }
        public double QuantidadeMinima { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }


        public Estoque()
        {

        }

        public bool ExisteDespedicio()
        {
            return QuantidadeAtual > QuantidadeMaxima;
        }

        public bool AtingiuQuantidadeMinima()
        {
            return QuantidadeAtual <= QuantidadeMinima;
        }


    }
}
