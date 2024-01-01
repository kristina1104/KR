interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
    List<T> GetAll();
}

interface IStoreService
{
    void AddUser(User user);
    User GetUser(int userId);
    void AddProduct(Product product);
    Product GetProduct(int productId);
    void MakePurchase(User user, Product product, int quantity);
    
}
interface IUserRepository : IRepository<User>
{
}

interface IProductRepository : IRepository<Product>
{
}

interface IPurchaseRepository : IRepository<Purchase>
{
}
