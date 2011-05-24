using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Rob.XpMan.PotterKata2.Tests
{
    ///<summary>
    /// BasketPricerTests tests for BasketPricer
    /// Date: 2011-05-21
    /// Author: Robert Stevenson-Leggett
    ///</summary>
    [TestFixture]
    public class BasketPricerTests
    {
        private BasketPricer _basketPricer;

        [SetUp]
        public void SetUp()
        {
            _basketPricer = new BasketPricer();
        }

        [Test]
        public void Price_should_return_zero_for_an_empty_basket()
        {
            //Arrange
            var bookArray = new int[0];

                //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Price_should_return_8_for_a_single_book()
        {
            //Arrange
            var bookArray = new[] {0};

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Price_should_return_16_for_2_of_the_same_book()
        {
            //Arrange
            var bookArray = new[] { 0, 0 };

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result,Is.EqualTo(16));
        }

        [Test]
        public void Price_should_return_discounted_value_for_2_different_books()
        {
            //Arrange
            var bookArray = new[] { 0, 1 };

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(15.2m));
        }

        [Test]
        public void Price_should_return_discounted_value_for_3_different_books()
        {
            //Arrange
            var bookArray = new[] { 0, 1, 2 };

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(21.6m));
        }

        [Test]
        public void Price_should_return_discounted_value_for_2_different_and_one_same_books()
        {
            //Arrange
            var bookArray = new[] { 0, 0, 1 };

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(23.2m));
        }

        [Test]
        [TestCase(1, 23.2f)]
        [TestCase(2, 23.2f)]
        [TestCase(3, 23.2f)]
        [TestCase(4, 23.2f)]
        public void Price_should_return_discounted_value_for_any_list_of_books(int numBooks, decimal expectedPrice)
        {
            //Arrange
            var bookArray = GetBooks(numBooks);

            //Act
            decimal result = _basketPricer.Price(bookArray);

            //Assert
            Assert.That(result, Is.EqualTo(expectedPrice));
        }

        private int[] GetBooks(int numbooks)
        {
            var bookList = new List<int>();
            for(int i = 0; i < numbooks; i++)
            {
               bookList.Add(0); 
            }
            return bookList.ToArray();
        }

        [TearDown]
        public void TearDown()
        {
        }
    }

    public class BasketPricer
    {
        private const int BookPrice = 8;

        public decimal Price(int[] books)
        {
            int distinct = books.Distinct().Count();
            int repeated = books.Length - distinct;

            return GetDiscountedPrice(distinct) + repeated * BookPrice;
        }

        private Decimal GetDiscountedPrice(int numBooks)
        {
            var discounts = new Dictionary<int, decimal> {{0,1m},{1,1m},{2, 0.95m}, {3, 0.9m}};
            return (numBooks * BookPrice) * discounts[numBooks];
        }
    }

   
}