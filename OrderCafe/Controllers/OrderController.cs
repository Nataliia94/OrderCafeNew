﻿using Microsoft.AspNetCore.Mvc;
using OrderCafe.Models.DataBase;
using OrderCafe.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCafe.Controllers
{
    public class OrderController : Controller
    {
        private readonly IDataManagmant service;

        public OrderController(IDataManagmant _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            var orders = service.GetOrders();
            return View(orders.ToArray());
        }
        public IActionResult Details(string id)
        { 
            var order = service.GetOrder(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost] 
        public IActionResult Create(Order model)
        {
           var or= service.AddOrder(model);
            return RedirectToAction("Details", new {id=or});
        }
        public IActionResult Edit(string id)
        {
            var order = service.GetOrder(id);
           

            if (order is null)
            {
                throw new Exception($"Order with registration number equals {id} not found");
            }

            
            return View(order);
        }
        [HttpPost]
        public IActionResult Edit(string id, Order model)
        {
            service.UpdateOrder(id, model);
            return RedirectToAction("Index");
            
        }
        public IActionResult Delete(string id)
        {
            var order = service.GetOrder(id);
            if (order is null)
            {
                throw new Exception($"Order with registration number equals {id} not found");
            }
            return View(order);
        }
        [HttpDelete,HttpPost]
        public IActionResult Delete (string id , bool? isDelete)
        {
            service.DeleteOrder(id);
            return RedirectToAction("Index"); 

        }
    }
}