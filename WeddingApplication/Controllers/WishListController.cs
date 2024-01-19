using Microsoft.AspNetCore.Mvc;
using WeddingApplication.ViewModels;
using WeddingApplication.Models;
using System;
using System.Collections.Generic;

namespace WeddingApplication.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            // Create an instance of ShopItemsViewModel
            ShopItemsViewModel shopItemsViewModel = new ShopItemsViewModel();
            shopItemsViewModel.PopulateItems();
            return View(shopItemsViewModel);
        }
        [HttpGet]
        public JsonResult GetItems(string category, int price)
        {
            ShopItemsViewModel shopItemsViewModel = new ShopItemsViewModel();
            shopItemsViewModel.PopulateItems();
            Models.Range range = new Models.Range();
            List<string> ids = new List<string>();
            
            foreach (ShopItemsViewModel items in shopItemsViewModel.Items)
            {
                bool validItem = true;
                if (items.Category != category && category != "All Categories")
                {
                    validItem = false;
                }
                if(price == 10)
                {
                    range.Min = 0;
                    range.Max = 10;
                    if (!range.IsNumInRange(items.Price))
                    {
                        validItem = false;
                    }
                }
                if (price == 25)
                {
                    range.Min = 10;
                    range.Max = 24.99m;
                    if (!range.IsNumInRange(items.Price))
                    {
                        validItem = false;
                    }
                }
                if (price == 100)
                {
                    range.Min = 25;
                    range.Max = 99.99m;
                    if (!range.IsNumInRange(items.Price))
                    {
                        validItem = false;
                    }
                }
                if (price == 250)
                {
                    range.Min = 100;
                    range.Max = 249.99m;
                    if (!range.IsNumInRange(items.Price))
                    {
                        validItem = false;
                    }
                }
                if (price == 251)
                {
                    range.Min = 250;
                    range.Max = Decimal.MaxValue;
                    if (!range.IsNumInRange(items.Price))
                    {
                        validItem = false;
                    }
                }

                if (validItem)
                {
                    ids.Add(items.ItemId);
                }
            }

            return Json(ids, new System.Text.Json.JsonSerializerOptions());
        }

    }
}
