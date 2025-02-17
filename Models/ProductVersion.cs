using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projet6_NexaWorks.Models
{
    public class ProductVersion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Version { get; set; }

        //FK
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<TicketProductOperatingSystem> TicketsProductOperatingSystems { get; set; }
    }
}
