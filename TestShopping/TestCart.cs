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
            Assert.That(_cart.Articles.Count(), Is.EqualTo(0));

            //when
            _cart.Add(ArticleGenerator.Generate(1));

            //then
            Assert.That(_cart.Articles.Count(), Is.EqualTo(1));
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

<<<<<<< HEAD
            //then
            Assert.AreEqual(Article.Count-1, _cart.Articles.Count);
        }
        #region private methods
        private List<Article> GenerateArticles(int amountOfArticles)
=======
        [Test]
        public void Remove_EmptyCartyWithArticles_Success()
>>>>>>> 3d62fb8148117bd090250751686ac183e100f39d
        {
            //given
            //refer to Setup
            int amountOfArticlesToRemove = 10;
            _cart.Add(ArticleGenerator.Generate(amountOfArticlesToRemove));
            Assert.AreEqual(amountOfArticlesToRemove, _cart.Articles.Count());

            //when
            _cart.Remove((null));

            //then
            Assert.AreEqual(0, _cart.Articles.Count());
        }
    }
}