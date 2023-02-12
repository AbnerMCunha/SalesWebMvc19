
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc19.Services;
using SalesWebMvc19.Models;
using SalesWebMvc19.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc19.Controllers {
    public class SellersController : Controller {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            //Instanciar todos os departamentos registrados no banco de dados
            var departments = _departmentService.FindAll();
            //Intanciar sellerViewModel com a lista de todos os departametos como atributo da ViewModel
            var TelaDeSeller = new SellerFormViewModel{ Departments= departments};
            //Passar a ViewModel no Retorno da View.
            return View(TelaDeSeller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            //var seller = _sellerService.FindById(id.Value);
            //var departments = _departmentService.FindAll();
            //var vm = new SellerFormViewModel {Seller = seller, Departments = departments };
            //return View(vm);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id) {
            _sellerService.RemoveSeller(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
