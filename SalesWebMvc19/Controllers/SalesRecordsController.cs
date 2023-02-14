using Microsoft.AspNetCore.Mvc;
using SalesWebMvc19.Models;
using SalesWebMvc19.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc19.Controllers {
    public class SalesRecordsController : Controller {

        private SalesRecordService _saleRecordService;
        private readonly SalesWebMvc19Context _context;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch()
        {
            //var a = await _saleRecordService.FindAll();
            return View();
        }

        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
