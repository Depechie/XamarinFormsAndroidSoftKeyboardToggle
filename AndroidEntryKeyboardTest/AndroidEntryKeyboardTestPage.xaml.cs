using Xamarin.Forms;

namespace AndroidEntryKeyboardTest
{
	public partial class AndroidEntryKeyboardTestPage : ContentPage
	{
		public AndroidEntryKeyboardTestPage()
		{
			InitializeComponent();
		}

		private void OnShowKeyboardClicked(object sender, System.EventArgs e)
		{
			BarcodeEntry.IsSoftKeyboardEnabled = true;
		}

		private void OnUnfocused(object sender, FocusEventArgs e)
		{
			BarcodeEntry.IsSoftKeyboardEnabled = false;
		}
	}
}
