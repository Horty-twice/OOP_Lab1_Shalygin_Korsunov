using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс тестов для проверки корректной работы класса OnlineStoreBuilder,
    /// реализующего паттерн "Строитель" для создания объектов OnlineStore.
    /// </summary>
    [TestClass]
    public class StoreBuilderTests
    {
        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает название магазина.
        /// </summary>
        [TestMethod]
        public void SetName_ValidName_NameIsSet()
        {
            // Arrange
            string expectedName = "Test Store";
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName(expectedName);
            Store store = builder.Build();

            // Assert
            Assert.AreEqual(expectedName, store._name);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает владельца магазина.
        /// </summary>
        [TestMethod]
        public void SetOwner_ValidOwner_OwnerIsSet()
        {
            // Arrange
            string expectedOwner = "John Doe";
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetOwner(expectedOwner);
            Store store = builder.Build();

            // Assert
            Assert.AreEqual(expectedOwner, store._owner);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает количество посетителей.
        /// </summary>
        [TestMethod]
        public void SetNumberOfVisitors_ValidNumberOfVisitors_NumberOfVisitorsIsSet()
        {
            // Arrange
            int expectedNumberOfVisitors = 100;
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName("test");
            builder.SetOwner("test");
            builder.SetOnlineStoreProperties(expectedNumberOfVisitors, 1, 1, 1, 1);
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(expectedNumberOfVisitors, store.NumberOfVisitors);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает количество товаров.
        /// </summary>
        [TestMethod]
        public void SetNumberOfProducts_ValidNumberOfProducts_NumberOfProductsIsSet()
        {
            // Arrange
            int expectedNumberOfProducts = 50;
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName("test");
            builder.SetOwner("test");
            builder.SetOnlineStoreProperties(1, expectedNumberOfProducts, 1, 1, 1);
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(expectedNumberOfProducts, store.NumberOfProducts);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает ежемесячные покупки.
        /// </summary>
        [TestMethod]
        public void SetMonthlyPurchases_ValidMonthlyPurchases_MonthlyPurchasesIsSet()
        {
            // Arrange
            int expectedMonthlyPurchases = 20;
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName("test");
            builder.SetOwner("test");
            builder.SetOnlineStoreProperties(1, 1, expectedMonthlyPurchases, 1, 1);
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(expectedMonthlyPurchases, store.MonthlyPurchases);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает ежемесячный доход.
        /// </summary>
        [TestMethod]
        public void SetMonthlyRevenue_ValidMonthlyRevenue_MonthlyRevenueIsSet()
        {
            // Arrange
            double expectedMonthlyRevenue = 10000;
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName("test");
            builder.SetOwner("test");
            builder.SetOnlineStoreProperties(1, 1, 1, expectedMonthlyRevenue, 1);
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(expectedMonthlyRevenue, store.MonthlyRevenue);
        }

        /// <summary>
        /// Тест проверяет, что строитель правильно устанавливает годовой доход.
        /// </summary>
        [TestMethod]
        public void SetAnnualRevenue_ValidAnnualRevenue_AnnualRevenueIsSet()
        {
            // Arrange
            double expectedAnnualRevenue = 120000;
            StoreBuilder builder = new StoreBuilder();

            // Act
            builder.SetName("test");
            builder.SetOwner("test");
            builder.SetOnlineStoreProperties(1, 1, 1, 1, expectedAnnualRevenue);
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(expectedAnnualRevenue, store.AnnualRevenue);
        }

        /// <summary>
        /// Тест проверяет, что строитель создает объект с установленными значениями по умолчанию.
        /// </summary>
        [TestMethod]
        public void Build_NoValuesSet_ReturnsObjectWithDefaultValues()
        {
            // Arrange
            StoreBuilder builder = new StoreBuilder();

            // Act
            OnlineStore store = (OnlineStore)builder.Build();

            // Assert
            Assert.AreEqual(string.Empty, store._name);
            Assert.AreEqual(string.Empty, store._owner);
            Assert.AreEqual(0, store.NumberOfVisitors);
            Assert.AreEqual(0, store.NumberOfProducts);
            Assert.AreEqual(0, store.MonthlyPurchases);
            Assert.AreEqual(0, store.MonthlyRevenue);
            Assert.AreEqual(0, store.AnnualRevenue);
        }
    }
}