using Microsoft.AspNetCore.Mvc;
using TheCraftShop.Models;
using TheCraftShop.ViewModels;

namespace TheCraftShop.Controllers
{
    //controller class inherits from the base Controller class
    public class HomeController : Controller
    {
        //private fields, keeps track of the injected data (repository)
        private readonly IHandicraftRepository _handicraftRepository;

        //constructor, using the repository classes through the constructor (automatically injected by the dependency injection system)
        public HomeController(IHandicraftRepository handicraftRepository)
        {
            _handicraftRepository = handicraftRepository;
        }

        //action method, will be invoked when a request is received. Returns the default view.
        public IActionResult Index()
        {
            //using a viewmodel, passing all data needed
            var homeViewModel = new HomeViewModel
            {
                NewItem = _handicraftRepository.NewItem
            };
            return View(homeViewModel);
        }
    }
}
