using Microsoft.Maui.Controls;

namespace FURPALS
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Handle back navigation
            Navigation.PopAsync();
        }

        private void OnOptionsClicked(object sender, EventArgs e)
        {
            // Handle opening additional options
        }

        private void OnEditProfileClicked(object sender, EventArgs e)
        {
            // Handle profile editing logic
        }

        private void OnAddFriendClicked(object sender, EventArgs e)
        {
            // Handle add friend logic
        }
    }
}
