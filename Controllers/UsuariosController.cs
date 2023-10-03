using api_auth.DTO;
using api_auth.Interfaces;
using api_auth.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace api_auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController :ControllerBase
    {
        public UsuariosController() 
        {
            
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Post()
        {
            return Ok("Requisição anonima ");
        }
        [HttpPut("{login}")]
        [Authorize(Roles ="Professor")]
        public ActionResult Put()
        {

            return Ok("Acesso somente com a role professor");
        }
        [HttpGet]
        [Authorize(Roles = "Professor,Aluno")]
        public ActionResult Get()
        {
            var nome = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Nome").Value;
            var interno = bool.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Interno").Value);
            if (!interno)
            {
                return Ok("Usuario Externo");
            }

            if(nome == "vitor")
            {
                return Ok("Usuario Bloqueado");
            }

            return Ok("Role Professor ou aluno liberada");
        }
        
       

        [HttpGet("Error")]
        [Authorize(Roles = "Aluno")]
        public ActionResult GetError()
        {
            //apenas role aluno 
            throw new NotImplementedException("Não encontrado");
        }

        [HttpGet("ApenasProfessor")]
        [Authorize(Roles = "Professor")]
        public ActionResult ApenasProfessor()
        {
            return Ok("apenas role professor");
        }

    }
}
