using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamedhPos.UI.Web.AspNetMvc.PosApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeEFRepo employeeRepo;

        public EmployeeController()
        {
            employeeRepo = new EmployeeEFRepo();
        }

        public ActionResult Index()
        {
            var employees = employeeRepo.GetAll();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var employee = employeeRepo.GetById(id);
            return View(employee);
        }

        public ActionResult Create()
        {
            int count = employeeRepo.GetCount();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employeeRepo.Save(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var employee = employeeRepo.GetById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            employeeRepo.Save(employee);
            return RedirectToAction("Index");
        }
    }
}