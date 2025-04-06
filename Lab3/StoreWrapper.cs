namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс-обертка для представления информации о магазине в DataGridView.
    /// </summary>
    public class StoreWrapper
    {
        /// <summary>
        /// Получает или задает идентификатор магазина.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Получает или задает название магазина.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает владельца магазина.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Получает или задает тип магазина.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StoreWrapper"/>.
        /// </summary>
        /// <param name="id">Идентификатор магазина.</param>
        /// <param name="name">Название магазина.</param>
        /// <param name="owner">Владелец магазина.</param>
        /// <param name="type">Тип магазина.</param>
        public StoreWrapper(int id, string name, string owner, string type)
        {
            Id = id;
            Name = name;
            Owner = owner;
            Type = type;
        }
    }
}