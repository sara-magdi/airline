using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
    public class AirCraftCrew
    {
        [Key]
        public int AircraftId { get; set; }
        public int Capacity { get; set; }
        public string Model  { get; set; }
        public int CrewId { get; set; }
        [MaxLength(30)]
        public string Pilot { get; set; }
        [MaxLength(30)]
        public string Assistant { get; set; }
        [MaxLength(30)]
        public string Hostess1 { get; set; }
        [MaxLength(30)]
        public string Hosstess2 { get; set; }
        public virtual ICollection<Airline> Airlines { get; set; }
        public virtual ICollection<Assigned> Assigneds { get; set; }


        public AirCraftCrew()
        {
            Airlines = new HashSet<Airline>();
            Assigneds = new HashSet<Assigned>();

        }
      
    }
}
