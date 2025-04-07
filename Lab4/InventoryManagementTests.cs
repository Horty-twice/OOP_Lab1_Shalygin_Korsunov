using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;

namespace OOP_Lab1_Shalygin_Korsunov.Tests // Укажите пространство имен для тестов
{
    /// <summary>
    /// Класс, содержащий тесты для класса <see cref="InventoryManagement"/>.
    /// </summary>
    [TestClass]
    public class InventoryManagementTests
    {
        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.AddProduct"/> добавляет продукт с валидными данными.
        /// </summary>
        [TestMethod]
        public void AddProduct_ValidInput_ProductAdded()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Стул";
            int quantity = 5;

            // Act
            inventory.AddProduct(productName, quantity);
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(quantity, actualQuantity, "Продукт не был добавлен.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.AddProduct"/> увеличивает количество существующего продукта.
        /// </summary>
        [TestMethod]
        public void AddProduct_ExistingProduct_QuantityIncreased()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Стол";
            int initialQuantity = 3;
            int additionalQuantity = 2;
            inventory.AddProduct(productName, initialQuantity);

            // Act
            inventory.AddProduct(productName, additionalQuantity);
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(initialQuantity + additionalQuantity, actualQuantity, "Количество продукта не увеличилось.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.AddProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если название продукта пустое.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddProduct_EmptyProductName_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "";
            int quantity = 5;

            // Act
            inventory.AddProduct(productName, quantity);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.AddProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если количество продукта равно нулю.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddProduct_ZeroQuantity_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Книга";
            int quantity = 0;

            // Act
            inventory.AddProduct(productName, quantity);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> удаляет продукт с валидными данными.
        /// </summary>
        [TestMethod]
        public void RemoveProduct_ValidInput_ProductRemoved()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Кресло";
            int initialQuantity = 5;
            int quantityToRemove = 3;
            inventory.AddProduct(productName, initialQuantity);

            // Act
            inventory.RemoveProduct(productName, quantityToRemove);
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(initialQuantity - quantityToRemove, actualQuantity, "Количество продукта не уменьшилось.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> полностью удаляет продукт со склада, если удаляется все его количество.
        /// </summary>
        [TestMethod]
        public void RemoveProduct_RemoveAllQuantity_ProductRemovedFromInventory()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Диван";
            int quantity = 5;
            inventory.AddProduct(productName, quantity);

            // Act
            inventory.RemoveProduct(productName, quantity);
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(0, actualQuantity, "Продукт не был удален полностью.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если продукт не найден на складе.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveProduct_ProductNotFound_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Тумбочка";
            int quantityToRemove = 3;

            // Act
            inventory.RemoveProduct(productName, quantityToRemove);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если удаляется больше, чем есть на складе.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveProduct_NotEnoughQuantity_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Шкаф";
            int initialQuantity = 2;
            int quantityToRemove = 5;
            inventory.AddProduct(productName, initialQuantity);

            // Act
            inventory.RemoveProduct(productName, quantityToRemove);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если название продукта пустое.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveProduct_EmptyProductName_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "";
            int quantityToRemove = 3;

            // Act
            inventory.RemoveProduct(productName, quantityToRemove);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.RemoveProduct"/> выбрасывает исключение <see cref="ArgumentException"/>, если количество продукта для удаления равно нулю.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveProduct_ZeroQuantity_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Лампа";
            int quantityToRemove = 0;
            inventory.AddProduct(productName, 5);

            // Act
            inventory.RemoveProduct(productName, quantityToRemove);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.CheckProductAvailability"/> возвращает правильное количество продукта, если продукт существует на складе.
        /// </summary>
        [TestMethod]
        public void CheckProductAvailability_ProductExists_ReturnsQuantity()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Зеркало";
            int quantity = 10;
            inventory.AddProduct(productName, quantity);

            // Act
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(quantity, actualQuantity, "Неверное количество продукта.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.CheckProductAvailability"/> возвращает 0, если продукта не существует на складе.
        /// </summary>
        [TestMethod]
        public void CheckProductAvailability_ProductDoesNotExist_ReturnsZero()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "Ковер";

            // Act
            int actualQuantity = inventory.CheckProductAvailability(productName);

            // Assert
            Assert.AreEqual(0, actualQuantity, "Должен вернуться 0.");
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.CheckProductAvailability"/> выбрасывает исключение <see cref="ArgumentException"/>, если название продукта пустое.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckProductAvailability_EmptyProductName_ThrowsArgumentException()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName = "";

            // Act
            inventory.CheckProductAvailability(productName);
        }

        /// <summary>
        /// Тест проверяет, что метод <see cref="InventoryManagement.GetInventory"/> возвращает корректный список товаров и их количество.
        /// </summary>
        [TestMethod]
        public void GetInventory_ReturnsCorrectInventory()
        {
            // Arrange
            InventoryManagement inventory = new InventoryManagement();
            string productName1 = "Стол";
            int quantity1 = 5;
            string productName2 = "Стул";
            int quantity2 = 3;

            inventory.AddProduct(productName1, quantity1);
            inventory.AddProduct(productName2, quantity2);

            // Act
            ReadOnlyDictionary<string, int> actualInventory = inventory.GetInventory();

            // Assert
            Assert.AreEqual(2, actualInventory.Count, "Неверное количество элементов в инвентаре.");
            Assert.AreEqual(quantity1, actualInventory[productName1.ToLower()], "Неверное количество товара 'Стол'."); // Проверяем с учетом toLower()
            Assert.AreEqual(quantity2, actualInventory[productName2.ToLower()], "Неверное количество товара 'Стул'."); // Проверяем с учетом toLower()
        }
    }
}