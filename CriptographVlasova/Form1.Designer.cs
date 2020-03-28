namespace CriptographVlasova
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Shifr = new System.Windows.Forms.Button();
            this.Deshifr = new System.Windows.Forms.Button();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(122, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходная строчка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(121, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шифр замены";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 195);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Shifr
            // 
            this.Shifr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shifr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shifr.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Shifr.Location = new System.Drawing.Point(213, 330);
            this.Shifr.Name = "Shifr";
            this.Shifr.Size = new System.Drawing.Size(199, 42);
            this.Shifr.TabIndex = 5;
            this.Shifr.Text = "Зашифровать";
            this.Shifr.UseVisualStyleBackColor = true;
            this.Shifr.Click += new System.EventHandler(this.ZashifrovatButton_Click);
            // 
            // Deshifr
            // 
            this.Deshifr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deshifr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deshifr.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Deshifr.Location = new System.Drawing.Point(3, 330);
            this.Deshifr.Name = "Deshifr";
            this.Deshifr.Size = new System.Drawing.Size(204, 42);
            this.Deshifr.TabIndex = 6;
            this.Deshifr.Text = "Дешифровать";
            this.Deshifr.UseVisualStyleBackColor = true;
            this.Deshifr.Click += new System.EventHandler(this.DeshifrovatButton_Click);
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(437, 12);
            this.resultTextbox.Multiline = true;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(405, 386);
            this.resultTextbox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Deshifr);
            this.panel1.Controls.Add(this.Shifr);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 386);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(854, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Shifr;
        private System.Windows.Forms.Button Deshifr;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Panel panel1;
    }
}

