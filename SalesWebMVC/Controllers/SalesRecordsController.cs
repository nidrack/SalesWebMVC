using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;
        public SalesRecordsController (SalesRecordService salesRecordService)
        {
            salesRecordService = _salesRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearchAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }

    }
}
