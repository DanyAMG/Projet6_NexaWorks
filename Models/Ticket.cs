using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projet6_NexaWorks.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Status { get; set; } //true = Resolu / False = En Cours
        public string Description { get; set; }
        public string Response { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }

        //FK
        public ICollection<TicketProductOperatingSystem> TicketsProductOperatingSystems { get; set; }
    }
}
