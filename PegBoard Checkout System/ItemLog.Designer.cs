namespace PegBoard_Checkout_System
{
    partial class ItemLog
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblStatusLb = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Awaiting Operation";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(458, 27);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(594, 33);
            this.txtStatus.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(301, 84);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(108, 25);
            this.lblLog.TabIndex = 8;
            this.lblLog.Text = "Item Log";
            // 
            // lblStatusLb
            // 
            this.lblStatusLb.AutoSize = true;
            this.lblStatusLb.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLb.Location = new System.Drawing.Point(301, 30);
            this.lblStatusLb.Name = "lblStatusLb";
            this.lblStatusLb.Size = new System.Drawing.Size(136, 25);
            this.lblStatusLb.TabIndex = 7;
            this.lblStatusLb.Text = "Item Status";
            // 
            // lbItems
            // 
            this.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbItems.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 19;
            this.lbItems.Location = new System.Drawing.Point(12, 30);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(272, 268);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedValueChanged += new System.EventHandler(this.lbItems_SelectedValueChanged);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(672, 81);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(72, 23);
            this.lblAction.TabIndex = 9;
            this.lblAction.Text = "Action";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(672, 129);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(81, 23);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Reason";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(672, 267);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 23);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // txtAction
            // 
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAction.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.Location = new System.Drawing.Point(759, 81);
            this.txtAction.Name = "txtAction";
            this.txtAction.ReadOnly = true;
            this.txtAction.Size = new System.Drawing.Size(293, 31);
            this.txtAction.TabIndex = 3;
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(759, 129);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReason.Size = new System.Drawing.Size(293, 118);
            this.txtReason.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(759, 264);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(293, 31);
            this.txtTime.TabIndex = 5;
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLog.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 19;
            this.lbLog.Location = new System.Drawing.Point(458, 87);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(197, 211);
            this.lbLog.TabIndex = 2;
            this.lbLog.SelectedValueChanged += new System.EventHandler(this.lbLog_SelectedValueChanged);
            // 
            // ItemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 316);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblStatusLb);
            this.Controls.Add(this.lbItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemLog";
            this.Text = "ItemLog";
            this.Load += new System.EventHandler(this.ItemLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblStatusLb;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ListBox lbLog;
    }
}