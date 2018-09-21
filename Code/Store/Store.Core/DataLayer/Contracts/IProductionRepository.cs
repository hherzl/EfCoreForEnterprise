using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.EntityLayer.Production;

namespace Store.Core.DataLayer.Contracts
{
    public interface IProductionRepository : IRepository
    {
        IQueryable<Product> GetProducts(Int32? productCategoryID = null);

        Task<Product> GetProductAsync(Product entity);

        Product GetProductByName(String productName);

        IQueryable<ProductCategory> GetProductCategories();

        ProductCategory GetProductCategory(ProductCategory entity);

        IQueryable<ProductInventory> GetProductInventories(Int32? productID = null, String warehouseID = null);

        ProductInventory GetProductInventory(ProductInventory entity);

        IQueryable<Warehouse> GetWarehouses();

        Task<Warehouse> GetWarehouseAsync(Warehouse entity);
    }
}
