namespace Xyz.Mechenbier.Outlook.RecipientChecker
{
    partial class OptionsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFlaggedRecipients = new System.Windows.Forms.Label();
            this.txtFlaggedRecipients = new System.Windows.Forms.TextBox();
            this.txtWarningText = new System.Windows.Forms.TextBox();
            this.lblWarningText = new System.Windows.Forms.Label();
            this.lblRecipientInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlaggedRecipients
            // 
            this.lblFlaggedRecipients.AutoSize = true;
            this.lblFlaggedRecipients.Location = new System.Drawing.Point(8, 8);
            this.lblFlaggedRecipients.Name = "lblFlaggedRecipients";
            this.lblFlaggedRecipients.Size = new System.Drawing.Size(101, 13);
            this.lblFlaggedRecipients.TabIndex = 0;
            this.lblFlaggedRecipients.Text = "Flagged Recipients:";
            // 
            // txtFlaggedRecipients
            // 
            this.txtFlaggedRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlaggedRecipients.Location = new System.Drawing.Point(115, 5);
            this.txtFlaggedRecipients.Name = "txtFlaggedRecipients";
            this.txtFlaggedRecipients.Size = new System.Drawing.Size(232, 20);
            this.txtFlaggedRecipients.TabIndex = 1;
            // 
            // txtWarningText
            // 
            this.txtWarningText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarningText.Location = new System.Drawing.Point(115, 53);
            this.txtWarningText.Multiline = true;
            this.txtWarningText.Name = "txtWarningText";
            this.txtWarningText.Size = new System.Drawing.Size(232, 44);
            this.txtWarningText.TabIndex = 3;
            // 
            // lblWarningText
            // 
            this.lblWarningText.AutoSize = true;
            this.lblWarningText.Location = new System.Drawing.Point(8, 56);
            this.lblWarningText.Name = "lblWarningText";
            this.lblWarningText.Size = new System.Drawing.Size(74, 13);
            this.lblWarningText.TabIndex = 2;
            this.lblWarningText.Text = "Warning Text:";
            // 
            // lblRecipientInstructions
            // 
            this.lblRecipientInstructions.AutoSize = true;
            this.lblRecipientInstructions.Location = new System.Drawing.Point(118, 29);
            this.lblRecipientInstructions.Name = "lblRecipientInstructions";
            this.lblRecipientInstructions.Size = new System.Drawing.Size(206, 13);
            this.lblRecipientInstructions.TabIndex = 6;
            this.lblRecipientInstructions.Text = "Separate Recipients with a semicolon (\";\")";
            // 
            // OptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecipientInstructions);
            this.Controls.Add(this.txtWarningText);
            this.Controls.Add(this.lblWarningText);
            this.Controls.Add(this.txtFlaggedRecipients);
            this.Controls.Add(this.lblFlaggedRecipients);
            this.MinimumSize = new System.Drawing.Size(350, 100);
            this.Name = "OptionsPage";
            this.Size = new System.Drawing.Size(350, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFlaggedRecipients;
        private System.Windows.Forms.TextBox txtFlaggedRecipients;
        private System.Windows.Forms.TextBox txtWarningText;
        private System.Windows.Forms.Label lblWarningText;
        private System.Windows.Forms.Label lblRecipientInstructions;
    }
}
