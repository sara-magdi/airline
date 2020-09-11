using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Airline
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Transaction")]
        public int TransactionId { get; set; }
        [ForeignKey("AirCraftCrew")]
        public int AircraftId { get; set; }
        [ForeignKey("Phone")]
        public int PhoneId { get; set; }



        public virtual Employee Employee { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual AirCraftCrew AirCraftCrew { get; set; }
        public virtual Phone Phone { get; set; }


    }
}
