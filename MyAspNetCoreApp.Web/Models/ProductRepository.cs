namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {


        new() { Id = 1, Name = "kalem", Price = 113, Stock = 500 },
        new () { Id = 2, Name = "kalem2", Price = 123, Stock = 2600 },
        new () { Id = 3, Name = "kalem3", Price = 813, Stock = 2020 }

        };



        public List<Product> GetAll() => _products;
        public void Add(Product newProduct)=>_products.Add(newProduct);   
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id{id}'ye sahip ürün bulunmamaktadır");
            }

            _products.Remove(hasProduct);


        }
        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id{updateProduct.Id}'ye sahip ürün bulunmamaktadır");
            }

            hasProduct.Name= updateProduct.Name;
            hasProduct.Price= updateProduct.Price;
            hasProduct.Stock= updateProduct.Stock;

            var index = _products.FindIndex(x=> x.Id == updateProduct.Id);

            _products[index]=hasProduct;

        }
    }
}
