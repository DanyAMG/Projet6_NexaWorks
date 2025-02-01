namespace Projet6_NexaWorks.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }

        //FK
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductVersionId { get; set; }
        public ProductVersion ProductVersion { get; set; }
        public ICollection<TicketOperatingSystem> TicketsOperatingSystems { get; set; }
        public ICollection<Date> Dates { get; set; }
    }
}
