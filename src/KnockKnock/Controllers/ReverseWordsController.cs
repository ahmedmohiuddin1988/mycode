using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockKnock.Process;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnockKnock.Controllers
{
   
    [Route("api/[controller]")]


    public class ReverseWordsController : Controller
    { /// <summary>
      /// Reverses the letters of each word in a sentence.
      /// </summary>
      /// <param name="sentence"></param>
        // GET: api/values

        // [HttpGet("{sentence:string}")]
        [HttpGet]
        public string Get(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return "";
            return new ReverseWordProcess().Reverse(sentence);
        }

        
    }
}
