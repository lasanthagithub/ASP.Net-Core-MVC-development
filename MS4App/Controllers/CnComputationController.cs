using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MS4App.Data;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> CnComputationViewEdit()
        {
            var applicationDbContext = _context.CnItems;
            return View(await applicationDbContext.ToListAsync());

        }

        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> CnComputationViewEdit()
        //{
        //    var applicationDbContext = _context.CnItems;
        //    return View(await applicationDbContext.ToListAsync());

        //}
    }
}