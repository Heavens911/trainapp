namespace Traunappwindow
{
    partial class OrderForm
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
            this.OrderNameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PField = new System.Windows.Forms.TextBox();
            this.SField = new System.Windows.Forms.TextBox();
            this.SpotField = new System.Windows.Forms.TextBox();
            this.LustraField = new System.Windows.Forms.TextBox();
            this.PipeField = new System.Windows.Forms.TextBox();
            this.Price3Field = new System.Windows.Forms.TextBox();
            this.Price2Field = new System.Windows.Forms.TextBox();
            this.Price1Field = new System.Windows.Forms.TextBox();
            this.UglField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderNameField
            // 
            this.OrderNameField.Location = new System.Drawing.Point(209, 50);
            this.OrderNameField.Name = "OrderNameField";
            this.OrderNameField.Size = new System.Drawing.Size(100, 20);
            this.OrderNameField.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PField
            // 
            this.PField.Location = new System.Drawing.Point(209, 76);
            this.PField.Name = "PField";
            this.PField.Size = new System.Drawing.Size(100, 20);
            this.PField.TabIndex = 3;
            this.PField.TextChanged += new System.EventHandler(this.PField_TextChanged);
            this.PField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PField_KeyPress);
            this.PField.Validated += new System.EventHandler(this.DoubleField_Validated);
            // 
            // SField
            // 
            this.SField.Location = new System.Drawing.Point(209, 103);
            this.SField.Name = "SField";
            this.SField.Size = new System.Drawing.Size(100, 20);
            this.SField.TabIndex = 4;
            this.SField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PField_KeyPress);
            this.SField.Validated += new System.EventHandler(this.DoubleField_Validated);
            // 
            // SpotField
            // 
            this.SpotField.Location = new System.Drawing.Point(209, 131);
            this.SpotField.Name = "SpotField";
            this.SpotField.Size = new System.Drawing.Size(100, 20);
            this.SpotField.TabIndex = 5;
            this.SpotField.Validated += new System.EventHandler(this.IntField_Validated);
            // 
            // LustraField
            // 
            this.LustraField.Location = new System.Drawing.Point(209, 157);
            this.LustraField.Name = "LustraField";
            this.LustraField.Size = new System.Drawing.Size(100, 20);
            this.LustraField.TabIndex = 6;
            this.LustraField.Validated += new System.EventHandler(this.IntField_Validated);
            // 
            // PipeField
            // 
            this.PipeField.Location = new System.Drawing.Point(209, 183);
            this.PipeField.Name = "PipeField";
            this.PipeField.Size = new System.Drawing.Size(100, 20);
            this.PipeField.TabIndex = 7;
            this.PipeField.Validated += new System.EventHandler(this.IntField_Validated);
            // 
            // Price3Field
            // 
            this.Price3Field.Location = new System.Drawing.Point(209, 299);
            this.Price3Field.Name = "Price3Field";
            this.Price3Field.ReadOnly = true;
            this.Price3Field.Size = new System.Drawing.Size(100, 20);
            this.Price3Field.TabIndex = 22;
            // 
            // Price2Field
            // 
            this.Price2Field.Location = new System.Drawing.Point(209, 270);
            this.Price2Field.Name = "Price2Field";
            this.Price2Field.ReadOnly = true;
            this.Price2Field.Size = new System.Drawing.Size(100, 20);
            this.Price2Field.TabIndex = 21;
            // 
            // Price1Field
            // 
            this.Price1Field.Location = new System.Drawing.Point(209, 241);
            this.Price1Field.Name = "Price1Field";
            this.Price1Field.ReadOnly = true;
            this.Price1Field.Size = new System.Drawing.Size(100, 20);
            this.Price1Field.TabIndex = 20;
            // 
            // UglField
            // 
            this.UglField.Location = new System.Drawing.Point(209, 212);
            this.UglField.Name = "UglField";
            this.UglField.Size = new System.Drawing.Size(100, 20);
            this.UglField.TabIndex = 19;
            this.UglField.Validated += new System.EventHandler(this.IntField_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Название заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Периметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Светильник";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Люстра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Трубы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Углы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Цена1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Цена2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Цена3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancellButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price3Field);
            this.Controls.Add(this.Price2Field);
            this.Controls.Add(this.Price1Field);
            this.Controls.Add(this.UglField);
            this.Controls.Add(this.PipeField);
            this.Controls.Add(this.LustraField);
            this.Controls.Add(this.SpotField);
            this.Controls.Add(this.SField);
            this.Controls.Add(this.PField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderNameField);
            this.Name = "OrderForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OrderNameField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PField;
        private System.Windows.Forms.TextBox SField;
        private System.Windows.Forms.TextBox SpotField;
        private System.Windows.Forms.TextBox LustraField;
        private System.Windows.Forms.TextBox PipeField;
        private System.Windows.Forms.TextBox Price3Field;
        private System.Windows.Forms.TextBox Price2Field;
        private System.Windows.Forms.TextBox Price1Field;
        private System.Windows.Forms.TextBox UglField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}