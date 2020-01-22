using SimpleInjector;
using TheShop.Repository;
using TheShop.Service;
using TheShop.Service.Suppliers;

namespace TheShop
{
    public class Bootstrap
    {
        public static Container Container;
        public static void Start()
        {
            Container = new Container();

            Container.Register<IArticleRepository, ArticleRepository>();
            Container.Register<ILoggerService, LoggerService>();
            Container.Register<IShopService, ShopService>();
            Container.Register<IArticleService, ArticleService>();
            Container.Collection.Register<ISupplier>(typeof(Supplier1), typeof(Supplier2), typeof(Supplier3));
        }
    }
}
