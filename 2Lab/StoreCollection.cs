using System;//содержит основные классы и типы .NET Framework.
using System.Collections.Generic;//содержит обобщенные коллекции (например, Dictionary, List).
using System.Linq;//добавляет методы расширения для работы с коллекциями (например, Where, ToList).

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс, представляющий коллекцию онлайн-магазинов.
    /// Обеспечивает добавление, удаление, поиск и уведомление об изменениях в коллекции.
    /// </summary>
    class StoreCollection
    {
        /// <summary>
        /// Приватное поле, представляющее словарь (Dictionary) для хранения онлайн-магазинов.
        /// Ключом является название магазина (string), значением - объект OnlineStore.
        /// Используется StringComparer.OrdinalIgnoreCase для нечувствительного к регистру сравнения ключей.
        /// </summary>
        private Dictionary<string, OnlineStore> _stores = new Dictionary<string, OnlineStore>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Делегат для событий, связанных с изменением коллекции онлайн-магазинов.
        /// Принимает два аргумента: объект, вызвавший событие (object) и аргументы события (StoreEventArgs).
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        public delegate void StoreEventHandler(object sender, StoreEventArgs e);

        /// <summary>
        /// Событие, которое вызывается при добавлении нового онлайн-магазина в коллекцию.
        /// </summary>
        public event StoreEventHandler StoreAdded;

        /// <summary>
        /// Событие, которое вызывается при удалении онлайн-магазина из коллекции.
        /// </summary>
        public event StoreEventHandler StoreRemoved;

        /// <summary>
        /// Класс, представляющий аргументы для событий, связанных с изменением коллекции онлайн-магазинов.
        /// Содержит информацию об онлайн-магазине, который был добавлен или удален.
        /// </summary>
        public class StoreEventArgs : EventArgs
        {
            /// <summary>
            /// Объект OnlineStore, связанный с событием.
            /// </summary>
            public OnlineStore Store { get; set; }
        }

        /// <summary>
        /// Метод для добавления нового онлайн-магазина в коллекцию.
        /// </summary>
        /// <param name="store">Объект OnlineStore, который нужно добавить.</param>
        public void AddStore(OnlineStore store)
        {
            _stores.Add(store._name, store); // Добавляем магазин в словарь, используя store._name в качестве ключа
            OnStoreAdded(new StoreEventArgs { Store = store }); // Вызываем событие StoreAdded
        }

        /// <summary>
        /// Метод для удаления онлайн-магазина из коллекции.
        /// </summary>
        /// <param name="storeName">Название магазина, который нужно удалить.</param>
        public void RemoveStore(string storeName)
        {
            if (_stores.ContainsKey(storeName)) // Проверяем, существует ли магазин с указанным названием в коллекции
            {
                OnlineStore store = _stores[storeName]; // Получаем объект OnlineStore по названию
                _stores.Remove(storeName); // Удаляем магазин из словаря
                OnStoreRemoved(new StoreEventArgs { Store = store }); // Вызываем событие StoreRemoved
            }
        }

        /// <summary>
        /// Защищенный виртуальный метод для вызова события StoreAdded.
        /// Позволяет производным классам переопределить логику вызова события.
        /// </summary>
        /// <param name="e">Аргументы события.</param>
        protected virtual void OnStoreAdded(StoreEventArgs e)
        {
            StoreAdded?.Invoke(this, e); // Вызываем событие StoreAdded, если есть подписчики
        }

        /// <summary>
        /// Защищенный виртуальный метод для вызова события StoreRemoved.
        /// Позволяет производным классам переопределить логику вызова события.
        /// </summary>
        /// <param name="e">Аргументы события.</param>
        protected virtual void OnStoreRemoved(StoreEventArgs e)
        {
            StoreRemoved?.Invoke(this, e); // Вызываем событие StoreRemoved, если есть подписчики
        }

        /// <summary>
        /// Метод для получения копии всех онлайн-магазинов в коллекции.
        /// </summary>
        /// <returns>Словарь, содержащий копию всех онлайн-магазинов.</returns>
        public Dictionary<string, OnlineStore> GetAllStores()
        {
            return new Dictionary<string, OnlineStore>(_stores); // Возвращаем копию словаря, чтобы не дать изменить оригинал напрямую
        }
    }
}
