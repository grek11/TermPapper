namespace ЭС
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переменныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цельToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.консультацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.создатьToolStripMenuItem.Text = "Створити";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.открытьToolStripMenuItem.Text = "Відкрити";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сохранитьToolStripMenuItem.Text = "Зберегти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Enabled = false;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Зберегти як";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доменыToolStripMenuItem,
            this.переменныеToolStripMenuItem,
            this.правилаToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Enabled = false;
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.редактированиеToolStripMenuItem.Text = "Редагування";
            // 
            // доменыToolStripMenuItem
            // 
            this.доменыToolStripMenuItem.Enabled = false;
            this.доменыToolStripMenuItem.Name = "доменыToolStripMenuItem";
            this.доменыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.доменыToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.доменыToolStripMenuItem.Text = "Домени";
            this.доменыToolStripMenuItem.Click += new System.EventHandler(this.доменыToolStripMenuItem_Click);
            // 
            // переменныеToolStripMenuItem
            // 
            this.переменныеToolStripMenuItem.Enabled = false;
            this.переменныеToolStripMenuItem.Name = "переменныеToolStripMenuItem";
            this.переменныеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.переменныеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.переменныеToolStripMenuItem.Text = "Змінні";
            this.переменныеToolStripMenuItem.Click += new System.EventHandler(this.цельToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Enabled = false;
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.пускToolStripMenuItem_Click);
            // 
            // консультацияToolStripMenuItem
            // 
            this.консультацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цельToolStripMenuItem1,
            this.пускToolStripMenuItem1});
            this.консультацияToolStripMenuItem.Enabled = false;
            this.консультацияToolStripMenuItem.Name = "консультацияToolStripMenuItem";
            this.консультацияToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.консультацияToolStripMenuItem.Text = "Початок";
            // 
            // цельToolStripMenuItem1
            // 
            this.цельToolStripMenuItem1.Enabled = false;
            this.цельToolStripMenuItem1.Name = "цельToolStripMenuItem1";
            this.цельToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.цельToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.цельToolStripMenuItem1.Text = "Наша ціль";
            this.цельToolStripMenuItem1.Click += new System.EventHandler(this.цельToolStripMenuItem1_Click);
            // 
            // пускToolStripMenuItem1
            // 
            this.пускToolStripMenuItem1.Enabled = false;
            this.пускToolStripMenuItem1.Name = "пускToolStripMenuItem1";
            this.пускToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.пускToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.пускToolStripMenuItem1.Text = "Почати";
            this.пускToolStripMenuItem1.Click += new System.EventHandler(this.пускToolStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.es";
            this.saveFileDialog1.Filter = "Файлы экспертной системы|*.es|Все файлы|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.es";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы экспертной системы|*.es|Все файлы|*.*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 415);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(454, 454);
            this.MinimumSize = new System.Drawing.Size(454, 454);
            this.Name = "frmMain";
            this.Text = "Експертна система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переменныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цельToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem доменыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    }
}

