﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Model;
using Contoso.Model.Models;

namespace ContosoWeb.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService departmentService;
        public DepartmentController()
        {
            departmentService = new DepartmentService();
        }
        // GET: Department
        public ActionResult Index()
        {
            var departments = departmentService.GetAllDepartments();
            return View(departments);
        }

        public ActionResult Create(Department department)
        {
            departmentService.AddDepartment(department);
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}