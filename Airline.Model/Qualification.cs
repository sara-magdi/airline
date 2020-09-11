using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }
        public string Qualifications { get; set; }
    }
}
