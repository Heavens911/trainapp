using System;

namespace Traunappwindow
{
    partial class MainFrom
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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientSName = new System.Windows.Forms.TextBox();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.DelOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(161, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(166, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить Заказчика (ФИО )";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр заказчиков";
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.Location = new System.Drawing.Point(57, 70);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(236, 264);
            this.ClientListBox.TabIndex = 3;
            this.ClientListBox.SelectedIndexChanged += new System.EventHandler(this.ClientListBox_SelectedIndexChanged);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(177, 363);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(136, 20);
            this.ClientName.TabIndex = 4;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(161, 444);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(167, 23);
            this.DelButton.TabIndex = 5;
            this.DelButton.Text = "Удалить выбранную запись";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите Фамилию и Имя заказчика для добавления в список";
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.Location = new System.Drawing.Point(412, 70);
            this.OrdersListBox.MultiColumn = true;
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(116, 264);
            this.OrdersListBox.TabIndex = 7;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заказ";
            // 
            // ClientSName
            // 
            this.ClientSName.Location = new System.Drawing.Point(177, 389);
            this.ClientSName.Name = "ClientSName";
            this.ClientSName.Size = new System.Drawing.Size(136, 20);
            this.ClientSName.TabIndex = 9;
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Location = new System.Drawing.Point(412, 402);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(198, 36);
            this.EditOrderButton.TabIndex = 10;
            this.EditOrderButton.Text = "Изменить запись";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.ChangeButtonClick_Click);
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(565, 70);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(242, 264);
            this.OrderTextBox.TabIndex = 11;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(412, 354);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(198, 36);
            this.AddOrderButton.TabIndex = 12;
            this.AddOrderButton.Text = "Добавить Запись";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // DelOrderButton
            // 
            this.DelOrderButton.Location = new System.Drawing.Point(412, 444);
            this.DelOrderButton.Name = "DelOrderButton";
            this.DelOrderButton.Size = new System.Drawing.Size(198, 36);
            this.DelOrderButton.TabIndex = 13;
            this.DelOrderButton.Text = "Удалить запись";
            this.DelOrderButton.UseVisualStyleBackColor = true;
            this.DelOrderButton.Click += new System.EventHandler(this.DelOrderButton_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 508);
            this.Controls.Add(this.DelOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.ClientSName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdersListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientSName;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.TextBox OrderTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button DelOrderButton;
    }
}

