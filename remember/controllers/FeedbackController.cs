using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using remember.Models;

namespace remember.controllers
{   

    public class FeedbackController : Controller
    {
        private IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository) {
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            else {
                return View();
            }
            

        }

        public IActionResult FeedbackComplete() {
            return View();
        }
    }
}