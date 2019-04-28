using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MissionController : Controller
    {


        public IActionResult Index()
        {
            var mission = new List<Mission>() {
                new Mission(){ Id="10000",Name="设计数据库",Rank="简单",Principal="刘娜"},
                   new Mission(){ Id="10001",Name="完成用例图",Rank="中等",Principal="张建"},
                     new Mission(){ Id="10002",Name="完成ui设计",Rank="简单",Principal="小强"},
            };
            //ViewData["mission"] = mission;
            return View("Index", mission);
        }

        public IActionResult Privacy()
        {

            return View();
        }


    }
}
