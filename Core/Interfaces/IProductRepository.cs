using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces
{
  public interface IProductRepository
  {
    Task<Product> GetProductByIdAsync(int id);
    //IReadOnly only allows to read from the list, and not other methods related to normal lists
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
  }
}