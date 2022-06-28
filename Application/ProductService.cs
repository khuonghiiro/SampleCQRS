using SampleCQRS.Core;

namespace SampleCQRS.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;    

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
