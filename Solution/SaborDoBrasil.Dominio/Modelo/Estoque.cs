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

        public Estoque AlterarQuantidade(int quantidade)
        {
            if (QuantidadeAtual == 0 && quantidade < 0 || (QuantidadeAtual + quantidade < 0))
            {
                return this;
            }

            QuantidadeAtual += quantidade;

            if (AtingiuQuantidadeMinima())
            {
                Email email = new Email();
                email.EnviarEmailAutomaticamente(this);
            }
            else if (ExisteDespedicio())
            {
                Log log = new Log();
                
                log.GerarLog(this);
            }

            return this;
        }
    }
}
