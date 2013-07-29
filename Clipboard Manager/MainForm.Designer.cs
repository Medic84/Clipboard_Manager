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
            this.TMainList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TWinAutoRun = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TClearConfig = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.googleplus = new System.Windows.Forms.PictureBox();
            this.twitter = new System.Windows.Forms.PictureBox();
            this.vkontakte = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TT = new System.Windows.Forms.Timer(this.components);
            this.TContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleplus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkontakte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TMainList
            // 
            this.TMainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TMainList.ContextMenuStrip = this.TContextMenu;
            this.TMainList.Location = new System.Drawing.Point(6, 6);
            this.TMainList.MultiSelect = false;
            this.TMainList.Name = "TMainList";
            this.TMainList.Size = new System.Drawing.Size(580, 361);
            this.TMainList.TabIndex = 0;
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Image = global::ClipMng.Properties.Resources.delete;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 399);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TMainList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TWinAutoRun);
            this.groupBox2.Location = new System.Drawing.Point(6, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автозапуск";
            // 
            // TWinAutoRun
            // 
            this.TWinAutoRun.AutoSize = true;
            this.TWinAutoRun.Location = new System.Drawing.Point(6, 61);
            this.TWinAutoRun.Name = "TWinAutoRun";
            this.TWinAutoRun.Size = new System.Drawing.Size(177, 17);
            this.TWinAutoRun.TabIndex = 0;
            this.TWinAutoRun.Text = "Запускать вместе с Windows";
            this.TWinAutoRun.UseVisualStyleBackColor = true;
            this.TWinAutoRun.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TClearConfig);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Логирование";
            // 
            // TClearConfig
            // 
            this.TClearConfig.Location = new System.Drawing.Point(208, 175);
            this.TClearConfig.Name = "TClearConfig";
            this.TClearConfig.Size = new System.Drawing.Size(81, 23);
            this.TClearConfig.TabIndex = 4;
            this.TClearConfig.Text = "Очистить";
            this.TClearConfig.UseVisualStyleBackColor = true;
            this.TClearConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(241, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Делить лог на части при нехватке места";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Максимальный объем лога:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Location = new System.Drawing.Point(6, 68);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(283, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Вести логирование";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.facebook);
            this.tabPage3.Controls.Add(this.googleplus);
            this.tabPage3.Controls.Add(this.twitter);
            this.tabPage3.Controls.Add(this.vkontakte);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(592, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "О программе";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(124, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clipboard Manager";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(256, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://mediclab.org";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClipMng.Properties.Resources.my_qr_code;
            this.pictureBox2.Location = new System.Drawing.Point(485, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 78);
            this.label4.TabIndex = 9;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Добавляйтесь в подписки:";
            // 
            // facebook
            // 
            this.facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebook.Image = global::ClipMng.Properties.Resources.facebook_32;
            this.facebook.Location = new System.Drawing.Point(443, 338);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(32, 32);
            this.facebook.TabIndex = 7;
            this.facebook.TabStop = false;
            // 
            // googleplus
            // 
            this.googleplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googleplus.Image = global::ClipMng.Properties.Resources.googleplus_32;
            this.googleplus.Location = new System.Drawing.Point(481, 338);
            this.googleplus.Name = "googleplus";
            this.googleplus.Size = new System.Drawing.Size(32, 32);
            this.googleplus.TabIndex = 6;
            this.googleplus.TabStop = false;
            this.googleplus.Click += new System.EventHandler(this.googleplus_Click);
            // 
            // twitter
            // 
            this.twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitter.Image = global::ClipMng.Properties.Resources.twitter_32;
            this.twitter.Location = new System.Drawing.Point(557, 338);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(32, 32);
            this.twitter.TabIndex = 5;
            this.twitter.TabStop = false;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // vkontakte
            // 
            this.vkontakte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkontakte.Image = global::ClipMng.Properties.Resources.vkontakte_32;
            this.vkontakte.Location = new System.Drawing.Point(519, 338);
            this.vkontakte.Name = "vkontakte";
            this.vkontakte.Size = new System.Drawing.Size(32, 32);
            this.vkontakte.TabIndex = 4;
            this.vkontakte.TabStop = false;
            this.vkontakte.Click += new System.EventHandler(this.vkontakte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClipMng.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright © Medic84 2011";
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
            // TT
            // 
            this.TT.Interval = 500;
            this.TT.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 423);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Clipboard Manager 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.googleplus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkontakte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TMainList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip TContextMenu;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox TWinAutoRun;
        private System.Windows.Forms.Button TClearConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox vkontakte;
        private System.Windows.Forms.PictureBox twitter;
        private System.Windows.Forms.PictureBox googleplus;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TT;
    }
}

