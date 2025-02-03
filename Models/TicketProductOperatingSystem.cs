namespace Projet6_NexaWorks.Models
{
    public class TicketProductOperatingSystem
    {
        //FK
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int AppOperatingSystemId { get; set; }
        public AppOperatingSystem AppOperatingSystem { get; set; }
        public int ProductVersionId { get; set; }
        public ProductVersion ProductVersion { get; set; }
    }   
}
