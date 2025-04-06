using Microsoft.VisualStudio.TestTools.UnitTesting; // Импортирует пространство имен MSTest для модульного тестирования.

namespace OOP_Lab1_Shalygin_Korsunov // Убедитесь, что это то же пространство имен, что и ваш класс OnlineStore
{
    /// <summary>
    /// Класс тестов для проверки функциональности класса OnlineStore.
    /// </summary>
    [TestClass] // Атрибут, указывающий, что это класс, содержащий тестовые методы.
    public class OnlineStoreTests
    {
        /// <summary>
        /// Тест проверяет, что метод DisplayName возвращает правильное название магазина.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        public void DisplayName_ReturnsCorrectName()
        {
            // Arrange - Подготовка данных для теста.
            OnlineStore store = new OnlineStore("Test Store"); // Создаем экземпляр класса OnlineStore с названием "Test Store".

            // Act - Выполнение тестируемого кода.
            string name = store.DisplayName(); // Вызываем метод DisplayName и сохраняем результат в переменную name.

            // Assert - Проверка результата.
            Assert.AreEqual("Название: Test Store", name); // Проверяем, что возвращенное значение name равно ожидаемому значению.
    
        }

        /// <summary>
        /// Тест проверяет, что метод CheckSufficientVisitors выбрасывает исключение InsufficientVisitorsException,
        /// когда недостаточно посетителей для достижения требуемого дохода.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        [ExpectedException(typeof(InsufficientVisitorsException))] //Указывает,что метод, выбросит исключение InsufficientVisitorsException.
        public void CheckSufficientVisitors_ThrowsException_WhenNotEnoughVisitors()
        {
            // Arrange - Подготовка данных для теста.
            // Создаем экземпляр класса OnlineStore с названием "Test Store" и 10 товарами.
            OnlineStore store = new OnlineStore("Test Store", 10); 
            store.NumberOfVisitors = 10; // Устанавливаем количество посетителей в 10.
            store.MonthlyRevenue = 100; // Устанавливаем ежемесячный доход в 100.
            double requiredRevenuePerVisitor = 20; // Устанавливаем требуемый доход на одного посетителя в 20.

            // Act - Выполнение тестируемого кода.
            // Вызываем метод CheckSufficientVisitors. Если метод не выбрасывает исключение InsufficientVisitorsException,
            // тест завершается неудачей.
            store.CheckSufficientVisitors(requiredRevenuePerVisitor); 
        }

        /// <summary>
        /// Тест проверяет, что метод CheckSufficientVisitors возвращает true,
        /// когда достаточно посетителей для достижения требуемого дохода.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        public void CheckSufficientVisitors_ReturnsTrue_WhenEnoughVisitors()
        {
            // Arrange - Подготовка данных для теста.
            OnlineStore store = new OnlineStore("Test Store", 10); // Создаем экземпляр класса с названием "Test Store" и 10 товарами.
            store.NumberOfVisitors = 100; // Устанавливаем количество посетителей в 100.
            store.MonthlyRevenue = 2000; // Устанавливаем ежемесячный доход в 2000.
            double requiredRevenuePerVisitor = 10; // Устанавливаем требуемый доход на одного посетителя в 10.

            // Act - Выполнение тестируемого кода.
            // Вызываем метод CheckSufficientVisitors и сохраняем результат в переменную result.
            bool result = store.CheckSufficientVisitors(requiredRevenuePerVisitor); 

            // Assert - Проверка результата.
            Assert.IsTrue(result); // Проверяем, что возвращенное значение result равно true.
            // Assert.IsTrue(condition); - Проверяет, что условие (condition) истинно.  Если условие ложно, тест завершается неудачей.
        }
    }
}