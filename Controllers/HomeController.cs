using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Models;
using LostInTheWoods.Factory;

namespace LostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory _TrailFactory;
        public HomeController(TrailFactory uFactory)
        {
            _TrailFactory = uFactory;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(_TrailFactory.FindAll());
        }
        [HttpGet("NewTrail")]
        public IActionResult NewForm()
        {
            return View();
        }
        [HttpPost("NewTrail")]
        public IActionResult New(Trail form)
        {
            if(ModelState.IsValid)
            {
                _TrailFactory.Add(form);
                return RedirectToAction("Index");
            }
            return View("NewForm");
        }
        [HttpGet("trails/{id}")]
        public IActionResult Detail(int id)
        {
            return View(_TrailFactory.FindByID(id));
        }
        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _TrailFactory.DeleteByID(id);
            return RedirectToAction("Index");
        }
        
    }
}
