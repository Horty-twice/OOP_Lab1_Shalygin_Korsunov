using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Форма для управления коллекцией магазинов и тестирования производительности коллекций.
    /// </summary>
    public partial class CollectionForm : Form
    {
        private StoreCollection _storeCollection = new StoreCollection();
        private StoreListenner _storeListenner = new StoreListenner();

        /// <summary>
        /// Конструктор класса CollectionForm.
        /// </summary>
        public CollectionForm()
        {
            InitializeComponent();

            // Подписываемся на события
            _storeCollection.StoreAdded += _storeListenner.OnStoreAdded;
            _storeCollection.StoreRemoved += _storeListenner.OnStoreRemoved;

            // Лямбда-выражение - выводит сообщение в MessageBox
            _storeCollection.StoreAdded += (sender, e) =>
            {
                MessageBox.Show($"Магазин '{e.Store._name}' добавлен!", "Уведомление");
            };

            UpdateListView(); // Обновляем ListView при запуске формы
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить магазин".
        /// Добавляет новый магазин в коллекцию.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddStoreButton_Click_1(object sender, EventArgs e)
        {
            string storeName = StoreNameTextBox.Text;
            int numberOfProducts = (int)NumberOfProductsNumericUpDown.Value;

            OnlineStore newStore = new OnlineStore(storeName, numberOfProducts);
            _storeCollection.AddStore(newStore);

            UpdateListView(); // Обновляем ListView
            StoreNameTextBox.Clear();
            NumberOfProductsNumericUpDown.Value = 0;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить магазин".
        /// Удаляет магазин из коллекции.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveStoreButton_Click_1(object sender, EventArgs e)
        {
            string storeName = StoreNameTextBox.Text; // Получаем имя магазина из текстового поля

            if (!string.IsNullOrEmpty(storeName)) // Проверяем, что название магазина не пустое
            {
                _storeCollection.RemoveStore(storeName);
                UpdateListView(); // Обновляем ListView
                StoreNameTextBox.Clear();
                NumberOfProductsNumericUpDown.Value = 0;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите название магазина для удаления.", "Предупреждение"); // Сообщаем пользователю о необходимости ввести название магазина
            }
        }

        /// <summary>
        /// Метод для обновления ListView.
        /// Отображает список магазинов в ListView.
        /// </summary>
        private void UpdateListView()
        {
            StoresListView.Items.Clear(); // Очищаем ListView

            Dictionary<string, OnlineStore> stores = _storeCollection.GetAllStores();
            foreach (var store in stores)
            {
                ListViewItem item = new ListViewItem(store.Value._name); // Имя магазина - первый столбец
                item.SubItems.Add(store.Value.NumberOfProducts.ToString()); // Количество продуктов - второй столбец
                StoresListView.Items.Add(item);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Запустить тест производительности".
        /// Запускает тесты производительности для Dictionary и Array.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void PerformanceTestButton_Click(object sender, EventArgs e)
        {
            PerformanceListView.Items.Clear();
            int numberOfElements = 1000000; // Уменьшено для более быстрого теста
            int numberOfTestIterations = 3; // Добавили повторения теста и усреднение

            // Generate Data
            List<OnlineStore> stores = GenerateRandomStores(numberOfElements);

            // Test Dictionary
            TestCollection("Dictionary", stores, AddToDictionary, ReadFromDictionary, ReadFromDictionaryRandom, numberOfTestIterations);

            // Test Array
            TestCollection("Array", stores, AddToArray, ReadFromArray, ReadFromArrayRandom, numberOfTestIterations);
        }

        /// <summary>
        /// Генерирует список случайных магазинов для тестирования производительности.
        /// </summary>
        /// <param name="count">Количество магазинов для генерации.</param>
        /// <returns>Список сгенерированных магазинов.</returns>
        private List<OnlineStore> GenerateRandomStores(int count)
        {
            List<OnlineStore> stores = new List<OnlineStore>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                OnlineStore store = new OnlineStore($"Random Store {i}", random.Next(1, 100));
                stores.Add(store);
            }
            return stores;
        }

        /// <summary>
        /// Запускает тест производительности для заданной коллекции.
        /// Включает прогрев, измерение времени добавления, последовательного и случайного чтения, а также усреднение результатов.
        /// </summary>
        /// <param name="collectionName">Название коллекции (например, "Dictionary" или "Array").</param>
        /// <param name="stores">Список магазинов, используемый для тестирования.</param>
        /// <param name="addAction">Метод для добавления элементов в коллекцию.</param>
        /// <param name="readSequentialAction">Метод для последовательного чтения элементов из коллекции.</param>
        /// <param name="readRandomAction">Метод для случайного чтения элементов из коллекции.</param>
        /// <param name="numberOfWarmUpIterations">Количество итераций прогрева.</param>
        /// <param name="numberOfTestIterations">Количество итераций для измерения производительности и усреднения результатов.</param>
        private void TestCollection(string collectionName, List<OnlineStore> stores, Action<List<OnlineStore>> addAction, Action<List<OnlineStore>> readSequentialAction, Action<List<OnlineStore>> readRandomAction, int numberOfTestIterations)
        {
            long addTime = 0, readSequentialTime = 0, readRandomTime = 0;


            // Test (Тестирование)
            for (int i = 0; i < numberOfTestIterations; i++)
            {
                Stopwatch stopwatch = new Stopwatch();

                // Add
                stopwatch.Restart();
                addAction(stores);
                stopwatch.Stop();
                addTime += stopwatch.ElapsedMilliseconds;

                // Read Sequential
                stopwatch.Restart();
                readSequentialAction(stores);
                stopwatch.Stop();
                readSequentialTime += stopwatch.ElapsedMilliseconds;

                // Read Random
                stopwatch.Restart();
                readRandomAction(stores);
                stopwatch.Stop();
                readRandomTime += stopwatch.ElapsedMilliseconds;

                // Reset Collections (Очистка коллекций после каждой итерации)
                _dictionary = new Dictionary<string, OnlineStore>(StringComparer.OrdinalIgnoreCase);
                _array = null;
            }

            // Average (Усреднение результатов)
            addTime /= numberOfTestIterations;
            readSequentialTime /= numberOfTestIterations;
            readRandomTime /= numberOfTestIterations;

            // Display Results
            ListViewItem item = new ListViewItem(collectionName);
            item.SubItems.Add(addTime.ToString());
            item.SubItems.Add(readSequentialTime.ToString());
            item.SubItems.Add(readRandomTime.ToString());
            PerformanceListView.Items.Add(item);
        }

        /// <summary>
        /// Словарь для хранения магазинов.
        /// </summary>
        private Dictionary<string, OnlineStore> _dictionary = new Dictionary<string, OnlineStore>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Добавляет элементы из списка в словарь и измеряет время добавления.
        /// </summary>
        /// <param name="stores">Список магазинов для добавления.</param>
        private void AddToDictionary(List<OnlineStore> stores)
        {
            _dictionary = new Dictionary<string, OnlineStore>(StringComparer.OrdinalIgnoreCase);
            foreach (var store in stores)
            {
                _dictionary.Add(store._name, store);
            }
        }

        /// <summary>
        /// Последовательно считывает элементы из словаря.
        /// </summary>
        /// <param name="stores">Список магазинов для чтения.</param>
        private void ReadFromDictionary(List<OnlineStore> stores)
        {
            foreach (var store in stores)
            {
                // Доступ к элементу по ключу (быстро)
                OnlineStore s = _dictionary[store._name];
            }
        }

        /// <summary>
        /// Случайно считывает элементы из словаря.
        /// </summary>
        /// <param name="stores">Список магазинов для чтения.</param>
        private void ReadFromDictionaryRandom(List<OnlineStore> stores)
        {
            Random rnd = new Random();
            List<string> keys = new List<string>(_dictionary.Keys); // Получаем список ключей
            for (int i = 0; i < stores.Count; i++)
            {
                int index = rnd.Next(keys.Count); // Генерируем случайный индекс
                string randomKey = keys[index]; // Получаем случайный ключ
                OnlineStore s = _dictionary[randomKey]; // Читаем элемент по случайному ключу
            }
        }

        /// <summary>
        /// Массив для хранения магазинов.
        /// </summary>
        private OnlineStore[] _array;

        /// <summary>
        /// Добавляет элементы из списка в массив и измеряет время добавления.
        /// </summary>
        /// <param name="stores">Список магазинов для добавления.</param>
        private void AddToArray(List<OnlineStore> stores)
        {
            _array = new OnlineStore[stores.Count]; // Создаем массив нужного размера
            for (int i = 0; i < stores.Count; i++)
            {
                _array[i] = stores[i]; // Добавляем элементы в массив по одному
            }
        }

        /// <summary>
        /// Последовательно считывает элементы из массива.
        /// </summary>
        /// <param name="stores">Список магазинов для чтения.</param>
        private void ReadFromArray(List<OnlineStore> stores)
        {
            // Для последовательного чтения из массива создаем словарь для быстрого поиска
            Dictionary<string, OnlineStore> arrayDictionary = new Dictionary<string, OnlineStore>();
            foreach (var store in _array)
            {
                arrayDictionary[store._name] = store;
            }

            foreach (var store in stores)
            {
                // Используем словарь для поиска по имени (быстро)
                OnlineStore s = arrayDictionary[store._name];
            }
        }

        /// <summary>
        /// Случайно считывает элементы из массива.
        /// </summary>
        /// <param name="stores">Список магазинов для чтения.</param>
        private void ReadFromArrayRandom(List<OnlineStore> stores)
        {
            Random rnd = new Random();
            for (int i = 0; i < stores.Count; i++)
            {
                int index = rnd.Next(stores.Count);
                OnlineStore s = _array[index];
            }
        }
    }
}