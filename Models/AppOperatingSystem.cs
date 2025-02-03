namespace Projet6_NexaWorks.Models
{
    public class AppOperatingSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TicketProductOperatingSystem> TicketsProductOperatingSystems { get; set; }
    }
}
