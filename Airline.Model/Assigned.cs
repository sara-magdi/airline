using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Assigned
    {
        [Key]
        public int Pass { get; set; }
        public int price { get; set; }
        public DateTime TimeSpent { get; set; }
        public DateTime DeptDateTime { get; set; }
        [ForeignKey("Route")]
        public int RouteId { get; set; }
        [ForeignKey("AirCraftCrew")]
        public int AircraftId { get; set; }

        public virtual Route Route { get; set; }
        public virtual AirCraftCrew AirCraftCrew { get; set; }

    }
}
