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
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
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
            this.addProductButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductButton.AutoSize = true;
            this.addProductButton.BackColor = System.Drawing.Color.White;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductButton.Location = new System.Drawing.Point(583, 32);
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
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 23;
            this.logListBox.Location = new System.Drawing.Point(11, 159);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1250, 510);
            this.logListBox.TabIndex = 39;
            // 
            // showInventoryButton
            // 
            this.showInventoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showInventoryButton.AutoSize = true;
            this.showInventoryButton.BackColor = System.Drawing.Color.White;
            this.showInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInventoryButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInventoryButton.Location = new System.Drawing.Point(1030, 32);
            this.showInventoryButton.Name = "showInventoryButton";
            this.showInventoryButton.Size = new System.Drawing.Size(218, 61);
            this.showInventoryButton.TabIndex = 40;
            this.showInventoryButton.Text = "Весь список товаров";
            this.showInventoryButton.UseVisualStyleBackColor = false;
            this.showInventoryButton.Click += new System.EventHandler(this.showInventoryButton_Click);
            // 
            // FacadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1269, 681);
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
    }
}