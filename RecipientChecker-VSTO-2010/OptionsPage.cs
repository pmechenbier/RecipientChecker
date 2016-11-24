using System;
using System.Windows.Forms;
using MicrosoftOutlook = Microsoft.Office.Interop.Outlook;

namespace Xyz.Mechenbier.Outlook.RecipientChecker
{
    public partial class OptionsPage : UserControl, MicrosoftOutlook.PropertyPage
    {
        MicrosoftOutlook.PropertyPageSite _propertyPageSite = null;
        bool _dirty = false;

        public OptionsPage()
        {
            InitializeComponent();
            this.Load += OptionsPage_Load;
            this.txtFlaggedRecipients.TextChanged += TextboxTextChanged;
            this.txtWarningText.TextChanged += TextboxTextChanged;
        }

        private void OptionsPage_Load(object sender, EventArgs e)
        {
            _propertyPageSite = GetPropertyPageSite();
            LoadOptions();
        }

        private void TextboxTextChanged(object sender, EventArgs e)
        {
            OnDirty(true);
        }

        public void Apply()
        {
            if (_dirty)
            {
                SaveOptions();
                OnDirty(false);
            }
        }

        public bool Dirty
        {
            get { return _dirty; }
        }

        public void GetPageInfo(ref string HelpFile, ref int HelpContext) { }

        MicrosoftOutlook.PropertyPageSite GetPropertyPageSite()
        {
            Type type = typeof(System.Object);
            string assembly = type.Assembly.CodeBase.Replace("mscorlib.dll", "System.Windows.Forms.dll");
            assembly = assembly.Replace("file:///", "");

            string assemblyName = System.Reflection.AssemblyName.GetAssemblyName(assembly).FullName;
            Type unsafeNativeMethods = Type.GetType(System.Reflection.Assembly.CreateQualifiedName(assemblyName, "System.Windows.Forms.UnsafeNativeMethods"));

            Type oleObj = unsafeNativeMethods.GetNestedType("IOleObject");
            System.Reflection.MethodInfo methodInfo = oleObj.GetMethod("GetClientSite");
            object propertyPageSite = methodInfo.Invoke(this, null);

            return (MicrosoftOutlook.PropertyPageSite)propertyPageSite;
        }

        void OnDirty(bool isDirty)
        {
            _dirty = isDirty;
            _propertyPageSite.OnStatusChange();
        }

        void LoadOptions()
        {
            txtWarningText.Text = Properties.Settings.Default.DisplayMessage;
            txtFlaggedRecipients.Text = Properties.Settings.Default.FlaggedAddressWords;
        }

        void SaveOptions()
        {
            Properties.Settings.Default.DisplayMessage = txtWarningText.Text;
            Properties.Settings.Default.FlaggedAddressWords = txtFlaggedRecipients.Text;
            Properties.Settings.Default.Save();
        }
    }
}
