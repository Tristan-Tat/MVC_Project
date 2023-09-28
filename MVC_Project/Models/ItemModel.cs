using System.Xml.Linq;

namespace MVC_Project.Models
{
    public class ItemModel
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    public ItemModel(int id, string name, decimal price)
    {
        Id = id; Name = name; Price = price;
    }

        public override string ToString() => $"Item#{Id} / {Name} / {Price}";

    }
}
