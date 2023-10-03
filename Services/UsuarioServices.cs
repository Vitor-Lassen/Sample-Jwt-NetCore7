using api_auth.Interfaces;
using api_auth.Model;

namespace api_auth.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        public Usuario Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Criar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string login)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Obter()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorLogin(string login)
        {
            return new Usuario(){
                Nome = "Vitor", 
                Login = "vitor.lassen",
                Senha = "pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=",
                Permissao = "Professor",
                Interno = true
            }; 
        }
    }
}