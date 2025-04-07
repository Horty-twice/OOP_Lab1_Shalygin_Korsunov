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
        /// Словарь, хранящий информацию о товарах (название и количество).
        /// </summary>
        private Dictionary<string, int> _inventory = new Dictionary<string, int>();

        /// <summary>
        /// Событие, возникающее при изменении запасов на складе.
        /// </summary>
        public event EventHandler<string> InventoryChanged;

        /// <summary>
        /// Метод для вызова события InventoryChanged.
        /// </summary>
        /// <param name="message">Сообщение, передаваемое вместе с событием.</param>
        protected virtual void OnInventoryChanged(string message)
        {
            InventoryChanged?.Invoke(this, message);
        }

        /// <summary>
        /// Добавляет указанное количество товара на склад.
        /// </summary>
        /// <param name="productName">Название товара.</param>
        /// <param name="quantity">Количество товара для добавления.</param>
        public void AddProduct(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName))
            {
                OnInventoryChanged("Ошибка: Название продукта не может быть пустым или null.");
                return;
            }

            if (quantity <= 0)
            {
                OnInventoryChanged("Ошибка: Количество продукта для добавления должно быть больше 0.");
                return;
            }

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
        /// Удаляет указанное количество товара со склада.
        /// </summary>
        /// <param name="productName">Название товара.</param>
        /// <param name="quantity">Количество товара для удаления.</param>
        public void RemoveProduct(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName))
            {
                OnInventoryChanged("Ошибка: Название продукта не может быть пустым или null.");
                return;
            }

            if (quantity <= 0)
            {
                OnInventoryChanged("Ошибка: Количество продукта для удаления должно быть больше 0.");
                return;
            }

            string productNameLower = productName.ToLower();

            if (!_inventory.ContainsKey(productNameLower))
            {
                OnInventoryChanged($"Ошибка: Продукт '{productName}' не найден на складе.");
                return;
            }

            if (_inventory[productNameLower] < quantity)
            {
                OnInventoryChanged($"Ошибка: Недостаточное количество продукта '{productName}' на складе для удаления.");
                return;
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
        /// Проверяет наличие товара на складе.
        /// </summary>
        /// <param name="productName">Название товара.</param>
        /// <returns>Количество товара на складе. Возвращает 0, если товар не найден.</returns>
        public int CheckProductAvailability(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                OnInventoryChanged("Ошибка: Название продукта не может быть пустым или null.");
                return 0;
            }

            string productNameLower = productName.ToLower();

            if (_inventory.ContainsKey(productNameLower))
            {
                int quantity = _inventory[productNameLower];
                OnInventoryChanged($"На складе {quantity} единиц товара '{productName}'.");
                return quantity;
            }
            else
            {
                OnInventoryChanged($"Товар '{productName}' не найден на складе.");
                return 0;
            }

        }

        /// <summary>
        /// Возвращает список товаров на складе.
        /// </summary>
        /// <returns>ReadOnlyDictionary, содержащий названия товаров и их количество.</returns>
        public ReadOnlyDictionary<string, int> GetInventory()
        {
            return new ReadOnlyDictionary<string, int>(_inventory);
        }
    }
}