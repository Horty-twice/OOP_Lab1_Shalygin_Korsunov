namespace OOP_Lab1_Shalygin_Korsunov.Lab4
{
    partial class InventoryForm
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.infoLablelAboutListProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(13, 56);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(856, 452);
            this.inventoryListBox.TabIndex = 0;
            // 
            // infoLablelAboutListProducts
            // 
            this.infoLablelAboutListProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLablelAboutListProducts.AutoSize = true;
            this.infoLablelAboutListProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLablelAboutListProducts.Location = new System.Drawing.Point(259, 9);
            this.infoLablelAboutListProducts.Name = "infoLablelAboutListProducts";
            this.infoLablelAboutListProducts.Size = new System.Drawing.Size(370, 27);
            this.infoLablelAboutListProducts.TabIndex = 1;
            this.infoLablelAboutListProducts.Text = "Список всех добавленных товаров:";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(881, 534);
            this.Controls.Add(this.infoLablelAboutListProducts);
            this.Controls.Add(this.inventoryListBox);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label infoLablelAboutListProducts;
    }
}