using Yummy.Models;

namespace Yummy.Pages;

public partial class Home : ContentPage
{
    public List<PopularRecipes> PopularRecipesList { get; set; }

    public Home()
	{

        PopularRecipesList = new List<PopularRecipes>{
            new PopularRecipes() { Id = 1, Slika = "slika1.png", Naziv ="Chicken Fajitas", Kalorije = "294 Calories" }
        };

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

        BindingContext = this;

        PopularRecipesList = new List<PopularRecipes>() {
            new PopularRecipes { Slika = "slika1.jpg", Naziv = "Chicken Fajitas", Kalorije = "294 Calories" },
            new PopularRecipes { Slika = "slika1.jpg", Naziv = "Chicken Fajitas", Kalorije = "294 Calories" },
            new PopularRecipes { Slika = "slika1.jpg", Naziv = "Chicken Fajitas", Kalorije = "294 Calories" },
            new PopularRecipes { Slika = "slika1.jpg", Naziv = "Chicken Fajitas", Kalorije = "294 Calories" }
        };
    }


}
