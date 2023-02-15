using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Minha_Primeira_API_API.Models;


namespace Minha_Primeira_API_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Tatyana de Alencar Jacques");
        }

        [HttpGet ("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(id + " Tatyana de Alencar Jacques");
        }
        
        [HttpPost]
        public ActionResult<Objeto> Post (Objeto obj)
        {
            return Ok(obj.ValorrA + obj.ValorB);
        }        
        
        [HttpPut]
        public ActionResult<PessoaObj> Put (PessoaObj pessoa)
        {   
            return Ok($"Nome {pessoa.Nome} - Data Nascimento {pessoa.DataNascimento}");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            List<Pessoa> Pessoas = new List<Pessoa>
            { 
                new Pessoa (1, "João"),
                new Pessoa (2, "Maria"),
                new Pessoa (3, "Davi"),
                new Pessoa (4,"Mariana")
            
            };
            var pessoaEscolhida = Pessoas.Where(p => p.Id== id).FirstOrDefault();
            Pessoas.Remove(pessoaEscolhida);

            string pessoasListadas = "Lista de pessoas: ";
            foreach (Pessoa pessoa in Pessoas)
            {
                pessoasListadas+= pessoa.ToString() + " ";
            }

            return Ok($@"Pessoa deletada com sucesso! " + pessoasListadas);
 
        }
    }
}
