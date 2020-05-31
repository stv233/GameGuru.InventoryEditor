namespace Inventory_editor
{
    partial class IfrMain
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
            this.ImsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.IpbBackground = new System.Windows.Forms.PictureBox();
            this.IpbItemZone = new System.Windows.Forms.PictureBox();
            this.ImsMainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbItemZone)).BeginInit();
            this.SuspendLayout();
            // 
            // ImsMainMenu
            // 
            this.ImsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ImsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ImsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ImsMainMenu.Name = "ImsMainMenu";
            this.ImsMainMenu.Size = new System.Drawing.Size(1223, 28);
            this.ImsMainMenu.TabIndex = 0;
            this.ImsMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 640);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IpbItemZone);
            this.tabPage1.Controls.Add(this.IpbBackground);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1215, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Small element";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1215, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Numbers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // IpbBackground
            // 
            this.IpbBackground.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbBackground.Image = global::Inventory_editor.Properties.Resources.background;
            this.IpbBackground.Location = new System.Drawing.Point(0, 0);
            this.IpbBackground.Name = "IpbBackground";
            this.IpbBackground.Size = new System.Drawing.Size(1215, 615);
            this.IpbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbBackground.TabIndex = 0;
            this.IpbBackground.TabStop = false;
            // 
            // IpbItemZone
            // 
            this.IpbItemZone.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbItemZone.Image = global::Inventory_editor.Properties.Resources.itemzone;
            this.IpbItemZone.Location = new System.Drawing.Point(528, 33);
            this.IpbItemZone.Name = "IpbItemZone";
            this.IpbItemZone.Size = new System.Drawing.Size(663, 398);
            this.IpbItemZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbItemZone.TabIndex = 1;
            this.IpbItemZone.TabStop = false;
            // 
            // IfrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ImsMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ImsMainMenu;
            this.Name = "IfrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory edittor";
            this.UseWaitCursor = true;
            this.ImsMainMenu.ResumeLayout(false);
            this.ImsMainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IpbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbItemZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox IpbBackground;
        private System.Windows.Forms.PictureBox IpbItemZone;
    }
}

