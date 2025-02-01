namespace Projet6_NexaWorks.Models
{
    public class TicketOperatingSystem
    {
        //FK qui forment la clé primaire composite
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int AppOperatingSystemId { get; set; }
        public AppOperatingSystem AppOperatingSystem { get; set; }


    }   
}
