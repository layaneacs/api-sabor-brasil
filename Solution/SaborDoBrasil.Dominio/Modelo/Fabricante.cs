namespace SaborDoBrasil.Dominio.Modelo
{
    public class Fabricante : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Fabricante()
        {

        }

        public bool NomeValido()
        {
            foreach (char c in Nome)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        public bool TelefoneValido()
        {
            foreach (char c in Nome)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
