using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private IBookStoreRepository repository;

        public NavigationMenuViewComponent (IBookStoreRepository r)
        {
            repository = r;
        }
        
        public IViewComponentResult Invoke()
        {
            //This will show all the books of a certain category. It will also use the url so people can type in what category they want
            //I think
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
            
    }
}
