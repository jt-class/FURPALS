namespace FURPALS
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void OnCreateAccount(object sender, EventArgs eventArgs)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }

}
