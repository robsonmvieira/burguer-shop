using BS.CrossCutting.ValueObject;

namespace BS.Domain.Models
{
    public class Client: Entity
    {
        public string Name { get; set; }
        public CPF CPF { get; set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
        public Status Status { get; private set; }
        
        
                
        protected Client()
        {
            
        }
    }
}