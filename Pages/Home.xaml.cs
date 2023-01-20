namespace Yummy.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	
    DateTime currentTime = DateTime.Now;

        if (currentTime.Hour >= 6 && currentTime.Hour < 12)
        {
            timeOfTheDayImage.Source = "morning.png";
            messageTextBlock.Text = "Good Morning";
        }
        else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
        {
            timeOfTheDayImage.Source = "afternoon.png";
            messageTextBlock.Text = "Good Afternoon";
        }
        else if (currentTime.Hour >= 18 && currentTime.Hour < 21)
        {
            timeOfTheDayImage.Source = "evening.png";
            messageTextBlock.Text = "Good Evening";
        }
        else
        {
            timeOfTheDayImage.Source = "night.png";
            messageTextBlock.Text = "Good Night";
        }
    }

}
