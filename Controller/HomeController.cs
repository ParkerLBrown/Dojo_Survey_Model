using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_Model.Models;

namespace Dojo_Survey_Model
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }


        [HttpPost("survey")]
        public IActionResult SurveyAnswers(Survey answers)
        {
            Console.WriteLine("YOYOYOYOYOYOYOYO");
            if(ModelState.IsValid)
            {
                Console.WriteLine("redirecting from survey to answers");
                return View("SurveyAnswers", answers);
            }
            else
            {
                Console.WriteLine("redirecting from survey to index");
                return View("Index");
            }
        }
    }


}