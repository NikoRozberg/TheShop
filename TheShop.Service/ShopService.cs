using System;
using System.Collections.Generic;
using TheShop.Common;
using TheShop.Model;
using TheShop.Service;
using TheShop.Service.ViewModels;

namespace TheShop
{
    public class ShopService : IShopService
    {
        private readonly ILoggerService _logger;
        private readonly IArticleService _articleService;


        public ShopService(ILoggerService logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public ArticleViewModel OrderArticle(int id, int maxExpectedPrice, int buyerId)
        {            
            _logger.Info(string.Format(Resources.Trying_to_order_article_with_id__and_max_price_less_than__, id, maxExpectedPrice));

            var article = _articleService.GetFromSuppliers(id, maxExpectedPrice);

            if (article.IsNull()) return null;

            _articleService.Save(ArticleViewModel.CreateModel(article));
            _logger.Info(string.Format(Resources.Order_successful_for_article_with_id, id));
            return article;
        }

        public ArticleViewModel SellArticle(int id, int buyerId)
        {
            _logger.Info(string.Format(Resources.Trying_to_sell_article_with_id__, id));

            var article = _articleService.GetById(id);

            if (article.IsNull()) return null;

            article.IsSold = true;
            article.SoldDate = DateTime.Now;
            article.BuyerId = buyerId;

            _articleService.Save(ArticleViewModel.CreateModel(article));
            _logger.Info(string.Format(Resources.Article_with_id__is_sold, article.Id));

            return article;
        }

        public ArticleViewModel GetArticleById(int id) => _articleService.GetById(id);
    }
}
