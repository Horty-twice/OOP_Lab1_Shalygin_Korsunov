namespace OOP_Lab1_Shalygin_Korsunov.Lab4
{
    partial class FacadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacadeForm));
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.lblquanity = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.showInventoryButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.FindProductButton = new System.Windows.Forms.Button();
            this.productNameTextBoxForDeleteOrFind = new System.Windows.Forms.TextBox();
            this.lblProductNameForDeleteOrFind = new System.Windows.Forms.Label();
            this.quantityForDeleteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityProductsForDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityForDeleteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(225, 72);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.quantityNumericUpDown.TabIndex = 38;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductName.Location = new System.Drawing.Point(8, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(175, 25);
            this.lblProductName.TabIndex = 35;
            this.lblProductName.Text = "Название товара:";
            // 
            // addProductButton
            // 
            this.addProductButton.AutoSize = true;
            this.addProductButton.BackColor = System.Drawing.Color.White;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductButton.Location = new System.Drawing.Point(11, 120);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(188, 61);
            this.addProductButton.TabIndex = 34;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTextBox.Location = new System.Drawing.Point(225, 21);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(337, 30);
            this.productNameTextBox.TabIndex = 28;
            // 
            // lblquanity
            // 
            this.lblquanity.AutoSize = true;
            this.lblquanity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblquanity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblquanity.Location = new System.Drawing.Point(8, 77);
            this.lblquanity.Name = "lblquanity";
            this.lblquanity.Size = new System.Drawing.Size(123, 25);
            this.lblquanity.TabIndex = 20;
            this.lblquanity.Text = "Количество";
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 27;
            this.logListBox.Location = new System.Drawing.Point(7, 230);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1250, 355);
            this.logListBox.TabIndex = 39;
            // 
            // showInventoryButton
            // 
            this.showInventoryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showInventoryButton.AutoSize = true;
            this.showInventoryButton.BackColor = System.Drawing.Color.White;
            this.showInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInventoryButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInventoryButton.Location = new System.Drawing.Point(517, 613);
            this.showInventoryButton.Name = "showInventoryButton";
            this.showInventoryButton.Size = new System.Drawing.Size(218, 61);
            this.showInventoryButton.TabIndex = 40;
            this.showInventoryButton.Text = "Весь список товаров";
            this.showInventoryButton.UseVisualStyleBackColor = false;
            this.showInventoryButton.Click += new System.EventHandler(this.showInventoryButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.AutoSize = true;
            this.DeleteProductButton.BackColor = System.Drawing.Color.White;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductButton.Location = new System.Drawing.Point(1039, 112);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(218, 61);
            this.DeleteProductButton.TabIndex = 41;
            this.DeleteProductButton.Text = "Удалить товар";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // FindProductButton
            // 
            this.FindProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindProductButton.BackColor = System.Drawing.Color.White;
            this.FindProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindProductButton.Location = new System.Drawing.Point(729, 112);
            this.FindProductButton.Name = "FindProductButton";
            this.FindProductButton.Size = new System.Drawing.Size(213, 76);
            this.FindProductButton.TabIndex = 42;
            this.FindProductButton.Text = "Проверить наличие товара";
            this.FindProductButton.UseVisualStyleBackColor = false;
            this.FindProductButton.Click += new System.EventHandler(this.FindProductButton_Click);
            // 
            // productNameTextBoxForDeleteOrFind
            // 
            this.productNameTextBoxForDeleteOrFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextBoxForDeleteOrFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTextBoxForDeleteOrFind.Location = new System.Drawing.Point(924, 21);
            this.productNameTextBoxForDeleteOrFind.Name = "productNameTextBoxForDeleteOrFind";
            this.productNameTextBoxForDeleteOrFind.Size = new System.Drawing.Size(337, 30);
            this.productNameTextBoxForDeleteOrFind.TabIndex = 43;
            // 
            // lblProductNameForDeleteOrFind
            // 
            this.lblProductNameForDeleteOrFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductNameForDeleteOrFind.AutoSize = true;
            this.lblProductNameForDeleteOrFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductNameForDeleteOrFind.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductNameForDeleteOrFind.Location = new System.Drawing.Point(724, 24);
            this.lblProductNameForDeleteOrFind.Name = "lblProductNameForDeleteOrFind";
            this.lblProductNameForDeleteOrFind.Size = new System.Drawing.Size(175, 25);
            this.lblProductNameForDeleteOrFind.TabIndex = 44;
            this.lblProductNameForDeleteOrFind.Text = "Название товара:";
            // 
            // quantityForDeleteNumericUpDown
            // 
            this.quantityForDeleteNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityForDeleteNumericUpDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityForDeleteNumericUpDown.Location = new System.Drawing.Point(924, 72);
            this.quantityForDeleteNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityForDeleteNumericUpDown.Name = "quantityForDeleteNumericUpDown";
            this.quantityForDeleteNumericUpDown.Size = new System.Drawing.Size(337, 30);
            this.quantityForDeleteNumericUpDown.TabIndex = 47;
            // 
            // lblQuantityProductsForDelete
            // 
            this.lblQuantityProductsForDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityProductsForDelete.AutoSize = true;
            this.lblQuantityProductsForDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantityProductsForDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantityProductsForDelete.Location = new System.Drawing.Point(724, 77);
            this.lblQuantityProductsForDelete.Name = "lblQuantityProductsForDelete";
            this.lblQuantityProductsForDelete.Size = new System.Drawing.Size(123, 25);
            this.lblQuantityProductsForDelete.TabIndex = 46;
            this.lblQuantityProductsForDelete.Text = "Количество";
            // 
            // FacadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1269, 686);
            this.Controls.Add(this.quantityForDeleteNumericUpDown);
            this.Controls.Add(this.lblQuantityProductsForDelete);
            this.Controls.Add(this.lblProductNameForDeleteOrFind);
            this.Controls.Add(this.productNameTextBoxForDeleteOrFind);
            this.Controls.Add(this.FindProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.showInventoryButton);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.lblquanity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacadeForm";
            this.Text = "FacadeForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityForDeleteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label lblquanity;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Button showInventoryButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button FindProductButton;
        private System.Windows.Forms.TextBox productNameTextBoxForDeleteOrFind;
        private System.Windows.Forms.Label lblProductNameForDeleteOrFind;
        private System.Windows.Forms.NumericUpDown quantityForDeleteNumericUpDown;
        private System.Windows.Forms.Label lblQuantityProductsForDelete;
    }
}