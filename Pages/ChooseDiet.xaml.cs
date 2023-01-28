using Yummy.Models;

namespace Yummy.Pages;

public partial class ChooseDiet : ContentPage
{
    public List<Dijeta> listDijeta { get; set; }

    public ChooseDiet()
    {

        listDijeta = new List<Dijeta>{
            new Dijeta {Id=1, NazivDijeta="Gluten-free diet"},
            new Dijeta {Id=2, NazivDijeta="High-protein diet"},
            new Dijeta { Id = 3, NazivDijeta = "Lactose-free diet" },
            new Dijeta { Id = 4, NazivDijeta = "Low-crab diet" },
            new Dijeta { Id = 5, NazivDijeta = "Low-sugar diet" },
            new Dijeta { Id = 6, NazivDijeta = "Mediterranean diet" },
            new Dijeta { Id = 7, NazivDijeta = "Raw diet" },
            new Dijeta { Id = 8, NazivDijeta = "Vegetarian" },
            new Dijeta { Id = 9, NazivDijeta = "Vegan" },
        };

        InitializeComponent();
        BindingContext = this;

        VrstaDijeta1Naziv.Text = listDijeta[0].NazivDijeta;
        VrstaDijeta2Naziv.Text = listDijeta[1].NazivDijeta;
        VrstaDijeta3Naziv.Text = listDijeta[2].NazivDijeta;
        VrstaDijeta4Naziv.Text = listDijeta[3].NazivDijeta;
        VrstaDijeta5Naziv.Text = listDijeta[4].NazivDijeta;
        VrstaDijeta6Naziv.Text = listDijeta[5].NazivDijeta;
        VrstaDijeta7Naziv.Text = listDijeta[6].NazivDijeta;
        VrstaDijeta8Naziv.Text = listDijeta[7].NazivDijeta;
        VrstaDijeta9Naziv.Text = listDijeta[8].NazivDijeta;

    }
    private async void Done_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Home");
    }
}
