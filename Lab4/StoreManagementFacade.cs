// StoreManagementFacade.cs

using System;
using System.Collections.ObjectModel;

namespace OOP_Lab1_Shalygin_Korsunov
{
    public class StoreManagementFacade
    {
        private InventoryManagement _inventoryManagement;

        public StoreManagementFacade()
        {
            _inventoryManagement = new InventoryManagement();
        }

        // Добавляем обработчик события
        public event EventHandler<string> InventoryChanged
        {
            add { _inventoryManagement.InventoryChanged += value; }
            remove { _inventoryManagement.InventoryChanged -= value; }
        }

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

        public ReadOnlyDictionary<string, int> GetInventory()
        {
            return _inventoryManagement.GetInventory();
        }
    }
}