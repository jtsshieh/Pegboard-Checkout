namespace PegBoard_Checkout_System
{
    partial class CheckIn
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.dtpMoment = new System.Windows.Forms.DateTimePicker();
            this.lblMoment = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(270, 174);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(134, 42);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // dtpMoment
            // 
            this.dtpMoment.CalendarFont = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMoment.CustomFormat = "MM/dd/yyyy \'at\' hh:mm tt";
            this.dtpMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMoment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMoment.Location = new System.Drawing.Point(122, 132);
            this.dtpMoment.Name = "dtpMoment";
            this.dtpMoment.ShowUpDown = true;
            this.dtpMoment.Size = new System.Drawing.Size(282, 31);
            this.dtpMoment.TabIndex = 2;
            // 
            // lblMoment
            // 
            this.lblMoment.AutoSize = true;
            this.lblMoment.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoment.Location = new System.Drawing.Point(12, 132);
            this.lblMoment.Name = "lblMoment";
            this.lblMoment.Size = new System.Drawing.Size(104, 25);
            this.lblMoment.TabIndex = 6;
            this.lblMoment.Text = "Moment";
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(122, 59);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReason.Size = new System.Drawing.Size(282, 66);
            this.txtReason.TabIndex = 1;
            // 
            // cbItem
            // 
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(122, 12);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(282, 33);
            this.cbItem.TabIndex = 0;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(12, 62);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(91, 25);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Reason";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(12, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(62, 25);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 228);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dtpMoment);
            this.Controls.Add(this.lblMoment);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckIn";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.DateTimePicker dtpMoment;
        private System.Windows.Forms.Label lblMoment;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblItem;
    }
}