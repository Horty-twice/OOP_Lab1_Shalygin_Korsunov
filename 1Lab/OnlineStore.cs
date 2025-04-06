using System;
using System.Runtime.InteropServices; // Для DllImport

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Представляет пользовательский тип исключения, который выбрасывается,
    /// когда недостаточно посетителей для достижения необходимой ежемесячной прибыли.
    /// Наследуется от класса <see cref="Exception"/>.
    /// </summary>
    public class InsufficientVisitorsException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InsufficientVisitorsException"/> с указанным сообщением об ошибке.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        public InsufficientVisitorsException(string message) : base(message) { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InsufficientVisitorsException"/>
        /// с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое является причиной этого исключения.
        /// </summary>
        /// <param name="message">Сообщение, описывающееException) { }

        /// <summary>
        /// Получает или задает количество посетителей, связанное с исключением.
        /// </summary>
        public int NumberOfVisitors { get; set; }

        /// <summary>
        /// Получает или задает ежемесячную прибыль, связанную с исключением.
        /// </summary>
        public double MonthlyRevenue { get; set; }

        /// <summary>
        /// Получает или задает требуемую прибыль на одного посетителя, необходимую для предотвращения исключения.
        /// </summary>
        public double RequiredRevenuePerVisitor { get; set; }
    }

    /// <summary>
    /// Представляет пользовательский тип исключения, который выбрасывается, когда происходит недопустимое приведение типов.
    /// Наследуется от класса <see cref="InvalidCastException"/>.
    /// </summary>
    public class CustomInvalidCastException : InvalidCastException
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomInvalidCastException"/> с указанным сообщением об ошибке.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        public CustomInvalidCastException(string message) : base(message) { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomInvalidCastException"/>
        /// с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое является причиной этого исключения.
        /// </summary>
        ///  <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        /// <param name="innerException">Исключение, которое является причиной текущего исключения, или пустая ссылка, если внутреннее исключение не задано.</param>
        public CustomInvalidCastException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Получает или задает дополнительную информацию об исключении, например, контекст или подробности ошибки.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Получает или задает значение, которое не удалось привести к ожидаемому типу.
        /// </summary>
        public string OffendingValue { get; set; }

        /// <summary>
        /// Получает или задает ожидаемый тип, к которому пытались привести значение.
        /// </summary>
        public Type ExpectedType { get; set; }
    }

    /// <summary>
    /// Представляет онлайн-магазин, наследуется от базового класса <see cref="Store"/>.
    /// </summary>
    public class OnlineStore : Store
    {
        #region Поля
        /// <summary>
        /// Количество посетителей.
        /// </summary>
        protected internal int _numberOfVisitors;

        /// <summary>
        /// Количество продуктов.
        /// </summary>
        protected internal int _numberOfProducts;

        /// <summary>
        /// Количество ежемесячных покупок.
        /// </summary>
        protected internal int _monthlyPurchases;

        /// <summary>
        /// Ежемесячный доход.
        /// </summary>
        protected internal double _monthlyRevenue;

        /// <summary>
        /// Годовой доход онлайн-магазина. Доступно через свойство <see cref="AnnualRevenue"/>.
        /// </summary>
        protected internal double _annualRevenue;

        #endregion

        #region Константы

        /// <summary>
        /// Константа для отображения значка ошибки в MessageBox.
        /// </summary>
        public const uint MB_ICONERROR = 0x00000010;

        /// <summary>
        /// Константа для отображения кнопки "OK" в MessageBox.
        /// </summary>
        public const uint MB_OK = 0x00000000;

        #endregion

        #region Статические поля и свойства

        /// <summary>
        /// Статический счетчик количества созданных объектов <see cref="OnlineStore"/>.
        /// </summary>
        private static int _objectCount = 0;

        /// <summary>
        /// Возвращает общее количество созданных объектов <see cref="OnlineStore"/>.
        /// </summary>
        public static int ObjectCount => _objectCount;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OnlineStore"/> с значениями по умолчанию.
        /// </summary>
        public OnlineStore() : base() // Используем конструктор базового класса
        {
            _numberOfVisitors = 0;
            _numberOfProducts = 0;
            _monthlyPurchases = 0;
            _monthlyRevenue = 0;
            _annualRevenue = 0;
            _objectCount++;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OnlineStore"/> с указанным именем.
        /// </summary>
        /// <param name="name">Название онлайн-магазина.</param>
        public OnlineStore(string name) : base()
        {
            _numberOfVisitors = 0;
            _numberOfProducts = 0;
            _monthlyPurchases = 0;
            _monthlyRevenue = 0;
            _annualRevenue = 0;
            _name = name;

            _objectCount++;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OnlineStore"/> с указанным именем и количеством товаров.
        /// </summary>
        /// <param name="name">Название онлайн-магазина.</param>
        /// <param name="numerOfProducts">Количество товаров в онлайн-магазине.</param>
        public OnlineStore(string name, int numerOfProducts) : base()
        {
            _numberOfVisitors = 0;
            _monthlyPurchases = 0;
            _monthlyRevenue = 0;
            _annualRevenue = 0;

            _name = name;
            _numberOfProducts = numerOfProducts;

            _objectCount++;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OnlineStore"/> со всеми параметрами.
        /// </summary>
        /// <param name="owner">Владелец онлайн-магазина.</param>
        /// <param name="name">Название онлайн-магазина.</param>
        /// <param name="numerOfVisitors">Количество посетителей онлайн-магазина.</param>
        /// <param name="numerOfProducts">Количество товаров в онлайн-магазине.</param>
        /// <param name="monthlyPurchases">Количество ежемесячных покупок в онлайн-магазине.</param>
        /// <param name="monthlyRevenue">Ежемесячная прибыль онлайн-магазина.</param>
        /// <param name="annualRevenue">Годовой доход онлайн-магазина.</param>
        public OnlineStore(string owner, string name, int numerOfVisitors, int numerOfProducts,
            int monthlyPurchases, double monthlyRevenue, double annualRevenue) : base()
        {
            _owner = owner;
            _name = name;
            _numberOfVisitors = numerOfVisitors;
            _numberOfProducts = numerOfProducts;
            _monthlyPurchases = monthlyPurchases;
            _monthlyRevenue = monthlyRevenue;
            _annualRevenue = annualRevenue;

            _objectCount++;
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Получает или задает количество посетителей онлайн-магазина.
        /// </summary>
        public int NumberOfVisitors
        {
            get { return _numberOfVisitors; }
            internal set { _numberOfVisitors = value; }
        }

        /// <summary>
        /// Получает или задает количество товаров в онлайн-магазине.
        /// </summary>
        public int NumberOfProducts
        {
            get { return _numberOfProducts; }
            internal set { _numberOfProducts = value; }
        }

        /// <summary>
        /// Получает или задает количество ежемесячных покупок в онлайн-магазине.
        /// </summary>
        public int MonthlyPurchases
        {
            get { return _monthlyPurchases; }
            internal set { _monthlyPurchases = value; }
        }

        /// <summary>
        /// Получает или задает ежемесячную прибыль онлайн-магазина.
        /// </summary>
        public double MonthlyRevenue
        {
            get { return _monthlyRevenue; }
            internal set { _monthlyRevenue = value; }
        }

        /// <summary>
        /// Получает или задает годовой доход онлайн-магазина.
        /// </summary>
        public double AnnualRevenue
        {
            get { return _annualRevenue; }
            internal set { _annualRevenue = value; }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Переопределяет метод <see cref="object.ToString"/> для возврата строкового представления объекта <see cref="OnlineStore"/>,
        /// включающего значения всех его полей.
        /// </summary>
        /// <returns>Строка, представляющая объект <see cref="OnlineStore"/>.</returns>
        public override string ToString()
        {
            return $"Тип магазина: Online\n" + base.ToString() + "\n" + // Используем ToString базового класса
                   $"Число посетителей: {_numberOfVisitors}\n" +
                   $"Число продуктов: {_numberOfProducts}\n" +
                   $"Месячное число покупок: {_monthlyPurchases}\n" +
                   $"Денежный оборот в месяц: {_monthlyRevenue}\n" +
                   $"Денежный оборот в год: {_annualRevenue}";
        }

        /// <summary>
        /// Выводит в консоль информацию о владельце онлайн-магазина.
        /// </summary>
        public string DisplayOwner()
        {
            return $"Основатель: {_owner}";
        }

        /// <summary>
        /// Выводит в консоль название онлайн-магазина.
        /// </summary>
        public string DisplayName()
        {
            return $"Название: {_name}";
        }

        /// <summary>
        /// Выводит в консоль количество посетителей онлайн-магазина.
        /// </summary>
        public string DisplayNumberOfVisitors()
        {
            return $"Число посетителей: {_numberOfVisitors}";
        }

        /// <summary>
        /// Выводит в консоль количество продуктов в онлайн-магазине.
        /// </summary>
        public string DisplayNumberOfProducts()
        {
            return $"Число продуктов: {_numberOfProducts}";
        }

        /// <summary>
        /// Выводит в консоль количество ежемесячных покупок в онлайн-магазине.
        /// </summary>
        public string DisplayMonthlyPurchases()
        {
            return $"Число покупок в месяц: {_monthlyPurchases}";
        }

        /// <summary>
        /// Выводит в консоль ежемесячный денежный оборот онлайн-магазина.
        /// </summary>
        public string DisplayMonthlyRevenue()
        {
            return $"Денежный оборот в месяц: {_monthlyRevenue}";
        }

        /// <summary>
        /// Выводит в консоль годовой денежный оборот онлайн-магазина.
        /// </summary>
        public string DisplayAnnualRevenue()
        {
            return $"Денежный оборот в год: {_annualRevenue}";
        }

        /// <summary>
        /// Возвращает количество продуктов в онлайн-магазине в шестнадцатеричном представлении.
        /// </summary>
        /// <returns>Строка, представляющая количество продуктов в шестнадцатеричном формате.</returns>
        public string DisplayNumberOfProductsHex()
        {
            return _numberOfProducts.ToString("X");
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public string PerformInvalidCast(object obj)
        {
            try
            {
                string text = (string)obj;
                return text;
            }
            catch (InvalidCastException ex)
            {
                string invalid = $"Обнаружено InvalidCastException: {ex.Message}\n";
                CustomInvalidCastException customEx = new CustomInvalidCastException("Произошла ошибка приведения типов." +
                    " Не удалось преобразовать объект к строке.", ex);
                customEx.AdditionalInfo = "Попытка приведения object к string.";
                customEx.OffendingValue = obj?.ToString();//предотвращаем вызов исключения NullReferenceException
                customEx.ExpectedType = typeof(string);
                invalid += $"Дополнительная информация: {customEx.AdditionalInfo}\n";
                invalid += $"Значение, которое не удалось привести: {customEx.OffendingValue}";
                invalid += $"Ожидаемый тип: {customEx.ExpectedType}";
                MessageBox(IntPtr.Zero, customEx.Message, "Ошибка приведения типов", MB_OK | MB_ICONERROR);
                return invalid;
            }
        }

        public bool CheckSufficientVisitors(double requiredRevenuePerVisitor)
        {
            if (_numberOfVisitors == 0)
            {
                InsufficientVisitorsException ex = new InsufficientVisitorsException("Невозможно проверить достаточность посетителей, так как их число равно нулю.");
                ex.NumberOfVisitors = _numberOfVisitors;
                ex.MonthlyRevenue = _monthlyRevenue;
                ex.RequiredRevenuePerVisitor = requiredRevenuePerVisitor;
                throw ex;
            }

            double actualRevenuePerVisitor = _monthlyRevenue / _numberOfVisitors;

            if (actualRevenuePerVisitor < requiredRevenuePerVisitor)
            {
                InsufficientVisitorsException ex = new InsufficientVisitorsException($"Недостаточно посетителей для " +
                    $"достижения требуемого дохода на посетителя." + $"  Требуется {requiredRevenuePerVisitor}, " +
                    $" фактический доход {_monthlyRevenue / _numberOfVisitors}.");
                ex.NumberOfVisitors = _numberOfVisitors;
                ex.MonthlyRevenue = _monthlyRevenue;
                ex.RequiredRevenuePerVisitor = requiredRevenuePerVisitor;
                throw ex;
            }

            return true; // Достаточно посетителей
        }

        /// <summary>
        /// Анализирует количество посетителей и обрабатывает исключение <see cref="InsufficientVisitorsException"/>, если оно возникает.
        /// </summary>
        /// <param name="requiredRevenuePerVisitor">Требуемая прибыль на одного посетителя.</param>
        public string AnalyzeVisitors(double requiredRevenuePerVisitor)
        {
            try
            {
                if (CheckSufficientVisitors(requiredRevenuePerVisitor))
                {
                    return "Достаточно посетителей для достижения требуемого дохода.";
                }
                else
                {
                    return "Недостаточно посетителей для достижения требуемого дохода.";
                }
            }
            catch (InsufficientVisitorsException ex)
            {
                string invalid = $"Ошибка: {ex.Message}\n";
                invalid += $"Число посетителей: {ex.NumberOfVisitors}\n";
                invalid += $"Месячный доход: {ex.MonthlyRevenue}\n";
                invalid += $"Требуемый доход на посетителя: {ex.RequiredRevenuePerVisitor} \n";

                // Вывод MessageBox
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка", MB_OK | MB_ICONERROR);
                return invalid;
            }
        }

        #endregion
    }
}