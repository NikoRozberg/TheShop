using TheShop.Model;
using TheShop.Service.ViewModels;

namespace TheShop.Service
{
    public interface IArticleService
    {
        ArticleViewModel GetById(int id);
        ArticleViewModel GetFromSuppliers(int id, int maxExpectedPrice);
        void Save(Article article);
    }
}