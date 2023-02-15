using Microsoft.AspNetCore.Mvc;
using SalesWebMvc19.Models;
using SalesWebMvc19.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc19.Controllers {
    public class SalesRecordsController : Controller {
        private readonly SalesRecordService _salesRecordService;
        public SalesRecordsController(SalesRecordService salesRecordService)  {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            //caso nao seja posto filtros, atribuir valores padronizados
            if (!minDate.HasValue)
            {
                minDate = new DateTime( 2018, 1, 1 );
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            //Passando viewData para receber os valores na caixa de texto, da view
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            //Chamando metodo que retorna lista de sales filtradas pelas datas passadas
            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);

            //Passando lista pra view
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            //caso nao seja posto filtros, atribuir valores padronizados
            if (!minDate.HasValue)
            {
                minDate = new DateTime(2018, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            //Passando viewData para receber os valores na caixa de texto, da view
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            //Chamando metodo que retorna lista de sales filtradas pelas datas passadas
            var result = await _salesRecordService.FindByDateGroupingAsync(minDate, maxDate);

            //Passando lista pra view
            return View(result);
        }
    }
}
