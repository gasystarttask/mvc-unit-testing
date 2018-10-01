namespace MvcUnitTesting.Controllers
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }

        public Product(int id, string v)
        {
            Id = id;
            Name = v;
        }
    }
}