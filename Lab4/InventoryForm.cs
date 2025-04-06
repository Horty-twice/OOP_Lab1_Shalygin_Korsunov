using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov.Lab4
{
    // <summary>
    /// Форма для отображения списка товаров на складе.
    /// </summary>
    public partial class InventoryForm: Form
    {
        /// <summary>
        /// Словарь, содержащий информацию о товарах и их количестве.
        /// </summary>
        private Dictionary<string, int> _inventory;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InventoryForm"/>.
        /// </summary>
        /// <param name="inventory">Словарь с информацией о товарах и их количестве.</param>
        public InventoryForm(Dictionary<string, int> inventory)
        {
            InitializeComponent();

            _inventory = inventory;
            DisplayInventory();
        }

        /// <summary>
        /// Отображает список товаров в ListBox.
        /// </summary>
        private void DisplayInventory()
        {
            inventoryListBox.Items.Clear();
            foreach (var item in _inventory)
            {
                inventoryListBox.Items.Add($"{item.Key}: {item.Value}");
            }
        }
    }
}
