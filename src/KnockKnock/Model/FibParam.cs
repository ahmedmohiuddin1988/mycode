using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnockKnock.Model
{
    public class FibParam
    {
        [Required]
        public long n { get; set; }
    }
}
