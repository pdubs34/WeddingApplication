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
        public JsonResult GetItems(string category, string price)
        {
            ShopItemsViewModel shopItemsViewModel = new ShopItemsViewModel();
            shopItemsViewModel.PopulateItems();
            Models.Range range = new Models.Range();
            List<string> ids = new List<string>();
            
            foreach (ShopItemsViewModel items in shopItemsViewModel.Items)
            {
                bool validItem = false;
                if (items.Category == category || category == "All Categories")
                {
                    validItem = true;
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
