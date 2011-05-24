using NUnit.Framework;

namespace Rob.XpMan.PotterKata.Tests
{
    ///<summary>
    /// BookPricerTests tests for BookPricer
    /// Date: 2011-05-21
    /// Author: Robert Stevenson-Leggett
    ///</summary>
    [TestFixture]
    public class BookPricerTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void BookPricer_should_return_zero_for_an_empty_basket()
        {
            //Arrange
            var bookPricer = new BookPricer();

                //Act
            int price = bookPricer.Price(new int[]{});

            //Assert
            Assert.That(price, Is.EqualTo(0));
        }

        [Test] 
        public void BookPricer_should_return_8_if_the_basket_contains_one_book()
        {
            //Arrange
            var bookPricer = new BookPricer();

            //Act
            int price = bookPricer.Price(new int[] {0});

            //Assert
            Assert.That(price, Is.EqualTo(8));
        }

        [Test]
        [TestCase(0,8)]
        [TestCase(1, 8)]
        [TestCase(2, 8)]
        [TestCase(3, 8)]
        [TestCase(4, 8)]
        public void BookPricer_should_handle_simple_cases(int bookNum, decimal expectedPrice)
        {
            var bookPricer = new BookPricer();

            int price = bookPricer.Price(new[] { bookNum });

            Assert.That(price,Is.EqualTo(expectedPrice));
            
        }

        [Test]
        [TestCase(new[] {0,0}, 16)]
        [TestCase(new[] {1,1,1}, 24)]
        public void BookPricer_should_not_apply_discount_for_multiple_copies_of_the_same_book(int[] books, decimal expectedPrice)
        {
            var bookPricer = new BookPricer();

            int price = bookPricer.Price(books);

            Assert.That(price, Is.EqualTo(expectedPrice));
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}