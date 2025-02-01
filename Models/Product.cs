namespace Projet6_NexaWorks.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<ProductVersion> ProductVersions { get; set; }
    }
}
