namespace OOP_Lab1_Shalygin_Korsunov
{
    partial class CollectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionForm));
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfProductsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.RemoveStoreButton = new System.Windows.Forms.Button();
            this.StoresListView = new System.Windows.Forms.ListView();
            this.FormName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PerformanceTestButton = new System.Windows.Forms.Button();
            this.PerformanceListView = new System.Windows.Forms.ListView();
            this.Collection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readSequentialTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readRandomTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InfoBlock_Name = new System.Windows.Forms.Label();
            this.InfoBlock_PRODUCTS = new System.Windows.Forms.Label();
            this.INFO_LIST_STORES = new System.Windows.Forms.Label();
            this.INFO_TEST = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProductsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreNameTextBox.Location = new System.Drawing.Point(12, 39);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(294, 30);
            this.StoreNameTextBox.TabIndex = 0;
            // 
            // NumberOfProductsNumericUpDown
            // 
            this.NumberOfProductsNumericUpDown.Location = new System.Drawing.Point(12, 129);
            this.NumberOfProductsNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumberOfProductsNumericUpDown.Name = "NumberOfProductsNumericUpDown";
            this.NumberOfProductsNumericUpDown.Size = new System.Drawing.Size(294, 22);
            this.NumberOfProductsNumericUpDown.TabIndex = 1;
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.Bisque;
            this.AddStoreButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStoreButton.Location = new System.Drawing.Point(327, 22);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(132, 58);
            this.AddStoreButton.TabIndex = 2;
            this.AddStoreButton.Text = " Добавить магазин";
            this.AddStoreButton.UseVisualStyleBackColor = false;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click_1);
            // 
            // RemoveStoreButton
            // 
            this.RemoveStoreButton.BackColor = System.Drawing.Color.Bisque;
            this.RemoveStoreButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStoreButton.Location = new System.Drawing.Point(465, 22);
            this.RemoveStoreButton.Name = "RemoveStoreButton";
            this.RemoveStoreButton.Size = new System.Drawing.Size(132, 56);
            this.RemoveStoreButton.TabIndex = 3;
            this.RemoveStoreButton.Text = "Удалить магазин";
            this.RemoveStoreButton.UseVisualStyleBackColor = false;
            this.RemoveStoreButton.Click += new System.EventHandler(this.RemoveStoreButton_Click_1);
            // 
            // StoresListView
            // 
            this.StoresListView.BackColor = System.Drawing.Color.Cornsilk;
            this.StoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FormName,
            this.productsColumn});
            this.StoresListView.HideSelection = false;
            this.StoresListView.Location = new System.Drawing.Point(3, 194);
            this.StoresListView.Name = "StoresListView";
            this.StoresListView.Size = new System.Drawing.Size(710, 506);
            this.StoresListView.TabIndex = 4;
            this.StoresListView.UseCompatibleStateImageBehavior = false;
            this.StoresListView.View = System.Windows.Forms.View.Details;
            // 
            // FormName
            // 
            this.FormName.Text = "Название";
            this.FormName.Width = 312;
            // 
            // productsColumn
            // 
            this.productsColumn.Text = "Количество продуктов";
            this.productsColumn.Width = 395;
            // 
            // PerformanceTestButton
            // 
            this.PerformanceTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformanceTestButton.BackColor = System.Drawing.Color.Bisque;
            this.PerformanceTestButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerformanceTestButton.Location = new System.Drawing.Point(1046, 18);
            this.PerformanceTestButton.Name = "PerformanceTestButton";
            this.PerformanceTestButton.Size = new System.Drawing.Size(242, 66);
            this.PerformanceTestButton.TabIndex = 5;
            this.PerformanceTestButton.Text = "Запустить тест производительности";
            this.PerformanceTestButton.UseVisualStyleBackColor = false;
            this.PerformanceTestButton.Click += new System.EventHandler(this.PerformanceTestButton_Click);
            // 
            // PerformanceListView
            // 
            this.PerformanceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformanceListView.BackColor = System.Drawing.Color.Cornsilk;
            this.PerformanceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Collection,
            this.addTimeColumn,
            this.readSequentialTimeColumn,
            this.readRandomTimeColumn});
            this.PerformanceListView.HideSelection = false;
            this.PerformanceListView.Location = new System.Drawing.Point(775, 194);
            this.PerformanceListView.Name = "PerformanceListView";
            this.PerformanceListView.Size = new System.Drawing.Size(751, 506);
            this.PerformanceListView.TabIndex = 6;
            this.PerformanceListView.UseCompatibleStateImageBehavior = false;
            this.PerformanceListView.View = System.Windows.Forms.View.Details;
            // 
            // Collection
            // 
            this.Collection.Text = "Коллекция";
            this.Collection.Width = 89;
            // 
            // addTimeColumn
            // 
            this.addTimeColumn.Text = "Время добавления";
            this.addTimeColumn.Width = 154;
            // 
            // readSequentialTimeColumn
            // 
            this.readSequentialTimeColumn.Text = "Последовательное чтение";
            this.readSequentialTimeColumn.Width = 196;
            // 
            // readRandomTimeColumn
            // 
            this.readRandomTimeColumn.Text = "Случайное чтение";
            this.readRandomTimeColumn.Width = 131;
            // 
            // InfoBlock_Name
            // 
            this.InfoBlock_Name.AutoSize = true;
            this.InfoBlock_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBlock_Name.Location = new System.Drawing.Point(7, 9);
            this.InfoBlock_Name.Name = "InfoBlock_Name";
            this.InfoBlock_Name.Size = new System.Drawing.Size(212, 27);
            this.InfoBlock_Name.TabIndex = 7;
            this.InfoBlock_Name.Text = " Название магазина";
            // 
            // InfoBlock_PRODUCTS
            // 
            this.InfoBlock_PRODUCTS.AutoSize = true;
            this.InfoBlock_PRODUCTS.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBlock_PRODUCTS.Location = new System.Drawing.Point(7, 95);
            this.InfoBlock_PRODUCTS.Name = "InfoBlock_PRODUCTS";
            this.InfoBlock_PRODUCTS.Size = new System.Drawing.Size(219, 27);
            this.InfoBlock_PRODUCTS.TabIndex = 8;
            this.InfoBlock_PRODUCTS.Text = "Количество товаров";
            // 
            // INFO_LIST_STORES
            // 
            this.INFO_LIST_STORES.AutoSize = true;
            this.INFO_LIST_STORES.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INFO_LIST_STORES.Location = new System.Drawing.Point(264, 168);
            this.INFO_LIST_STORES.Name = "INFO_LIST_STORES";
            this.INFO_LIST_STORES.Size = new System.Drawing.Size(166, 23);
            this.INFO_LIST_STORES.TabIndex = 9;
            this.INFO_LIST_STORES.Text = "Список магазинов";
            // 
            // INFO_TEST
            // 
            this.INFO_TEST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.INFO_TEST.AutoSize = true;
            this.INFO_TEST.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INFO_TEST.Location = new System.Drawing.Point(979, 168);
            this.INFO_TEST.Name = "INFO_TEST";
            this.INFO_TEST.Size = new System.Drawing.Size(326, 23);
            this.INFO_TEST.TabIndex = 10;
            this.INFO_TEST.Text = "Результат теста производительности";
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1526, 704);
            this.Controls.Add(this.INFO_TEST);
            this.Controls.Add(this.INFO_LIST_STORES);
            this.Controls.Add(this.InfoBlock_PRODUCTS);
            this.Controls.Add(this.InfoBlock_Name);
            this.Controls.Add(this.PerformanceListView);
            this.Controls.Add(this.PerformanceTestButton);
            this.Controls.Add(this.StoresListView);
            this.Controls.Add(this.RemoveStoreButton);
            this.Controls.Add(this.AddStoreButton);
            this.Controls.Add(this.NumberOfProductsNumericUpDown);
            this.Controls.Add(this.StoreNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectionForm";
            this.Text = "CollectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProductsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.NumericUpDown NumberOfProductsNumericUpDown;
        private System.Windows.Forms.Button AddStoreButton;
        private System.Windows.Forms.Button RemoveStoreButton;
        private System.Windows.Forms.ListView StoresListView;
        private System.Windows.Forms.Button PerformanceTestButton;
        private System.Windows.Forms.ListView PerformanceListView;
        private System.Windows.Forms.Label InfoBlock_Name;
        private System.Windows.Forms.Label InfoBlock_PRODUCTS;
        private System.Windows.Forms.Label INFO_LIST_STORES;
        private System.Windows.Forms.Label INFO_TEST;
        private System.Windows.Forms.ColumnHeader Collection;
        private System.Windows.Forms.ColumnHeader addTimeColumn;
        private System.Windows.Forms.ColumnHeader readSequentialTimeColumn;
        private System.Windows.Forms.ColumnHeader readRandomTimeColumn;
        private System.Windows.Forms.ColumnHeader FormName;
        private System.Windows.Forms.ColumnHeader productsColumn;
    }
}