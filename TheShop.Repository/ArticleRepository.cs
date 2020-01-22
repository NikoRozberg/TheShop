using System.Collections.Generic;
using System.Linq;
using TheShop.Model;

namespace TheShop.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly List<Article> _articles = new List<Article>();

        public Article GetById(int id) => _articles.FirstOrDefault(x => x.Id == id);

        public void Save(Article article) => _articles.Add(article);
    }
}
