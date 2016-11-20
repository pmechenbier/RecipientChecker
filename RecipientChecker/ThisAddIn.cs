﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace RecipientChecker
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.ItemSend += Application_ItemSend;
            this.Application.OptionsPagesAdd += Application_OptionsPagesAdd;
        }

        private void Application_OptionsPagesAdd(Outlook.PropertyPages Pages)
        {
            Pages.Add(new OptionsPage(), "Options");
        }

        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            List<string> recipients = new List<string>();
            List<string> flaggedAddresses = Properties.Settings.Default.FlaggedAddressWords.Split(';').ToList();
            Outlook.MailItem mailItem00 = Item as Outlook.MailItem;
            Outlook.MeetingItem mailItem06 = Item as Outlook.MeetingItem;
            Outlook.Recipients mailItemRecipients = mailItem00 == null ? null : mailItem00.Recipients;
            Outlook.Recipients meetingItemRecipients = mailItem06 == null ? null : mailItem06.Recipients;

            if (mailItemRecipients != null)
            {
                foreach (Outlook.Recipient recipient in mailItemRecipients)
                {
                    recipients.Add(recipient.Name);
                }
            }

            if (meetingItemRecipients != null)
            {
                foreach (Outlook.Recipient recipient in meetingItemRecipients)
                {
                    recipients.Add(recipient.Name);
                }
            }

            bool recipientContainsFlaggedAddress = recipients.Any(x => flaggedAddresses.Any(y => x.IndexOf(y, StringComparison.OrdinalIgnoreCase) > -1));

            if (recipientContainsFlaggedAddress)
            {
                DialogResult result = MessageBox.Show(Properties.Settings.Default.DisplayMessage, "Flagged Recipient Detected!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.No)
                {
                    Cancel = true;
                }
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
