using Yummy.Models;

namespace Yummy.Pages;

public partial class Home : ContentPage
{
    public List<PopularRecipes> PopularRecipesList { get; set; }
    public List<Ideas> IdeasList { get; set; }

    public Home()
    {

        PopularRecipesList = new List<PopularRecipes>{
            new PopularRecipes { Id = 6, Slika = "slika1.jpg", Naziv = "Chicken Fajitas", Kalorije = "294 Calories", Dijeta = "High-protein", Instrukcije = "nanananananannanananananan" },
            new PopularRecipes { Id = 7, Slika = "slika2.jpg", Naziv = "Hot Italian Chilli", Kalorije = "316 Calories", Dijeta = "Gluten-free", Instrukcije = "nanananananannanananananan" },
            new PopularRecipes { Id = 8, Slika = "slika3.jpg", Naziv = "Coconut Rice Bowls", Kalorije = "373 Calories", Dijeta = "Vegan", Instrukcije = "nanananananannanananananan" },
            new PopularRecipes { Id = 9, Slika = "slika4.jpg", Naziv = "Peanut Butter Cookies", Kalorije = "126 Calories", Dijeta = "Lactose-free", Instrukcije = "nanananananannanananananan" }
        };

        BindingContext = this;

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
            messageTextBlock.Text = "Good Afternoon ";
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

    private async void SeeAll_ButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Search");
    }

    private async void SeeAllIdeas_ButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Search");
    }


}
