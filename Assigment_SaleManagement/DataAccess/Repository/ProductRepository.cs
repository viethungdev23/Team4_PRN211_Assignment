using DataAccess.Models;
using DataAccess.Repository;

namespace DataAccess.Repository;
public class ProductRepository : IProductRepository
{
    private readonly SaleManagementContext _db;
    public ProductRepository() {
        _db = new();
    }
    public void CreateMember(Product product)
    {
        if (product is not null)
        {
            this._db.Products.Add(product);
            this._db.SaveChanges();
        }
    }

    public bool Delete(int productId)
    {
        Product? product = GetProductById(productId);
        _db.Remove(product);
        return _db.SaveChanges() > 0;
    }

    public IEnumerable<Product> GetAllProduct()
    {
        return _db.Products.ToList();
    }

    public Product GetProductById(int productId)
    {
        return this._db.Products
            .Where(c => c.ProductId.Equals(productId))
            .FirstOrDefault();
    }

    public List<Product> GetProducts() => _db.Products.ToList();

    public void Update(Product c)
    {
        if (c is not null)
        {

            var product = _db.Products.First(g => g.ProductId.Equals(c.ProductId));
            _db.Entry(product).CurrentValues.SetValues(c);
            _db.SaveChanges();
        }
    }
}
