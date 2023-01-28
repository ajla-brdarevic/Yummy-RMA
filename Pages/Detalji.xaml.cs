using Yummy.Models;

namespace Yummy.Pages;

public partial class Detalji : ContentPage
{
	public Detalji(IdeasSearch ideasSearch)
	{
		InitializeComponent();
        jeloNaziv.Text = ideasSearch.Naslov;
        kratkiOpis.Text = ideasSearch.KratkiOpis;
        sourceImage.Source = ideasSearch.Slika;
        dugiOpis.Text = ideasSearch.DugiOpis;
        instrukcije.Text = ideasSearch.Instrukcije;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Okay!", "Your meal is stored!", "OK");

    }
}