using Yummy.Models;

namespace Yummy.Pages;

public partial class Search : ContentPage
{
    public IList<IdeasSearch> MealsList { get; set; }

    public Search()
	{
		InitializeComponent();
        MealsList = new List<IdeasSearch>();

        MealsList.Add(new IdeasSearch
        {
            Id = 1,
            Naslov = "Gluten-free courgette pancakes",
            KratkiOpis = "92 Calories",
            Slika = "gfcourgettepancakes.jpg",
            DugiOpis = "1 medium courgette, coarsely grated.\r\n150ml reduced-fat coconut milk.\r\n1 orange, zested, plus 150ml orange juice.\r\n1 tbsp vinegar.\r\n3 tbsp maple syrup, plus extra to serve.\r\n1½ tsp vanilla extract.\r\n1 tsp ground cinnamon.\r\n1 tsp mixed spice.",
            Instrukcije = "STEP 1\r\nTip the grated courgette into a clean tea towel and squeeze out as much water as you can. Set aside. In a jug, mix the coconut milk with the orange zest and juice, vinegar, maple syrup and vanilla extract.\r\n\r\nSTEP 2\r\nCombine the cinnamon, mixed spice, powdered egg replacer, xanthan gum (if using), baking powder, flour and ¼ tsp salt. Add the wet ingredients to the dry. Whisk to make a smooth batter, then stir in the courgette.\r\n\r\nSTEP 3\r\nYou will need to cook the pancakes in batches. Heat the oil in a frying pan over a medium-low heat. Add 2 tbsp batter per pancake, leaving 4cm between each. Cook for 3-4 mins until bubbles form on top. Flip and cook for another 1-2 mins.\r\n\r\nSTEP 4\r\nTransfer the pancakes to a wire rack while you cook the rest. Serve warm with extra maple syrup and yogurt and berries, if you like."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 2,
            Naslov = "Salad bowl",
            KratkiOpis = "154 Calories",
            Slika = "saladblow.png",
            DugiOpis = "8 cherry tomatoes in halves\r\n½ avocado in thin slices\r\n50 g red cabbage, shredded\r\n20 g butterhead lettuce, in small leaves\r\n1 carrot in ribbons",
            Instrukcije = "STEP 1\r\nFirst, make the pickle. Mix all the ingredients together in a large bowl with 1 tsp flaky sea salt, then cover and set aside until needed.\r\n\r\nSTEP 2\r\nMix the couscous with 280ml boiling water in a bowl, cover and leave for 4 mins, then fluff up with a fork. Set aside to cool slightly.\r\n\r\nSTEP 3\r\nMeanwhile, drain and rinse the beans, tip into a bowl, then stir in the olive oil and chilli flakes along with a little seasoning.\r\n\r\nSTEP 4\r\nMix most of the dill through the couscous and season. To assemble, spoon the quick pickle, couscous, radishes, beans and cucumber into separate parts of each bowl. Top the pickle with the reserved dill and grind over some black pepper."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 3,
            Naslov = "Red Snapper with Potatoes \r\nand Onions",
            KratkiOpis = "120 Calories",
            Slika = "redsnapperpotatoes.jpg",
            DugiOpis = "1 ½ cups loosely packed fresh flat-leaf parsley leaves\r\n1 medium shallot (about 2 oz.), roughly chopped\r\n3 garlic cloves, roughly chopped\r\n1 tablespoon fresh thyme leaves\r\n1 ½ teaspoons lemon zest (from 1 lemon)",
            Instrukcije = "STEP 1\r\nPreheat oven to 425°F. Line a rimmed baking sheet with parchment paper. Set aside.\r\n\r\nSTEP 2\r\nProcess parsley, shallot, garlic, thyme, lemon zest, and red pepper in a food processor until finely chopped, about 15 seconds. Add oil, and process until well incorporated, about 15 seconds. Toss together potatoes, onion wedges, 2 tablespoons of the parsley mixture, and 1 teaspoon of the salt in a large bowl.\r\n\r\nSTEP 3\r\nCut 3 (2-inch-long) slits diagonally on both sides of fish, cutting all the way to the bone on both sides. Rub exterior and inside of cuts with 1 cup of the parsley mixture and remaining 1 3/4 teaspoons salt; place fish on prepared baking sheet. Spread potato mixture around fish. Bake in preheated oven until fish is opaque and flaky and vegetables are tender, about 30 minutes.\r\n\r\nSTEP 4\r\nDrizzle fish with remaining 1/4 cup parsley mixture. Serve with lemon wedges."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 4,
            Naslov = "Mediterranean style shrimp",
            KratkiOpis = "341 Calories",
            Slika = "meditstyleshrimp.jpg",
            DugiOpis = "1 1/4 lb large shrimp (or prawns, peeled and deveined (if frozen, be sure to thaw first))\r\n1 tbsp all-purpose flour\r\n1 to 2 tsp smoked Spanish paprika\r\n1/2 tsp each salt and pepper\r\n1/2 tsp ground coriander",
            Instrukcije = "STEP 1\r\nStart by marinating the shrimp in olive oil, salt, pepper, allspice, oregano, lemon juice and extra virgin olive oil.\r\n\r\nSTEP 2\r\nMeanwhile, sauté onion in some olive oil until translucent and a bit golden. Add in the garlic and sliced pepper, followed by the rest of the spices. Cook for a minute or two.\r\n\r\nSTEP 3\r\nAdd the shrimp, tomatoes and a bit of water to the vegetables and cook for about 5 minutes, until the shrimp is pink and curled.\r\n\r\nSTEP 4\r\nTop with chopped parsley and more lemon juice if desired. Serve warm with your favorite side dish."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 5,
            Naslov = "Risotto gamberi",
            KratkiOpis = "270 Calories",
            Slika = "risottogamb.jpg",
            DugiOpis = "1 Tbsp olive oil ((extra virgin))\r\n1 Tbsp shallot ((finely diced, up to 2 tablespoons))\r\n2 cloves garlic ((minced))\r\n1 1/2 cups Arborio rice\r\n1/4 cup white wine ((dry white wine))",
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 6,
            Naslov = "Chicken Fajitas",
            KratkiOpis = "270 Calories",
            Slika = "slika1.jpg",
            DugiOpis = "1 Tbsp olive oil ((extra virgin))\r\n1 Tbsp shallot ((finely diced, up to 2 tablespoons))\r\n2 cloves garlic ((minced))\r\n1 1/2 cups Arborio rice\r\n1/4 cup white wine ((dry white wine))",
            Instrukcije = "STEP 1\r\nSeason the chicken. Generously sprinkle the fajita seasoning on both sides of the chicken and use your fingers to press it in.\r\n\r\nSTEP 2\r\nCook the chicken. Heat a large skillet over medium heat and lightly coat it with a drizzle of olive oil or avocado oil. Sear the chicken breasts for about 7-8 minutes on each side. Then remove them from the pan and let them rest for a few minutes before slicing into strips.\r\n\r\nSTEP 3\r\nSaute the bell peppers and onion. While the chicken is cooking, cut the bell peppers and onions into thin slices. Then saute them in the same skillet over medium heat for a few minutes until caramelized. You’re essentially making fajita veggies.\r\n\r\nSTEP 4\r\nMix together. Add the chicken back into the skillet, squeeze fresh lime juice on top and stir everything together.\r\n\r\nSTEP 5\r\nWrap it up. Serve immediately with tortillas and extra toppings."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 7,
            Naslov = "Hot Italian Chilli",
            KratkiOpis = "316 Calories",
            Slika = "slika2.jpg",
            DugiOpis = "1 Tbsp olive oil ((extra virgin))\r\n1 Tbsp shallot ((finely diced, up to 2 tablespoons))\r\n2 cloves garlic ((minced))\r\n1 1/2 cups Arborio rice\r\n1/4 cup white wine ((dry white wine))",
            Instrukcije = "STEP 1\r\nIn a large skillet, cook beef and sausage over medium heat until no longer pink. Meanwhile, in a 3-qt. slow cooker, combine the tomatoes, tomato sauce, onion, red pepper, water, celery, broth, chili powder, Italian seasoning, sugar, garlic and salt.\r\n\r\nSTEP 2\r\nDrain beef mixture; add to the slow cooker. Cover and cook on low for 6 hours or until vegetables are tender.\r\n\r\nSTEP 3\r\nAdd the beans, mushrooms, zucchini and parsley. Cover and cook on high for 30 minutes or until vegetables are tender. Sprinkle with cheese if desired."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 8,
            Naslov = "Coconut Rice Bowls",
            KratkiOpis = "270 Calories",
            Slika = "slika3.jpg",
            DugiOpis = "1 Tbsp olive oil ((extra virgin))\r\n1 Tbsp shallot ((finely diced, up to 2 tablespoons))\r\n2 cloves garlic ((minced))\r\n1 1/2 cups Arborio rice\r\n1/4 cup white wine ((dry white wine))",
            Instrukcije = "STEP 1\r\nCook the rice: Add rice, coconut milk, water, curry powder, salt, and 1 teaspoon of ginger.  Bring to a simmer.  And cook for 20 minutes.\r\n\r\nSTEP 2\r\nMake the Sauce: Whisk together sriracha, soy sauce, and coconut sugar.  Set aside.\r\n\r\nSTEP 3\r\nPat tofu dry and cut into thick strips.Prep veggies. Here we are using asparagus, but you can swap out for your season favorites. Cutting the asparagus at an angle with cook it more quickly.\r\n\r\nSTEP 4\r\nSear Tofu (or cook chicken, fish or shrimp if using):  Heat a pan to med-high (we like cast iron).\r\n\r\nAdd 1 tablespoon coconut oil and a sprinkle of salt and pepper.  Add tofu and sear for about 3 minutes without moving tofu around, flip over and sear for another 3 minutes.  Set tofu aside.\r\n\r\nSTEP 5\r\nSauté Veggies: In the same pan that you cooked the tofu in add 1 tablespoon coconut oil sauté asparagus (or other vegetables) for about 1 minute.\r\n\r\nAdd garlic, lemongrass, ginger and stir over medium heat for about 3-4 minutes, until asparagus is tender.  Add green onions and 1 tablespoon of water, scraping the pan to loosen all the stuck bits, cooking for another minute more.\r\nSTEP SIX\r\nCombine: Add tofu, sauce, peas, and lime juice, stirring to combine.  Take off the heat."
        });

        MealsList.Add(new IdeasSearch
        {
            Id = 9,
            Naslov = "Peanut Butter Cookies",
            KratkiOpis = "270 Calories",
            Slika = "slika4.jpg",
            DugiOpis = "1 Tbsp olive oil ((extra virgin))\r\n1 Tbsp shallot ((finely diced, up to 2 tablespoons))\r\n2 cloves garlic ((minced))\r\n1 1/2 cups Arborio rice\r\n1/4 cup white wine ((dry white wine))",
            Instrukcije = "STEP 1\r\nBeat butter, peanut butter, white sugar, and brown sugar with an electric mixer in a large bowl until smooth; beat in eggs.\r\n\r\nSTEP 2\r\nSift flour, baking soda, baking powder, and salt into a separate bowl; stir into butter mixture until dough is just combined. Chill cookie dough in the refrigerator for 1 hour.\r\n\r\nSTEP 3\r\nPreheat the oven to 375 degrees F (190 degrees C).\r\n\r\nSTEP 4\r\nRoll dough into 1-inch balls and place 2 inches apart onto ungreased baking sheets. Flatten each ball with a fork, making a crisscross pattern.\r\n\r\nSTEP 5\r\nBake in the preheated oven until edges are golden, about 10 minutes. Cool on the baking sheets briefly before removing to a wire rack to cool completely."
        });
        BindingContext = this;

    }

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var myListView = (ListView)sender;
        var odabranaTura = (IdeasSearch)myListView.SelectedItem;
        await Navigation.PushModalAsync(new Detalji(odabranaTura));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        IdeasSearch preporucenoJelo = new IdeasSearch();

        Random RandomBrojac = new Random();
        int RandomId = RandomBrojac.Next(1, MealsList.Count() + 1);

        preporucenoJelo = MealsList.Where(x => x.Id == RandomId).FirstOrDefault();

        await Navigation.PushModalAsync(new Detalji(preporucenoJelo));
    }
}