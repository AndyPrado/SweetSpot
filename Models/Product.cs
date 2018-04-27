using System.Collections.Generic;

namespace SweetSpot.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description  { get; set; }
        public string Image { get; set; }
        public List<Ingredients> Ingredients { get; private set; }
        

        public Product(int id, string name, decimal price, string description, string image, List<Ingredients> ingredients)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Image = image;
            this.Ingredients = ingredients;
        }
    }
}