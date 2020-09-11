using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(30)]
        public string EmployeeName { get; set; }
        [MaxLength(70)]
        public string Address { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int year { get; set; }
        [MaxLength(30)]
        public string Position { get; set; }
        [Required]
        public string Gender { get; set; }
        [ForeignKey("Qualification")]
        public int QualificationId { get; set; }
        public virtual Qualification Qualification { get; set; }

        public virtual ICollection<Airline> Airlines { get; set; }
        public Employee()
        {
            Airlines = new HashSet<Airline>();
        }
    }
}
