class StoreService : IStoreService
{
    private IUserRepository userRepository;
    private IProductRepository productRepository;
    private IPurchaseRepository purchaseRepository;

    public StoreService(IUserRepository userRepository, IProductRepository productRepository, IPurchaseRepository purchaseRepository)
    {
        this.userRepository = userRepository;
        this.productRepository = productRepository;
        this.purchaseRepository = purchaseRepository;
    }

    public void AddUser(User user) => userRepository.Add(user);

    public User GetUser(int userId) => userRepository.Get(userId);

    public void AddProduct(Product product) => productRepository.Add(product);

    public Product GetProduct(int productId) => productRepository.Get(productId);

    public void MakePurchase(User user, Product product, int quantity)
    {
        
    }
   
}