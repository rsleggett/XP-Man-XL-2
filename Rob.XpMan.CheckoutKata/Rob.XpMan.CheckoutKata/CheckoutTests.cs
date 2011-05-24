using NUnit.Framework;

namespace Rob.XpMan.CheckoutKata
{
    ///<summary>
    /// CheckoutTests tests for Checkout
    /// Date: 2011-05-21
    /// Author: Robert Stevenson-Leggett
    ///</summary>
    [TestFixture]
    public class CheckoutTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void GetTotal_With_ItemD_In_Basket_Returns_15_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.D);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(15));
        }

        [Test]
        public void GetTotal_With_ItemC_In_Basket_Returns_20_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.C);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(20));
        }

        [Test]
        public void GetTotal_With_ItemB_In_Basket_Returns_30_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.B);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(30));
        }

        [Test]
        public void GetTotal_With_Two_Of_ItemC_Returns_40_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.C);
            checkout.AddItem(bee.C);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(40));
        }

        [Test]
        public void GetTotal_With_Two_Of_ItemB_Returns_50_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(50));
        }

        [Test]
        public void GetTotal_With_Three_Of_ItemB_Returns_80_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(80));
        }


        [Test]
        public void GetTotal_With_Three_Of_ItemB_Returns_100_Cents()
        {
            //Arrange
            var checkout = new Checkout();
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);
            checkout.AddItem(bee.B);

            //Act
            int totalPrice = checkout.GetTotal();

            //Assert
            Assert.That(totalPrice, Is.EqualTo(100));
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}