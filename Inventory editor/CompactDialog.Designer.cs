namespace Inventory_editor
{
    partial class CompactDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactDialog));
            this.IlbMessage = new System.Windows.Forms.Label();
            this.IbtYes = new System.Windows.Forms.Button();
            this.IbtNo = new System.Windows.Forms.Button();
            this.IcbDontAsk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IlbMessage
            // 
            this.IlbMessage.AutoSize = true;
            this.IlbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbMessage.ForeColor = System.Drawing.Color.Navy;
            this.IlbMessage.Location = new System.Drawing.Point(7, 40);
            this.IlbMessage.Name = "IlbMessage";
            this.IlbMessage.Size = new System.Drawing.Size(936, 72);
            this.IlbMessage.TabIndex = 0;
            this.IlbMessage.Text = resources.GetString("IlbMessage.Text");
            this.IlbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IbtYes
            // 
            this.IbtYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IbtYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.IbtYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtYes.Location = new System.Drawing.Point(202, 209);
            this.IbtYes.Name = "IbtYes";
            this.IbtYes.Size = new System.Drawing.Size(97, 32);
            this.IbtYes.TabIndex = 1;
            this.IbtYes.Text = "Yes";
            this.IbtYes.UseVisualStyleBackColor = false;
            // 
            // IbtNo
            // 
            this.IbtNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IbtNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.IbtNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtNo.Location = new System.Drawing.Point(643, 209);
            this.IbtNo.Name = "IbtNo";
            this.IbtNo.Size = new System.Drawing.Size(97, 32);
            this.IbtNo.TabIndex = 2;
            this.IbtNo.Text = "No";
            this.IbtNo.UseVisualStyleBackColor = false;
            // 
            // IcbDontAsk
            // 
            this.IcbDontAsk.AutoSize = true;
            this.IcbDontAsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IcbDontAsk.Location = new System.Drawing.Point(402, 216);
            this.IcbDontAsk.Name = "IcbDontAsk";
            this.IcbDontAsk.Size = new System.Drawing.Size(132, 21);
            this.IcbDontAsk.TabIndex = 3;
            this.IcbDontAsk.Text = "Don\'t ask again.";
            this.IcbDontAsk.UseVisualStyleBackColor = true;
            // 
            // CompactDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(947, 291);
            this.Controls.Add(this.IcbDontAsk);
            this.Controls.Add(this.IbtNo);
            this.Controls.Add(this.IbtYes);
            this.Controls.Add(this.IlbMessage);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompactDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compact mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IlbMessage;
        private System.Windows.Forms.Button IbtYes;
        private System.Windows.Forms.Button IbtNo;
        private System.Windows.Forms.CheckBox IcbDontAsk;
    }
}