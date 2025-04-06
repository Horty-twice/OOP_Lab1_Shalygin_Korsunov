namespace OOP_Lab1_Shalygin_Korsunov
{
    partial class BuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderForm));
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblNumberOfVisitors = new System.Windows.Forms.Label();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.lblMonthlyPurchases = new System.Windows.Forms.Label();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.lblAnnualRevenue = new System.Windows.Forms.Label();
            this.OwnerTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfVisitorsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfProductsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthlyPurchasesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MonthlyRevenueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnnualRevenueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreateStoreButton = new System.Windows.Forms.Button();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.lblStoreTypeLabel = new System.Windows.Forms.Label();
            this.StoreTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblStoreArea = new System.Windows.Forms.Label();
            this.StoreAreaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StoresDataGridView = new System.Windows.Forms.DataGridView();
            this.StoreNameToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.lblStoreNameToDelete = new System.Windows.Forms.Label();
            this.DeleteStoreButton = new System.Windows.Forms.Button();
            this.ClearStoresButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVisitorsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProductsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyPurchasesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRevenueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualRevenueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreAreaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStoreName.Location = new System.Drawing.Point(13, 95);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(197, 25);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Название магазина:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOwner.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOwner.Location = new System.Drawing.Point(13, 148);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(108, 25);
            this.lblOwner.TabIndex = 1;
            this.lblOwner.Text = "Владелец:";
            // 
            // lblNumberOfVisitors
            // 
            this.lblNumberOfVisitors.AutoSize = true;
            this.lblNumberOfVisitors.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberOfVisitors.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfVisitors.Location = new System.Drawing.Point(13, 192);
            this.lblNumberOfVisitors.Name = "lblNumberOfVisitors";
            this.lblNumberOfVisitors.Size = new System.Drawing.Size(250, 25);
            this.lblNumberOfVisitors.TabIndex = 2;
            this.lblNumberOfVisitors.Text = "Количество посетителей:";
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberOfProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfProducts.Location = new System.Drawing.Point(13, 248);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(210, 25);
            this.lblNumberOfProducts.TabIndex = 3;
            this.lblNumberOfProducts.Text = "Количество товаров:";
            // 
            // lblMonthlyPurchases
            // 
            this.lblMonthlyPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthlyPurchases.AutoSize = true;
            this.lblMonthlyPurchases.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonthlyPurchases.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonthlyPurchases.Location = new System.Drawing.Point(716, 39);
            this.lblMonthlyPurchases.Name = "lblMonthlyPurchases";
            this.lblMonthlyPurchases.Size = new System.Drawing.Size(233, 25);
            this.lblMonthlyPurchases.TabIndex = 4;
            this.lblMonthlyPurchases.Text = "Ежемесячные покупки:";
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthlyRevenue.AutoSize = true;
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonthlyRevenue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(716, 95);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(214, 25);
            this.lblMonthlyRevenue.TabIndex = 5;
            this.lblMonthlyRevenue.Text = "Ежемесячный доход:";
            // 
            // lblAnnualRevenue
            // 
            this.lblAnnualRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnualRevenue.AutoSize = true;
            this.lblAnnualRevenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnualRevenue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnnualRevenue.Location = new System.Drawing.Point(716, 148);
            this.lblAnnualRevenue.Name = "lblAnnualRevenue";
            this.lblAnnualRevenue.Size = new System.Drawing.Size(162, 25);
            this.lblAnnualRevenue.TabIndex = 6;
            this.lblAnnualRevenue.Text = "Годовой доход:";
            // 
            // OwnerTextBox
            // 
            this.OwnerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerTextBox.Location = new System.Drawing.Point(291, 143);
            this.OwnerTextBox.Name = "OwnerTextBox";
            this.OwnerTextBox.Size = new System.Drawing.Size(337, 30);
            this.OwnerTextBox.TabIndex = 8;
            // 
            // NumberOfVisitorsNumericUpDown
            // 
            this.NumberOfVisitorsNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfVisitorsNumericUpDown.Location = new System.Drawing.Point(291, 194);
            this.NumberOfVisitorsNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberOfVisitorsNumericUpDown.Name = "NumberOfVisitorsNumericUpDown";
            this.NumberOfVisitorsNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.NumberOfVisitorsNumericUpDown.TabIndex = 9;
            // 
            // NumberOfProductsNumericUpDown
            // 
            this.NumberOfProductsNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfProductsNumericUpDown.Location = new System.Drawing.Point(291, 248);
            this.NumberOfProductsNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberOfProductsNumericUpDown.Name = "NumberOfProductsNumericUpDown";
            this.NumberOfProductsNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.NumberOfProductsNumericUpDown.TabIndex = 10;
            // 
            // MonthlyPurchasesNumericUpDown
            // 
            this.MonthlyPurchasesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthlyPurchasesNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthlyPurchasesNumericUpDown.Location = new System.Drawing.Point(981, 34);
            this.MonthlyPurchasesNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MonthlyPurchasesNumericUpDown.Name = "MonthlyPurchasesNumericUpDown";
            this.MonthlyPurchasesNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.MonthlyPurchasesNumericUpDown.TabIndex = 11;
            // 
            // MonthlyRevenueNumericUpDown
            // 
            this.MonthlyRevenueNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthlyRevenueNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthlyRevenueNumericUpDown.Location = new System.Drawing.Point(981, 90);
            this.MonthlyRevenueNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MonthlyRevenueNumericUpDown.Name = "MonthlyRevenueNumericUpDown";
            this.MonthlyRevenueNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.MonthlyRevenueNumericUpDown.TabIndex = 12;
            // 
            // AnnualRevenueNumericUpDown
            // 
            this.AnnualRevenueNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnualRevenueNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnnualRevenueNumericUpDown.Location = new System.Drawing.Point(981, 143);
            this.AnnualRevenueNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.AnnualRevenueNumericUpDown.Name = "AnnualRevenueNumericUpDown";
            this.AnnualRevenueNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.AnnualRevenueNumericUpDown.TabIndex = 13;
            // 
            // CreateStoreButton
            // 
            this.CreateStoreButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateStoreButton.AutoSize = true;
            this.CreateStoreButton.BackColor = System.Drawing.Color.White;
            this.CreateStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStoreButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateStoreButton.Location = new System.Drawing.Point(721, 232);
            this.CreateStoreButton.Name = "CreateStoreButton";
            this.CreateStoreButton.Size = new System.Drawing.Size(188, 61);
            this.CreateStoreButton.TabIndex = 14;
            this.CreateStoreButton.Text = "Создать магазин";
            this.CreateStoreButton.UseVisualStyleBackColor = false;
            this.CreateStoreButton.Click += new System.EventHandler(this.CreateStoreButton_Click_1);
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreNameTextBox.Location = new System.Drawing.Point(291, 90);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(337, 30);
            this.StoreNameTextBox.TabIndex = 8;
            // 
            // lblStoreTypeLabel
            // 
            this.lblStoreTypeLabel.AutoSize = true;
            this.lblStoreTypeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreTypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStoreTypeLabel.Location = new System.Drawing.Point(13, 39);
            this.lblStoreTypeLabel.Name = "lblStoreTypeLabel";
            this.lblStoreTypeLabel.Size = new System.Drawing.Size(143, 25);
            this.lblStoreTypeLabel.TabIndex = 16;
            this.lblStoreTypeLabel.Text = "Тип магазина:";
            // 
            // StoreTypeComboBox
            // 
            this.StoreTypeComboBox.FormattingEnabled = true;
            this.StoreTypeComboBox.Location = new System.Drawing.Point(291, 42);
            this.StoreTypeComboBox.Name = "StoreTypeComboBox";
            this.StoreTypeComboBox.Size = new System.Drawing.Size(337, 24);
            this.StoreTypeComboBox.TabIndex = 17;
            this.StoreTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.StoreTypeComboBox_SelectedIndexChanged_1);
            // 
            // lblStoreArea
            // 
            this.lblStoreArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStoreArea.AutoSize = true;
            this.lblStoreArea.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreArea.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStoreArea.Location = new System.Drawing.Point(13, 196);
            this.lblStoreArea.Name = "lblStoreArea";
            this.lblStoreArea.Size = new System.Drawing.Size(197, 25);
            this.lblStoreArea.TabIndex = 18;
            this.lblStoreArea.Text = "Площадь магазина:";
            // 
            // StoreAreaNumericUpDown
            // 
            this.StoreAreaNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreAreaNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreAreaNumericUpDown.Location = new System.Drawing.Point(291, 194);
            this.StoreAreaNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.StoreAreaNumericUpDown.Name = "StoreAreaNumericUpDown";
            this.StoreAreaNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.StoreAreaNumericUpDown.TabIndex = 19;
            // 
            // StoresDataGridView
            // 
            this.StoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresDataGridView.Location = new System.Drawing.Point(18, 325);
            this.StoresDataGridView.Name = "StoresDataGridView";
            this.StoresDataGridView.RowHeadersWidth = 51;
            this.StoresDataGridView.RowTemplate.Height = 24;
            this.StoresDataGridView.Size = new System.Drawing.Size(1300, 399);
            this.StoresDataGridView.TabIndex = 20;
            // 
            // StoreNameToDeleteTextBox
            // 
            this.StoreNameToDeleteTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreNameToDeleteTextBox.Location = new System.Drawing.Point(413, 745);
            this.StoreNameToDeleteTextBox.Name = "StoreNameToDeleteTextBox";
            this.StoreNameToDeleteTextBox.Size = new System.Drawing.Size(337, 30);
            this.StoreNameToDeleteTextBox.TabIndex = 22;
            // 
            // lblStoreNameToDelete
            // 
            this.lblStoreNameToDelete.AutoSize = true;
            this.lblStoreNameToDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreNameToDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStoreNameToDelete.Location = new System.Drawing.Point(23, 750);
            this.lblStoreNameToDelete.Name = "lblStoreNameToDelete";
            this.lblStoreNameToDelete.Size = new System.Drawing.Size(331, 25);
            this.lblStoreNameToDelete.TabIndex = 21;
            this.lblStoreNameToDelete.Text = "Название магазина для удаления:";
            // 
            // DeleteStoreButton
            // 
            this.DeleteStoreButton.AutoSize = true;
            this.DeleteStoreButton.BackColor = System.Drawing.Color.White;
            this.DeleteStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStoreButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStoreButton.Location = new System.Drawing.Point(852, 732);
            this.DeleteStoreButton.Name = "DeleteStoreButton";
            this.DeleteStoreButton.Size = new System.Drawing.Size(188, 61);
            this.DeleteStoreButton.TabIndex = 23;
            this.DeleteStoreButton.Text = "Удалить магазин";
            this.DeleteStoreButton.UseVisualStyleBackColor = false;
            this.DeleteStoreButton.Click += new System.EventHandler(this.DeleteStoreButton_Click);
            // 
            // ClearStoresButton
            // 
            this.ClearStoresButton.AutoSize = true;
            this.ClearStoresButton.BackColor = System.Drawing.Color.White;
            this.ClearStoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearStoresButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearStoresButton.Location = new System.Drawing.Point(1117, 732);
            this.ClearStoresButton.Name = "ClearStoresButton";
            this.ClearStoresButton.Size = new System.Drawing.Size(188, 61);
            this.ClearStoresButton.TabIndex = 24;
            this.ClearStoresButton.Text = "Очистить список";
            this.ClearStoresButton.UseVisualStyleBackColor = false;
            this.ClearStoresButton.Click += new System.EventHandler(this.ClearStoresButton_Click);
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1330, 831);
            this.Controls.Add(this.ClearStoresButton);
            this.Controls.Add(this.DeleteStoreButton);
            this.Controls.Add(this.StoreNameToDeleteTextBox);
            this.Controls.Add(this.lblStoreNameToDelete);
            this.Controls.Add(this.StoresDataGridView);
            this.Controls.Add(this.StoreAreaNumericUpDown);
            this.Controls.Add(this.lblStoreArea);
            this.Controls.Add(this.StoreTypeComboBox);
            this.Controls.Add(this.lblStoreTypeLabel);
            this.Controls.Add(this.CreateStoreButton);
            this.Controls.Add(this.AnnualRevenueNumericUpDown);
            this.Controls.Add(this.MonthlyRevenueNumericUpDown);
            this.Controls.Add(this.MonthlyPurchasesNumericUpDown);
            this.Controls.Add(this.NumberOfProductsNumericUpDown);
            this.Controls.Add(this.StoreNameTextBox);
            this.Controls.Add(this.NumberOfVisitorsNumericUpDown);
            this.Controls.Add(this.OwnerTextBox);
            this.Controls.Add(this.lblAnnualRevenue);
            this.Controls.Add(this.lblMonthlyRevenue);
            this.Controls.Add(this.lblMonthlyPurchases);
            this.Controls.Add(this.lblNumberOfProducts);
            this.Controls.Add(this.lblNumberOfVisitors);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblStoreName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuilderForm";
            this.Text = "BuilderForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfVisitorsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfProductsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyPurchasesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRevenueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualRevenueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreAreaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblNumberOfVisitors;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label lblMonthlyPurchases;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.Label lblAnnualRevenue;
        private System.Windows.Forms.TextBox OwnerTextBox;
        private System.Windows.Forms.NumericUpDown NumberOfVisitorsNumericUpDown;
        private System.Windows.Forms.NumericUpDown NumberOfProductsNumericUpDown;
        private System.Windows.Forms.NumericUpDown MonthlyPurchasesNumericUpDown;
        private System.Windows.Forms.NumericUpDown MonthlyRevenueNumericUpDown;
        private System.Windows.Forms.NumericUpDown AnnualRevenueNumericUpDown;
        private System.Windows.Forms.Button CreateStoreButton;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.Label lblStoreTypeLabel;
        private System.Windows.Forms.ComboBox StoreTypeComboBox;
        private System.Windows.Forms.Label lblStoreArea;
        private System.Windows.Forms.NumericUpDown StoreAreaNumericUpDown;
        private System.Windows.Forms.DataGridView StoresDataGridView;
        private System.Windows.Forms.TextBox StoreNameToDeleteTextBox;
        private System.Windows.Forms.Label lblStoreNameToDelete;
        private System.Windows.Forms.Button DeleteStoreButton;
        private System.Windows.Forms.Button ClearStoresButton;
    }
}