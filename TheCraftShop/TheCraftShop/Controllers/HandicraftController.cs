
using Microsoft.AspNetCore.Mvc;
using TheCraftShop.Models;
using TheCraftShop.ViewModels;

namespace TheCraftShop.Controllers
{
    //controller class inherits from the base Controller class
    public class HandicraftController : Controller
    {
        //private fields, keeps track of the injected data (repository)
        private readonly IHandicraftRepository _handicraftRepository;
        private readonly ICraftMethodRepository _craftMethodRepository;

        //constructor, using the repository classes through the constructor (automatically injected by the dependency injection system)
        public HandicraftController(IHandicraftRepository handicraftRepository, ICraftMethodRepository craftMethodRepository)
        {
            _handicraftRepository = handicraftRepository;
            _craftMethodRepository = craftMethodRepository;
        }

        //action method, will be invoked when a request is received. Returns the view that lists all handicrafts.
        public ViewResult List()
        {
            //using a viewmodel, passing all data needed
            HandicraftListViewModel handicraftListViewModel = new HandicraftListViewModel();
            handicraftListViewModel.Handicrafts = _handicraftRepository.AllHandicrafts;

            //returns the view model result
            return View(handicraftListViewModel);
        }

        //returns the hardcoded view in Contact.cshtml
        public ViewResult Contact()
        {
            //returns the hardcoded view in Contact.cshtml
            return View();
        }

        //returns an own view for each handicraft
        public IActionResult Details(int id)
        {
            var handicraft = _handicraftRepository.GetHandicraftById(id);
            if (handicraft == null)
            {
                return NotFound();
            }
            return View(handicraft);
        }
        //returns a view whit all croched handicrafts
        public IActionResult Crochet()
        {
            var crochetViewModel = new CrochetViewModel();
            crochetViewModel.Crochet = _handicraftRepository.Crochet;

            return View(crochetViewModel);
        }
        //returns a view whit all macrame handicrafts
        public IActionResult Macrame()
        {
            var macrameViewModel = new MacrameViewModel();
            macrameViewModel.Macrame = _handicraftRepository.Macrame;

            return View(macrameViewModel);
        }
        //returns a view whit all drawn handicrafts
        public IActionResult Drawing()
        {
            var drawingViewModel = new DrawingViewModel();
            drawingViewModel.Drawing = _handicraftRepository.Drawing;

            return View(drawingViewModel);
        }
    }
}
