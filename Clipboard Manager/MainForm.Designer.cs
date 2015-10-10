namespace ClipMng
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMainList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TMainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.слежениеЗаБуферомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TContextMenu.SuspendLayout();
            this.TMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TContextMenu
            // 
            this.TContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem1,
            this.скопироватьToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.удалитьToolStripMenuItem1});
            this.TContextMenu.Name = "contextMenuStrip1";
            this.TContextMenu.Size = new System.Drawing.Size(147, 76);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // TMainList
            // 
            this.TMainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TMainList.ContextMenuStrip = this.TContextMenu;
            this.TMainList.FullRowSelect = true;
            this.TMainList.GridLines = true;
            this.TMainList.Location = new System.Drawing.Point(12, 25);
            this.TMainList.MultiSelect = false;
            this.TMainList.Name = "TMainList";
            this.TMainList.Size = new System.Drawing.Size(600, 379);
            this.TMainList.TabIndex = 1;
            this.TMainList.UseCompatibleStateImageBehavior = false;
            this.TMainList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Текст";
            this.columnHeader1.Width = 423;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата и время";
            this.columnHeader2.Width = 152;
            // 
            // TMainMenu
            // 
            this.TMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.TMainMenu.Location = new System.Drawing.Point(0, 0);
            this.TMainMenu.Name = "TMainMenu";
            this.TMainMenu.Size = new System.Drawing.Size(624, 24);
            this.TMainMenu.TabIndex = 2;
            this.TMainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПрограммыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.слежениеЗаБуферомToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиПрограммыToolStripMenuItem
            // 
            this.настройкиПрограммыToolStripMenuItem.Name = "настройкиПрограммыToolStripMenuItem";
            this.настройкиПрограммыToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.настройкиПрограммыToolStripMenuItem.Text = "Настройки программы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // слежениеЗаБуферомToolStripMenuItem
            // 
            this.слежениеЗаБуферомToolStripMenuItem.Checked = true;
            this.слежениеЗаБуферомToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.слежениеЗаБуферомToolStripMenuItem.Name = "слежениеЗаБуферомToolStripMenuItem";
            this.слежениеЗаБуферомToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.слежениеЗаБуферомToolStripMenuItem.Text = "Слежение за буфером";
            this.слежениеЗаБуферомToolStripMenuItem.CheckedChanged += new System.EventHandler(this.слежениеЗаБуферомToolStripMenuItem_CheckedChanged);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // показатьToolStripMenuItem1
            // 
            this.показатьToolStripMenuItem1.Image = global::ClipMng.Properties.Resources.show;
            this.показатьToolStripMenuItem1.Name = "показатьToolStripMenuItem1";
            this.показатьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.показатьToolStripMenuItem1.Text = "Показать";
            this.показатьToolStripMenuItem1.Click += new System.EventHandler(this.показатьToolStripMenuItem1_Click);
            // 
            // скопироватьToolStripMenuItem1
            // 
            this.скопироватьToolStripMenuItem1.Image = global::ClipMng.Properties.Resources.copy_doc;
            this.скопироватьToolStripMenuItem1.Name = "скопироватьToolStripMenuItem1";
            this.скопироватьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.скопироватьToolStripMenuItem1.Text = "Скопировать";
            this.скопироватьToolStripMenuItem1.Click += new System.EventHandler(this.скопироватьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::ClipMng.Properties.Resources.delete;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.TMainList);
            this.Controls.Add(this.TMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clipboard Manager 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TContextMenu.ResumeLayout(false);
            this.TMainMenu.ResumeLayout(false);
            this.TMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip TContextMenu;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ListView TMainList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip TMainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem слежениеЗаБуферомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

