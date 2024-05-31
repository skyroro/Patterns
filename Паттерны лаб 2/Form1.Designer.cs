namespace Паттерны_лаб_2
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
            this.GenerationUsual = new System.Windows.Forms.Button();
            this.GenerationSparse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Bord = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Shadow = new System.Windows.Forms.CheckBox();
            this.Renumber = new System.Windows.Forms.Button();
            this.Recover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerationUsual
            // 
            this.GenerationUsual.BackColor = System.Drawing.SystemColors.Window;
            this.GenerationUsual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerationUsual.Location = new System.Drawing.Point(35, 35);
            this.GenerationUsual.Name = "GenerationUsual";
            this.GenerationUsual.Size = new System.Drawing.Size(255, 120);
            this.GenerationUsual.TabIndex = 0;
            this.GenerationUsual.Text = "Генерация обычной матрицы";
            this.GenerationUsual.UseVisualStyleBackColor = false;
            this.GenerationUsual.Click += new System.EventHandler(this.GenerationUsual_Click);
            // 
            // GenerationSparse
            // 
            this.GenerationSparse.BackColor = System.Drawing.SystemColors.Window;
            this.GenerationSparse.Location = new System.Drawing.Point(35, 161);
            this.GenerationSparse.Name = "GenerationSparse";
            this.GenerationSparse.Size = new System.Drawing.Size(255, 120);
            this.GenerationSparse.TabIndex = 1;
            this.GenerationSparse.Text = "Генерация разреженной матрицы";
            this.GenerationSparse.UseVisualStyleBackColor = false;
            this.GenerationSparse.Click += new System.EventHandler(this.GenerationSparse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(305, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 700);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1025, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 700);
            this.textBox1.TabIndex = 3;
            // 
            // Bord
            // 
            this.Bord.AutoSize = true;
            this.Bord.BackColor = System.Drawing.SystemColors.Window;
            this.Bord.Location = new System.Drawing.Point(35, 556);
            this.Bord.Name = "Bord";
            this.Bord.Size = new System.Drawing.Size(128, 29);
            this.Bord.TabIndex = 4;
            this.Bord.Text = "Граница";
            this.Bord.UseVisualStyleBackColor = false;
            this.Bord.CheckedChanged += new System.EventHandler(this.Bord_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(305, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(700, 35);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "  panel";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(1025, 35);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(700, 35);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "  textbox";
            // 
            // Shadow
            // 
            this.Shadow.AutoSize = true;
            this.Shadow.BackColor = System.Drawing.SystemColors.Window;
            this.Shadow.Location = new System.Drawing.Point(183, 556);
            this.Shadow.Name = "Shadow";
            this.Shadow.Size = new System.Drawing.Size(92, 29);
            this.Shadow.TabIndex = 7;
            this.Shadow.Text = "Тень";
            this.Shadow.UseVisualStyleBackColor = false;
            this.Shadow.CheckedChanged += new System.EventHandler(this.Shadow_CheckedChanged);
            // 
            // Renumber
            // 
            this.Renumber.Location = new System.Drawing.Point(35, 287);
            this.Renumber.Name = "Renumber";
            this.Renumber.Size = new System.Drawing.Size(255, 120);
            this.Renumber.TabIndex = 0;
            this.Renumber.Text = "Перенумеровать";
            this.Renumber.UseVisualStyleBackColor = true;
            this.Renumber.Click += new System.EventHandler(this.Renumber_Click);
            // 
            // Recover
            // 
            this.Recover.Location = new System.Drawing.Point(35, 413);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(255, 120);
            this.Recover.TabIndex = 1;
            this.Recover.Text = "Восстановить";
            this.Recover.UseVisualStyleBackColor = true;
            this.Recover.Click += new System.EventHandler(this.Recover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1762, 802);
            this.Controls.Add(this.Recover);
            this.Controls.Add(this.Shadow);
            this.Controls.Add(this.Renumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerationSparse);
            this.Controls.Add(this.GenerationUsual);
            this.Name = "Form1";
            this.Text = "Визуализация матриц";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerationUsual;
        private System.Windows.Forms.Button GenerationSparse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Bord;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox Shadow;
        private System.Windows.Forms.Button Recover;
        private System.Windows.Forms.Button Renumber;
    }
}

