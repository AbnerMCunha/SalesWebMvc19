﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc19.Services;
using SalesWebMvc19.Models;
using SalesWebMvc19.Models.ViewModels;
using SalesWebMvc19.Services.Exceptions;
using System.Diagnostics;

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
            //Instanciando uma view Model já carrecagada com uma lista contendo todos os departamentos
            var vm = new SellerFormViewModel { Departments = _departmentService.FindAll() };
            //Passar a ViewModel no Retorno da View.
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            if (!ModelState.IsValid)    //Se formularario nao tiver sido validado(com as validações dos campops, retornar ao formulario)
            {
                return View(seller);
            }
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id Not provided" });
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = $"Seller Id: {id} Not found" });
            }
            //var seller = _sellerService.FindById(id.Value);
            //var departments = _departmentService.FindAll();
            //var vm = new SellerFormViewModel {Seller = seller, Departments = departments };
            //return View(vm);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.RemoveSeller(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id Not provided" });
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = $"Id: {id} Not provided" });
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id Not provided" });
            }
            var obj = _sellerService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = $"Seller Id: {id} Not Found" });
            }
            //Instanciando uma view Model já carrecagada o proprio vendedor em ediação e com uma lista contendo todos os departamentos
            var vmComVendedor = new SellerFormViewModel { Seller = obj, Departments = _departmentService.FindAll() };
            return View(vmComVendedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)    //int id
        {
            if (!ModelState.IsValid)    //Se formularario nao tiver sido validado(com as validações dos campops, retornar ao formulario)
            {
                return View(seller);
            }

            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id Mismatch" });
            }
            if (seller == null)
            {
                return RedirectToAction(nameof(Error), new { Message = $"Seller Id: {id} not found" });
            }

            try
            {
                _sellerService.UpdateSeller(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { Message = e.Message });
            }
            catch (DbConcurrencyExcption e)
            {
                //return RedirectToAction(Error(message));
                //return NotFound();
                return RedirectToAction(nameof(Error), new { Message = e.Message });
            }
        }

        public IActionResult Error(string message, int? id)
        {
            //Definindo a message de erro personalizada de acorodo com cada contexto
            //fazendo instancia condicionaldo Id

            var vm = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Message = message
            };
            return View(vm);
        }

        //public SellerFormViewModel CarregaVmSellerDepartment(Seller? seller)//Carregando a View Model de SellerViewModel com os dados de departameto pois é utilizada mais de uma vez;
        //{
        //    if(seller == null) { 
        //        //Instanciando uma view Model já carrecagada com uma lista contendo todos os departamentos
        //        var TelaDeSeller = new SellerFormViewModel { Departments = _departmentService.FindAll() };
        //        return TelaDeSeller;
        //    }else 
        //    {
        //        //Instanciando uma view Model já carrecagada com uma lista contendo todos os departamentos
        //        var TelaDeSeller = new SellerFormViewModel { Seller =seller, Departments = _departmentService.FindAll() };
        //        return TelaDeSeller;

        //    }
        //}
    }

}
