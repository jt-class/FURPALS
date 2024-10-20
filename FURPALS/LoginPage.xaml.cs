using System.Text.RegularExpressions;

namespace FURPALS;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
<<<<<<< HEAD
        InitializeComponent();
	}
    private async void OnSignIn(object sender, EventArgs e)
    {
        string email = Email_input.Text;
        string password = Password_input.Text;
        if (!IsValidEmail(email))
        {
            await DisplayAlert("Error", "Please enter a valid email address.", "OK");
            return;
        }
=======
      InitializeComponent();
	}

    public void ToSignIn(object sender, EventArgs e)
	{
        
    }
	public void ToSignUp(object sender, EventArgs e)
	{
>>>>>>> dec8326d097d0bfe3a5b5a97a6078851de10549b

        if (!IsValidPassword(password))
        {
            await DisplayAlert("Error", "Password must be at least 6 characters long.", "OK");
            return;
        }


        await Navigation.PushAsync(new UserAccountPage());
    }




    // enter valid email
    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email)) return false;

        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }
    //Password must be at least 6 characters long.
    private bool IsValidPassword(string password)
    {
        return !string.IsNullOrEmpty(password) && password.Length >= 6;
    }

    private async void ToSignUp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new UserAccountPage());

    }


    private async void OnSignUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserAccountPage());
    }
}