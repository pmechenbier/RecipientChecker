# Recipient Checker
Checks if recipients are in a Outlook email or meeting request item and ensures the user really means to send the item when the <kbd>Send</kbd> button is clicked by asking for user confirmation. Recipients are checked by their display name in the To, CC, and BCC fields.

Recipient Checker supports Microsoft Outlook 2013 and 2016, with support coming for Outlook 2010 and Office 365.

## Configuration
This Outlook Add-in has two configuration options:

* [Flagged Recipients](#flagged-recipients)
* [Warning Text](#warning-text)

### Flagged Recipients
Recipients can be configured by selecting the Recipient Checker Add-in in the Add-ins list and clicking the <kbd>Add-in Options...</kbd> button on the Add-in Outlook Options screen (File > Options > Add-ins). Multiple recipients can be checked by separating recipients with a semicolon (`;`).

The confirmation box will be displayed when the user clicks the <kbd>Send</kbd> button if any flagged recipient string is found in a email or meeting request list of recipient display names. Partial matches trigger the confirmation as well (e.g. the flagged recipient "everyone" is part of the recipient "EveryoneALL"). The flagged recipients are case-insensitive.

### Warning Text
The warning text displayed in the confirmation dialog.
