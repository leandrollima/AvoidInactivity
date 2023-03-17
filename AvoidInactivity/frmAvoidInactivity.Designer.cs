namespace AvoidInactivity
{
    partial class frmAvoidInactivity
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvoidInactivity));
            this.lblLastActivity = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastActivity
            // 
            this.lblLastActivity.AutoSize = true;
            this.lblLastActivity.Location = new System.Drawing.Point(32, 39);
            this.lblLastActivity.Name = "lblLastActivity";
            this.lblLastActivity.Size = new System.Drawing.Size(72, 15);
            this.lblLastActivity.TabIndex = 0;
            this.lblLastActivity.Text = "Last activity:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(32, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Activate/Inactivate process";
            // 
            // frmAvoidInactivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 120);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLastActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAvoidInactivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avoid inactivity";
            this.Activated += new System.EventHandler(this.frmAvoidInactivity_Activated);
            this.Deactivate += new System.EventHandler(this.frmAvoidInactivity_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLastActivity;
        private System.Windows.Forms.Timer Timer1;
        private Label lblStatus;
    }
}