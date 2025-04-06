using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Форма для демонстрации паттерна "Строитель" при создании объектов OnlineStore.
    /// </summary>
    public partial class BuilderForm: Form
    {
        /// <summary>
        /// Список для хранения созданных объектов Store.
        /// </summary>
        private List<Store> _stores = new List<Store>();
        /// <summary>
        /// Конструктор формы BuilderForm.
        /// </summary>
        public BuilderForm()
        {
            InitializeComponent();

            // Инициализация ComboBox
            StoreTypeComboBox.Items.Add("Online");
            StoreTypeComboBox.Items.Add("Offline");
            StoreTypeComboBox.SelectedIndex = 0; // Выбираем Online по умолчанию

            UpdateDataGridView(); // Отображаем пустую таблицу при запуске формы
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку CreateStoreButton.
        /// Создает объект OnlineStore с использованием паттерна "Строитель" и отображает информацию о нем в StoresDataGridView.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateStoreButton_Click_1(object sender, EventArgs e)
        {
            // Получаем данные из элементов управления формы
            string storeType = StoreTypeComboBox.SelectedItem.ToString();
            string storeName = StoreNameTextBox.Text;
            string owner = OwnerTextBox.Text;

            StoreBuilder builder = new StoreBuilder();
            builder.SetStoreType(storeType);
            builder.SetName(storeName);
            builder.SetOwner(owner);

            if (storeType == "Online")
            {
                int numberOfVisitors = (int)NumberOfVisitorsNumericUpDown.Value;
                int numberOfProducts = (int)NumberOfProductsNumericUpDown.Value;
                int monthlyPurchases = (int)MonthlyPurchasesNumericUpDown.Value;
                double monthlyRevenue = (double)MonthlyRevenueNumericUpDown.Value;
                double annualRevenue = (double)AnnualRevenueNumericUpDown.Value;

                builder.SetOnlineStoreProperties(numberOfVisitors, numberOfProducts, monthlyPurchases, monthlyRevenue, annualRevenue);
            }
            else if (storeType == "Offline")
            {
                double storeArea = (double)StoreAreaNumericUpDown.Value;
                builder.SetOfflineStoreProperties(storeArea);
            }

            Store newStore = builder.Build();
            _stores.Add(newStore);

            UpdateDataGridView();
            ClearInputFields();
        }


        /// <summary>
        /// Обработчик события нажатия на кнопку DeleteStoreButton.
        /// Удаляет магазин из списка по названию.
        /// </summary>
        private void DeleteStoreButton_Click(object sender, EventArgs e)
        {
            string storeNameToDelete = StoreNameToDeleteTextBox.Text;
            if (string.IsNullOrEmpty(storeNameToDelete))
            {
                MessageBox.Show("Пожалуйста, введите название магазина для удаления.", "Ошибка");
                return;
            }

            Store storeToRemove = _stores.Find(s => s._name == storeNameToDelete);
            if (storeToRemove != null)
            {
                _stores.Remove(storeToRemove);
                UpdateDataGridView();
                StoreNameToDeleteTextBox.Text = ""; // Очищаем поле ввода
            }
            else
            {
                MessageBox.Show($"Магазин с названием '{storeNameToDelete}' не найден.", "Информация");
            }
        }


        /// <summary>
        /// Обработчик события нажатия на кнопку ClearStoresButton.
        /// Очищает список магазинов.
        /// </summary>
        private void ClearStoresButton_Click(object sender, EventArgs e)
        {
            _stores.Clear();
            UpdateDataGridView();
        }


        /// <summary>
        /// Обработчик события изменения выбранного типа магазина в ComboBox.
        /// Показывает или скрывает элементы управления, специфичные для каждого типа магазина.
        /// </summary>
        private void StoreTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedStoreType = StoreTypeComboBox.SelectedItem.ToString();

            // Показываем или скрываем элементы управления для OnlineStore
            NumberOfVisitorsNumericUpDown.Visible = (selectedStoreType == "Online");
            NumberOfProductsNumericUpDown.Visible = (selectedStoreType == "Online");
            MonthlyPurchasesNumericUpDown.Visible = (selectedStoreType == "Online");
            MonthlyRevenueNumericUpDown.Visible = (selectedStoreType == "Online");
            AnnualRevenueNumericUpDown.Visible = (selectedStoreType == "Online");
            lblNumberOfVisitors.Visible = (selectedStoreType == "Online"); // Количество посетителей
            lblNumberOfProducts.Visible = (selectedStoreType == "Online"); // Количество товаров
            lblMonthlyPurchases.Visible = (selectedStoreType == "Online"); // Ежемесячные покупки
            lblMonthlyRevenue.Visible = (selectedStoreType == "Online"); // Ежемесячный доход
            lblAnnualRevenue.Visible = (selectedStoreType == "Online"); // Годовой доход

            // Показываем или скрываем элементы управления для OfflineStore
            StoreAreaNumericUpDown.Visible = (selectedStoreType == "Offline");
            lblStoreArea.Visible = (selectedStoreType == "Offline"); // Площадь магазина
        }



        /// <summary>
        /// Обновляет DataGridView со списком магазинов.
        /// </summary>
        private void UpdateDataGridView()
        {
            StoresDataGridView.DataSource = null; // Сброс источника данных
            StoresDataGridView.Columns.Clear(); // Очистка столбцов
            StoresDataGridView.AutoGenerateColumns = false; // Отключаем автогенерацию столбцов

            // Создаем столбцы
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "№";
            idColumn.DataPropertyName = "Id";
            StoresDataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Название";
            nameColumn.DataPropertyName = "Name";
            StoresDataGridView.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn ownerColumn = new DataGridViewTextBoxColumn();
            ownerColumn.HeaderText = "Владелец";
            ownerColumn.DataPropertyName = "Owner";
            StoresDataGridView.Columns.Add(ownerColumn);

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.HeaderText = "Тип";
            typeColumn.DataPropertyName = "Type";
            StoresDataGridView.Columns.Add(typeColumn);

            // Создаем список объектов StoreWrapper
            var gridData = new List<StoreWrapper>();
            for (int i = 0; i < _stores.Count; i++)
            {
                var store = _stores[i];
                gridData.Add(new StoreWrapper(i + 1, store._name, store._owner, store.GetType().Name));
            }

            StoresDataGridView.DataSource = gridData;
            StoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        /// <summary>
        /// Очищает поля ввода.
        /// </summary>
        private void ClearInputFields()
        {
            StoreNameTextBox.Text = "";
            OwnerTextBox.Text = "";
            NumberOfVisitorsNumericUpDown.Value = 0;
            NumberOfProductsNumericUpDown.Value = 0;
            MonthlyPurchasesNumericUpDown.Value = 0;
            MonthlyRevenueNumericUpDown.Value = 0;
            AnnualRevenueNumericUpDown.Value = 0;
            StoreAreaNumericUpDown.Value = 0;
        }
    }
}
