namespace MRV.Domain.Entities
{
    public sealed class Lead : Entity
    {
        public string? FirstName { get; private set; }
        public string? FullName { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Email { get; private set; }
        public string? Suburb { get; private set; }
        public string? Category { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public bool Accepted { get; set; }

        public Lead() { }

        public Lead(string firstName, string fullName, string phoneNumber, string email, string suburb, string category, string description, decimal price, bool accepted)
        {
            FirstName = firstName;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Suburb = suburb;
            Category = category;
            Description = description;
            Price = price;
            Accepted = accepted;
            DateCreated = DateTime.UtcNow;

            if (price > 500)
                Price -= (price * 0.10m);
        }

        public Lead(int id, string firstName, string fullName, string phoneNumber, string email, string suburb, string category, string description, decimal price, bool accepted)
        {
            Id = id;
            FirstName = firstName;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Suburb = suburb;
            Category = category;
            Description = description;
            Price = price;
            Accepted = accepted;
            DateCreated = DateTime.UtcNow;

            if (price > 500)
                Price -= (price * 0.10m);
        }

        public void UpdateStatus(bool accepted)
        {
            Accepted = accepted;
        }
    }
}
