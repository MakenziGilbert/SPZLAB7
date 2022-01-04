
namespace SPZLAB7
{
    partial class AddWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNameTbx = new System.Windows.Forms.TextBox();
            this.AddSurnameTbx = new System.Windows.Forms.TextBox();
            this.AddSalaryTbx = new System.Windows.Forms.TextBox();
            this.AddWorkerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зарплата:";
            // 
            // AddNameTbx
            // 
            this.AddNameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameTbx.Location = new System.Drawing.Point(122, 30);
            this.AddNameTbx.Name = "AddNameTbx";
            this.AddNameTbx.Size = new System.Drawing.Size(198, 26);
            this.AddNameTbx.TabIndex = 3;
            // 
            // AddSurnameTbx
            // 
            this.AddSurnameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSurnameTbx.Location = new System.Drawing.Point(122, 83);
            this.AddSurnameTbx.Name = "AddSurnameTbx";
            this.AddSurnameTbx.Size = new System.Drawing.Size(198, 26);
            this.AddSurnameTbx.TabIndex = 4;
            // 
            // AddSalaryTbx
            // 
            this.AddSalaryTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSalaryTbx.Location = new System.Drawing.Point(122, 145);
            this.AddSalaryTbx.Name = "AddSalaryTbx";
            this.AddSalaryTbx.Size = new System.Drawing.Size(198, 26);
            this.AddSalaryTbx.TabIndex = 5;
            // 
            // AddWorkerBtn
            // 
            this.AddWorkerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorkerBtn.Location = new System.Drawing.Point(122, 198);
            this.AddWorkerBtn.Name = "AddWorkerBtn";
            this.AddWorkerBtn.Size = new System.Drawing.Size(118, 43);
            this.AddWorkerBtn.TabIndex = 6;
            this.AddWorkerBtn.Text = "Добавить";
            this.AddWorkerBtn.UseVisualStyleBackColor = true;
            this.AddWorkerBtn.Click += new System.EventHandler(this.AddWorkerBtn_Click);
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 264);
            this.Controls.Add(this.AddWorkerBtn);
            this.Controls.Add(this.AddSalaryTbx);
            this.Controls.Add(this.AddSurnameTbx);
            this.Controls.Add(this.AddNameTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNameTbx;
        private System.Windows.Forms.TextBox AddSurnameTbx;
        private System.Windows.Forms.TextBox AddSalaryTbx;
        private System.Windows.Forms.Button AddWorkerBtn;
    }
}