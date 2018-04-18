namespace VMLAB5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.NAddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GaussButton = new System.Windows.Forms.Button();
            this.ZeidelButton = new System.Windows.Forms.Button();
            this.SweepButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.matrixDataGridView = new System.Windows.Forms.DataGridView();
            this.IsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество столбцов (строк):";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(219, 6);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 20);
            this.NTextBox.TabIndex = 1;
            // 
            // NAddButton
            // 
            this.NAddButton.Location = new System.Drawing.Point(325, 6);
            this.NAddButton.Name = "NAddButton";
            this.NAddButton.Size = new System.Drawing.Size(95, 23);
            this.NAddButton.TabIndex = 3;
            this.NAddButton.Text = "Ввести";
            this.NAddButton.UseVisualStyleBackColor = true;
            this.NAddButton.Click += new System.EventHandler(this.NAddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 242);
            this.dataGridView1.TabIndex = 4;
            // 
            // GaussButton
            // 
            this.GaussButton.Location = new System.Drawing.Point(607, 12);
            this.GaussButton.Name = "GaussButton";
            this.GaussButton.Size = new System.Drawing.Size(181, 23);
            this.GaussButton.TabIndex = 5;
            this.GaussButton.Text = "Решить методом Гаусса";
            this.GaussButton.UseVisualStyleBackColor = true;
            this.GaussButton.Click += new System.EventHandler(this.GaussButton_Click);
            // 
            // ZeidelButton
            // 
            this.ZeidelButton.Location = new System.Drawing.Point(607, 41);
            this.ZeidelButton.Name = "ZeidelButton";
            this.ZeidelButton.Size = new System.Drawing.Size(181, 23);
            this.ZeidelButton.TabIndex = 6;
            this.ZeidelButton.Text = "Решить методом Зейделя";
            this.ZeidelButton.UseVisualStyleBackColor = true;
            this.ZeidelButton.Click += new System.EventHandler(this.ZeidelButton_Click);
            // 
            // SweepButton
            // 
            this.SweepButton.Location = new System.Drawing.Point(607, 70);
            this.SweepButton.Name = "SweepButton";
            this.SweepButton.Size = new System.Drawing.Size(181, 23);
            this.SweepButton.TabIndex = 7;
            this.SweepButton.Text = "Решить методом прогонки";
            this.SweepButton.UseVisualStyleBackColor = true;
            this.SweepButton.Click += new System.EventHandler(this.SweepButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Точность: ";
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.Location = new System.Drawing.Point(78, 28);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.accuracyTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат: ";
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(80, 302);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.Size = new System.Drawing.Size(270, 63);
            this.resultDataGridView.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Трёхдиагональная матрица: ";
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGridView.Location = new System.Drawing.Point(169, 371);
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.ReadOnly = true;
            this.matrixDataGridView.Size = new System.Drawing.Size(348, 237);
            this.matrixDataGridView.TabIndex = 13;
            // 
            // IsButton
            // 
            this.IsButton.Location = new System.Drawing.Point(607, 99);
            this.IsButton.Name = "IsButton";
            this.IsButton.Size = new System.Drawing.Size(181, 23);
            this.IsButton.TabIndex = 14;
            this.IsButton.Text = "Проверить сходимость";
            this.IsButton.UseVisualStyleBackColor = true;
            this.IsButton.Click += new System.EventHandler(this.IsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Сходимость: ";
            // 
            // IsTextBox
            // 
            this.IsTextBox.Location = new System.Drawing.Point(264, 31);
            this.IsTextBox.Name = "IsTextBox";
            this.IsTextBox.Size = new System.Drawing.Size(100, 20);
            this.IsTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.IsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IsButton);
            this.Controls.Add(this.matrixDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accuracyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SweepButton);
            this.Controls.Add(this.ZeidelButton);
            this.Controls.Add(this.GaussButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NAddButton);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Button NAddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GaussButton;
        private System.Windows.Forms.Button ZeidelButton;
        private System.Windows.Forms.Button SweepButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView matrixDataGridView;
        private System.Windows.Forms.Button IsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IsTextBox;
    }
}

