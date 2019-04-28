using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //访问数据库，获取学生列表
            var user = new List<User>() {

               new User(){ Id="10000",Name="zhangs",Sex="男",Age=28,Position="开发",Title="负责人",Task="完成用例图"},
               new User(){ Id="10001",Name="刘丹",Sex="男",Age=28,Position="开发",Title="负责人",Task="完成用例图"},
               new User(){ Id="10002",Name="赵建",Sex="男",Age=28,Position="测试",Title="员工",Task="完成数据库"},
            };
             ViewData["user"] = user;
            //return View("Index", user);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}