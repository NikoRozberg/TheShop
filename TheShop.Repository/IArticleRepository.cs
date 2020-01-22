using TheShop.Model;

namespace TheShop.Repository
{
    public interface IArticleRepository
    {
        Article GetById(int id);
        void Save(Article article);
    }
}