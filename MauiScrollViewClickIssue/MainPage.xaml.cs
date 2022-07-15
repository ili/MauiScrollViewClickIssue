namespace MauiScrollViewClickIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		var btn = (Button)sender;
		var separator = btn.Text.IndexOf("|");

		btn.Text = btn.Text.Substring(0, separator+1) + $" {count}";
	}
}

