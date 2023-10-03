
using api_auth.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace api_auth.Interfaces
{
    public interface IUsuarioServices
    {
        public Usuario Criar(Usuario usuario);
        public Usuario ObterPorLogin(string login);
        public Usuario Atualizar(Usuario usuario);
        public List<Usuario> Obter();
        public void Deletar(string login);
    }
}
