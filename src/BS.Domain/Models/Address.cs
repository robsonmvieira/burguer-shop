namespace BS.Domain.Models
{
    public class Address: Entity
    {
        public string Street { get; set; }
        public string neighborhood { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string References { get; set; }
    }
    
    
}