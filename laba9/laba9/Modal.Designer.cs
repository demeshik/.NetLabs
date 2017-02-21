namespace laba9
{
    partial class Modal
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
            this.colorBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minX = new System.Windows.Forms.TextBox();
            this.maxX = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.finishBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.aval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dval = new System.Windows.Forms.TextBox();
            this.graphType = new System.Windows.Forms.ComboBox();
            this.dX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // colorBut
            // 
            this.colorBut.Location = new System.Drawing.Point(148, 55);
            this.colorBut.Name = "colorBut";
            this.colorBut.Size = new System.Drawing.Size(75, 23);
            this.colorBut.TabIndex = 1;
            this.colorBut.Text = "Click";
            this.colorBut.UseVisualStyleBackColor = true;
            this.colorBut.Click += new System.EventHandler(this.colorBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "minX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "maxX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "dX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "graphType:";
            // 
            // minX
            // 
            this.minX.Location = new System.Drawing.Point(148, 82);
            this.minX.Name = "minX";
            this.minX.Size = new System.Drawing.Size(75, 20);
            this.minX.TabIndex = 6;
            // 
            // maxX
            // 
            this.maxX.Location = new System.Drawing.Point(148, 105);
            this.maxX.Name = "maxX";
            this.maxX.Size = new System.Drawing.Size(75, 20);
            this.maxX.TabIndex = 7;
            // 
            // finishBut
            // 
            this.finishBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finishBut.Location = new System.Drawing.Point(113, 219);
            this.finishBut.Name = "finishBut";
            this.finishBut.Size = new System.Drawing.Size(75, 23);
            this.finishBut.TabIndex = 10;
            this.finishBut.Text = "OK";
            this.finishBut.UseVisualStyleBackColor = true;
            this.finishBut.Click += new System.EventHandler(this.finishBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "a:";
            // 
            // aval
            // 
            this.aval.Location = new System.Drawing.Point(34, 183);
            this.aval.Name = "aval";
            this.aval.Size = new System.Drawing.Size(26, 20);
            this.aval.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "b:";
            // 
            // bval
            // 
            this.bval.Location = new System.Drawing.Point(99, 183);
            this.bval.Name = "bval";
            this.bval.Size = new System.Drawing.Size(26, 20);
            this.bval.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "c:";
            // 
            // cval
            // 
            this.cval.Location = new System.Drawing.Point(167, 183);
            this.cval.Name = "cval";
            this.cval.Size = new System.Drawing.Size(26, 20);
            this.cval.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "d:";
            // 
            // dval
            // 
            this.dval.Location = new System.Drawing.Point(239, 183);
            this.dval.Name = "dval";
            this.dval.Size = new System.Drawing.Size(26, 20);
            this.dval.TabIndex = 18;
            // 
            // graphType
            // 
            this.graphType.FormattingEnabled = true;
            this.graphType.Items.AddRange(new object[] {
            "Diagramm",
            "Graphic"});
            this.graphType.Location = new System.Drawing.Point(148, 150);
            this.graphType.Name = "graphType";
            this.graphType.Size = new System.Drawing.Size(75, 21);
            this.graphType.TabIndex = 19;
            // 
            // dX
            // 
            this.dX.Location = new System.Drawing.Point(148, 128);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(75, 20);
            this.dX.TabIndex = 8;
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 315);
            this.Controls.Add(this.graphType);
            this.Controls.Add(this.dval);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finishBut);
            this.Controls.Add(this.dX);
            this.Controls.Add(this.maxX);
            this.Controls.Add(this.minX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorBut);
            this.Controls.Add(this.label1);
            this.Name = "Modal";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minX;
        private System.Windows.Forms.TextBox maxX;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button finishBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dval;
        private System.Windows.Forms.ComboBox graphType;
        private System.Windows.Forms.TextBox dX;
    }
}