namespace FURPALS;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
	private async void OnHeartClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new NotificationPage());
    }
	private async void OnHomeClicked(object sender, EventArgs e)
	{ 

	}
	private async void OnSearchClicked(object sender, EventArgs e)
	{

	}
	private async void OnAddClicked(object sender, EventArgs E)
	{

	}
	private async void OnMessagesClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Messages());
	}
	private async void OnProfileClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new UserProfile());
    }
	
}
	