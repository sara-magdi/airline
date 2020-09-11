using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Route
    {
        [Key]
        public int RouteId { get; set; }
        public string Origin { get; set; }
        public string Distination { get; set; }
        public string Classification { get; set; }
        public string Distance { get; set; }
        public virtual ICollection<Assigned> Assigneds { get; set; }
        public Route()
        {
            Assigneds = new HashSet<Assigned>();
        }

    }
}
