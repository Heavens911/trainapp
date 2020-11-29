namespace Ceiling_App
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.DelOrderButton = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(105, 423);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(194, 27);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить Заказчика (ФИО )";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр заказчиков";
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 15;
            this.ClientListBox.Location = new System.Drawing.Point(66, 81);
            this.ClientListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(275, 304);
            this.ClientListBox.TabIndex = 3;
            this.ClientListBox.SelectedIndexChanged += new System.EventHandler(this.ClientListBox_SelectedIndexChanged);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(104, 495);
            this.DelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(195, 27);
            this.DelButton.TabIndex = 5;
            this.DelButton.Text = "Удалить выбранную запись";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.ItemHeight = 15;
            this.OrdersListBox.Location = new System.Drawing.Point(481, 81);
            this.OrdersListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrdersListBox.MultiColumn = true;
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(135, 304);
            this.OrdersListBox.TabIndex = 7;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заказ";
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Location = new System.Drawing.Point(481, 464);
            this.EditOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(231, 42);
            this.EditOrderButton.TabIndex = 10;
            this.EditOrderButton.Text = "Изменить запись";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.ChangeButtonClick_Click);
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(659, 81);
            this.OrderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(282, 304);
            this.OrderTextBox.TabIndex = 11;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(481, 408);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(231, 42);
            this.AddOrderButton.TabIndex = 12;
            this.AddOrderButton.Text = "Добавить Запись";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // DelOrderButton
            // 
            this.DelOrderButton.Location = new System.Drawing.Point(481, 512);
            this.DelOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DelOrderButton.Name = "DelOrderButton";
            this.DelOrderButton.Size = new System.Drawing.Size(231, 42);
            this.DelOrderButton.TabIndex = 13;
            this.DelOrderButton.Text = "Удалить запись";
            this.DelOrderButton.UseVisualStyleBackColor = true;
            this.DelOrderButton.Click += new System.EventHandler(this.DelOrderButton_Click);
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(104, 456);
            this.EditClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(194, 27);
            this.EditClient.TabIndex = 0;
            this.EditClient.Text = "Редактировать Заказчика (ФИО )";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 586);
            this.Controls.Add(this.EditClient);
            this.Controls.Add(this.DelOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdersListBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.TextBox OrderTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button DelOrderButton;
        private System.Windows.Forms.Button EditClient;
    }
}

