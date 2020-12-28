using System.Collections.Generic;
using BS.CrossCutting.ValueObject;

namespace BS.Domain.Models
{
    public class Owner: Entity
    {
        public string Name { get; set; }
        public CNPJ CNPJ { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; private set; }
        
        public IList<Product> ProductsList { get; private set; }

        public Owner()
        {
            
        }

        public Owner(string name, int cnpj, Address address, string email, int phone)
        {
            ProductsList = new List<Product>();
            Name = name;
            CNPJ = new CNPJ(cnpj);
            Address = address;
            Email = new Email(email);
            Phone = new Phone(phone);
        }

        public void addProduct(Product product)
        {
            ProductsList.Add(product);
        }

        // public void AlterPhone(int newPhone)
        // {
        //     Phone.Number = Phone.alterNumber(newPhone);
        // }
    }
}