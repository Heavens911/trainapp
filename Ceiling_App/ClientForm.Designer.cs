namespace Ceiling_App
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientLastnameField = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancellButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя клиента";
            // 
            // ClientNameField
            // 
            this.ClientNameField.Location = new System.Drawing.Point(206, 84);
            this.ClientNameField.Name = "ClientNameField";
            this.ClientNameField.Size = new System.Drawing.Size(266, 23);
            this.ClientNameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия клиента";
            // 
            // ClientLastnameField
            // 
            this.ClientLastnameField.Location = new System.Drawing.Point(206, 128);
            this.ClientLastnameField.Name = "ClientLastnameField";
            this.ClientLastnameField.Size = new System.Drawing.Size(266, 23);
            this.ClientLastnameField.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(206, 189);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 44);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить запись";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancellButton
            // 
            this.CancellButton.Location = new System.Drawing.Point(381, 200);
            this.CancellButton.Name = "CancellButton";
            this.CancellButton.Size = new System.Drawing.Size(75, 23);
            this.CancellButton.TabIndex = 2;
            this.CancellButton.Text = "Отмена";
            this.CancellButton.UseVisualStyleBackColor = true;
            this.CancellButton.Click += new System.EventHandler(this.CancellButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 280);
            this.Controls.Add(this.CancellButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClientLastnameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientNameField);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientLastnameField;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancellButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}