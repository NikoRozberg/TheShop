using TheShop.Model;

namespace TheShop.Service.Suppliers
{
    public interface ISupplier
    {
        bool ArticleInInventory(int id);
        Article GetArticle(int id);
    }
}