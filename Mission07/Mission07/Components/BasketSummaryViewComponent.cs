using System;
using Microsoft.AspNetCore.Mvc;
using Mission07.Models;

namespace Mission07.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public BasketSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }

        public IViewComponentResult Invoke ()
        {
            return View(basket);
        }
    }
}
