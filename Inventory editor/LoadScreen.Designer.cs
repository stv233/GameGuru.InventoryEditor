namespace Inventory_editor
{
    partial class IfrLoadScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IfrLoadScreen));
            this.IlbTitle = new System.Windows.Forms.Label();
            this.IlbSite = new System.Windows.Forms.Label();
            this.IlbStatus = new System.Windows.Forms.Label();
            this.ItmStart = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IlbTitle
            // 
            this.IlbTitle.AutoSize = true;
            this.IlbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(5)))), ((int)(((byte)(77)))));
            this.IlbTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(244)))));
            this.IlbTitle.Location = new System.Drawing.Point(286, 104);
            this.IlbTitle.Name = "IlbTitle";
            this.IlbTitle.Size = new System.Drawing.Size(138, 18);
            this.IlbTitle.TabIndex = 0;
            this.IlbTitle.Text = "Inventory editor";
            // 
            // IlbSite
            // 
            this.IlbSite.AutoSize = true;
            this.IlbSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(5)))), ((int)(((byte)(77)))));
            this.IlbSite.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(53)))), ((int)(((byte)(178)))));
            this.IlbSite.Location = new System.Drawing.Point(328, 134);
            this.IlbSite.Name = "IlbSite";
            this.IlbSite.Size = new System.Drawing.Size(96, 18);
            this.IlbSite.TabIndex = 1;
            this.IlbSite.Text = "stv233.pro";
            this.IlbSite.Click += new System.EventHandler(this.IlbSite_Click);
            // 
            // IlbStatus
            // 
            this.IlbStatus.AutoSize = true;
            this.IlbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(5)))), ((int)(((byte)(77)))));
            this.IlbStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IlbStatus.ForeColor = System.Drawing.Color.Navy;
            this.IlbStatus.Location = new System.Drawing.Point(328, 212);
            this.IlbStatus.Name = "IlbStatus";
            this.IlbStatus.Size = new System.Drawing.Size(65, 18);
            this.IlbStatus.TabIndex = 2;
            this.IlbStatus.Text = "Starting";
            // 
            // ItmStart
            // 
            this.ItmStart.Enabled = true;
            this.ItmStart.Interval = 400;
            this.ItmStart.Tick += new System.EventHandler(this.ItmStart_Tick);
            // 
            // IfrLoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_editor.Properties.Resources.Loading;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 267);
            this.Controls.Add(this.IlbStatus);
            this.Controls.Add(this.IlbSite);
            this.Controls.Add(this.IlbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IfrLoadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IlbTitle;
        private System.Windows.Forms.Label IlbSite;
        private System.Windows.Forms.Label IlbStatus;
        private System.Windows.Forms.Timer ItmStart;
    }
}