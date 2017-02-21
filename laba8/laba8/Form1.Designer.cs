namespace laba8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.локализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1,
            this.локализацияToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеОкноToolStripMenuItem,
            this.открытьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            resources.ApplyResources(this.новоеОкноToolStripMenuItem, "новоеОкноToolStripMenuItem");
            this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            resources.ApplyResources(this.открытьФайлToolStripMenuItem, "открытьФайлToolStripMenuItem");
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадноеToolStripMenuItem,
            this.вертикальноеToolStripMenuItem,
            this.горизонтальноеToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            // 
            // каскадноеToolStripMenuItem
            // 
            this.каскадноеToolStripMenuItem.Name = "каскадноеToolStripMenuItem";
            resources.ApplyResources(this.каскадноеToolStripMenuItem, "каскадноеToolStripMenuItem");
            this.каскадноеToolStripMenuItem.Click += new System.EventHandler(this.каскадноеToolStripMenuItem_Click);
            // 
            // вертикальноеToolStripMenuItem
            // 
            this.вертикальноеToolStripMenuItem.Name = "вертикальноеToolStripMenuItem";
            resources.ApplyResources(this.вертикальноеToolStripMenuItem, "вертикальноеToolStripMenuItem");
            this.вертикальноеToolStripMenuItem.Click += new System.EventHandler(this.вертикальноеToolStripMenuItem_Click);
            // 
            // горизонтальноеToolStripMenuItem
            // 
            this.горизонтальноеToolStripMenuItem.Name = "горизонтальноеToolStripMenuItem";
            resources.ApplyResources(this.горизонтальноеToolStripMenuItem, "горизонтальноеToolStripMenuItem");
            this.горизонтальноеToolStripMenuItem.Click += new System.EventHandler(this.горизонтальноеToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem1, "оПрограммеToolStripMenuItem1");
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // локализацияToolStripMenuItem
            // 
            this.локализацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскаяToolStripMenuItem,
            this.английскаяToolStripMenuItem});
            this.локализацияToolStripMenuItem.Name = "локализацияToolStripMenuItem";
            resources.ApplyResources(this.локализацияToolStripMenuItem, "локализацияToolStripMenuItem");
            // 
            // русскаяToolStripMenuItem
            // 
            this.русскаяToolStripMenuItem.Name = "русскаяToolStripMenuItem";
            resources.ApplyResources(this.русскаяToolStripMenuItem, "русскаяToolStripMenuItem");
            this.русскаяToolStripMenuItem.Click += new System.EventHandler(this.русскаяToolStripMenuItem_Click);
            // 
            // английскаяToolStripMenuItem
            // 
            this.английскаяToolStripMenuItem.Name = "английскаяToolStripMenuItem";
            resources.ApplyResources(this.английскаяToolStripMenuItem, "английскаяToolStripMenuItem");
            this.английскаяToolStripMenuItem.Click += new System.EventHandler(this.английскаяToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem локализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскаяToolStripMenuItem;
    }
}

