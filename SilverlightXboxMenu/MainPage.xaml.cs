using System.Windows;
using System.Windows.Browser;

namespace SilverlightXboxMenu
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		    this.SocialMenuHeader.IsChecked = true;
		    VisualStateManager.GoToState(this, "Social", false);
		}
	}
}