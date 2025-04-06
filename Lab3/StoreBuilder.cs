using System;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Реализация строителя объектов Store.
    /// </summary>
    public class StoreBuilder : IStoreBuilder
    {
        /// <summary>
        /// Внутреннее поле для хранения создаваемого объекта Store.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Внутреннее поле для хранения типа создаваемого магазина (Online или Offline).
        /// </summary>
        private string _storeType;  // Добавлено

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StoreBuilder"/>.
        /// </summary>
        public StoreBuilder()
        {
            _store = new OnlineStore(); // По умолчанию создаем OnlineStore
            _storeType = "Online";
        }

        /// <summary>
        /// Устанавливает владельца магазина.
        /// </summary>
        /// <param name="owner">Владелец магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        public IStoreBuilder SetOwner(string owner)
        {
            _store._owner = owner;
            return this;
        }

        /// <summary>
        /// Устанавливает название магазина.
        /// </summary>
        /// <param name="name">Название магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        public IStoreBuilder SetName(string name)
        {
            _store._name = name;
            return this;
        }

        /// <summary>
        /// Устанавливает тип магазина.
        /// </summary>
        /// <param name="storeType">Тип магазина (Online или Offline).</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        public IStoreBuilder SetStoreType(string storeType)
        {
            _storeType = storeType;
            return this;
        }

        /// <summary>
        /// Устанавливает свойства, специфичные для онлайн-магазина.
        /// </summary>
        /// <param name="numberOfVisitors">Количество посетителей.</param>
        /// <param name="numberOfProducts">Количество товаров.</param>
        /// <param name="monthlyPurchases">Количество ежемесячных покупок.</param>
        /// <param name="monthlyRevenue">Ежемесячный доход.</param>
        /// <param name="annualRevenue">Годовой доход.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        public StoreBuilder SetOnlineStoreProperties(int numberOfVisitors, int numberOfProducts, int monthlyPurchases, double monthlyRevenue, double annualRevenue)
        {
            if (_store is OnlineStore onlineStore)
            {
                onlineStore.NumberOfVisitors = numberOfVisitors;
                onlineStore.NumberOfProducts = numberOfProducts;
                onlineStore.MonthlyPurchases = monthlyPurchases;
                onlineStore.MonthlyRevenue = monthlyRevenue;
                onlineStore.AnnualRevenue = annualRevenue;
            }
            return this;
        }

        /// <summary>
        /// Устанавливает свойства, специфичные для офлайн-магазина.
        /// </summary>
        /// <param name="storeArea">Площадь магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        public IStoreBuilder SetOfflineStoreProperties(double storeArea)
        {
            if (_store is OfflineStore offlineStore)
            {
                offlineStore.StoreArea = storeArea;
            }
            return this;
        }

        /// <summary>
        /// Создает объект Store на основе установленных параметров.
        /// </summary>
        /// <returns>Созданный объект Store.</returns>
        public Store Build()
        {
            if (_storeType == "Online")
            {
                return _store;
            }
            else if (_storeType == "Offline")
            {
                var offlineStore = new OfflineStore();
                offlineStore._name = _store._name;
                offlineStore._owner = _store._owner;
                _store = offlineStore;
                return _store;
            }
            else
            {
                throw new ArgumentException("Invalid store type.");
            }
        }
    }
}