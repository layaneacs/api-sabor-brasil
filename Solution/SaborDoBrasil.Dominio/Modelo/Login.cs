namespace SaborDoBrasil.Dominio.Modelo
{
    public class Login : EntidadeBase
    {
        public Usuarios Usuario { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }
    }
}
