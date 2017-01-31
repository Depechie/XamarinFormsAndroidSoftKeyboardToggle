using System;
using Xamarin.Forms;

namespace AndroidEntryKeyboardTest.Controls
{
	public class NoSoftKeyboardEntry : Entry
	{
		public static readonly BindableProperty IsSoftKeyboardEnabledProperty =
			BindableProperty.Create(nameof(IsSoftKeyboardEnabled), typeof(bool), typeof(NoSoftKeyboardEntry), false);

		public bool IsSoftKeyboardEnabled
		{
			get { return (bool)GetValue(IsSoftKeyboardEnabledProperty); }
			set { SetValue(IsSoftKeyboardEnabledProperty, value); }
		}
	}
}
