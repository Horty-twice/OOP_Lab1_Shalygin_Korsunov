using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс, управляющий запасами товаров на складе.
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// Словарь, хранящий информацию о товарах и их количестве на складе. 
        /// Ключ - название товара (в нижнем регистре), значение - количество.
        /// </summary>
        private Dictionary<string, int> _inventory;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InventoryManagement"/>.
        /// </summary>
        public InventoryManagement()
        {
            _inventory = new Dictionary<string, int>();
        }

        /// <summary>
        /// Событие, возникающее при изменении запасов на складе (добавлении или удалении товара).
        /// </summary>
        public event EventHandler<string> InventoryChanged;

        /// <summary>
        /// Вызывает событие <see cref="InventoryChanged"/>.
        /// </summary>
        /// <param name="message">Сообщение, передаваемое вместе с событием.</param>
        protected virtual void OnInventoryChanged(string message)
        {
            InventoryChanged?.Invoke(this, message);
        }

        /// <summary>
        /// Добавляет продукт на склад или увеличивает его количество, если он уже существует.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <param name="quantity">Количество продукта для добавления.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если название продукта пустое или количество не положительное.</exception>
        public void AddProduct(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("Название продукта не может быть пустым или null.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Количество продукта для добавления должно быть больше 0.");
            }

            // Приводим название товара к нижнему регистру для сравнения
            string productNameLower = productName.ToLower();

            if (_inventory.ContainsKey(productNameLower))
            {
                _inventory[productNameLower] += quantity;
                OnInventoryChanged($"Добавлен продукт: {productName}, Количество: {quantity}. Общее количество: {_inventory[productNameLower]}");
            }
            else
            {
                _inventory.Add(productNameLower, quantity);
                OnInventoryChanged($"Добавлен продукт: {productName}, Количество: {quantity}. Общее количество: {_inventory[productNameLower]}");
            }
        }

        /// <summary>
        /// Удаляет продукт со склада или уменьшает его количество, если он существует.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <param name="quantity">Количество продукта для удаления.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если название продукта пустое, количество не положительное, товара нет на складе или недостаточно товара для удаления.</exception>
        public void RemoveProduct(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("Название продукта не может быть пустым или null.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Количество продукта для удаления должно быть больше 0.");
            }

            // Приводим название товара к нижнему регистру для сравнения
            string productNameLower = productName.ToLower();

            if (!_inventory.ContainsKey(productNameLower))
            {
                throw new ArgumentException($"Продукт '{productName}' не найден на складе.");
            }

            if (_inventory[productNameLower] < quantity)
            {
                throw new ArgumentException($"Недостаточное количество продукта '{productName}' на складе для удаления.");
            }

            _inventory[productNameLower] -= quantity;

            if (_inventory[productNameLower] == 0)
            {
                _inventory.Remove(productNameLower);
                OnInventoryChanged($"Продукт '{productName}' удален со склада, так как его количество стало 0.");
            }
            else
            {
                OnInventoryChanged($"Удален продукт: {productName}, Количество: {quantity}. Остаток: {_inventory[productNameLower]}");
            }
        }

        /// <summary>
        /// Проверяет наличие продукта на складе.
        /// </summary>
        /// <param name="productName">Название продукта.</param>
        /// <returns>Количество продукта на складе. Если продукта нет, возвращает 0.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если название продукта пустое.</exception>
        public int CheckProductAvailability(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("Название продукта не может быть пустым или null.");
            }

            // Приводим название товара к нижнему регистру для сравнения
            string productNameLower = productName.ToLower();

            if (_inventory.ContainsKey(productNameLower))
            {
                return _inventory[productNameLower];
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Возвращает копию списка товаров на складе для отображения.
        /// </summary>
        /// <returns>ReadOnlyDictionary, содержащий названия товаров и их количество.</returns>
        public ReadOnlyDictionary<string, int> GetInventory()
        {
            Dictionary<string, int> displayInventory = new Dictionary<string, int>();
            foreach (var item in _inventory)
            {
                displayInventory.Add(item.Key.ToString(), item.Value);
            }
            return new ReadOnlyDictionary<string, int>(displayInventory);
        }
    }
}