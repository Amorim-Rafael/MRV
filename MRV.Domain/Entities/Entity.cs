namespace MRV.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public DateTime DateCreated { get; set; }
    }
}
