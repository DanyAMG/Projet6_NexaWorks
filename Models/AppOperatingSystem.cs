using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projet6_NexaWorks.Models
{
    public class AppOperatingSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TicketProductOperatingSystem> TicketsProductOperatingSystems { get; set; }
    }
}
