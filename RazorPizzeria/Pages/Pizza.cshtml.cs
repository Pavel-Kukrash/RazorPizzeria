using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=19, TomatoSauce=true, Cheese=true, FinalPrice=34},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=22, TomatoSauce=true, Cheese=true, FinalPrice=44},
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=15, TomatoSauce=false, Cheese=true, FinalPrice=56},
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=29, TomatoSauce=true, Cheese=true, FinalPrice=42},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=191, TomatoSauce=false, Cheese=true, FinalPrice=194},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=31, TomatoSauce=true, Cheese=true, FinalPrice=54}

            // and other

        };
        public void OnGet()
        {
        }
    }
}
