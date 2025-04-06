namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Интерфейс для строителя объектов Store.
    /// </summary>
    public interface IStoreBuilder
    {
        /// <summary>
        /// Устанавливает владельца магазина.
        /// </summary>
        /// <param name="owner">Владелец магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        IStoreBuilder SetOwner(string owner);

        /// <summary>
        /// Устанавливает название магазина.
        /// </summary>
        /// <param name="name">Название магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        IStoreBuilder SetName(string name);

        /// <summary>
        /// Устанавливает тип магазина (Online или Offline).
        /// </summary>
        /// <param name="storeType">Тип магазина.</param>
        /// <returns>Интерфейс строителя для цепочки вызовов.</returns>
        IStoreBuilder SetStoreType(string storeType); // Добавлено

        /// <summary>
        /// Создает объект Store на основе установленных параметров.
        /// </summary>
        /// <returns>Созданный объект Store.</returns>
        Store Build();
    }
}