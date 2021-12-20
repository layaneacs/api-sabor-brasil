namespace SaborDoBrasil.Dominio.Modelo
{
    public class Usuarios : EntidadeBase
    {
        public string NomeFuncionario { get; set; }
        public int CPF { get; set; }
        public Perfil Perfil { get; set; }
        public Login Login { get; set; }
    }

}

