using System;
using TheShop.Model;

namespace TheShop.Service.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public bool IsSold { get; set; }

        public DateTime SoldDate { get; set; }

        public int BuyerId { get; set; }


        public static ArticleViewModel CreateViewModel(Article article)
        {
            if (article != null)
            {
                return new ArticleViewModel()
                {
                    Id = article.Id,
                    Name = article.Name,
                    Price = article.Price,
                    IsSold = article.IsSold,
                    SoldDate = article.SoldDate,
                    BuyerId = article.BuyerId
                };
            }
            else
            {
                return null;
            }
        }

        public static Article CreateModel(ArticleViewModel article)
        {
            return new Article()
            {
                Id = article.Id,
                Name = article.Name,
                Price = article.Price,
                IsSold = article.IsSold,
                SoldDate = article.SoldDate,
                BuyerId = article.BuyerId
            };

        }
    }
}
