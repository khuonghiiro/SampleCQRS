using SampleCQRS.Core;

namespace SampleCQRS.Application
{
    public interface IProductService
    {
        //public List<Product> GetDataAll();

        //public Product GetElementById(int id);

        public void Add(Product product);

        //public void Update(int id, Product product);

        //public Product Delete(int id);
    }
}
