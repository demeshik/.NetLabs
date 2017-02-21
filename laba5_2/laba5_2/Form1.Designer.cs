namespace laba5_2
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
            this.heightFrom = new System.Windows.Forms.TextBox();
            this.heightTo = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.perimetrTo = new System.Windows.Forms.TextBox();
            this.perimetrFrom = new System.Windows.Forms.TextBox();
            this.squareTo = new System.Windows.Forms.TextBox();
            this.squareFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heightFrom
            // 
            this.heightFrom.Location = new System.Drawing.Point(129, 64);
            this.heightFrom.Name = "heightFrom";
            this.heightFrom.Size = new System.Drawing.Size(100, 20);
            this.heightFrom.TabIndex = 0;
            // 
            // heightTo
            // 
            this.heightTo.Location = new System.Drawing.Point(269, 64);
            this.heightTo.Name = "heightTo";
            this.heightTo.Size = new System.Drawing.Size(100, 20);
            this.heightTo.TabIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(420, 133);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Генерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // perimetrTo
            // 
            this.perimetrTo.Location = new System.Drawing.Point(269, 134);
            this.perimetrTo.Name = "perimetrTo";
            this.perimetrTo.Size = new System.Drawing.Size(100, 20);
            this.perimetrTo.TabIndex = 4;
            // 
            // perimetrFrom
            // 
            this.perimetrFrom.Location = new System.Drawing.Point(129, 134);
            this.perimetrFrom.Name = "perimetrFrom";
            this.perimetrFrom.Size = new System.Drawing.Size(100, 20);
            this.perimetrFrom.TabIndex = 5;
            // 
            // squareTo
            // 
            this.squareTo.Location = new System.Drawing.Point(269, 204);
            this.squareTo.Name = "squareTo";
            this.squareTo.Size = new System.Drawing.Size(100, 20);
            this.squareTo.TabIndex = 6;
            // 
            // squareFrom
            // 
            this.squareFrom.Location = new System.Drawing.Point(129, 204);
            this.squareFrom.Name = "squareFrom";
            this.squareFrom.Size = new System.Drawing.Size(100, 20);
            this.squareFrom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Периметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "От";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "До";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareFrom);
            this.Controls.Add(this.squareTo);
            this.Controls.Add(this.perimetrFrom);
            this.Controls.Add(this.perimetrTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.heightTo);
            this.Controls.Add(this.heightFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heightFrom;
        private System.Windows.Forms.TextBox heightTo;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox perimetrTo;
        private System.Windows.Forms.TextBox perimetrFrom;
        private System.Windows.Forms.TextBox squareTo;
        private System.Windows.Forms.TextBox squareFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

