namespace Projet6_NexaWorks.Models
{
    public class OperatingSystemVersion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public int AppOperatingSystemId { get; set; }
        public AppOperatingSystem AppOperatingSystem { get; set; }
    }
}
