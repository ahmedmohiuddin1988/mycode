using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnockKnock.Controllers
{
 ///  
    [Route("api/[controller]")]
    

    public class TokenController : Controller
    {/// <summary>
     /// Your token.
     /// </summary>
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return ("64a767e4-8153-4e8d-a3f2-ddc2b9334fd4");
        }

        
    }
}
