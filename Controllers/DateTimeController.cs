using Microsoft.AspNetCore.Mvc;

namespace APIdotnet.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateTimeController : ControllerBase
    {
        // GET: api/datetime
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult GetCurrentDateTime()
        {
            var currentDateTime = new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                Time = DateTime.Now.ToString("HH:mm:ss")
            };
            return Ok(currentDateTime);
        }

        [HttpGet("Apresentar/{nome}")]
         public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo";
            return Ok(new{mensagem});
        }
    }
}
