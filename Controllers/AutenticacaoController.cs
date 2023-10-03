
using api_auth.DTO;
using api_auth.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_auth.Controllers
{
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoServices _autenticacaoService;

        public AutenticacaoController(IAutenticacaoServices autenticacaoServices)
        {
            _autenticacaoService = autenticacaoServices;
        }

        [HttpPost("logar")]
        [AllowAnonymous]
        public IActionResult Logar(LoginDTO loginDTO)
        {
            if (!_autenticacaoService.Autenticar(loginDTO)) 
                return Unauthorized("Usuario ou Senha inválidos");

            string token = _autenticacaoService.GerarToken(loginDTO);
            return Ok(token);

        }
    }
}
