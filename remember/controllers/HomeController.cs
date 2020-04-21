using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using remember.Models;
using remember.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace remember.controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRespository;
        private IFeedbackRepository _feedbackRepository;

        public HomeController( INoodleRepository noodleRepository, IFeedbackRepository feedbackRepository) {
            _noodleRespository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var noodles = _noodleRespository.GetAllNoodles();
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRespository.GetAllNoodles().ToList()
            };
            return View(viewModel);
        }
        public String AboutUs() {
            return "AboutUs";
        }
    }
}
