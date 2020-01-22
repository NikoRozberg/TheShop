using TheShop.Model;
using TheShop.Service.ViewModels;

namespace TheShop
{
    public interface IShopService
    {
        ArticleViewModel GetArticleById(int id);
        ArticleViewModel OrderArticle(int id, int maxExpectedPrice, int buyerId);
        ArticleViewModel SellArticle(int id, int buyerId);
    }
}