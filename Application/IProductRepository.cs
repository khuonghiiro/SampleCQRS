using SampleCQRS.Core;

namespace SampleCQRS.Application
{
    public interface IProductRepository
    {
        Product[] GetProducts();
    }
}
