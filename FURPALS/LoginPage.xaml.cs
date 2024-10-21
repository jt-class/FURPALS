using System.Text.RegularExpressions;

namespace FURPALS;

public partial class LoginPage : ContentPage
{
    string email;
    string password;
	public LoginPage()
	{

        InitializeComponent();
	}
    private async void ToSignIn(object sender, EventArgs e)
    {
        email = Email_input.Text;
       password = Password_input.Text;
        if (!IsValidEmail(email))
        {
            await DisplayAlert("Error", "Please enter a valid email address.", "OK");
            return;
        }
        if (!IsValidPassword(password))
        {
            await DisplayAlert("Error", "Password must be at least 6 characters long.", "OK");
            return;
        }
        await Navigation.PushAsync(new HomePage()); //change the navgigation to homepage and fix the useraccount page layout

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

        await Navigation.PushAsync(new MainPage());

    }

}