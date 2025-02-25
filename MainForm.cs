using System;
using System.Globalization;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс, представляющий основную форму приложения для управления информацией об онлайн-магазине.
    /// </summary>
    public partial class InterfaceWindow : Form
    {
        const double requiredRevenuePerVisitor = 100000; // Задайте нужное значение
        //Переменные для объекта класса
        /// <summary>
        /// Значение по умолчанию для владельца онлайн-магазина.
        /// </summary>
        const string owner = "Виктория Сикрет";
        /// <summary>
        /// Значение по умолчанию для названия онлайн-магазина.
        /// </summary>
        const string name = "Viktory Secret";
        /// <summary>
        /// Значение по умолчанию для количества посетителей онлайн-магазина.
        /// </summary>
        const int numerOfVisitors = 100;
        /// <summary>
        /// Значение по умолчанию для количества товаров в онлайн-магазине.
        /// </summary>
        const int numerOfProducts = 3;
        /// <summary>
        /// Значение по умолчанию для количества ежемесячных покупок в онлайн-магазине.
        /// </summary>
        const int monthlyPurchases = 6;
        /// <summary>
        /// Значение по умолчанию для ежемесячной прибыли онлайн-магазина.
        /// </summary>
        const double monthlyRevenue = 60000;
        /// <summary>
        /// Значение по умолчанию для годовой прибыли онлайн-магазина.
        /// </summary>
        const double annualRevenue = 720000;

        //Инициализация объекта класса
        /// <summary>
        /// Объект класса OnlineStore, представляющий онлайн-магазин.
        /// </summary>
        OnlineStore onlineStore = new OnlineStore(owner, name, numerOfVisitors, numerOfProducts, 
            monthlyPurchases, monthlyRevenue, annualRevenue);

        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public InterfaceWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события загрузки формы MainForm, инициализирует текст MainInformation и OutputField.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainInformation.Text = "Лабораторная работа №1. Группа 23ВП1. Бригада: Корсунов, Шалыгин.";
            this.OutputField.Text = onlineStore.ToString();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку ChangeButton_Click, обновляет информацию 
        /// об онлайн-магазине на основе введенных данных в текстовые поля.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            // Локальные переменные для хранения введенных данных. Инициализированы значениями по умолчанию.
            string owner = onlineStore.Owner; // Сохраняем текущее значение, если поле не заполнено
            string name = onlineStore.Name;   // Сохраняем текущее значение, если поле не заполнено
            int numberOfVisitors = onlineStore.NumberOfVisitors; // Сохраняем текущее значение, если поле не заполнено
            int numberOfProducts = onlineStore.NumberOfProducts; // Сохраняем текущее значение, если поле не заполнено
            int monthlyPurchases = onlineStore.MonthlyPurchases; // Сохраняем текущее значение, если поле не заполнено
            double monthlyRevenue = onlineStore.MonthlyRevenue; // Сохраняем текущее значение, если поле не заполнено
            double annualRevenue = onlineStore.AnnualRevenue; // Сохраняем текущее значение, если поле не заполнено

            // Проверка и присвоение значения owner
            if (!string.IsNullOrEmpty(this.FounderTextBox.Text))
            {
                owner = this.FounderTextBox.Text;
            }

            // Проверка и присвоение значения name
            if (!string.IsNullOrEmpty(this.StoreNameTextBox.Text))
            {
                name = this.StoreNameTextBox.Text;
            }

            // Проверка и присвоение значения NumberOfVisitors
            if (!string.IsNullOrEmpty(this.NumderOfVisitorsTextBox.Text))
            {
                if (int.TryParse(this.NumderOfVisitorsTextBox.Text, out int visitors))
                {
                    numberOfVisitors = visitors;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для количества посетителей.");
                    return; // Прерываем выполнение, если формат неверный
                }
            }

            // Проверка и присвоение значения NumberOfProducts
            if (!string.IsNullOrEmpty(this.NumberOfProductsTextBox.Text))
            {
                if (int.TryParse(this.NumberOfProductsTextBox.Text, out int products))
                {
                    numberOfProducts = products;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для количества продуктов.");
                    return; // Прерываем выполнение, если формат неверный
                }
            }

            // Проверка и присвоение значения MonthlyPurchases
            if (!string.IsNullOrEmpty(this.NumberOfPurcashesTextBox.Text))
            {
                if (int.TryParse(this.NumberOfPurcashesTextBox.Text, out int purchases))
                {
                    monthlyPurchases = purchases;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для ежемесячных покупок.");
                    return; // Прерываем выполнение, если формат неверный
                }
            }

            // Проверка и присвоение значения MonthlyRevenue
            if (!string.IsNullOrEmpty(this.MonthlyTurnoverTextBox.Text))
            {
                if (double.TryParse(MonthlyTurnoverTextBox.Text.Replace(',', '.'), NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double value))
                {
                    monthlyRevenue = value;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для ежемесячной прибыли.");
                    return; // Прерываем выполнение, если формат неверный
                }
            }

            // Проверка и присвоение значения AnnualRevenue
            if (!string.IsNullOrEmpty(this.YearTurnoverTextBox.Text))
            {
                if (double.TryParse(YearTurnoverTextBox.Text.Replace(',', '.'), NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double value))
                {
                    annualRevenue = value;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для годовой прибыли.");
                    return; // Прерываем выполнение, если формат неверный
                }
            }

            // Присваиваем значения свойствам объекта onlineStore
            onlineStore.Owner = owner;
            onlineStore.Name = name;
            onlineStore.NumberOfVisitors = numberOfVisitors;
            onlineStore.NumberOfProducts = numberOfProducts;
            onlineStore.MonthlyPurchases = monthlyPurchases;
            onlineStore.MonthlyRevenue = monthlyRevenue;
            onlineStore.AnnualRevenue = annualRevenue;

            this.OutputField.Text = onlineStore.ToString();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку, вызывает метод PerformInvalidCast и обрабатывает исключение CustomInvalidCastException.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CallErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                onlineStore.PerformInvalidCast(123); // Вызываем метод, который может бросить исключение
            }
            catch (CustomInvalidCastException ex)
            {
                // Отображаем MessageBox с информацией об исключении
                OnlineStore.MessageBox(IntPtr.Zero, ex.Message + "\n" + ex.AdditionalInfo + "\n" +
                    ex.OffendingValue + "\n" + ex.ExpectedType, "Ошибка приведения типов", OnlineStore.MB_OK | OnlineStore.MB_ICONERROR);
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку, вызывает метод AnalyzeVisitors и 
        /// обрабатывает исключение InsufficientVisitorsException.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                string result = onlineStore.AnalyzeVisitors(requiredRevenuePerVisitor);
                MessageBox.Show(result); // Выводим результат, если исключения не было
            }
            catch (InsufficientVisitorsException ex)
            {
                // Отображаем MessageBox с информацией об исключении
                OnlineStore.MessageBox(IntPtr.Zero, ex.Message + "\n" + "Число посетителей: " + ex.NumberOfVisitors + "\n" +
                "Месячный доход: " + ex.MonthlyRevenue + "\n" + "Требуемый доход на посетителя: " +
                ex.RequiredRevenuePerVisitor, "Ошибка анализа посетителей", OnlineStore.MB_OK | OnlineStore.MB_ICONERROR);
            }
        }

        /// <summary>
        ///  Обработчик события нажатия на кнопку, выводит количество продуктов в шестнадцатеричном формате в label11.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ConversionTo16Format_Click(object sender, EventArgs e)
        {
            this.label11.Text = onlineStore.DisplayNumberOfProductsHex();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку, закрывает форму MainForm.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}