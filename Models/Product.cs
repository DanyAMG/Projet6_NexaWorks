namespace Projet6_NexaWorks.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK
        public ICollection<ProductVersion> ProductVersions { get; set; }
    }
}
