namespace laba6
{
    partial class Exec
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
            this.execListB = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦветуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.objCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.textSearch = new System.Windows.Forms.Label();
            this.valSearch = new System.Windows.Forms.TextBox();
            this.rezultList = new System.Windows.Forms.ListBox();
            this.rezultSearchLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valRegSearch = new System.Windows.Forms.TextBox();
            this.faqReg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // execListB
            // 
            this.execListB.FormattingEnabled = true;
            this.execListB.Location = new System.Drawing.Point(12, 27);
            this.execListB.Name = "execListB";
            this.execListB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.execListB.Size = new System.Drawing.Size(736, 95);
            this.execListB.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поЦветуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поЦветуToolStripMenuItem
            // 
            this.поЦветуToolStripMenuItem.Name = "поЦветуToolStripMenuItem";
            this.поЦветуToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.поЦветуToolStripMenuItem.Text = "По цвету";
            this.поЦветуToolStripMenuItem.Click += new System.EventHandler(this.поЦветуToolStripMenuItem_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имяToolStripMenuItem,
            this.датаРожденияToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // имяToolStripMenuItem
            // 
            this.имяToolStripMenuItem.Name = "имяToolStripMenuItem";
            this.имяToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.имяToolStripMenuItem.Text = "Имя";
            this.имяToolStripMenuItem.Click += new System.EventHandler(this.имяToolStripMenuItem_Click);
            // 
            // датаРожденияToolStripMenuItem
            // 
            this.датаРожденияToolStripMenuItem.Name = "датаРожденияToolStripMenuItem";
            this.датаРожденияToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.датаРожденияToolStripMenuItem.Text = "Дата рождения";
            this.датаРожденияToolStripMenuItem.Click += new System.EventHandler(this.датаРожденияToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fAQToolStripMenuItem.Text = "F.A.Q.";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.time,
            this.toolStripStatusLabel2,
            this.objCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Текущее время:";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel2.Text = "Кол-во объектов:";
            // 
            // objCount
            // 
            this.objCount.Name = "objCount";
            this.objCount.Size = new System.Drawing.Size(0, 17);
            // 
            // textSearch
            // 
            this.textSearch.AutoSize = true;
            this.textSearch.Location = new System.Drawing.Point(12, 145);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(162, 13);
            this.textSearch.TabIndex = 3;
            this.textSearch.Text = "Введите значение для поиска:";
            this.textSearch.Visible = false;
            // 
            // valSearch
            // 
            this.valSearch.Location = new System.Drawing.Point(74, 164);
            this.valSearch.Name = "valSearch";
            this.valSearch.Size = new System.Drawing.Size(100, 20);
            this.valSearch.TabIndex = 4;
            this.valSearch.Visible = false;
            // 
            // rezultList
            // 
            this.rezultList.FormattingEnabled = true;
            this.rezultList.Location = new System.Drawing.Point(12, 255);
            this.rezultList.Name = "rezultList";
            this.rezultList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rezultList.Size = new System.Drawing.Size(736, 95);
            this.rezultList.TabIndex = 5;
            this.rezultList.Visible = false;
            // 
            // rezultSearchLabel
            // 
            this.rezultSearchLabel.AutoSize = true;
            this.rezultSearchLabel.Location = new System.Drawing.Point(9, 239);
            this.rezultSearchLabel.Name = "rezultSearchLabel";
            this.rezultSearchLabel.Size = new System.Drawing.Size(109, 13);
            this.rezultSearchLabel.TabIndex = 6;
            this.rezultSearchLabel.Text = "Результаты поиска:";
            this.rezultSearchLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.searchButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Visible = false;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Location = new System.Drawing.Point(465, 145);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(188, 13);
            this.regLabel.TabIndex = 9;
            this.regLabel.Text = "Поиск по регулярному выражению:";
            this.regLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выражение:";
            this.label2.Visible = false;
            // 
            // valRegSearch
            // 
            this.valRegSearch.Location = new System.Drawing.Point(553, 164);
            this.valRegSearch.Name = "valRegSearch";
            this.valRegSearch.Size = new System.Drawing.Size(100, 20);
            this.valRegSearch.TabIndex = 11;
            this.valRegSearch.Visible = false;
            // 
            // faqReg
            // 
            this.faqReg.AutoSize = true;
            this.faqReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faqReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faqReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.faqReg.Location = new System.Drawing.Point(674, 167);
            this.faqReg.Name = "faqReg";
            this.faqReg.Size = new System.Drawing.Size(37, 13);
            this.faqReg.TabIndex = 12;
            this.faqReg.Text = "F.A.Q.";
            this.faqReg.Visible = false;
            this.faqReg.Click += new System.EventHandler(this.faqReg_Click);
            // 
            // Exec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 375);
            this.Controls.Add(this.faqReg);
            this.Controls.Add(this.valRegSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezultSearchLabel);
            this.Controls.Add(this.rezultList);
            this.Controls.Add(this.valSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.execListB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Exec";
            this.Text = "Exec";
            this.Load += new System.EventHandler(this.Exec_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox execListB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаРожденияToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel objCount;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦветуToolStripMenuItem;
        private System.Windows.Forms.Label textSearch;
        private System.Windows.Forms.TextBox valSearch;
        public System.Windows.Forms.ListBox rezultList;
        private System.Windows.Forms.Label rezultSearchLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valRegSearch;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Label faqReg;
    }
}