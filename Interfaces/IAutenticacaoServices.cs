
using api_auth.DTO;

namespace api_auth.Interfaces
{
    public interface IAutenticacaoServices
    {
        bool Autenticar(LoginDTO login);
        string GerarToken(LoginDTO loginDTO);
    }
}
