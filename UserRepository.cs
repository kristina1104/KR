class UserRepository : IUserRepository
{
    private List<User> users = new List<User>();

    public void Add(User user) => users.Add(user);
    public User Get(int id) => users.FirstOrDefault(u => u.Id == id);
    public List<User> GetAll() => users;
}

class ProductRepository : IProductRepository
{
    private List<Product> products = new List<Product>();

    public void Add(Product product) => products.Add(product);
    public Product Get(int id) => products.FirstOrDefault(p => p.Id == id);
    public List<Product> GetAll() => products;
}

class PurchaseRepository : IPurchaseRepository
{
    private List<Purchase> purchases = new List<Purchase>();

    public void Add(Purchase purchase) => purchases.Add(purchase);
    public Purchase Get(int id) => purchases.FirstOrDefault(p => p.Id == id);
    public List<Purchase> GetAll() => purchases;
}