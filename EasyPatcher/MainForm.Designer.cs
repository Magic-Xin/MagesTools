﻿namespace EasyPatcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_patch = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.button_delete_bak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // button_patch
            // 
            this.button_patch.Font = new System.Drawing.Font("宋体", 9F);
            this.button_patch.Location = new System.Drawing.Point(266, 39);
            this.button_patch.Name = "button_patch";
            this.button_patch.Size = new System.Drawing.Size(75, 23);
            this.button_patch.TabIndex = 2;
            this.button_patch.Text = "应用补丁";
            this.button_patch.UseVisualStyleBackColor = true;
            this.button_patch.Click += new System.EventHandler(this.button_patch_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.AllowDrop = true;
            this.textBox_path.Location = new System.Drawing.Point(77, 12);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(388, 21);
            this.textBox_path.TabIndex = 0;
            this.textBox_path.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_path_DragDrop);
            this.textBox_path.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_path_DragOver);
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.Black;
            this.textBox_log.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox_log.ForeColor = System.Drawing.Color.Silver;
            this.textBox_log.Location = new System.Drawing.Point(12, 68);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(491, 230);
            this.textBox_log.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(428, 39);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "保存日志";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "游戏路径:";
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(471, 12);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(32, 21);
            this.button_select.TabIndex = 1;
            this.button_select.Text = "...";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "选择游戏路径";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // linkLabel_version
            // 
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(12, 44);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(47, 12);
            this.linkLabel_version.TabIndex = 5;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "Version";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.Location = new System.Drawing.Point(509, 12);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(368, 286);
            this.pictureBox_main.TabIndex = 6;
            this.pictureBox_main.TabStop = false;
            // 
            // button_delete_bak
            // 
            this.button_delete_bak.Location = new System.Drawing.Point(347, 39);
            this.button_delete_bak.Name = "button_delete_bak";
            this.button_delete_bak.Size = new System.Drawing.Size(75, 23);
            this.button_delete_bak.TabIndex = 7;
            this.button_delete_bak.Text = "删除备份";
            this.button_delete_bak.UseVisualStyleBackColor = true;
            this.button_delete_bak.Click += new System.EventHandler(this.button_delete_bak_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 310);
            this.Controls.Add(this.button_delete_bak);
            this.Controls.Add(this.pictureBox_main);
            this.Controls.Add(this.linkLabel_version);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_patch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mages 全自动补丁工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_patch;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button button_delete_bak;
    }
}
