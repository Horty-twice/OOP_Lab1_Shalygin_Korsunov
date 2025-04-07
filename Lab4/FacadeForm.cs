using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov.Lab4
{
    /// <summary>
    /// Форма, реализующая фасад для управления магазином.
    /// </summary>
    public partial class FacadeForm : Form
    {
        /// <summary>
        /// Экземпляр класса <see cref="StoreManagementFacade"/> для управления магазином.
        /// </summary>
        private StoreManagementFacade _storeManagementFacade;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FacadeForm"/>.
        /// </summary>
        public FacadeForm()
        {
            InitializeComponent();
            _storeManagementFacade = new StoreManagementFacade();
            _storeManagementFacade.InventoryChanged += FacadeForm_InventoryChanged; //Подписка на событие
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Добавить товар".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие (кнопка).</param>
        /// <param name="e">Аргументы события.</param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBox.Text.Trim();
            int quantity = (int)quantityNumericUpDown.Value;

            _storeManagementFacade.AddProductToInventory(productName, quantity);

            productNameTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Весь список товаров".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие (кнопка).</param>
        /// <param name="e">Аргументы события.</param>
        private void showInventoryButton_Click(object sender, EventArgs e)
        {
            // Получаем список товаров из фасада
            var inventory = _storeManagementFacade.GetInventory(); // Вызываем метод GetInventory

            // Создаем и отображаем форму со списком товаров
            InventoryForm inventoryForm = new InventoryForm(new Dictionary<string, int>(inventory));
            inventoryForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Найти товар".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBoxForDeleteOrFind.Text.Trim();
            _storeManagementFacade.CheckProductAvailability(productName);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Удалить товар".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBoxForDeleteOrFind.Text.Trim();
            int quantity = (int)quantityForDeleteNumericUpDown.Value;
            _storeManagementFacade.RemoveProductFromInventory(productName, quantity);
        }

        /// <summary>
        /// Обработчик события InventoryChanged, вызываемого из InventoryManagement.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="message">Сообщение события.</param>
        private void FacadeForm_InventoryChanged(object sender, string message)
        {
            LogMessage(message);
        }

        /// <summary>
        /// Выводит сообщение в ListBox.
        /// </summary>
        /// <param name="message">Сообщение для вывода.</param>
        private void LogMessage(string message)
        {
            logListBox.Items.Add(message);
            logListBox.TopIndex = logListBox.Items.Count - 1; // Автоматическая прокрутка к последнему сообщению
        }

    }
}