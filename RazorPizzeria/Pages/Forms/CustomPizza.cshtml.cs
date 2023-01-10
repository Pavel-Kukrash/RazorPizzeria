using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Beef) PizzaPrice += 13;
            if (Pizza.Peperoni) PizzaPrice += 4;
            if (Pizza.Mushroom) PizzaPrice += 5;
            if (Pizza.Tuna) PizzaPrice += 7;
            if (Pizza.Pineapple) PizzaPrice += 15;
            if (Pizza.Ham) PizzaPrice += 6;

            return RedirectToPage("/Checkout/Checkout" , new {Pizza.PizzaName, PizzaPrice});
        }

    }
}