using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockKnock.Model;
using KnockKnock.Process;



// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
     
    public class FibonacciController : Controller
    {

        /// <summary>
        /// Returns the nth fibonacci number
        /// </summary>
        /// <param name="n"></param>
        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get( FibParam obj)
        {
            try
            {
                if (!ModelState.IsValid)
                    return   BadRequest(("The request is invalid."));

                if (obj.n <= 1)
                    return Ok(obj.n);
                else if (obj.n > FibonacciProcess.threshold)
                    return BadRequest();
                else
                    return Ok(new FibonacciProcess().NthFibonacciNumber(obj.n));
            }
            catch (Exception)
            {

                return BadRequest("The request is invalid.");
            }
        }

         


    }
}
