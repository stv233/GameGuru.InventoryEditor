namespace Inventory_editor
{
    partial class ExportDialog
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
            this.ItbStyleName = new System.Windows.Forms.TextBox();
            this.IlbStyleName = new System.Windows.Forms.Label();
            this.IbtOk = new System.Windows.Forms.Button();
            this.IbtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItbStyleName
            // 
            this.ItbStyleName.Location = new System.Drawing.Point(10, 42);
            this.ItbStyleName.Name = "ItbStyleName";
            this.ItbStyleName.Size = new System.Drawing.Size(547, 22);
            this.ItbStyleName.TabIndex = 0;
            this.ItbStyleName.Text = "Style";
            this.ItbStyleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IlbStyleName
            // 
            this.IlbStyleName.AutoSize = true;
            this.IlbStyleName.Location = new System.Drawing.Point(249, 9);
            this.IlbStyleName.Name = "IlbStyleName";
            this.IlbStyleName.Size = new System.Drawing.Size(78, 17);
            this.IlbStyleName.TabIndex = 1;
            this.IlbStyleName.Text = "Style name";
            // 
            // IbtOk
            // 
            this.IbtOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.IbtOk.Location = new System.Drawing.Point(195, 83);
            this.IbtOk.Name = "IbtOk";
            this.IbtOk.Size = new System.Drawing.Size(65, 23);
            this.IbtOk.TabIndex = 2;
            this.IbtOk.Text = "Export";
            this.IbtOk.UseVisualStyleBackColor = true;
            this.IbtOk.Click += new System.EventHandler(this.IbtOk_Click);
            // 
            // IbtCancel
            // 
            this.IbtCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IbtCancel.Location = new System.Drawing.Point(309, 83);
            this.IbtCancel.Name = "IbtCancel";
            this.IbtCancel.Size = new System.Drawing.Size(65, 23);
            this.IbtCancel.TabIndex = 3;
            this.IbtCancel.Text = "Cancel";
            this.IbtCancel.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 118);
            this.Controls.Add(this.IbtCancel);
            this.Controls.Add(this.IbtOk);
            this.Controls.Add(this.IlbStyleName);
            this.Controls.Add(this.ItbStyleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItbStyleName;
        private System.Windows.Forms.Label IlbStyleName;
        private System.Windows.Forms.Button IbtOk;
        private System.Windows.Forms.Button IbtCancel;
    }
}