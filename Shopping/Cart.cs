﻿using System.Globalization;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<Article> articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            
        }

        public void Remove(List<Article> articles)
        {
            throw new NotImplementedException();
        }

        public List<Article> Articles
        {
            get
            {
                return articles;
            }
        }
        #endregion public methods
    }
}
