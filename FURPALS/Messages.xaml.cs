namespace FURPALS
{
    public partial class Messages : ContentPage
    {

        public Messages()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {

        }

        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        private void OnPlusButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnMessageButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {

        }
    }
}
