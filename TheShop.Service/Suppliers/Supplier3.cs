﻿using TheShop.Common;
using TheShop.Model;

namespace TheShop.Service.Suppliers
{
    public class Supplier3 : ISupplier
    {
        public bool ArticleInInventory(int id) => true;

        public Article GetArticle(int id)
        {
            return new Article
            {
                Id = 1,
                Name = string.Format(Resources.Article_from__, Resources.supplier3),
                Price = 460
            };
        }
    }
}
