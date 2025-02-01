namespace Projet6_NexaWorks.Models
{
    public class AppOperatingSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TicketOperatingSystem> TicketsOperatingSystems { get; set; }
        public ICollection<OperatingSystemVersion> OperatingSystemVersions { get; set; }
    }
}
