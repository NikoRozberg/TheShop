using System;
using TheShop.Common;
using TheShop.Service;
using TheShop.Service.ViewModels;

namespace TheShop.App
{
	internal class Program
	{
		private static void Main(string[] args)
		{
            Bootstrap.Start();

            ArticleViewModel article;

            var shopService = Bootstrap.Container.GetInstance<IShopService>();
            var logger = Bootstrap.Container.GetInstance<ILoggerService>();

            article = shopService.OrderArticle(1, 500, 10);
            PrintArticle();

            article = shopService.SellArticle(1, 10);
            PrintArticle();

            article = shopService.GetArticleById(1);
            PrintArticle();

            article = shopService.GetArticleById(12);
            PrintArticle();

            Console.ReadKey();

            void PrintArticle()
            {
                if (article.IsNull())
                {
                    logger.Info(Resources.Article_not_available);
                    return;
                }

                logger.Info(string.Format(Resources.article_ID__, article.Id));
                logger.Info(string.Format(Resources.article_Name__, article.Name));
                logger.Info(string.Format(Resources.article_Price__, article.Price));
                logger.Info(string.Format(Resources.article_is_sold__, article.IsSold));
                if (article.IsSold) logger.Info(string.Format(Resources.article_buyer_id__, article.BuyerId));
            }
        }
	}
}