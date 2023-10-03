
namespace api_auth.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Permissao{ get; set; }
        public string Senha { get; set; }
        public bool Interno { get; set; }
    }
}
