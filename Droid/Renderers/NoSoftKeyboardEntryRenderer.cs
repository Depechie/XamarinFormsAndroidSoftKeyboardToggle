using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AndroidEntryKeyboardTest.Droid.Renderers;
using AndroidEntryKeyboardTest.Controls;

[assembly: ExportRenderer(typeof(NoSoftKeyboardEntry), typeof(NoSoftKeyboardEntryRenderer))]
namespace AndroidEntryKeyboardTest.Droid.Renderers
{
	public class NoSoftKeyboardEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				((NoSoftKeyboardEntry)Element).PropertyChanged += OnPropertyChanged;
				Control.ShowSoftInputOnFocus = ((NoSoftKeyboardEntry)Element).IsSoftKeyboardEnabled;
			}
		}

		private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			NoSoftKeyboardEntry entry = (NoSoftKeyboardEntry)Element;
			if (e.PropertyName.Equals(nameof(entry.IsSoftKeyboardEnabled)))
			{
				Control.ShowSoftInputOnFocus = entry.IsSoftKeyboardEnabled;
				if(entry.IsSoftKeyboardEnabled)
					Element.Focus();
			}
		}
	}
}
