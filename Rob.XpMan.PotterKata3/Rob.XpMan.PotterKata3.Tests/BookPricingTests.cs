using System;
using NUnit.Framework;

namespace Rob.XpMan.PotterKata3.Tests
{
    ///<summary>
    /// BookPricingTests tests for Potter Kata
    /// Date: 2011-05-21
    /// Author: Robert Stevenson-Leggett
    ///</summary>
    [TestFixture]
    public class BookPricingTests
    {
        [SetUp]
        public void SetUp()
        {
            _price = 0;
        }

        [Test] 
        public void Price_should_be_zero_for_no_books()
        {
            //Act
            decimal price = GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(0));
        }

        [Test]
        public void Price_should_be_8_for_one_book_2()
        {
            //Arrange
            AddBook(1);

            //Act
            decimal price = GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(8));
        }

        [Test]
        public void Price_should_be_16_for_two_books_2()
        {
            //Arrange
            AddBook(1);
            AddBook(1);

            //Act
            decimal price = GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(16));
        }


        [Test]
        public void Price_should_be_discounted_for_two_different_books()
        {
            //Arrange
            AddBook(1);
            AddBook(2);

            //Act
            decimal price = GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(15.2m));
        }

//        [Test]
//        public void Price_should_be_discounted_for_three_different_books()
//        {
            //Arrange
//            AddBook(1);
//            AddBook(2);
//            AddBook(3);
//
            //Act
//            decimal price = GetPrice();
//
            //Assert
//            Assert.That(price,Is.EqualTo(21.6m));
//        }

        [Test]
        public void Price_should_be_discounted_for_two_different_books_2()
        {
            //Arrange
            AddBook(3);
            AddBook(1);

            //Act
            decimal price = GetPrice();

            //Assert
            Assert.That(price, Is.EqualTo(15.2m));
        }

        private decimal _price = 0;

        private void AddBook(int i)
        {
            _price += 8;
            if (i != 1)
            {
                _price -= 0.8m;
            }

//            if(i == 3)
//            {
//                _price -= 1.6m;
//            }
        }

        private decimal GetPrice()
        {
            return _price;
        }
    }
}