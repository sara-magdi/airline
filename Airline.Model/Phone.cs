using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Phone
    {
        [Key]
        public int PhoneId { get; set; }

        public string PhoneNumber { get; set; }
    }
}
