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
            this.ItcMain = new System.Windows.Forms.TabControl();
            this.ItpInventory = new System.Windows.Forms.TabPage();
            this.IpbWeaponSlot2 = new System.Windows.Forms.PictureBox();
            this.IpbWeaponSlot1 = new System.Windows.Forms.PictureBox();
            this.IpbBody = new System.Windows.Forms.PictureBox();
            this.IpbDescriptionzone = new System.Windows.Forms.PictureBox();
            this.IpbBodyzone = new System.Windows.Forms.PictureBox();
            this.IpbItemZone = new System.Windows.Forms.PictureBox();
            this.IpbBackground = new System.Windows.Forms.PictureBox();
            this.ItpSmall = new System.Windows.Forms.TabPage();
            this.ItpNumbers = new System.Windows.Forms.TabPage();
            this.IpbSelector = new System.Windows.Forms.PictureBox();
            this.IlbSelector = new System.Windows.Forms.Label();
            this.IpbEquip = new System.Windows.Forms.PictureBox();
            this.IpbUnEquip = new System.Windows.Forms.PictureBox();
            this.IpbDelete = new System.Windows.Forms.PictureBox();
            this.IpbUse = new System.Windows.Forms.PictureBox();
            this.IlbEquipButton = new System.Windows.Forms.Label();
            this.IlbUnequipBurtton = new System.Windows.Forms.Label();
            this.IlbDeleteButton = new System.Windows.Forms.Label();
            this.IlbUseButton = new System.Windows.Forms.Label();
            this.ImsMainMenu.SuspendLayout();
            this.ItcMain.SuspendLayout();
            this.ItpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbWeaponSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbWeaponSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbDescriptionzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBodyzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbItemZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBackground)).BeginInit();
            this.ItpSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbUnEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbUse)).BeginInit();
            this.SuspendLayout();
            // 
            // ImsMainMenu
            // 
            this.ImsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ImsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ImsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ImsMainMenu.Name = "ImsMainMenu";
            this.ImsMainMenu.Size = new System.Drawing.Size(1342, 28);
            this.ImsMainMenu.TabIndex = 0;
            this.ImsMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ItcMain
            // 
            this.ItcMain.Controls.Add(this.ItpInventory);
            this.ItcMain.Controls.Add(this.ItpSmall);
            this.ItcMain.Controls.Add(this.ItpNumbers);
            this.ItcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItcMain.Location = new System.Drawing.Point(0, 31);
            this.ItcMain.Name = "ItcMain";
            this.ItcMain.SelectedIndex = 0;
            this.ItcMain.Size = new System.Drawing.Size(1344, 647);
            this.ItcMain.TabIndex = 1;
            // 
            // ItpInventory
            // 
            this.ItpInventory.Controls.Add(this.IpbWeaponSlot2);
            this.ItpInventory.Controls.Add(this.IpbWeaponSlot1);
            this.ItpInventory.Controls.Add(this.IpbBody);
            this.ItpInventory.Controls.Add(this.IpbDescriptionzone);
            this.ItpInventory.Controls.Add(this.IpbBodyzone);
            this.ItpInventory.Controls.Add(this.IpbItemZone);
            this.ItpInventory.Controls.Add(this.IpbBackground);
            this.ItpInventory.Location = new System.Drawing.Point(4, 25);
            this.ItpInventory.Name = "ItpInventory";
            this.ItpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.ItpInventory.Size = new System.Drawing.Size(1336, 618);
            this.ItpInventory.TabIndex = 0;
            this.ItpInventory.Text = "Inventory";
            this.ItpInventory.UseVisualStyleBackColor = true;
            // 
            // IpbWeaponSlot2
            // 
            this.IpbWeaponSlot2.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbWeaponSlot2.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbWeaponSlot2.Image = global::Inventory_editor.Properties.Resources.weaponslot2;
            this.IpbWeaponSlot2.Location = new System.Drawing.Point(8, 528);
            this.IpbWeaponSlot2.Name = "IpbWeaponSlot2";
            this.IpbWeaponSlot2.Size = new System.Drawing.Size(423, 70);
            this.IpbWeaponSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbWeaponSlot2.TabIndex = 6;
            this.IpbWeaponSlot2.TabStop = false;
            // 
            // IpbWeaponSlot1
            // 
            this.IpbWeaponSlot1.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbWeaponSlot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbWeaponSlot1.Image = global::Inventory_editor.Properties.Resources.weaponslot1;
            this.IpbWeaponSlot1.Location = new System.Drawing.Point(8, 437);
            this.IpbWeaponSlot1.Name = "IpbWeaponSlot1";
            this.IpbWeaponSlot1.Size = new System.Drawing.Size(423, 70);
            this.IpbWeaponSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbWeaponSlot1.TabIndex = 5;
            this.IpbWeaponSlot1.TabStop = false;
            // 
            // IpbBody
            // 
            this.IpbBody.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbBody.Image = global::Inventory_editor.Properties.Resources.body;
            this.IpbBody.Location = new System.Drawing.Point(30, 53);
            this.IpbBody.Name = "IpbBody";
            this.IpbBody.Size = new System.Drawing.Size(376, 357);
            this.IpbBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbBody.TabIndex = 4;
            this.IpbBody.TabStop = false;
            // 
            // IpbDescriptionzone
            // 
            this.IpbDescriptionzone.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbDescriptionzone.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbDescriptionzone.Image = global::Inventory_editor.Properties.Resources.descriptionzone;
            this.IpbDescriptionzone.Location = new System.Drawing.Point(528, 459);
            this.IpbDescriptionzone.Name = "IpbDescriptionzone";
            this.IpbDescriptionzone.Size = new System.Drawing.Size(663, 139);
            this.IpbDescriptionzone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbDescriptionzone.TabIndex = 3;
            this.IpbDescriptionzone.TabStop = false;
            // 
            // IpbBodyzone
            // 
            this.IpbBodyzone.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbBodyzone.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbBodyzone.Image = global::Inventory_editor.Properties.Resources.bodyzone;
            this.IpbBodyzone.Location = new System.Drawing.Point(8, 33);
            this.IpbBodyzone.Name = "IpbBodyzone";
            this.IpbBodyzone.Size = new System.Drawing.Size(423, 398);
            this.IpbBodyzone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbBodyzone.TabIndex = 2;
            this.IpbBodyzone.TabStop = false;
            // 
            // IpbItemZone
            // 
            this.IpbItemZone.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbItemZone.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbItemZone.Image = global::Inventory_editor.Properties.Resources.itemzone;
            this.IpbItemZone.Location = new System.Drawing.Point(528, 33);
            this.IpbItemZone.Name = "IpbItemZone";
            this.IpbItemZone.Size = new System.Drawing.Size(663, 398);
            this.IpbItemZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbItemZone.TabIndex = 1;
            this.IpbItemZone.TabStop = false;
            this.IpbItemZone.Resize += new System.EventHandler(this.IpbItemZone_Resize);
            // 
            // IpbBackground
            // 
            this.IpbBackground.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.IpbBackground.Image = global::Inventory_editor.Properties.Resources.background;
            this.IpbBackground.Location = new System.Drawing.Point(0, 0);
            this.IpbBackground.Name = "IpbBackground";
            this.IpbBackground.Size = new System.Drawing.Size(1294, 615);
            this.IpbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbBackground.TabIndex = 0;
            this.IpbBackground.TabStop = false;
            // 
            // ItpSmall
            // 
            this.ItpSmall.BackColor = System.Drawing.Color.DimGray;
            this.ItpSmall.Controls.Add(this.IlbUseButton);
            this.ItpSmall.Controls.Add(this.IlbDeleteButton);
            this.ItpSmall.Controls.Add(this.IlbUnequipBurtton);
            this.ItpSmall.Controls.Add(this.IlbEquipButton);
            this.ItpSmall.Controls.Add(this.IpbUse);
            this.ItpSmall.Controls.Add(this.IpbDelete);
            this.ItpSmall.Controls.Add(this.IpbUnEquip);
            this.ItpSmall.Controls.Add(this.IpbEquip);
            this.ItpSmall.Controls.Add(this.IlbSelector);
            this.ItpSmall.Controls.Add(this.IpbSelector);
            this.ItpSmall.Location = new System.Drawing.Point(4, 25);
            this.ItpSmall.Name = "ItpSmall";
            this.ItpSmall.Padding = new System.Windows.Forms.Padding(3);
            this.ItpSmall.Size = new System.Drawing.Size(1336, 618);
            this.ItpSmall.TabIndex = 1;
            this.ItpSmall.Text = "Small element";
            // 
            // ItpNumbers
            // 
            this.ItpNumbers.Location = new System.Drawing.Point(4, 25);
            this.ItpNumbers.Name = "ItpNumbers";
            this.ItpNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.ItpNumbers.Size = new System.Drawing.Size(1336, 618);
            this.ItpNumbers.TabIndex = 2;
            this.ItpNumbers.Text = "Numbers";
            this.ItpNumbers.UseVisualStyleBackColor = true;
            // 
            // IpbSelector
            // 
            this.IpbSelector.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbSelector.Location = new System.Drawing.Point(8, 143);
            this.IpbSelector.Name = "IpbSelector";
            this.IpbSelector.Size = new System.Drawing.Size(245, 227);
            this.IpbSelector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbSelector.TabIndex = 0;
            this.IpbSelector.TabStop = false;
            this.IpbSelector.Click += new System.EventHandler(this.IpbSelector_Click);
            // 
            // IlbSelector
            // 
            this.IlbSelector.AutoSize = true;
            this.IlbSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbSelector.ForeColor = System.Drawing.Color.White;
            this.IlbSelector.Location = new System.Drawing.Point(50, 373);
            this.IlbSelector.Name = "IlbSelector";
            this.IlbSelector.Size = new System.Drawing.Size(150, 39);
            this.IlbSelector.TabIndex = 1;
            this.IlbSelector.Text = "Selector";
            // 
            // IpbEquip
            // 
            this.IpbEquip.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbEquip.Location = new System.Drawing.Point(259, 143);
            this.IpbEquip.Name = "IpbEquip";
            this.IpbEquip.Size = new System.Drawing.Size(245, 227);
            this.IpbEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbEquip.TabIndex = 2;
            this.IpbEquip.TabStop = false;
            // 
            // IpbUnEquip
            // 
            this.IpbUnEquip.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbUnEquip.Location = new System.Drawing.Point(830, 143);
            this.IpbUnEquip.Name = "IpbUnEquip";
            this.IpbUnEquip.Size = new System.Drawing.Size(245, 227);
            this.IpbUnEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbUnEquip.TabIndex = 3;
            this.IpbUnEquip.TabStop = false;
            // 
            // IpbDelete
            // 
            this.IpbDelete.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbDelete.Location = new System.Drawing.Point(1081, 143);
            this.IpbDelete.Name = "IpbDelete";
            this.IpbDelete.Size = new System.Drawing.Size(245, 227);
            this.IpbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbDelete.TabIndex = 4;
            this.IpbDelete.TabStop = false;
            // 
            // IpbUse
            // 
            this.IpbUse.BackgroundImage = global::Inventory_editor.Properties.Resources.EmptyBackGround;
            this.IpbUse.Location = new System.Drawing.Point(544, 143);
            this.IpbUse.Name = "IpbUse";
            this.IpbUse.Size = new System.Drawing.Size(245, 227);
            this.IpbUse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpbUse.TabIndex = 5;
            this.IpbUse.TabStop = false;
            // 
            // IlbEquipButton
            // 
            this.IlbEquipButton.AutoSize = true;
            this.IlbEquipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbEquipButton.ForeColor = System.Drawing.Color.White;
            this.IlbEquipButton.Location = new System.Drawing.Point(271, 373);
            this.IlbEquipButton.Name = "IlbEquipButton";
            this.IlbEquipButton.Size = new System.Drawing.Size(220, 39);
            this.IlbEquipButton.TabIndex = 6;
            this.IlbEquipButton.Text = "Equip button";
            // 
            // IlbUnequipBurtton
            // 
            this.IlbUnequipBurtton.AutoSize = true;
            this.IlbUnequipBurtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbUnequipBurtton.ForeColor = System.Drawing.Color.White;
            this.IlbUnequipBurtton.Location = new System.Drawing.Point(823, 373);
            this.IlbUnequipBurtton.Name = "IlbUnequipBurtton";
            this.IlbUnequipBurtton.Size = new System.Drawing.Size(262, 39);
            this.IlbUnequipBurtton.TabIndex = 7;
            this.IlbUnequipBurtton.Text = "Unequip button";
            // 
            // IlbDeleteButton
            // 
            this.IlbDeleteButton.AutoSize = true;
            this.IlbDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbDeleteButton.ForeColor = System.Drawing.Color.White;
            this.IlbDeleteButton.Location = new System.Drawing.Point(1091, 373);
            this.IlbDeleteButton.Name = "IlbDeleteButton";
            this.IlbDeleteButton.Size = new System.Drawing.Size(232, 39);
            this.IlbDeleteButton.TabIndex = 8;
            this.IlbDeleteButton.Text = "Delete button";
            // 
            // IlbUseButton
            // 
            this.IlbUseButton.AutoSize = true;
            this.IlbUseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbUseButton.ForeColor = System.Drawing.Color.White;
            this.IlbUseButton.Location = new System.Drawing.Point(576, 373);
            this.IlbUseButton.Name = "IlbUseButton";
            this.IlbUseButton.Size = new System.Drawing.Size(191, 39);
            this.IlbUseButton.TabIndex = 9;
            this.IlbUseButton.Text = "Use button";
            // 
            // IfrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 673);
            this.Controls.Add(this.ItcMain);
            this.Controls.Add(this.ImsMainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ImsMainMenu;
            this.Name = "IfrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory editor";
            this.Load += new System.EventHandler(this.IfrMain_Load);
            this.ImsMainMenu.ResumeLayout(false);
            this.ImsMainMenu.PerformLayout();
            this.ItcMain.ResumeLayout(false);
            this.ItpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IpbWeaponSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbWeaponSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbDescriptionzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBodyzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbItemZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbBackground)).EndInit();
            this.ItpSmall.ResumeLayout(false);
            this.ItpSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbUnEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpbUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ImsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl ItcMain;
        private System.Windows.Forms.TabPage ItpInventory;
        private System.Windows.Forms.TabPage ItpSmall;
        private System.Windows.Forms.TabPage ItpNumbers;
        private System.Windows.Forms.PictureBox IpbBackground;
        private System.Windows.Forms.PictureBox IpbItemZone;
        private System.Windows.Forms.PictureBox IpbBodyzone;
        private System.Windows.Forms.PictureBox IpbDescriptionzone;
        private System.Windows.Forms.PictureBox IpbBody;
        private System.Windows.Forms.PictureBox IpbWeaponSlot2;
        private System.Windows.Forms.PictureBox IpbWeaponSlot1;
        private System.Windows.Forms.PictureBox IpbSelector;
        private System.Windows.Forms.Label IlbSelector;
        private System.Windows.Forms.PictureBox IpbDelete;
        private System.Windows.Forms.PictureBox IpbUnEquip;
        private System.Windows.Forms.PictureBox IpbEquip;
        private System.Windows.Forms.PictureBox IpbUse;
        private System.Windows.Forms.Label IlbDeleteButton;
        private System.Windows.Forms.Label IlbUnequipBurtton;
        private System.Windows.Forms.Label IlbEquipButton;
        private System.Windows.Forms.Label IlbUseButton;
    }
}

