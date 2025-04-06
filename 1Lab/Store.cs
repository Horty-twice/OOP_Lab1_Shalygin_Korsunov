namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Базовый класс для представления магазина.
    /// </summary>
    public abstract class Store
    {
        /// <summary>
        /// Название магазина.
        /// </summary>
        protected internal string _name;

        /// <summary>
        /// Владелец магазина.
        /// </summary>
        protected internal string _owner;

        /// <summary>
        /// Переопределенный метод ToString для представления информации о магазине.
        /// </summary>
        /// <returns>Строковое представление магазина.</returns>
        public override string ToString()
        {
            return $"Название: {_name}, Владелец: {_owner}";
        }
    }
}