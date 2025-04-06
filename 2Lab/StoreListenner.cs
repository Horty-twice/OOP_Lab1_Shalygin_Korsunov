using System;

namespace OOP_Lab1_Shalygin_Korsunov
{
    /// <summary>
    /// Класс, предназначенный для обработки событий, связанных с изменениями в коллекции магазинов.
    /// Этот класс выводит информацию о событиях в консоль.
    /// </summary>
    class StoreListenner
    {
        /// <summary>
        /// Обработчик события добавления магазина.  Выводит сообщение в консоль.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события, содержащие информацию о добавленном магазине.</param>
        public void OnStoreAdded(object sender, StoreCollection.StoreEventArgs e)
        {
            Console.WriteLine($"Добавлен магазин: {e.Store._name}");
        }

        /// <summary>
        /// Обработчик события удаления магазина.  Выводит сообщение в консоль.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события, содержащие информацию об удаленном магазине.</param>
        public void OnStoreRemoved(object sender, StoreCollection.StoreEventArgs e)
        {
            Console.WriteLine($"Удален магазин: {e.Store._name}");
        }
    }
}
