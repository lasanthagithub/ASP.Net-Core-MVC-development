using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MS4App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using MS4App.Models.CalculationViewModels;

namespace MS4App.Controllers
{
    public class CnComputationController : Controller
    {
        // Gettng info from database
        private readonly ApplicationDbContext _context;

        // Constructor
        public CnComputationController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [Authorize]
        public IActionResult CnComputationLanding()
        {
            return View();
        }


        [Authorize]
        public IActionResult CnComputationViewEdit()
        {
            var applicationDbContext = _context.CnItems;
            var a = applicationDbContext.ToList();
            
            CnItemsCollections cnItems = new CnItemsCollections();

            cnItems.CnItemsList = a;
            return View(cnItems);

        }


        [Authorize]
        [HttpPost]
        public IActionResult CnComputationViewEdit(string[] cnItemsSelected, string cnSelect)
        {
            var applicationDbContext = _context.CnItems;
            var a = applicationDbContext.ToList();

            CnItemsCollections cnItems = new CnItemsCollections
            {
                CnItemsList = a
            };

            ViewBag.CnSelectMessage = "Selected items save to " + cnSelect; 
            return View(cnItems);
        }
    }
}