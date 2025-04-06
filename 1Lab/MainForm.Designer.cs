namespace OOP_Lab1_Shalygin_Korsunov
{
    partial class InterfaceWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceWindow));
            this.OutputField = new System.Windows.Forms.Label();
            this.StoreInformation = new System.Windows.Forms.Label();
            this.Founder = new System.Windows.Forms.Label();
            this.NameOfStore = new System.Windows.Forms.Label();
            this.CountOfVisitors = new System.Windows.Forms.Label();
            this.CountOfProducts = new System.Windows.Forms.Label();
            this.CountOfPurcashes = new System.Windows.Forms.Label();
            this.MonthlyTurnover = new System.Windows.Forms.Label();
            this.YearTurnover = new System.Windows.Forms.Label();
            this.FounderTextBox = new System.Windows.Forms.TextBox();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.NumderOfVisitorsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfProductsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPurcashesTextBox = new System.Windows.Forms.TextBox();
            this.MonthlyTurnoverTextBox = new System.Windows.Forms.TextBox();
            this.YearTurnoverTextBox = new System.Windows.Forms.TextBox();
            this.ChangeInformation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MainInformation = new System.Windows.Forms.Label();
            this.CallErrorButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ConversionTo16Format = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputField
            // 
            this.OutputField.BackColor = System.Drawing.Color.Linen;
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputField.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputField.Location = new System.Drawing.Point(6, 112);
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(679, 438);
            this.OutputField.TabIndex = 0;
            // 
            // StoreInformation
            // 
            this.StoreInformation.AutoSize = true;
            this.StoreInformation.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreInformation.Location = new System.Drawing.Point(12, 82);
            this.StoreInformation.Name = "StoreInformation";
            this.StoreInformation.Size = new System.Drawing.Size(338, 24);
            this.StoreInformation.TabIndex = 1;
            this.StoreInformation.Text = "Информация об интернет-магазине:";
            // 
            // Founder
            // 
            this.Founder.AutoSize = true;
            this.Founder.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Founder.Location = new System.Drawing.Point(687, 137);
            this.Founder.Name = "Founder";
            this.Founder.Size = new System.Drawing.Size(263, 19);
            this.Founder.TabIndex = 2;
            this.Founder.Text = "Основатель интернет-магазина:";
            // 
            // NameOfStore
            // 
            this.NameOfStore.AutoSize = true;
            this.NameOfStore.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfStore.Location = new System.Drawing.Point(687, 185);
            this.NameOfStore.Name = "NameOfStore";
            this.NameOfStore.Size = new System.Drawing.Size(246, 19);
            this.NameOfStore.TabIndex = 3;
            this.NameOfStore.Text = "Название интернет-магазина:";
            // 
            // CountOfVisitors
            // 
            this.CountOfVisitors.AutoSize = true;
            this.CountOfVisitors.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfVisitors.Location = new System.Drawing.Point(687, 236);
            this.CountOfVisitors.Name = "CountOfVisitors";
            this.CountOfVisitors.Size = new System.Drawing.Size(166, 19);
            this.CountOfVisitors.TabIndex = 4;
            this.CountOfVisitors.Text = "Число посетителей:";
            // 
            // CountOfProducts
            // 
            this.CountOfProducts.AutoSize = true;
            this.CountOfProducts.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfProducts.Location = new System.Drawing.Point(687, 286);
            this.CountOfProducts.Name = "CountOfProducts";
            this.CountOfProducts.Size = new System.Drawing.Size(221, 19);
            this.CountOfProducts.TabIndex = 5;
            this.CountOfProducts.Text = "Число доступных товаров:";
            // 
            // CountOfPurcashes
            // 
            this.CountOfPurcashes.AutoSize = true;
            this.CountOfPurcashes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfPurcashes.Location = new System.Drawing.Point(687, 337);
            this.CountOfPurcashes.Name = "CountOfPurcashes";
            this.CountOfPurcashes.Size = new System.Drawing.Size(199, 19);
            this.CountOfPurcashes.TabIndex = 6;
            this.CountOfPurcashes.Text = "Число покупок в месяц:";
            // 
            // MonthlyTurnover
            // 
            this.MonthlyTurnover.AutoSize = true;
            this.MonthlyTurnover.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthlyTurnover.Location = new System.Drawing.Point(687, 391);
            this.MonthlyTurnover.Name = "MonthlyTurnover";
            this.MonthlyTurnover.Size = new System.Drawing.Size(226, 19);
            this.MonthlyTurnover.TabIndex = 7;
            this.MonthlyTurnover.Text = "Денежный оборот в месяц:";
            // 
            // YearTurnover
            // 
            this.YearTurnover.AutoSize = true;
            this.YearTurnover.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTurnover.Location = new System.Drawing.Point(687, 447);
            this.YearTurnover.Name = "YearTurnover";
            this.YearTurnover.Size = new System.Drawing.Size(205, 19);
            this.YearTurnover.TabIndex = 8;
            this.YearTurnover.Text = "Денежный оборот в год:";
            // 
            // FounderTextBox
            // 
            this.FounderTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FounderTextBox.Location = new System.Drawing.Point(968, 133);
            this.FounderTextBox.Name = "FounderTextBox";
            this.FounderTextBox.Size = new System.Drawing.Size(137, 27);
            this.FounderTextBox.TabIndex = 9;
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNameTextBox.Location = new System.Drawing.Point(968, 177);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(137, 27);
            this.StoreNameTextBox.TabIndex = 10;
            // 
            // NumderOfVisitorsTextBox
            // 
            this.NumderOfVisitorsTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumderOfVisitorsTextBox.Location = new System.Drawing.Point(968, 228);
            this.NumderOfVisitorsTextBox.Name = "NumderOfVisitorsTextBox";
            this.NumderOfVisitorsTextBox.Size = new System.Drawing.Size(137, 27);
            this.NumderOfVisitorsTextBox.TabIndex = 11;
            // 
            // NumberOfProductsTextBox
            // 
            this.NumberOfProductsTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfProductsTextBox.Location = new System.Drawing.Point(968, 282);
            this.NumberOfProductsTextBox.Name = "NumberOfProductsTextBox";
            this.NumberOfProductsTextBox.Size = new System.Drawing.Size(137, 27);
            this.NumberOfProductsTextBox.TabIndex = 12;
            // 
            // NumberOfPurcashesTextBox
            // 
            this.NumberOfPurcashesTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPurcashesTextBox.Location = new System.Drawing.Point(968, 329);
            this.NumberOfPurcashesTextBox.Name = "NumberOfPurcashesTextBox";
            this.NumberOfPurcashesTextBox.Size = new System.Drawing.Size(137, 27);
            this.NumberOfPurcashesTextBox.TabIndex = 13;
            // 
            // MonthlyTurnoverTextBox
            // 
            this.MonthlyTurnoverTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyTurnoverTextBox.Location = new System.Drawing.Point(968, 383);
            this.MonthlyTurnoverTextBox.Name = "MonthlyTurnoverTextBox";
            this.MonthlyTurnoverTextBox.Size = new System.Drawing.Size(137, 27);
            this.MonthlyTurnoverTextBox.TabIndex = 14;
            // 
            // YearTurnoverTextBox
            // 
            this.YearTurnoverTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTurnoverTextBox.Location = new System.Drawing.Point(968, 439);
            this.YearTurnoverTextBox.Name = "YearTurnoverTextBox";
            this.YearTurnoverTextBox.Size = new System.Drawing.Size(137, 27);
            this.YearTurnoverTextBox.TabIndex = 15;
            // 
            // ChangeInformation
            // 
            this.ChangeInformation.AutoSize = true;
            this.ChangeInformation.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInformation.Location = new System.Drawing.Point(703, 82);
            this.ChangeInformation.Name = "ChangeInformation";
            this.ChangeInformation.Size = new System.Drawing.Size(392, 19);
            this.ChangeInformation.TabIndex = 18;
            this.ChangeInformation.Text = "Изменение ифнормации об интернет-магазине:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SeaShell;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(248, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 62);
            this.label11.TabIndex = 20;
            // 
            // MainInformation
            // 
            this.MainInformation.BackColor = System.Drawing.Color.Moccasin;
            this.MainInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainInformation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainInformation.Location = new System.Drawing.Point(417, 9);
            this.MainInformation.Name = "MainInformation";
            this.MainInformation.Size = new System.Drawing.Size(418, 58);
            this.MainInformation.TabIndex = 21;
            // 
            // CallErrorButton
            // 
            this.CallErrorButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CallErrorButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CallErrorButton.Location = new System.Drawing.Point(2, 9);
            this.CallErrorButton.Name = "CallErrorButton";
            this.CallErrorButton.Size = new System.Drawing.Size(153, 58);
            this.CallErrorButton.TabIndex = 24;
            this.CallErrorButton.Text = "Вызывать исключение";
            this.CallErrorButton.UseVisualStyleBackColor = false;
            this.CallErrorButton.Click += new System.EventHandler(this.CallErrorButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ControlButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlButton.Location = new System.Drawing.Point(170, 9);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(153, 58);
            this.ControlButton.TabIndex = 25;
            this.ControlButton.Text = "Проверить посетителей";
            this.ControlButton.UseVisualStyleBackColor = false;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // ConversionTo16Format
            // 
            this.ConversionTo16Format.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ConversionTo16Format.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConversionTo16Format.Location = new System.Drawing.Point(6, 557);
            this.ConversionTo16Format.Name = "ConversionTo16Format";
            this.ConversionTo16Format.Size = new System.Drawing.Size(200, 58);
            this.ConversionTo16Format.TabIndex = 26;
            this.ConversionTo16Format.Text = "Число товаров в 16-ом формате";
            this.ConversionTo16Format.UseVisualStyleBackColor = false;
            this.ConversionTo16Format.Click += new System.EventHandler(this.ConversionTo16Format_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(983, 570);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 45);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(842, 494);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(154, 56);
            this.ChangeButton.TabIndex = 28;
            this.ChangeButton.Text = "Внести изменения";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // InterfaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1121, 627);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConversionTo16Format);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.CallErrorButton);
            this.Controls.Add(this.MainInformation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ChangeInformation);
            this.Controls.Add(this.YearTurnoverTextBox);
            this.Controls.Add(this.MonthlyTurnoverTextBox);
            this.Controls.Add(this.NumberOfPurcashesTextBox);
            this.Controls.Add(this.NumberOfProductsTextBox);
            this.Controls.Add(this.NumderOfVisitorsTextBox);
            this.Controls.Add(this.StoreNameTextBox);
            this.Controls.Add(this.FounderTextBox);
            this.Controls.Add(this.YearTurnover);
            this.Controls.Add(this.MonthlyTurnover);
            this.Controls.Add(this.CountOfPurcashes);
            this.Controls.Add(this.CountOfProducts);
            this.Controls.Add(this.CountOfVisitors);
            this.Controls.Add(this.NameOfStore);
            this.Controls.Add(this.Founder);
            this.Controls.Add(this.StoreInformation);
            this.Controls.Add(this.OutputField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceWindow";
            this.Text = "OnlineStore";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputField;
        private System.Windows.Forms.Label StoreInformation;
        private System.Windows.Forms.Label Founder;
        private System.Windows.Forms.Label NameOfStore;
        private System.Windows.Forms.Label CountOfVisitors;
        private System.Windows.Forms.Label CountOfProducts;
        private System.Windows.Forms.Label CountOfPurcashes;
        private System.Windows.Forms.Label MonthlyTurnover;
        private System.Windows.Forms.Label YearTurnover;
        private System.Windows.Forms.TextBox FounderTextBox;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.TextBox NumderOfVisitorsTextBox;
        private System.Windows.Forms.TextBox NumberOfProductsTextBox;
        private System.Windows.Forms.TextBox NumberOfPurcashesTextBox;
        private System.Windows.Forms.TextBox MonthlyTurnoverTextBox;
        private System.Windows.Forms.TextBox YearTurnoverTextBox;
        private System.Windows.Forms.Label ChangeInformation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MainInformation;
        private System.Windows.Forms.Button CallErrorButton;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button ConversionTo16Format;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangeButton;
    }
}

