using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock.Process
{
    public class ReverseWordProcess
    {
         public string seperator = " ";
        //protected char[] separator = { ' ' };


        /// <summary>
        /// Reverses the sentence.
        /// </summary>
        /// <param name="sentence">The sentence.</param>
        /// <returns>Reserve sentence.</returns>
        public string Reverse( string sentence)
        {
           return  (string.Join(seperator,
              sentence.Split(seperator.ToArray())
                 .Select(x => new string(x.Reverse().ToArray()))));

           
        }

    
    }
}
