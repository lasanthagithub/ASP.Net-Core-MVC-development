using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MS4App.Controllers
{
    public class MS4AnalysisController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}