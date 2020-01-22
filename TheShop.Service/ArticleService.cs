using System;
using System.Collections.Generic;
using TheShop.Common;
using TheShop.Model;
using TheShop.Repository;
using TheShop.Service;
using TheShop.Service.Suppliers;
using TheShop.Service.ViewModels;

namespace TheShop.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IEnumerable<ISupplier> _suppliers;

        public ArticleService(IArticleRepository articleRepository, IEnumerable<ISupplier> suppliers)
        {
            _articleRepository = articleRepository;
            _suppliers = suppliers;
        }

        public ArticleViewModel GetFromSuppliers(int id, int maxExpectedPrice)
        {
            Article article = null;

            foreach (var supplier in _suppliers)
            {
                if (!supplier.ArticleInInventory(id)) continue;

                article = supplier.GetArticle(id);
                if (maxExpectedPrice >= article.Price)
                    return ArticleViewModel.CreateViewModel(article);
            }

            return ArticleViewModel.CreateViewModel(article);
        }

        public ArticleViewModel GetById(int id) => ArticleViewModel.CreateViewModel(_articleRepository.GetById(id));

        public void Save(Article article) => _articleRepository.Save(article);
    }
}
