namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Представляет офлайн-магазин, наследуется от базового класса <see cref="Store"/>.
    /// </summary>
    public class OfflineStore : Store
    {
        // Добавьте здесь специфичные для OfflineStore поля, если они есть.
        /// <summary>
        /// Площадь магазина.
        /// </summary>
        private double _storeArea;

        /// <summary>
        /// Получает или задает площадь магазина.
        /// </summary>
        public double StoreArea
        {
            get { return _storeArea; }
            set { _storeArea = value; }
        }

        /// <summary>
        /// Конструктор класса OfflineStore
        /// </summary>
        public OfflineStore() : base()
        {
            _storeArea = 0;
        }

        /// <summary>
        /// Конструктор класса OfflineStore
        /// </summary>
        /// <param name="name">Название магазина.</param>
        /// <param name="owner">Владелец магазина.</param>
        /// <param name="storeArea">Площадь магазина.</param>
        public OfflineStore(string name, string owner, double storeArea) : base()
        {
            _name = name;
            _owner = owner;
            _storeArea = storeArea;
        }

        /// <summary>
        /// Переопределение метода ToString для вывода информации об OfflineStore
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Тип магазина: Offline\n" + base.ToString() + $"\nПлощадь: {_storeArea}";
        }
    }
}