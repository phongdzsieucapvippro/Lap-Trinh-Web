namespace Bai_tap_thuc_hanh.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }  

        public List <Product> GetProductsList()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/noi com.jpg" },
                new Product { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/noi com.jpg"},
                new Product { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/noi com.jpg"},
            };
        }

        public Product GetProductById(int id)
        {
            return GetProductsList().FirstOrDefault(p => p.Id == id);
        }
    }
}
