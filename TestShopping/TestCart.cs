using Shopping;
using System;

namespace TestShopping
{
    public class TestCart
    {
        #region private attributes
        private Cart _cart = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _cart = new Cart();
        }

        [Test]
        public void Add_FirstArticle_Success()
        { //given
            //refer to Setup
            Assert.AreEqual(0, _cart.Articles.Count());

            //when
            _cart.Add(GenerateArticles(1));

            //then
            Assert.AreEqual(1, _cart.Articles.Count());
        }
        [Test]
        public void Remove_Article_Success()
        {
            //given
            //refer to Setup
            List<Article> Article = GenerateArticles(30);
            _cart.Add(Article);
            //when
            _cart.Remove(Article);

            //then
            Assert.AreEqual(Article.Count-1, _cart.Articles.Count);
        }
        #region private methods
        private List<Article> GenerateArticles(int amountOfArticles)
        {
            {
                List<Article> articles = new List<Article>();
                for (int i = 0; i < amountOfArticles; i++)
                {
                    articles.Add(new Article());
                }
                return articles;
            }
        }
        #endregion private methods
    }
}