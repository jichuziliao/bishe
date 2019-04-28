using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProjectController : Controller
    {


        public IActionResult Index()
        {
            var project = new List<Project>() {

                new Project(){ Id=10,Name="完成用例图",Principal="刘娜",Category="开发"},
                    new Project(){ Id=1,Name="完成用例图",Principal="张建",Category="科研"},
                     new Project(){ Id=4,Name="完成用例",Principal="小明",Category="开发"},

            };
            //ViewData["project"] = project;
            return View("Index", project);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
