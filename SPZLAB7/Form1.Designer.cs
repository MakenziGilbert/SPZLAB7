
namespace SPZLAB7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddWorkerBtn = new System.Windows.Forms.Button();
            this.ClearDBBtn = new System.Windows.Forms.Button();
            this.GetFromDBBtn = new System.Windows.Forms.Button();
            this.UpdateDBBtn = new System.Windows.Forms.Button();
            this.UpdateCompanyBtn = new System.Windows.Forms.Button();
            this.LoadBDBtn = new System.Windows.Forms.Button();
            this.ClearCompanyBtn = new System.Windows.Forms.Button();
            this.AddCompanyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(407, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 260);
            this.dataGridView2.TabIndex = 1;
            // 
            // AddWorkerBtn
            // 
            this.AddWorkerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorkerBtn.Location = new System.Drawing.Point(59, 287);
            this.AddWorkerBtn.Name = "AddWorkerBtn";
            this.AddWorkerBtn.Size = new System.Drawing.Size(109, 50);
            this.AddWorkerBtn.TabIndex = 2;
            this.AddWorkerBtn.Text = "Добавить работника";
            this.AddWorkerBtn.UseVisualStyleBackColor = true;
            this.AddWorkerBtn.Click += new System.EventHandler(this.AddWorkerBtn_Click);
            // 
            // ClearDBBtn
            // 
            this.ClearDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDBBtn.Location = new System.Drawing.Point(174, 343);
            this.ClearDBBtn.Name = "ClearDBBtn";
            this.ClearDBBtn.Size = new System.Drawing.Size(109, 50);
            this.ClearDBBtn.TabIndex = 4;
            this.ClearDBBtn.Text = "Очистить DataBase";
            this.ClearDBBtn.UseVisualStyleBackColor = true;
            this.ClearDBBtn.Click += new System.EventHandler(this.ClearDBBtn_Click);
            // 
            // GetFromDBBtn
            // 
            this.GetFromDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetFromDBBtn.Location = new System.Drawing.Point(59, 343);
            this.GetFromDBBtn.Name = "GetFromDBBtn";
            this.GetFromDBBtn.Size = new System.Drawing.Size(109, 50);
            this.GetFromDBBtn.TabIndex = 5;
            this.GetFromDBBtn.Text = "Загрузить из DataBase";
            this.GetFromDBBtn.UseVisualStyleBackColor = true;
            this.GetFromDBBtn.Click += new System.EventHandler(this.GetFromDBBtn_Click);
            // 
            // UpdateDBBtn
            // 
            this.UpdateDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDBBtn.Location = new System.Drawing.Point(174, 287);
            this.UpdateDBBtn.Name = "UpdateDBBtn";
            this.UpdateDBBtn.Size = new System.Drawing.Size(109, 50);
            this.UpdateDBBtn.TabIndex = 6;
            this.UpdateDBBtn.Text = "Обновить DataBase";
            this.UpdateDBBtn.UseVisualStyleBackColor = true;
            this.UpdateDBBtn.Click += new System.EventHandler(this.UpdateDBBtn_Click);
            // 
            // UpdateCompanyBtn
            // 
            this.UpdateCompanyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateCompanyBtn.Location = new System.Drawing.Point(573, 287);
            this.UpdateCompanyBtn.Name = "UpdateCompanyBtn";
            this.UpdateCompanyBtn.Size = new System.Drawing.Size(109, 50);
            this.UpdateCompanyBtn.TabIndex = 10;
            this.UpdateCompanyBtn.Text = "Обновить DataBase";
            this.UpdateCompanyBtn.UseVisualStyleBackColor = true;
            this.UpdateCompanyBtn.Click += new System.EventHandler(this.UpdateCompanyBtn_Click);
            // 
            // LoadBDBtn
            // 
            this.LoadBDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadBDBtn.Location = new System.Drawing.Point(458, 343);
            this.LoadBDBtn.Name = "LoadBDBtn";
            this.LoadBDBtn.Size = new System.Drawing.Size(109, 50);
            this.LoadBDBtn.TabIndex = 9;
            this.LoadBDBtn.Text = "Загрузить из DataBase";
            this.LoadBDBtn.UseVisualStyleBackColor = true;
            this.LoadBDBtn.Click += new System.EventHandler(this.LoadBDBtn_Click);
            // 
            // ClearCompanyBtn
            // 
            this.ClearCompanyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearCompanyBtn.Location = new System.Drawing.Point(573, 343);
            this.ClearCompanyBtn.Name = "ClearCompanyBtn";
            this.ClearCompanyBtn.Size = new System.Drawing.Size(109, 50);
            this.ClearCompanyBtn.TabIndex = 8;
            this.ClearCompanyBtn.Text = "Очистить DataBase";
            this.ClearCompanyBtn.UseVisualStyleBackColor = true;
            this.ClearCompanyBtn.Click += new System.EventHandler(this.ClearCompanyBtn_Click);
            // 
            // AddCompanyBtn
            // 
            this.AddCompanyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCompanyBtn.Location = new System.Drawing.Point(458, 287);
            this.AddCompanyBtn.Name = "AddCompanyBtn";
            this.AddCompanyBtn.Size = new System.Drawing.Size(109, 50);
            this.AddCompanyBtn.TabIndex = 7;
            this.AddCompanyBtn.Text = "Добавить предприятие";
            this.AddCompanyBtn.UseVisualStyleBackColor = true;
            this.AddCompanyBtn.Click += new System.EventHandler(this.AddCompanyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.UpdateCompanyBtn);
            this.Controls.Add(this.LoadBDBtn);
            this.Controls.Add(this.ClearCompanyBtn);
            this.Controls.Add(this.AddCompanyBtn);
            this.Controls.Add(this.UpdateDBBtn);
            this.Controls.Add(this.GetFromDBBtn);
            this.Controls.Add(this.ClearDBBtn);
            this.Controls.Add(this.AddWorkerBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddWorkerBtn;
        private System.Windows.Forms.Button ClearDBBtn;
        private System.Windows.Forms.Button GetFromDBBtn;
        private System.Windows.Forms.Button UpdateDBBtn;
        private System.Windows.Forms.Button UpdateCompanyBtn;
        private System.Windows.Forms.Button LoadBDBtn;
        private System.Windows.Forms.Button ClearCompanyBtn;
        private System.Windows.Forms.Button AddCompanyBtn;
    }
}

