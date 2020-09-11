using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Model
{
   public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public virtual ICollection<Airline> Airlines { get; set; }
        public Transaction()
        {
            Airlines = new HashSet<Airline>();

        }

    }
}
