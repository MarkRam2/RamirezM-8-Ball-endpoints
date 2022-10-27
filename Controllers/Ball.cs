using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RamirezM_8_Ball.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ballcontroller : ControllerBase
    {
        public string responce(){
        Random rndNum = new Random();
int Rnum = rndNum.Next(0, 9);


string[] Res = { "no", "yes", "not really", "that would be a good idea", "possibly", "ask again", "absolutly not", "might be your best idea", "ask your mom", "ask your dad" };

return (Res[Rnum]);
        }
    }
}