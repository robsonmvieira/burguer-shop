using System;

namespace BS.Domain.Models
{
    public class Product: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal? InitialValue { get; set; }
        public decimal PromocionalValue { get; set; }
        public bool Available { get; private set; }
        public Guid CategoryId { get; set; }
        
        public Guid OwnerId { get; set; }
        public Category Category { get; set; }
        public Owner Owner { get; set; }


        public Product()
        {
            
        }
        public Product(string name, string description, string photo, decimal? initialValue, decimal promocionalValue, Guid categoryId, Category category, Owner owner)
        {
            Name = name;
            Description = description;
            Photo = photo;
            InitialValue = initialValue;
            PromocionalValue = promocionalValue;
            Available = true;
            CategoryId = categoryId;
            Category = category;
            Owner = owner;
        }


        public void UnavailableProduct()
        {
            Available = false;
        }
    }
}