namespace Projet6_NexaWorks.Models
{
    public class Date
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public bool Type {  get; set; }

        //FK
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
