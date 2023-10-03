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

        public Usuario ObterPorId(string login)
        {
            return new Usuario(){
                Nome = "Vitor", 
                Login = "vitor.lassen",
                Senha = "t+lL5RPpboxFzSPRYideWhLr3pEApCXE683X+k3NiXw=",
                Permissao = "Aluno"
            }; 
        }
    }
}