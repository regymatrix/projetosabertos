using System.Collections.Generic;
using System.Threading.Tasks;
using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
      [ApiController]
    [Route("[controller]")]
    public class CalculadoraController :ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Valor>>> RetanguloArea(){
            List<Valor> valores =   new List<Valor>();
            Valor v = new Valor();
            v.indice=1;
            v.valor=2;
            valores.Add(v);
            return valores;
        }
            [HttpGet]
            [Route("R2")]
           public async Task<ActionResult<List<Valor>>> RetanguloArea2(){
            List<Valor> valores =   new List<Valor>();
            Valor v = new Valor();
            v.indice=1;
            v.valor=2;
            valores.Add(v);
            return valores;
        }

          [HttpGet]
           [Route("R3")]
           public async Task<ActionResult<string>> RetanguloArea3(string[] valores){
           
            return "56";
            
           }
        
    }
}