namespace Projet6_NexaWorks.Models
{
    public class ProductVersion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<TicketProductOperatingSystem> TicketsProductOperatingSystems { get; set; }
    }
}
