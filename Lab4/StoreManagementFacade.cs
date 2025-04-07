using System;
using System.Collections.ObjectModel;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс, представляющий фасад для управления магазином, упрощающий взаимодействие с подсистемой управления запасами.
    /// </summary>
    public class StoreManagementFacade
    {
        /// <summary>
        /// Экземпляр класса InventoryManagement, представляющий подсистему управления запасами.
        /// </summary>
        private InventoryManagement _inventoryManagement;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StoreManagementFacade"/>.
        /// </summary>
        public StoreManagementFacade()
        {
            _inventoryManagement = new InventoryManagement();
        }

        /// <summary>
        /// Событие, возникающее при изменении запасов на складе. Переадресовывает событие из <see cref="InventoryManagement"/>.
        /// </summary>
        public event EventHandler<string> InventoryChanged
        {
            add { _inventoryManagement.InventoryChanged += value; }
            remove { _inventoryManagement.InventoryChanged -= value; }
        }

        /// <summary>
        /// Добавляет продукт на склад. Обрабатывает исключения, возникающие при добавлении продукта, и выводит сообщение об ошибке в консоль.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <param name="quantity">Количество продукта для добавления.</param>
        public void AddProductToInventory(string productName, int quantity)
        {
            try
            {
                _inventoryManagement.AddProduct(productName, quantity);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при добавлении продукта: {ex.Message}");
            }
        }

        /// <summary>
        /// Удаляет продукт со склада. Обрабатывает исключения, возникающие при удалении продукта, и выводит сообщение об ошибке в консоль.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <param name="quantity">Количество продукта для удаления.</param>
        public void RemoveProductFromInventory(string productName, int quantity)
        {
            try
            {
                _inventoryManagement.RemoveProduct(productName, quantity);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при удалении продукта: {ex.Message}");
            }
        }

        /// <summary>
        /// Проверяет наличие продукта на складе. Обрабатывает исключения, возникающие при проверке продукта, и выводит сообщение об ошибке в консоль.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <returns>Количество продукта на складе. Возвращает 0 в случае ошибки.</returns>
        public int CheckProductAvailability(string productName)
        {
            try
            {
                return _inventoryManagement.CheckProductAvailability(productName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при проверке продукта: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Возвращает список товаров на складе.
        /// </summary>
        /// <returns>ReadOnlyDictionary, содержащий названия товаров и их количество.</returns>
        public ReadOnlyDictionary<string, int> GetInventory()
        {
            return _inventoryManagement.GetInventory();
        }
    }
}