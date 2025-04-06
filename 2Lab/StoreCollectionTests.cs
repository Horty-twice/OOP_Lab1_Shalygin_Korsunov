using Microsoft.VisualStudio.TestTools.UnitTesting; // Добавляем using для MSTest
using System.Collections.Generic;


namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс тестов для класса StoreCollection.
    /// </summary>
    [TestClass] // Помечаем класс как класс тестов для MSTest
    public class StoreCollectionTests
    {
        /// <summary>
        /// Тест для метода AddStore.
        /// Проверяет, что при добавлении магазина он действительно добавляется в коллекцию.
        /// </summary>
        [TestMethod] // Помечаем метод как тестовый метод для MSTest
        public void AddStore_ValidStore_StoreAddedToCollection()
        {
            // Arrange (Подготовка данных для теста)
            StoreCollection storeCollection = new StoreCollection();
            OnlineStore store = new OnlineStore("Test Store", 10);

            // Act (Выполнение тестируемого метода)
            storeCollection.AddStore(store);

            // Assert (Проверка результата)
            Assert.AreEqual(1, storeCollection.GetAllStores().Count); // Проверяем, что в коллекции 1 элемент
            CollectionAssert.Contains(storeCollection.GetAllStores().Values, store); // Проверяем, что добавленный магазин есть в коллекции
        }

        /// <summary>
        /// Тест для метода RemoveStore.
        /// Проверяет, что при удалении существующего магазина он удаляется из коллекции.
        /// </summary>
        [TestMethod]
        public void RemoveStore_ExistingStore_StoreRemovedFromCollection()
        {
            // Arrange
            StoreCollection storeCollection = new StoreCollection();
            OnlineStore store = new OnlineStore("Test Store", 10);
            storeCollection.AddStore(store);

            // Act
            storeCollection.RemoveStore("Test Store");

            // Assert
            Assert.AreEqual(0, storeCollection.GetAllStores().Count); // Проверяем, что коллекция пуста
        }

        /// <summary>
        /// Тест для метода RemoveStore.
        /// Проверяет, что при попытке удалить несуществующий магазин коллекция остается неизменной.
        /// </summary>
        [TestMethod]
        public void RemoveStore_NonExistingStore_CollectionUnchanged()
        {
            // Arrange
            StoreCollection storeCollection = new StoreCollection();
            OnlineStore store = new OnlineStore("Test Store", 10);
            storeCollection.AddStore(store);

            // Act
            storeCollection.RemoveStore("NonExisting Store");

            // Assert
            Assert.AreEqual(1, storeCollection.GetAllStores().Count); // Проверяем, что коллекция по-прежнему содержит 1 элемент
            CollectionAssert.Contains(storeCollection.GetAllStores().Values, store); // Проверяем, что оригинальный магазин все еще в коллекции
        }

        /// <summary>
        /// Тест для метода GetAllStores.
        /// Проверяет, что метод возвращает все добавленные магазины.
        /// </summary>
        [TestMethod]
        public void GetAllStores_StoresAdded_ReturnsAllStores()
        {
            // Arrange
            StoreCollection storeCollection = new StoreCollection();
            OnlineStore store1 = new OnlineStore("Store 1", 10);
            OnlineStore store2 = new OnlineStore("Store 2", 20);
            storeCollection.AddStore(store1);
            storeCollection.AddStore(store2);

            // Act
            Dictionary<string, OnlineStore> allStores = storeCollection.GetAllStores();

            // Assert
            Assert.AreEqual(2, allStores.Count); // Проверяем количество элементов
            CollectionAssert.Contains(allStores.Values, store1); // Проверяем наличие store1
            CollectionAssert.Contains(allStores.Values, store2); // Проверяем наличие store2
        }
    }
}
